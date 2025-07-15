using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeViajes_v2
{
    public class CLSReserva
    {
        public int IdReserva { get; set; }
        public int IdCliente { get; set; }
        public string IdViaje { get; set; }
        public int AsientosSeleccionados { get; set; }
        public int CantidadAdultos { get; set; }
        public int CantidadNinios { get; set; }
        public int Estado { get; set; }
        public DateTime FechaReserva { get; set; }
        public int ImporteTotal { get; set; }

        public string ButacasTexto { get; set; }

        public CLSReserva() { }

        public int CalcularMontoTotal(int precioPorAdulto, int precioPorNinio)
        {
            ImporteTotal = (CantidadAdultos *  precioPorAdulto) + (CantidadNinios * precioPorNinio);
            return ImporteTotal;
        }

        public int CalcularDevolucion()
        {
            return (int)(ImporteTotal * 0.8);
        }

        public string EstadoTexto
        {
            get
            {
                return Estado == 1 ? "Confirmada" : "Cancelada";
            }
        }

        public override string ToString()
        {
            // Para guardar en archivo fácilmente
            return $"{IdReserva};{IdCliente};{IdViaje};{AsientosSeleccionados};{CantidadAdultos};{CantidadNinios};{Estado};{FechaReserva:yyyy-MM-dd};{ImporteTotal}";
        }

        public static CLSReserva FromString(string linea)
        {
            string[] partes = linea.Split(';');
            return new CLSReserva
            {
                IdReserva = int.Parse(partes[0]),
                IdCliente = int.Parse(partes[1]),
                IdViaje = partes[2],
                AsientosSeleccionados = int.Parse(partes[3]),
                CantidadAdultos = int.Parse(partes[4]),
                CantidadNinios = int.Parse(partes[5]),
                Estado = int.Parse(partes[6]),
                FechaReserva = DateTime.Parse(partes[7]),
                ImporteTotal = int.Parse(partes[8])
            };
        }
    }
}
