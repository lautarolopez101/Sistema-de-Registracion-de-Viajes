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
                    if (!string.IsNullOrEmpty(txtNombre.Text) && !string.IsNullOrEmpty(txtApellido.Text) && !string.IsNullOrEmpty(txtNombre_Usuario.Text) && !string.IsNullOrEmpty(txtPassword.Text))
                    {
                        Pasajeros cliente = new Pasajeros(
                            txtNombre_Usuario.Text,
                            txtPassword.Text,
                            txtNombre.Text,
                            txtApellido.Text,
                            DTPFecha_Nacimiento.Text,
                            Convert.ToInt32(txtDNI.Text)
                        );

                        using (StreamWriter sw = new StreamWriter("Clientes.csv", true))
                        {
                            sw.WriteLine($"{cliente.Nombre_Usuario},{cliente.Password},{cliente.Nombre},{cliente.Apellido},{cliente.Fecha_Nacimiento},{cliente.DNI}");
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
            txtNombre_Usuario.Clear();
            txtPassword.Clear();
            txtPassword_Confirm.Clear();
            DTPFecha_Nacimiento.ResetText();
            txtNombre.Focus();
        }

       
    }
}
