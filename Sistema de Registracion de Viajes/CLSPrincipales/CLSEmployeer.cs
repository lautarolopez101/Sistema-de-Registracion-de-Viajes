using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Registracion_de_Viajes
{
    public class CLSEmployeer : CLSClient
    {
        public CLSEmployeer()
        {
            
        }
        public CLSEmployeer(int rol,string user, string password, string nombre, string apellido, int dni, DateTime fecha_nacimiento, string direccion, int telefono, string correo)
            : base(rol,user, password, nombre, apellido, dni, fecha_nacimiento, direccion, telefono, correo)
        {
            // Constructor de CLSEmpleado (puedes agregar más lógica aquí si hace falta)
        }

        // Comprar Pasaje
        // Reservar Pasaje
        // Cancelar Pasaje
        //Agregar Cliente
        // Eliminar CLiente
        // Modificar Cliente

    }
}
