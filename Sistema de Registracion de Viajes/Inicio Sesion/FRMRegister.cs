using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Registracion_de_Viajes
{
    public partial class FRMRegister : Form
    {
        public FRMRegister()
        {
            InitializeComponent();
        }

        private void btnCrear_Cuenta_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtPassword.Text == txtPassword_Confirm.Text)
                 {
                    if (!string.IsNullOrEmpty(txtNombre.Text) && !string.IsNullOrEmpty(txtApellido.Text) && !string.IsNullOrEmpty(txtUser.Text) && !string.IsNullOrEmpty(txtPassword.Text))
                    {
                        CLSPasajero cliente = new CLSPasajero(
                            txtUser.Text,
                            txtPassword.Text,
                            txtNombre.Text,
                            txtApellido.Text,
                            Convert.ToInt32(txtDNI.Text),
                            Convert.ToDateTime(DTPFecha_Nacimiento.Text),
                            txtDireccion.Text,
                            Convert.ToInt32(txtTelefono.Text),
                            txtMail.Text
                        );

                        using (StreamWriter sw = new StreamWriter("Clientes.csv", true))
                        {
                            sw.WriteLine($"{cliente.User}," +
                                $"{cliente.Password}," +
                                $"{cliente.Nombre}," +
                                $"{cliente.Apellido}," +
                                $"{cliente.DNI}," +
                                $"{cliente.Fecha_Nacimiento}," +
                                $"{cliente.Direccion}," +
                                $"{cliente.Telefono}," +
                                $"{cliente.Correo}");

                        }
                        MessageBox.Show("Cliente Creado Exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error al Crear Cliente, Completa todos los Campos ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    MessageBox.Show("Error al Crear Cliente, Las contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }       
            catch (Exception ex)
            {
                MessageBox.Show("Error al Crear Cliente " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtNombre.Clear();
            txtApellido.Clear();
            txtDNI.Clear();
            txtUser.Clear();
            txtPassword.Clear();
            txtPassword_Confirm.Clear();
            DTPFecha_Nacimiento.ResetText();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtMail.Clear();
            txtNombre.Focus();
        }

       
    }
}
