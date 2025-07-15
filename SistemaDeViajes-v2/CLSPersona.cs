using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeViajes_v2
{
    public class CLSPersona
    {
        private string _Nombre;

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        private string _Apellido;

        public string Apellido
        {
            get { return _Apellido; }
            set { _Apellido = value; }
        }

        private string _Mail;

        public string Mail
        {
            get { return _Mail; }
            set { _Mail = value; }
        }

        private int _Telefono;

        public int Telefono
        {
            get { return _Telefono; }
            set { _Telefono = value; }
        }

        private string _Password;

        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }

        private int _DNI;

        public int DNI
        {
            get { return _DNI; }
            set { _DNI = value; }
        }

        private int _ID;

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        public CLSPersona(string nombre, string apellido, string mail, int telefono, string password, int dni, int id)
        {
            Nombre = nombre;
            Apellido = apellido;
            Mail = mail;
            Telefono = telefono;
            Password = password;
            DNI = dni;
            ID = id;
        }
    }
}
