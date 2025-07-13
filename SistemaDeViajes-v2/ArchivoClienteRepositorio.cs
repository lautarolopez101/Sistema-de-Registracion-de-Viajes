using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeViajes_v2
{
    public class ArchivoClienteRepositorio : IClienteRepositorio
    {

        private readonly string _filePath = "clientes.txt";

        // Implementación del método GetAllClientes de la interfaz IClienteRepository
        public List<CLSCliente> GetAllClientes()
        {
            List<CLSCliente> listaclientes = new List<CLSCliente>();

            listaclientes.Clear();
            try
            {
                using (StreamReader sr = new StreamReader(_filePath))
                {

                    sr.ReadLine();

                    string linea;
                    while ((linea = sr.ReadLine()) != null)
                    {
                        if (string.IsNullOrWhiteSpace(linea)) continue;

                        string[] vec = linea.Split(';');

                        const int ExpectedFields = 7;
                        if (vec.Length < ExpectedFields)
                        {
                            Console.WriteLine($"Advertencia (ArchivoClienteRepositorio): Línea de cliente incompleta o incorrecta (se esperaban {ExpectedFields} campos, se encontraron {vec.Length}): '{linea}'. Saltando esta línea.");
                            continue;
                        }

                        int telefonoLeido = 0, dniLeido = 0, idLeido = 0;
                        bool telefonoOk = int.TryParse(vec[3].Trim(), out telefonoLeido);
                        bool dniOk = int.TryParse(vec[5].Trim(), out dniLeido);
                        bool idOk = int.TryParse(vec[6].Trim(), out idLeido);

                        if (telefonoOk && dniOk && idOk)
                        {
                            CLSCliente cliente = new CLSCliente(
                                vec[0].Trim(),
                                vec[1].Trim(),
                                vec[2].Trim(),
                                telefonoLeido,
                                vec[4].Trim(),
                                dniLeido,
                                idLeido
                            );
                            listaclientes.Add(cliente);
                        }
                        else
                        {
                            Console.WriteLine($"Advertencia (FileClienteRepository): Error al convertir datos numéricos de cliente en la línea: '{linea}'.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al cargar clientes desde el archivo: {ex.Message}", ex);
            }
            return listaclientes;
        }

        // Implementación del método AddCliente de la interfaz IClienteRepository
        public void AddCliente(CLSCliente cliente)
        {
            try
            {
                using (StreamWriter sw = File.AppendText(_filePath))
                {
                    sw.WriteLine(cliente.ToFileLine());
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al guardar el cliente en el archivo: {ex.Message}", ex);
            }
        }
    }
}

