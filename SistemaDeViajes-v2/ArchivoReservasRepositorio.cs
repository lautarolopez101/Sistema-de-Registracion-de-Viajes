using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeViajes_v2
{
    public class ArchivoReservasRepositorio : IReservasRepositorio
    {

        private readonly string _filePath = "ReservasVuelos.txt";

        // Implementación del método GetAllReservas de la interfaz IReservaRepository
        public List<CLSReserva> GetAllReservas()
        {
            List<CLSReserva> listareservas = new List<CLSReserva>();
            listareservas.Clear();
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

                        CLSReserva reserva = new CLSReserva();

                        reserva = reserva.FromString(linea);

                        const int ExpectedFields = 9;
                        if (vec.Length < ExpectedFields)
                        {
                            Console.WriteLine($"Advertencia (FileReservaRepository): Línea de reserva incompleta o incorrecta (se esperaban {ExpectedFields} campos, se encontraron {vec.Length}): '{linea}'. Saltando esta línea.");
                            continue;
                        }

                        int idReserva = 0;
                        int idCliente = 0;
                        int asientosSeleccionados = 0;
                        int cantidadAdultos = 0;
                        int cantidadNinios = 0;
                        int estado = 0;
                        int importeTotal = 0;
                        DateTime fechaReserva = DateTime.MinValue;
                        int idviaje = 0;


                        listareservas.Add(reserva);
                        
                    }
                }

            }
            catch (Exception ex)
            {
                throw new Exception($"Error al cargar reservas desde el archivo: {ex.Message}", ex);
            }
            return listareservas;
        }

        public void AddReserva(CLSReserva reserva)
        {
            try
            {
                using (StreamWriter sw = File.AppendText(_filePath))
                {
                    sw.WriteLine(reserva.ToFileLine());
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al guardar la reserva en el archivo: {ex.Message}", ex);
            }
        }
    }
}

