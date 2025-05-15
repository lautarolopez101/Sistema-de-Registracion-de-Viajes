using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Registracion_de_Viajes
{
    public abstract  class CLSAdministrador :CLSEmpleado
    {

        protected CLSAdministrador(string nombre, string apellido, int dni, DateTime fecha_nacimiento, string direccion, int telefono, string correo)
            : base(nombre, apellido, dni, fecha_nacimiento, direccion, telefono, correo)
        {
            // Constructor de CLSAdministrador (puedes agregar más lógica aquí si hace falta)
        }
        

    }
}
