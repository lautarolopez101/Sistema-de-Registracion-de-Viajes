using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Registracion_de_Viajes
{
    public class CLSAdministrador :CLSEmployeer
    {
        public static CLSAdministrador CurrentAdmin { get; private set; }

        public static void loginadmin(CLSAdministrador admin)
        {
            CurrentAdmin = admin;   
        }

        public static void logoutadmin()
        {
            CurrentAdmin = null;
        }

        public static bool isLoggedInadmin()
        {
            return CurrentAdmin != null;
        }
        public CLSAdministrador()
        {
            // Constructor por defecto de CLSAdministrador (puedes agregar más lógica aquí si hace falta)
        }
        public CLSAdministrador(int rol, string user, string password, string name, 
            string lastname, int dni, DateTime fecha_nacimiento, 
            string address, int phone, string mail)
            : base(rol, user, password, name, lastname, dni, fecha_nacimiento, address, phone, mail)
        {
            // Constructor de CLSAdministrador (puedes agregar más lógica aquí si hace falta)
        }
        // Comprar Pasaje
        // Reservar Pasaje
        // Cancelar Pasaje
        //Agregar Cliente
        // Eliminar CLiente
        // Modificar Cliente
        //Agregar Empresa
        //Eliminar Empresa 
        //Modificar Empresa
        // Agregar Viaje
        // Eliminar Viaje
        // Modificar Viaje

    }
}
