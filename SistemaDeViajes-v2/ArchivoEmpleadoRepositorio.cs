using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeViajes_v2
{
    public class ArchivoEmpleadoRepositorio : IEmpleadoRepositorio
    {
        private readonly string _filePath = "empleados.txt";

        public List<CLSEmpleado> GetAllEmpleados()
        {
            List<CLSEmpleado> empleados = new List<CLSEmpleado>();
            if (!File.Exists(_filePath)) return empleados;

            try
            {
                using (StreamReader sr = new StreamReader(_filePath))
                {
                    // VERIFICA ESTO: Si tu archivo tiene una línea de cabecera, DESCOMENTA la siguiente línea.
                    // Si NO tiene cabecera, MANTENLA COMENTADA.
                    // sr.ReadLine(); // Saltar la primera línea (cabecera)

                    string linea;
                    while ((linea = sr.ReadLine()) != null)
                    {
                        if (string.IsNullOrWhiteSpace(linea)) continue;

                        string[] vec = linea.Split(';');
                        const int ExpectedFields = 6; // Nombre;Apellido;Email;Password;ID;Puesto (AJUSTA ESTO SEGÚN TU CLASE CLSEmpleado)

                        if (vec.Length < ExpectedFields)
                        {
                            Console.WriteLine($"Advertencia (FileEmpleadoRepository): Línea de empleado con formato incorrecto o incompleta (se esperaban {ExpectedFields} campos, se encontraron {vec.Length}): '{linea}'. Saltando esta línea.");
                            continue;
                        }

                        int idLeido=0, telefonoleido=0, dnileido=0;
                        bool idOk = int.TryParse(vec[4].Trim(), out idLeido); // Asumiendo que el ID está en el índice 4
                        bool telefonoOk = int.TryParse(vec[5].Trim(), out telefonoleido);
                        bool dniOk = int.TryParse(vec[5].Trim(), out dnileido);


                        if (idOk && telefonoOk && dniOk)
                        {
                            CLSEmpleado empleado = new CLSEmpleado(
                                vec[0].Trim(), // Nombre
                                vec[1].Trim(), // Apellido
                                vec[2].Trim(), // Email
                                telefonoleido, 
                                vec[4].Trim(), // Password
                                dnileido, 
                                idLeido

                            );
                            empleados.Add(empleado);
                        }
                        else
                        {
                            Console.WriteLine($"Advertencia (FileEmpleadoRepository): Error al convertir datos numéricos de empleado en la línea: '{linea}'. Asegúrese de que el ID sea un número válido.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al cargar empleados desde el archivo: {ex.Message}", ex);
            }
            return empleados;
        }
    }
}

