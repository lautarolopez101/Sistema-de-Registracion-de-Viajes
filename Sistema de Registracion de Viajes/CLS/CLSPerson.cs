using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Registracion_de_Viajes
{
    public abstract class CLSPerson
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int DNI { get; set; }
        public DateTime Fecha_Nacimiento { get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }
        public string Mail { get; set; }
        private int Edad_;

        public int Edad
        {
            set { Edad_ = ( DateTime.Now.Year -  Fecha_Nacimiento.Year); }
        }

        protected CLSPerson()
        {
            

        }
        public CLSPerson(string name, string lastname, int dni, DateTime fecha_nacimiento, string address, int phone, string mail)
        {
            Name = name;
            LastName = lastname;
            DNI = dni;
            Fecha_Nacimiento = fecha_nacimiento;
            Address = address;
            Phone = phone;
            Mail = mail;
           
        }
    }
}
