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
        public CLSPasajero(string user, string password, string name, string lastname, int dni, DateTime fechaNacimiento, string address, int phone, string mail)
        : base(name, lastname, dni, fechaNacimiento, address, phone, mail)
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
