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
    public partial class FRMLogin : Form
    {
        public FRMLogin()
        {
            InitializeComponent();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            FRMRegister register = new FRMRegister();
            register.MdiParent = this;
            register.Dock = DockStyle.Fill;
            register.TopLevel = false;
            register.FormBorderStyle = FormBorderStyle.None;
            register.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string password = txtPassword.Text;

            foreach(var line in File.ReadLines("Clientes.csv"))
            {
                var data = line.Split(',');
                if (data[0] == user && data[1] == password)
                {
                    MessageBox.Show("Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            txtUser.Clear();
            txtPassword.Clear();
            txtUser.Focus();
        }
    }
}
