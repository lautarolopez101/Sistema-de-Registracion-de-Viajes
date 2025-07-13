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
    public partial class FormMenuEmpleado : Form
    {
        private CLSEmpleado empleadologueado;
        private Form currentChildForm;

        public FormMenuEmpleado(CLSEmpleado empleado)
        {
            InitializeComponent();

            empleadologueado = empleado;
        }

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            FRMRegistrarCliente nuevoform = new FRMRegistrarCliente();
            nuevoform.Show();
            this.Hide();
        }

        
    }
}
