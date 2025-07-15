using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeViajes_v2
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void BtnIniciarSesion_Click(object sender, EventArgs e)
        {
            string email = txtCorreo.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password)) 
            {
                MessageBox.Show("Ingrese usuario y contraseña");
                return;
            }

            List<CLSCliente> clientes = ObtenerClientesDesdeArchivo("clientes.txt");

            CLSCliente clienteEncontrado = clientes.FirstOrDefault(c =>
            c.Email.Equals(email,StringComparison.OrdinalIgnoreCase) && c.Password == password);

            if (clienteEncontrado != null)
            {
                MessageBox.Show($"Bienvenido {clienteEncontrado.Nombre} {clienteEncontrado.Apellido}");

                FormMenu menu = new FormMenu(clienteEncontrado);
                menu.Show();
                this.Hide();
            }
            else 
            {
                MessageBox.Show("Correo o contraseña incorrectos");
            }
        }

        private List<CLSCliente> ObtenerClientesDesdeArchivo(string rutaArchivo)
        {
            List<CLSCliente> lista = new List<CLSCliente>();

            if (File.Exists(rutaArchivo))
            {
                string[] lineas = File.ReadAllLines(rutaArchivo);

                for (int i = 1; i < lineas.Length; i++)
                {
                    string[] partes = lineas[i].Split(',');

                    if (partes.Length == 6)
                    {
                        CLSCliente cliente = new CLSCliente
                        {
                            Id = int.Parse(partes[0]),
                            Dni = partes[1],
                            Nombre = partes[2],
                            Apellido = partes[3],
                            Email = partes[4],
                            Password = partes[5],
                        };
                        lista.Add(cliente);
                    }
                }
            }
            return lista;
        }
    }
}
