using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Registracion_de_Viajes
{
    public abstract class CLSPasajero : CLSPersona
    {

        public CLSPasajero(string nombre, string apellido, int dni, DateTime fechaNacimiento, string direccion, int telefono, string email)
        : base(nombre, apellido, dni, fechaNacimiento, direccion, telefono, email)
        {
            // Constructor de CLSPasajero (puedes agregar más lógica aquí si hace falta)
        }

    }
}
