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
        

        private IClienteRepositorio _clienteRepositorio;
        private IEmpleadoRepositorio _empleadoRepositorio;
        public FormLogin()
        {
            InitializeComponent();

            _clienteRepositorio = new ArchivoClienteRepositorio();
            _empleadoRepositorio = new ArchivoEmpleadoRepositorio();
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


    }
}
