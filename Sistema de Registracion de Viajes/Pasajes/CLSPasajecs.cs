using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Registracion_de_Viajes
{
    public class CLSPasajecs
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }
        public string Destino { get; set; }
        public string Empresa { get; set; }
        public string  Medio_Transporte { get; set; }
        public DateTime Fecha_Salida { get; set; }
        public DateTime Fecha_Llegada { get; set; }
        public int Cant_Pasajeros { get; set; }
        
        
        
        public CLSPasajecs(string nombre,string apellido,
            int dni, string destino, 
            string empresa, DateTime fecha_salida, 
            DateTime fecha_llegada,int cant_pasajeros,
            string medio_transporte)
        {
            Nombre = nombre;
            Apellido = apellido;
            DNI = dni;
            Destino = destino;
            Empresa = empresa;
            Fecha_Salida = fecha_salida;
            Fecha_Llegada = fecha_llegada;
            Cant_Pasajeros = cant_pasajeros;
            Medio_Transporte = medio_transporte;
        }
    }
}
