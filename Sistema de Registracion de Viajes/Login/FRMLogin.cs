using Sistema_de_Registracion_de_Viajes.Admin;
using Sistema_de_Registracion_de_Viajes.Client;
using Sistema_de_Registracion_de_Viajes.CLS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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

        /* 

      -El sistema de registraciön de viajes no es ni mås ni menos que la herramienta que
          habitualmente utiliza cua/quier empresa dedicada a turismo.
      -Como es sabido Ia registraci6n de los viajes va a estar asociada a cada cliente. a cada
          empresa, destino, paquetes adquiridos, cantidad de adultos. cantidad de nihos
          indicando la edad de cada uno, fecha de salida y fecha de retorno, eI medio por el
          cual va a viajar, sea aéreo, maritimo O terrestre.
      -El sistema de registracion de viajes permitirå hacer un registro de cada cliente con
          los viajes realizados de manera de que se puede elegir un cliente y saber en qué
          destjno se estuvo como también elegir un destino y saber cuåles fueron los clientes
          que realizaron dicho viaje.
      -El Sistema deberá proponer distintos destinos y los cupos de cada uno de ellos.
     -Dicho cupo se descontara  ante la adquisición de los distintos clientes y aumentara
          en el caso de renuncia al viaje.
     -El sistema calculara el importe de devolución ante Ia cancelación dependiendo de
          la fecha del viaje y Ia cantidad de dias de antelacion de la cancelacion.
         puede persistir datos en archivos CSV.


      */

        private void btnSignup_Click(object sender, EventArgs e)
        {
            FRMSignup signup = new FRMSignup();
            signup.ShowDialog();
        }

        // Current user login method
        public CLSAdministrador CurrentAdmin { get; private set; }
        public CLSEmployeer CurrentEmployeer { get; private set; }
        public CLSClient CurrentClient { get; private set; }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if(!string.IsNullOrEmpty(txtPassword.Text) || !string.IsNullOrEmpty(txtUser.Text))
                {
                    bool userExists = false;
                    foreach (var line in File.ReadAllLines("users.csv"))
                    {
                        var data = line.Split(',');
                        int rol = int.Parse(data[0]); // Assuming the first column is the role as an integer
                        if (data[1] == txtUser.Text && data[2] == txtPassword.Text)
                        {
                            if (rol == 0)
                            {
                                //Admin
                                CurrentAdmin = new CLSAdministrador(0, data[1], data[2], data[3], data[4],
                                    int.Parse(data[5]), DateTime.Parse(data[6]), data[7], int.Parse(data[8]), data[9]);
                                CLSAdministrador.loginadmin(CurrentAdmin);
                                userExists = true;
                                FormShow(rol);
                                break;
                            }
                            else
                            {
                                if (rol == 1)
                                {
                                    //Employeer
                                    CurrentEmployeer = new CLSEmployeer(1, data[1], data[2], data[3], data[4],
                                        int.Parse(data[5]), DateTime.Parse(data[6]), data[7], int.Parse(data[8]), data[9]);
                                    CLSEmployeer.loginemp(CurrentEmployeer);
                                    userExists = true;
                                    FormShow(rol);
                                    break;
                                }
                                else if (rol == 2)
                                {
                                    //Client
                                    CurrentClient = new CLSClient(2, data[1], data[2], data[3], data[4],
                                        int.Parse(data[5]), DateTime.Parse(data[6]), data[7], int.Parse(data[8]), data[9]);
                                    CLSClient.loginclient(CurrentClient);
                                    userExists = true;
                                    FormShow(rol);
                                    break;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    if (!userExists)
                    {
                        MessageBox.Show("User can't be found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please fill in all fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        public void FormShow(int i)
        {
            if (i == 0)
            {
                // Open Admin Form
                FRMClient adminForm = new FRMAdmin();
                adminForm.Show();
            }
            else
            {
                if (i == 2)
                {
                    // Open Employeer Form
                    FRMEmployeer employeerForm = new FRMEmployeer();
                    employeerForm.Show();
                }
                else if (i == 3)
                {
                    // Open Client Form
                    FRMClient clientForm = new FRMClient();
                    clientForm.Show();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
           
             txtUser.BackColor = Color.White;
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
         txtUser.BackColor = ColorTranslator.FromHtml("#E8F6FF");
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            txtPassword.BackColor = Color.White;
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.BackColor = ColorTranslator.FromHtml("#E8F6FF");
        }
    }
}
