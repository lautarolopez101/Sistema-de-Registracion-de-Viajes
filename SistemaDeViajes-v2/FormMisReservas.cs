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
<<<<<<< HEAD
            if (DgvReservasCliente.CurrentRow == null)
            {
                MessageBox.Show("Seleccioná una reserva para cancelar.");
                return;
            }

            int idReservaSeleccionada = Convert.ToInt32(DgvReservasCliente.CurrentRow.Cells["IdReserva"].Value);
            string idViaje = DgvReservasCliente.CurrentRow.Cells["IdViaje"].Value.ToString();
            string butacasTexto = DgvReservasCliente.CurrentRow.Cells["Butacas"].Value.ToString();
            string[] butacasAEliminar = butacasTexto.Split(';');

            MessageBox.Show($"ID Viaje: '{idViaje}'\nButacas: '{butacasTexto}'");

            string ruta = "reservas.txt";
            string rutaButacas = "butacas_vuelo.txt";

            if (!File.Exists(ruta))
            {
                MessageBox.Show("No se encontró el archivo de reservas.");
                return;
            }

            string[] lineas = File.ReadAllLines(ruta);
            for (int i = 1; i < lineas.Length; i++) // empezamos desde 1 para conservar encabezado
            {
                string[] partes = lineas[i].Split(',');

                if (int.TryParse(partes[0], out int idReserva) && idReserva == idReservaSeleccionada)
                {
                    partes[8] = "2"; // Estado cancelado (usá el número que represente "cancelada" en tu sistema)
                    lineas[i] = string.Join(",", partes);

                    // Liberar butacas
                   
                    if (File.Exists(rutaButacas))
                    {
                        List<string> lineasButacas = File.ReadAllLines(rutaButacas).ToList();

                        foreach (string butaca in butacasAEliminar)
                        {
                            string butacaLimpia = butaca.Trim();
                            string objetivo = $"{idViaje.Trim()},{butacaLimpia}";
                            MessageBox.Show($"Buscando eliminar: '{objetivo}'");

                            int eliminadas = lineasButacas.RemoveAll(l =>
                            {
                                string[] partes = l.Split(',');
                                return partes.Length == 2 &&
                                       partes[0].Trim() == idViaje.Trim() &&
                                       partes[1].Trim() == butacaLimpia;
                            });

                            MessageBox.Show($"Eliminadas: {eliminadas}");
                        }


                        File.WriteAllLines(rutaButacas, lineasButacas);
                    }

                    break; 
                }
            }

            File.WriteAllLines(ruta, lineas);
            MessageBox.Show("Reserva cancelada correctamente.");

            // Recargar el DataGridView
            CargarReservasCliente();
        }


=======

        }

>>>>>>> d5c9284cf3308a32f306d8e02def64f594b61442
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
<<<<<<< HEAD

            DgvReservasCliente.DataSource = reservas.Select(r => new
            {
                r.IdReserva,
                r.IdViaje,
                r.AsientosSeleccionados,
                r.CantidadAdultos,
                r.CantidadNinios,
                r.ImporteTotal,
                r.FechaReserva,
                Estado = r.EstadoTexto,
                Butacas = r.ButacasTexto
            }).ToList();

=======
            DgvReservasCliente.DataSource = reservas;
>>>>>>> d5c9284cf3308a32f306d8e02def64f594b61442
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
