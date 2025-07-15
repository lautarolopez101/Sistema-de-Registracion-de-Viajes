using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Registracion_de_Viajes
{
    public class Pasajeros
    {

        public string Nombre { get; set; }
        public string Apellido{ get; set; }
        public string Fecha_Nacimiento { get; set; }
        public string Nombre_Usuario { get; set; } 
        public String Password { get; set; }
        public int DNI {  get; set; }


        public Pasajeros(string nombre_usuario,string password,string nombre,string apellido, string fecha_nacimiento, int dni)
        {
            Nombre = nombre;
            Apellido = apellido;
            Fecha_Nacimiento = fecha_nacimiento;
            Nombre_Usuario = nombre_usuario;
            Password = password;
            DNI = dni;
        }

    }
}
