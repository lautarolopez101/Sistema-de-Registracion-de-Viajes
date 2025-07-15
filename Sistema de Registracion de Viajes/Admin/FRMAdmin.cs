using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Registracion_de_Viajes.Admin
{
    public partial class FRMAdmin : Form
    {
        bool sidebarExpand;
        bool managercollapse;
        public FRMAdmin()
        {
            InitializeComponent();
        }

        //Current Session Admin
        public CLSAdministrador Currentadmin { get; private set; }


        private void OpenForm(object formson)
        {
            if(this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form fh = formson as Form;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(fh);
            this.mainpanel.Tag = fh;
            fh.Show();
        }

        //Functionality for the buttons in the sidebar

        private void btnEmployeerManage_Click(object sender, EventArgs e)
        {
            OpenForm(new FRMEmployeerManager());
        }

        private void btnClientManage_Click(object sender, EventArgs e)
        {
            OpenForm(new FRMClientManager());
        }

        private void btnTripManage_Click(object sender, EventArgs e)
        {
            OpenForm(new FRMTripManager());
        }

        private void btnAccoutnsManage_Click(object sender, EventArgs e)
        {
            OpenForm(new FRMAccountsManager());
        }

        private void btnCompaniesManage_Click(object sender, EventArgs e)
        {
            OpenForm(new FRMCompaniesManager());
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Logout the current admin and close the form
            CLSAdministrador.logoutadmin();
            this.Close();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CLSAdministrador.logoutadmin();
            this.Close();
        }

       


















        // Design and functionality for the sidebar and manager panel
        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if(sidebarExpand)
            {
                // If sidebar is epxanded, minimize
               sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();

                }
            }
            else
            {
                // If sidebar is minimized, expand
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
                
            }
        }
        private void panel1_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }
        private void menubutton_Click(object sender, EventArgs e)
        {
            // set timer interval to lowest to make it smoother
            sidebarTimer.Start();
        }

        private void ManagerTimer_Tick(object sender, EventArgs e)
        {
            if(managercollapse)
            {
                ManageContainer.Height += 10;
                if (ManageContainer.Height == ManageContainer.MaximumSize.Height)
                {
                    managercollapse = false;
                    ManagerTimer.Stop();
                }
            }
            else
            {
                ManageContainer.Height -= 10;
                if (ManageContainer.Height == ManageContainer.MinimumSize.Height)
                {
                    managercollapse = true;
                    ManagerTimer.Stop();
                }
            }
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            // set timer interval to lowest to make it smoother
            ManagerTimer.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void bar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }
    }
}
