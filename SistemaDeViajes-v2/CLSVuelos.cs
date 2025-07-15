using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeViajes_v2
{
    public class CLSVuelos
    {
        public string Codigo { get; set; }
        public string Origen {  get; set; }
        public string Destino { get; set; }
        public DateTime Fecha { get; set; }
        public string Horario { get; set; }
        public decimal Precio { get; set; }
    }
}
