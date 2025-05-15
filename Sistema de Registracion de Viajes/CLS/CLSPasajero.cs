using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Registracion_de_Viajes
{
    public  class CLSPasajero : CLSPersona
    {

        public string User { get; set; }
        public string Password { get; set; }
        public CLSPasajero(string user, string password, string nombre, string apellido, int dni, DateTime fechaNacimiento, string direccion, int telefono, string email)
        : base(nombre, apellido, dni, fechaNacimiento, direccion, telefono, email)
        {
            User = user;
            Password = password;

            // Constructor de CLSPasajero (puedes agregar más lógica aquí si hace falta)
        }

        // Comprar Pasaje
        // Reservar Pasaje
        // Cancelar Pasaje
    }
}
