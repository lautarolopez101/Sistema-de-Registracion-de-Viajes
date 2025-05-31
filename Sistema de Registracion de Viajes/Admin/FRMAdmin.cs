using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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


        //Functionality for the buttons in the sidebar

        private void btnEmployeerManage_Click(object sender, EventArgs e)
        {

        }

        private void btnClientManage_Click(object sender, EventArgs e)
        {

        }

        private void btnTripManage_Click(object sender, EventArgs e)
        {

        }

        private void btnAccoutnsManage_Click(object sender, EventArgs e)
        {

        }

        private void btnCompaniesManage_Click(object sender, EventArgs e)
        {

        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Logout the current admin and close the form
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

       
    }
}
