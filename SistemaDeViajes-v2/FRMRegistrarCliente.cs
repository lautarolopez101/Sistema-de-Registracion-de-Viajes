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
    public partial class FRMRegistrarCliente : Form
    {
        List<CLSCliente> listaclientes = new List<CLSCliente>();
        private IClienteRepositorio _clienteRepositorio;

        public delegate void DataUpdatedEventHandler(object sender, string dataType);
        public event DataUpdatedEventHandler OnClientesUpdated;

        public delegate void ErrorNotificationEventHandler(string message, string caption, MessageBoxIcon icon);
        public event ErrorNotificationEventHandler OnErrorNotification;

        public FRMRegistrarCliente()
        {
            InitializeComponent();
            _clienteRepositorio = new ArchivoClienteRepositorio();

            ActualizarClientes();


            OnClientesUpdated += FRMRegistrarCliente_OnClientesUpdated;
            OnErrorNotification += FRMRegistrarCliente_OnErrorNotification;
        }

        private void FRMRegistrarCliente_OnErrorNotification(string message, string caption, MessageBoxIcon icon)
        {
            MessageBox.Show(message, caption, MessageBoxButtons.OK, icon);
        }

        private void FRMRegistrarCliente_OnClientesUpdated(object sender, string dataType)
        {
            if (dataType == "Clientes")
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = listaclientes;
            }
        }

        private void ActualizarClientes()
        {
            try
            {
                // Llama al repositorio para obtener todos los clientes
                listaclientes = _clienteRepositorio.GetAllClientes();
            }
            catch (Exception ex)
            {
                OnErrorNotification?.Invoke($"Error al cargar clientes: {ex.Message}", "Error de Carga", MessageBoxIcon.Error);
                listaclientes.Clear(); // Asegúrate de que la lista esté vacía si hubo un error grave
            }
            finally
            {
                // Dispara el evento para actualizar la UI si es necesario
                OnClientesUpdated?.Invoke(this, "Clientes");
            }

        }



        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombreCliente.Text) || string.IsNullOrEmpty(txtApellidoCliente.Text) ||
                string.IsNullOrEmpty(txtDNICliente.Text) || string.IsNullOrEmpty(txtMailCliente.Text) ||
                string.IsNullOrEmpty(txtPasswordCliente.Text) || string.IsNullOrEmpty(txtTelefonoCliente.Text))
            {
                OnErrorNotification("Por favor, complete todos los campos.", "Campos Vacíos", MessageBoxIcon.Error);
                return;
            }


            string nombre = txtNombreCliente.Text.Trim();
            string apellido = txtApellidoCliente.Text.Trim();
            string mail = txtMailCliente.Text.Trim();
            string password = txtPasswordCliente.Text.Trim();
            int DNI;
            if (!int.TryParse(txtDNICliente.Text.Trim(), out DNI))
            {
                OnErrorNotification?.Invoke("El DNI debe ser un número válido.", "Error de Formato", MessageBoxIcon.Error);
                return;
            }

            int telefono;
            if (!int.TryParse(txtTelefonoCliente.Text.Trim(), out telefono))
            {
                OnErrorNotification?.Invoke("El Teléfono debe ser un número válido.", "Error de Formato", MessageBoxIcon.Error);
                return;
            }

            // Generar ID único para el nuevo cliente (aquí podrías mover esta lógica al repositorio si quisieras)
            int nuevoId = 1;
            if (listaclientes.Any())
            {
                nuevoId = listaclientes.Max(c => c.ID) + 1;
            }

            CLSCliente nuevoCliente = new CLSCliente(
                nombre,
                apellido,
                mail,
                telefono,
                password,
                DNI,
                nuevoId
            );

            try
            {
                // Llama al repositorio para agregar el cliente
                _clienteRepositorio.AddCliente(nuevoCliente);
                listaclientes.Add(nuevoCliente); // Agrega también a la lista en memoria si el guardado fue exitoso

                OnErrorNotification?.Invoke("Cliente agregado exitosamente.", "Éxito", MessageBoxIcon.Information);

                // Limpiar los campos
                txtNombreCliente.Clear(); txtApellidoCliente.Clear(); txtMailCliente.Clear();
                txtTelefonoCliente.Clear(); txtPasswordCliente.Clear(); txtDNICliente.Clear();
            }
            catch (Exception ex)
            {
                OnErrorNotification?.Invoke($"Error al guardar el cliente: {ex.Message}", "Error de Guardado", MessageBoxIcon.Error);
            }
            finally
            {
                OnClientesUpdated?.Invoke(this, "Clientes");
            }
        }

        private void brnEliminarCliente_Click(object sender, EventArgs e)
        {

        }
    }
}
