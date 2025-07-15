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
            CargarClientesEnDataGridView();

            OnClientesUpdated += FRMClienteABM_OnClientesUpdated;
            OnErrorNotification += FRMClienteABM_OnErrorNotification;

            txtIDCliente.ReadOnly = true;
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

        private void CargarClientesEnDataGridView()
        {
            try
            {
                // Obtiene la lista de clientes del repositorio
                List<CLSCliente> clientes = _clienteRepositorio.GetAllClientes();

                dgvClientes.DataSource = clientes;


                dgvClientes.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dgvClientes.AllowUserToAddRows = false; // Para evitar que el usuario añada filas directamente
                dgvClientes.ReadOnly = true; // Para hacer el DataGridView de solo lectura
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los clientes: {ex.Message}", "Error de Carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Si hay un error, el DataGridView no muestra datos incorrectos
                dgvClientes.DataSource = null;
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
                listaclientes.Clear();
            }
            finally
            {
                // Dispara el evento para actualizar la Interfaz de Usuario si es necesario
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

            // Generar ID único para el nuevo cliente 
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
                OnErrorNotification?.Invoke("Por favor, seleccione un cliente de la lista para eliminar", "Ningún Cliente seleccionado", MessageBoxIcon.Error);
                return;
            }
            CLSCliente clienteSeleccionado = dgvClientes.CurrentRow.DataBoundItem as CLSCliente;
            if (clienteSeleccionado == null)
            {
                OnErrorNotification?.Invoke("No se pudo obtener la información del cliente seleccionado. Por favor, intente nuevamente", "Error de selección", MessageBoxIcon.Error);
                return;
            }
            idClienteAEliminar = clienteSeleccionado.ID;


            // Preguntar confirmación al usuario
            DialogResult confirmacion = MessageBox.Show($"¿Está seguro de que desea eliminar al cliente con ID {idClienteAEliminar}? Esta acción no se puede deshacer.", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmacion == DialogResult.No)
            {
                return; // El usuario canceló la operación
            }

            if (ClienteTieneReservasActivas(idClienteAEliminar))
            {
                OnErrorNotification?.Invoke("No se puede eliminar el cliente ya que tiene reservas activas. Cancele las reservas primero.", "Error de Eliminación", MessageBoxIcon.Warning);
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
                OnErrorNotification?.Invoke($"Error: {ex.Message}", "Archivo no encontrado", MessageBoxIcon.Warning);
            }
            catch (InvalidOperationException ex)
            {
                OnErrorNotification?.Invoke($"Error: {ex.Message}", "Cliente no encontrado", MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                OnErrorNotification?.Invoke($"Ocurrio un error al eliminar al cliente: {ex.Message}", "Error Inesperado", MessageBoxIcon.Error);
            }
        }

        private void dgvClientes_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                CLSCliente clienteSeleccionado = dgvClientes.Rows[e.RowIndex].DataBoundItem as CLSCliente;
                if (clienteSeleccionado != null)
                {
                    // Cargar los datos del cliente seleccionado en los TextBoxes
                    txtNombreCliente.Text = clienteSeleccionado.Nombre;
                    txtApellidoCliente.Text = clienteSeleccionado.Apellido;
                    txtMailCliente.Text = clienteSeleccionado.Mail;
                    txtTelefonoCliente.Text = clienteSeleccionado.Telefono.ToString();
                    txtPasswordCliente.Text = clienteSeleccionado.Password;
                    txtDNICliente.Text = clienteSeleccionado.DNI.ToString();
                    txtIDCliente.Text = clienteSeleccionado.ID.ToString();
                }
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
                    sr.ReadLine(); 
                    string linea;
                    while ((linea = sr.ReadLine()) != null)
                    {
                        if (string.IsNullOrWhiteSpace(linea)) continue;
                        try
                        {
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
                throw new InvalidOperationException("No se pudo verificar el estado de las reservas debido a un error.", ex);
            }
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            CLSCliente clienteAModificar;
            int idModificar;

            // *** PASO 1: VERIFICAR SI HAY UNA FILA SELECCIONADA EN EL DATAGRIDVIEW ***
            if (dgvClientes.CurrentRow == null)
            {
                MessageBox.Show(
                    "Por favor, seleccione un cliente de la lista para modificar.",
                    "Ningún Cliente Seleccionado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                return;
            }

            // *** PASO 2: OBTENER EL ID DEL CLIENTE SELECCIONADO DESDE EL TEXTBOX (que ya debería estar cargado por CellClick) ***
            if (!int.TryParse(txtIDCliente.Text, out idModificar))
            {
                // Esto podría ocurrir si el txtID.Text se corrompió o no fue cargado correctamente
                MessageBox.Show("No se pudo obtener el ID del cliente seleccionado. Por favor, recargue la lista e intente de nuevo.", "Error de ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // *** PASO 3: VALIDAR LOS DEMÁS CAMPOS DE ENTRADA 
            int telefonoModificado, dniModificado;

            if (!int.TryParse(txtTelefonoCliente.Text, out telefonoModificado))
            {
                MessageBox.Show("El Teléfono no es válido. Debe ser un número.", "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(txtDNICliente.Text, out dniModificado))
            {
                MessageBox.Show("El DNI no es válido. Debe ser un número.", "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtNombreCliente.Text) ||
                string.IsNullOrWhiteSpace(txtApellidoCliente.Text) ||
                string.IsNullOrWhiteSpace(txtMailCliente.Text) ||
                string.IsNullOrWhiteSpace(txtPasswordCliente.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios (Nombre, Apellido, Mail, Password).", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // *** PASO 4: CREAR EL OBJETO CLSCLIENTE CON LOS DATOS MODIFICADOS ***
            // Usamos el idModificar que obtuvimos del txtID (que a su vez fue cargado por la selección del DGV)
            clienteAModificar = new CLSCliente(
                txtNombreCliente.Text.Trim(),
                txtApellidoCliente.Text.Trim(),
                txtMailCliente.Text.Trim(),
                telefonoModificado,
                txtPasswordCliente.Text.Trim(),
                dniModificado,
                idModificar // Este es el ID del cliente que se está modificando
            );

            DialogResult confirmacion = MessageBox.Show($"¿Está seguro de que desea guardar los cambios para el cliente con ID {clienteAModificar.ID}?", "Confirmar Modificación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmacion == DialogResult.No)
            {
                return;
            }

            try
            {
                _clienteRepositorio.ModificarCliente(clienteAModificar);
                MessageBox.Show($"Cliente con ID {clienteAModificar.ID} modificado exitosamente.", "Modificación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarClientesEnDataGridView(); // Recargar para ver los cambios
                LimpiarCamposCliente(); // Limpiar los TextBoxes
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
                MessageBox.Show($"Ocurrió un error al modificar el cliente: {ex.Message}", "Error Inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCamposCliente()
        {
            txtNombreCliente.Clear();
            txtApellidoCliente.Clear();
            txtMailCliente.Clear();
            txtTelefonoCliente.Clear();
            txtPasswordCliente.Clear();
            txtDNICliente.Clear();
            txtIDCliente.Clear();
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


