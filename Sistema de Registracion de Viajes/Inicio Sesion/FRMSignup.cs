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
                if(
                     !string.IsNullOrEmpty(txtAddress.Text) || !string.IsNullOrEmpty(txtUser.Text) || !string.IsNullOrEmpty(txtPassword.Text)
                      || !string.IsNullOrEmpty(txtName.Text) || !string.IsNullOrEmpty(txtLastName.Text) || !string.IsNullOrEmpty(txtDNI.Text)
                        || !string.IsNullOrEmpty(txtMail.Text) || !string.IsNullOrEmpty(txtPassword_Confirmed.Text) || !string.IsNullOrEmpty(txtPhone.Text)

                    )
                {

                    if(txtPassword.Text == txtPassword_Confirmed.Text)
                    {
                        // Here you would typically save the user data to a database or file

                    string rol = CMBXRol.SelectedItem.ToString();

                        if (rol == "Administrator")
                        {
                            CLSAdministrador admin = new CLSAdministrador(1,txtUser.Text,txtPassword.Text,
                                txtName.Text, txtLastName.Text, int.Parse(txtDNI.Text),dateTimePicker1.Value, //Create User 
                                txtAddress.Text, int.Parse(txtPhone.Text), txtMail.Text 
                                );
                            using(StreamWriter sw = new StreamWriter("users.csv", true))
                            {
                                sw.WriteLine($"{admin.Rol},{admin.User},{admin.Password},{admin.Name},{admin.LastName},{admin.DNI}," +
                                    $"{admin.Fecha_Nacimiento.ToShortDateString()},{admin.Address},{admin.Phone},{admin.Mail}");
                            }
                            MessageBox.Show("You have been registered as an Administrator", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            if (rol == "Employeer")
                            {

                                CLSEmployeer employeer = new CLSEmployeer(2,txtUser.Text, txtPassword.Text,
                                    txtName.Text, txtLastName.Text, int.Parse(txtDNI.Text), dateTimePicker1.Value,  //Create User 
                                    txtAddress.Text, int.Parse(txtPhone.Text), txtMail.Text
                                    );
                                using (StreamWriter sw = new StreamWriter("users.csv", true))
                                {
                                    sw.WriteLine($"{employeer.Rol},{employeer.User},{employeer.Password},{employeer.Name},{employeer.LastName},{employeer.DNI}," +
                                        $"{employeer.Fecha_Nacimiento.ToShortDateString()},{employeer.Address},{employeer.Phone},{employeer.Mail}");
                                }

                                MessageBox.Show("You have been registered as an Employeer", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else if(rol == "Client")
                            {

                                CLSClient client = new CLSClient(3,txtUser.Text, txtPassword.Text,
                                    txtName.Text, txtLastName.Text, int.Parse(txtDNI.Text), dateTimePicker1.Value,   //Create User 
                                    txtAddress.Text, int.Parse(txtPhone.Text), txtMail.Text
                                    );

                                using (StreamWriter sw = new StreamWriter("users.csv", true))
                                {
                                    sw.WriteLine($"{client.Rol},{client.User},{client.Password},{client.Name},{client.LastName},{client.DNI}," +
                                        $"{client.Fecha_Nacimiento.ToShortDateString()},{client.Address},{client.Phone},{client.Mail}");
                                }
                                    MessageBox.Show("You have been registered as an Client", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();

                            }

                        }


                    }
                    else
                    {
                        MessageBox.Show("Password aren't the same, Check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please, fill all the fields","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
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

      
    }
}
