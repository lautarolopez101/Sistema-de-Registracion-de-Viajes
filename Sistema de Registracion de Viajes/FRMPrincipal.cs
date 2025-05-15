using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Registracion_de_Viajes
{
   public partial class FRMPrincipal : Form
    {
        public FRMPrincipal()
        {
            InitializeComponent();
        }

        private void FRMPrincipal_Load(object sender, EventArgs e)
        {
            FRMLogin login = new FRMLogin();
            login.MdiParent = this;
            login.Dock = DockStyle.Fill;
            login.TopLevel = false;
            login.FormBorderStyle = FormBorderStyle.None;
            login.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMLogin login = new FRMLogin();
            login.MdiParent = this;
            login.Dock = DockStyle.Fill;
            login.TopLevel = false;
            login.FormBorderStyle = FormBorderStyle.None;
            login.Show();
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMRegister register = new FRMRegister();
            register.MdiParent = this;
            register.Dock = DockStyle.Fill;
            register.TopLevel = false;
            register.FormBorderStyle = FormBorderStyle.None;
            register.Show();
        }

<<<<<<< HEAD
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
=======
        private void sistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {

>>>>>>> cbd90bf (Login-Sign Up, Hay que Probar)
        }
    }
}
