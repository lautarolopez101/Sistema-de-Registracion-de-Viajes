using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeViajes_v2
{
<<<<<<< HEAD
    public class CLSCliente
    {
        public int Id { get; set; }
        public string Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
=======
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
>>>>>>> d5c9284cf3308a32f306d8e02def64f594b61442
    }
}
