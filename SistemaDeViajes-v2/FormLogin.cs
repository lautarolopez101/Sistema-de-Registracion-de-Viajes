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
<<<<<<< HEAD
        public FormLogin()
        {
            InitializeComponent();
=======
        

        private IClienteRepositorio _clienteRepositorio;
        private IEmpleadoRepositorio _empleadoRepositorio;
        public FormLogin()
        {
            InitializeComponent();

            _clienteRepositorio = new ArchivoClienteRepositorio();
            _empleadoRepositorio = new ArchivoEmpleadoRepositorio();
>>>>>>> d5c9284cf3308a32f306d8e02def64f594b61442
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

<<<<<<< HEAD
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
=======
            List<CLSCliente> clientes = new List<CLSCliente>();
            try
            {
                clientes = _clienteRepositorio.GetAllClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar clientes: {ex.Message}", "Error de Carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CLSCliente clienteEncontrado = clientes.FirstOrDefault(c => c.Mail.Equals(email, StringComparison.OrdinalIgnoreCase) && c.Password == password);

            if (clienteEncontrado != null)
            {
                MessageBox.Show($"Bienvenido Cliente: {clienteEncontrado.Nombre} {clienteEncontrado.Apellido}");
                FormMenu menuCliente = new FormMenu(clienteEncontrado); // O un FormMenu específico para clientes
                menuCliente.Show();
                this.Hide();
                return; // Cliente encontrado, salimos del método
            }

            List<CLSEmpleado> empleados = new List<CLSEmpleado>();
            try
            {
                empleados = _empleadoRepositorio.GetAllEmpleados();
            }
            catch (Exception ex)
            {
                // Manejo de error si no se pueden cargar los empleados
                MessageBox.Show($"Error al cargar empleados: {ex.Message}", "Error de Carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CLSEmpleado empleadoEncontrado = empleados.FirstOrDefault(emp =>emp.Mail.Equals(email, StringComparison.OrdinalIgnoreCase) && emp.Password == password);

            if (empleadoEncontrado != null)
            {
                MessageBox.Show($"Bienvenido Empleado: {empleadoEncontrado.Nombre} {empleadoEncontrado.Apellido}");
                FormMenuEmpleado menuEmpleado = new FormMenuEmpleado(empleadoEncontrado); // Un FormMenu diferente para empleados
                menuEmpleado.Show();
                this.Hide();
                return; // Empleado encontrado, salimos del método
            }
            else
            {
                // Si no se encontró ni como cliente ni como empleado
                MessageBox.Show("Correo o contraseña incorrectos.", "Error de Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


>>>>>>> d5c9284cf3308a32f306d8e02def64f594b61442
    }
}
