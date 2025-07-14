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
    public partial class FRMClienteABM : Form
    {
        private readonly string _clientesFilePath = "clientes.txt"; // Ruta del archivo de clientes
        private readonly string _reservasFilePath = "reservas.txt"; // Ruta del archivo de reservas


        List<CLSCliente> listaclientes = new List<CLSCliente>();
        private IClienteRepositorio _clienteRepositorio;

        public delegate void DataUpdatedEventHandler(object sender, string dataType);
        public event DataUpdatedEventHandler OnClientesUpdated;

        public delegate void ErrorNotificationEventHandler(string message, string caption, MessageBoxIcon icon);
        public event ErrorNotificationEventHandler OnErrorNotification;

        public FRMClienteABM()
        {
            InitializeComponent();
            _clienteRepositorio = new ArchivoClienteRepositorio();

            ActualizarClientes();


            OnClientesUpdated += FRMClienteABM_OnClientesUpdated;
            OnErrorNotification += FRMClienteABM_OnErrorNotification;
        }

        private void FRMClienteABM_OnErrorNotification(string message, string caption, MessageBoxIcon icon)
        {
            MessageBox.Show(message, caption, MessageBoxButtons.OK, icon);
        }

        private void FRMClienteABM_OnClientesUpdated(object sender, string dataType)
        {
            if (dataType == "Clientes")
            {
                dgvClientes.DataSource = null;
                dgvClientes.DataSource = listaclientes;
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

            int idClienteAEliminar;
            
            if (dgvClientes.CurrentRow == null) 
            { 
                /* mensaje de error */ return; 
            }
            CLSCliente clienteSeleccionado = dgvClientes.CurrentRow.DataBoundItem as CLSCliente;
            if (clienteSeleccionado == null) 
            { 
                /* mensaje de error */ return; 
            }
            idClienteAEliminar = clienteSeleccionado.ID;


            // Preguntar confirmación al usuario
            DialogResult confirmacion = MessageBox.Show($"¿Está seguro de que desea eliminar al cliente con ID {idClienteAEliminar}? Esta acción no se puede deshacer.", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmacion == DialogResult.No)
            {
                return; // El usuario canceló la operación
            }

            // 3. (CRÍTICO) Verificar si el cliente tiene reservas activas
            // Esta lógica debe estar en tu formulario o en una clase de lógica de negocio,
            // NO en el repositorio de clientes, ya que el repositorio de clientes no debería
            // saber sobre reservas.
            // Necesitarás un _reservaRepository o una función para leer el archivo de reservas.

            if (ClienteTieneReservasActivas(idClienteAEliminar)) // <-- NECESITARÁS IMPLEMENTAR ESTE MÉTODO EN TU FORMULARIO
            {
                MessageBox.Show("No se puede eliminar el cliente ya que tiene reservas activas. Cancele las reservas primero.", "Error de Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            try
            {
                _clienteRepositorio.DeleteCliente(idClienteAEliminar);
                MessageBox.Show($"Cliente con ID {idClienteAEliminar} eliminado exitosamente.", "Eliminación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

               ActualizarClientes(); 
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Archivo no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Cliente no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al eliminar el cliente: {ex.Message}", "Error Inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ClienteTieneReservasActivas(int idCliente)
        {
            // **Copiar y adaptar la lógica de verificación de reservas que ya tenías**
            // Necesitarás leer tu archivo de reservas (ej. "ReservasVuelos.txt")
            // y buscar si hay alguna reserva con ese idCliente y que su estado sea "activo" (no finalizado/cancelado).
            // Ejemplo (simplificado, asumiendo una ruta de archivo de reservas y una clase CLSReserva con Estado e IdCliente):
            string reservasFilePath = "ReservasVuelos.txt"; // Asegúrate que esta ruta sea correcta
            if (!File.Exists(reservasFilePath)) return false;

            try
            {
                List<CLSReserva> todasLasReservas = new List<CLSReserva>();
                using (StreamReader sr = new StreamReader(reservasFilePath))
                {
                    // sr.ReadLine(); // Descomentar si hay cabecera en reservas.txt
                    string linea;
                    while ((linea = sr.ReadLine()) != null)
                    {
                        if (string.IsNullOrWhiteSpace(linea)) continue;
                        try
                        {
                            // Asegúrate de tener CLSReserva.CreaReservaDesdeLinea
                            todasLasReservas.Add(CLSReserva.CreaReservaDesdeLinea(linea));
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Advertencia: Error al parsear línea de reserva para verificar: {linea}. {ex.Message}");
                        }
                    }
                }

                // Asume un enum EstadoReserva donde 0, 1, etc. son activos, y 2, 3 son finalizados/cancelados
                // Reemplaza esta lógica con la tuya:
                return todasLasReservas.Any(r => r.IdCliente == idCliente && r.Estado != (int)EstadoReserva.Finalizada && r.Estado != (int)EstadoReserva.Cancelada);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al verificar reservas activas: {ex.Message}", "Error de Verificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Si hay un error al leer el archivo de reservas, es mejor asumir un problema.
                throw new InvalidOperationException("No se pudo verificar el estado de las reservas debido a un error.", ex);
            }
        }
        public enum EstadoReserva
        {
            Activa = 0, // O el valor que uses para reservas activas
            Confirmada = 1,
            Finalizada = 2,
            Cancelada = 3 // O los valores que uses para estados que NO son activos
        }
    }
}
