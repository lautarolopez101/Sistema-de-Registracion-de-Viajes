using Sistema_de_Registracion_de_Viajes.Empresas;
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
    public partial class FRMEmpresas : Form
    {
        public FRMEmpresas()
        {
            InitializeComponent();
        }

        private void verListaDeEmpresasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMLista_Empresas lista = new FRMLista_Empresas();
            lista.MdiParent = this.MdiParent;
            lista.FormBorderStyle = FormBorderStyle.None;
            lista.Dock = DockStyle.Fill;
            lista.TopLevel = false;
            lista.Show();
        }
    }
}
