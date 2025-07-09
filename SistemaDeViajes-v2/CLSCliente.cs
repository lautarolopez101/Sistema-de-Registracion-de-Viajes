using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeViajes_v2
{
    public class CLSCliente : CLSPersona
    {
        List<CLSReserva> listareservas = new List<CLSReserva>();
       public CLSCliente(string nombre, string apellido, string mail, int telefono, string password, int dni, int id) : base(nombre, apellido, mail, telefono, password, dni, id)
        {
        }

        public string ToFileLine()
        {
            return $"{Nombre};{Apellido};{Mail};{Telefono};{Password};{DNI};{ID}";
        }
    }
}
