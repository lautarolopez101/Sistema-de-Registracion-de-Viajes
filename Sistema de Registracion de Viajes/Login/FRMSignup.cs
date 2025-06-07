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
    public partial class FRMSignup : Form
    {
        public FRMSignup()
        {
            InitializeComponent();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtAddress.Text) &&
                    !string.IsNullOrEmpty(txtUser.Text) &&
                    !string.IsNullOrEmpty(txtPassword.Text) &&
                    !string.IsNullOrEmpty(txtName.Text) &&
                    !string.IsNullOrEmpty(txtLastName.Text) &&
                    !string.IsNullOrEmpty(txtDNI.Text) &&
                    !string.IsNullOrEmpty(txtMail.Text) &&
                    !string.IsNullOrEmpty(txtPassword_Confirmed.Text) &&
                    !string.IsNullOrEmpty(txtPhone.Text))
                {
                    if (txtPassword.Text == txtPassword_Confirmed.Text)
                    {
                        CLSPerson persona = null;
                        string rolSeleccionado = CMBXRol.SelectedItem.ToString();

                        switch (rolSeleccionado)
                        {
                            case "Administrator":
                                persona = new CLSAdministrador(0, txtUser.Text, txtPassword.Text, txtName.Text, txtLastName.Text,
                                    int.Parse(txtDNI.Text), dateTimePicker1.Value, txtAddress.Text, int.Parse(txtPhone.Text), txtMail.Text);
                                break;

                            case "Employeer":
                                persona = new CLSEmployeer(1, txtUser.Text, txtPassword.Text, txtName.Text, txtLastName.Text,
                                    int.Parse(txtDNI.Text), dateTimePicker1.Value, txtAddress.Text, int.Parse(txtPhone.Text), txtMail.Text);
                                break;

                            case "Client":
                                persona = new CLSClient(2, txtUser.Text, txtPassword.Text, txtName.Text, txtLastName.Text,
                                    int.Parse(txtDNI.Text), dateTimePicker1.Value, txtAddress.Text, int.Parse(txtPhone.Text), txtMail.Text);
                                break;
                        }

                        if (persona != null)
                        {
                            using (StreamWriter sw = new StreamWriter("..\\..\\Archivos\\users.csv", true))
                            {
                                sw.WriteLine($"{persona.Rol},{persona.User},{persona.Password},{persona.Name},{persona.LastName},{persona.DNI}," +
                                             $"{persona.Fecha_Nacimiento:yyyy-MM-dd},{persona.Address},{persona.Phone},{persona.Mail}");
                            }

                            MessageBox.Show($"You have been registered as a {rolSeleccionado}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Passwords aren't the same. Check again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please, fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrarse: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
