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

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

      

    }
}
