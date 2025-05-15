using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Registracion_de_Viajes
{
    public abstract class CLSPersona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }
        public DateTime Fecha_Nacimiento { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
        public string Correo { get; set; }
        private int Edad_;

        public int Edad
        {
            set { Edad_ = ( DateTime.Now.Year -  Fecha_Nacimiento.Year); }
        }

        public CLSPersona(string nombre, string apellido, int dni, DateTime fecha_nacimiento, string direccion, int telefono, string correo)
        {
            Nombre = nombre;
            Apellido = apellido;
            DNI = dni;
            Fecha_Nacimiento = fecha_nacimiento;
            Direccion = direccion;
            Telefono = telefono;
            Correo = correo;
        }
    }
}
