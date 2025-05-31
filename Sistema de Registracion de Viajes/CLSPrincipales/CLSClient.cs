using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Registracion_de_Viajes
{
    public  class CLSClient : CLSPerson
    {

        public string User { get; set; }
        public string Password { get; set; }
        public int Rol { get; set; }

        public CLSClient()
        {
            

        }
        public CLSClient(int rol, string user, string password, string name, string lastname, int dni, DateTime fechaNacimiento, string address, int phone, string mail)
        : base(name, lastname, dni, fechaNacimiento, address, phone, mail)
        {
            User = user;
            Password = password;
            Rol = rol;
            // Constructor de CLSPasajero (puedes agregar más lógica aquí si hace falta)
        }

        // Comprar Pasaje
        // Reservar Pasaje
        // Cancelar Pasaje
    }
}
