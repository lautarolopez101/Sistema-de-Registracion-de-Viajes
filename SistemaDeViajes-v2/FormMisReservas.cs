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
    public partial class FormMisReservas : Form
    {
        private int idCliente;
        public FormMisReservas(int idCliente)
        {
            InitializeComponent();
            this.idCliente = idCliente;
            AplicarEstiloDgv();
        }

        private void BtnCancelarViaje_Click(object sender, EventArgs e)
        {

        }

        private void FormMisReservas_Load(object sender, EventArgs e)
        {
            CargarReservasCliente();
        }

        private void CargarReservasCliente()
        {
            string ruta = "reservas.txt";

            if (!File.Exists(ruta))
            {
                MessageBox.Show("No existe el archivo de reservas.");
                return;
            }

            List<CLSReserva> reservas = new List<CLSReserva>();
            string[] lineas = File.ReadAllLines(ruta);

            for (int i = 1; i<lineas.Length; i++)
            {
                string[] partes = lineas[i].Split(',');

                if (partes.Length >= 10 && int.TryParse(partes[1], out int idClienteEnArchivo) && idClienteEnArchivo == idCliente)
                {
                    CLSReserva reserva = new CLSReserva
                    {
                        IdReserva = int.Parse(partes[0]),
                        IdCliente = idClienteEnArchivo,
                        IdViaje = partes[2],
                        AsientosSeleccionados = int.Parse(partes[3]),
                        CantidadAdultos = int.Parse(partes[4]),
                        CantidadNinios = int.Parse(partes[5]),
                        ImporteTotal = int.Parse(partes[6]),
                        FechaReserva = DateTime.Parse(partes[7]),
                        Estado = int.Parse(partes[8]),
                        ButacasTexto = partes[9]
                    };

                    reservas.Add(reserva);
                }
            }
            DgvReservasCliente.DataSource = reservas;
        }

        private void AplicarEstiloDgv()
        {
            var dgv = DgvReservasCliente;

            dgv.BackgroundColor = Color.FromArgb(34, 33, 74);
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(215, 189, 226);
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(100, 149, 237);
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(91, 44, 111);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgv.GridColor = Color.FromArgb(34, 33, 74);
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AllowUserToAddRows = false;
            dgv.RowTemplate.Height = 30;
        }
    }
}
