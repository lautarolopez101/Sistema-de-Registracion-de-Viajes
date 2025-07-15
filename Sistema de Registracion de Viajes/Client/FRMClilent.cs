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

namespace Sistema_de_Registracion_de_Viajes.Client
{
    public partial class FRMClilent : Form
    {
        public FRMClilent()
        {
            InitializeComponent();
        }





        private void btnLogOut_Click(object sender, EventArgs e)
        {
            CLSClient.logoutclient();
            this.Close();
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            CLSClient.logoutclient();
            this.Close();
        }












        // Variables for the sidebar and menu collapse functionality
        bool sidebadExpand;
        bool menucollapse;
        private void MenuCollapseTimer_Tick(object sender, EventArgs e)
        {
            if (menucollapse)
            {
                ManageMenu.Height += 10;
                if (ManageMenu.Height == ManageMenu.MaximumSize.Height)
                {
                    menucollapse = false;
                    MenuCollapseTimer.Stop();
                }
                else
                {
                    ManageMenu.Height -= 10;
                    if (ManageMenu.Height == ManageMenu.MinimumSize.Height)
                    {
                        menucollapse = true;
                        MenuCollapseTimer.Stop();
                    }
                }
            }
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebadExpand)
            {
                sidebar.Width -= 10;
                if(sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebadExpand = false;
                    sidebarTimer.Stop();
                }
                else
                {
                    sidebar.Width += 10;
                    if(sidebar.Width == sidebar.MaximumSize.Width)
                    {
                        sidebadExpand = true;
                        sidebarTimer.Stop();
                    }   
                }
            }
        }

        

        private void btnCollapseMenu_Click(object sender, EventArgs e)
        {
            MenuCollapseTimer.Start();
        }

        private void lblMenu_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        [DllImport("user32.DLL",EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void bar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        
        private void panel1_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();   
        }
    }
}
