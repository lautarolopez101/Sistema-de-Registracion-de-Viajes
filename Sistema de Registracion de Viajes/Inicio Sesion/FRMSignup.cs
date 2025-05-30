using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
                        // Here you would typically save the user data to a database or file?


                    }
                    else
                    {
                        MessageBox.Show("Password aren't the same", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
