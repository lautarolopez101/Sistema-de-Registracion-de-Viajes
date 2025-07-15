using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Drawing.Drawing2D;
using FontAwesome.Sharp;

namespace SistemaDeViajes_v2
{
    public partial class FormReservarVuelo : Form
    {
        public int IdClienteLogueado { get; internal set; }

        public FormReservarVuelo()
        {
            InitializeComponent();
            BtnSeleccionarVuelo.Click += BtnSeleccionarVuelo_Click;
        }

        private void FormReservarVuelo_Load(object sender, EventArgs e)
        {
            // Ejemplo local. Reemplazalo por datos reales si tenés una BD
            CbOrigen.Items.Add("Buenos Aires");
            CbOrigen.Items.Add("Córdoba");
            CbOrigen.Items.Add("Mendoza");
            CbOrigen.Items.Add("Ushuaia");
            CbOrigen.SelectedIndex = 0;

            CbDestino.Items.Add("Buenos Aires");
            CbDestino.Items.Add("Córdoba");
            CbDestino.Items.Add("Mendoza");
            CbDestino.Items.Add("Ushuaia");
            CbDestino.SelectedIndex = 0;

            AplicarEstiloDgv();
            RedondearBoton(BtnBuscarVuelosDisponibles, 40);
        }

        private void BtnBuscarVuelosDisponibles_Click(object sender, EventArgs e)
        {
            DateTime fechaIda = DtpFechaIda.Value.Date;
            DateTime fechaVuelta = DtpFechaVuelta.Value.Date;
            string origen = CbOrigen.SelectedItem.ToString();
            string destino = CbDestino.SelectedItem.ToString();

            List<CLSVuelos> vuelos = ObtenerVuelosDisponibles(origen, destino, fechaIda, fechaVuelta);

            if (vuelos.Any())
            {
                DgvVuelosDisponibles.DataSource = vuelos;
            }
            else
            {
                MessageBox.Show("No hay vuelos Disponibles");

                DgvVuelosDisponibles.DataSource = null;
            }

        }

        private List<CLSVuelos> ObtenerVuelosDisponibles(string origen, string destino, DateTime Ida, DateTime Vuelta)
        {
            var vuelos = ObtenerVuelosDesdeArchivo("vuelos.txt");

            // DEBUG: Mostrar vuelo leído
            foreach (var v in vuelos)
            {
                MessageBox.Show($"Vuelo {v.Codigo} - Destino: '{v.Destino.Trim().ToLower()}' - Fecha: {v.Fecha.ToShortDateString()}");
            }

            // Filtrado con comparación robusta
            MessageBox.Show($"Destino buscado: '{destino.Trim().ToLower()}'");
            MessageBox.Show($"Fecha buscada: {Ida.ToShortDateString()}");

            var vuelosFiltrados = vuelos.Where(v =>
                v.Destino.Trim().ToLower() == destino.Trim().ToLower()
                && v.Origen.Trim().ToLower() == origen.Trim().ToLower() && v.Fecha.Date == Ida.Date
            ).ToList();

            MessageBox.Show($"Vuelos encontrados: {vuelosFiltrados.Count}");

            return vuelosFiltrados;
        }


        private List<CLSVuelos> ObtenerVuelosDesdeArchivo(string rutaArchivo)
        {
            List<CLSVuelos> vuelosLista = new List<CLSVuelos>();

            if (File.Exists(rutaArchivo))
            {
                string[] lineas = File.ReadAllLines(rutaArchivo);

                for (int i = 1; i < lineas.Length; i++)
                {
<<<<<<< HEAD
                    string[] datos = lineas[i].Split(',');
=======
                    string[] datos = lineas[i].Split(';');
>>>>>>> d5c9284cf3308a32f306d8e02def64f594b61442

                    if (datos.Length == 6)
                    {
                        CLSVuelos vuelo = new CLSVuelos()
                        {
                            Codigo = datos[0],
                            Origen = datos[1],
                            Destino = datos[2],
                            Fecha = DateTime.ParseExact(datos[3], "yyyy-MM-dd", CultureInfo.InvariantCulture),
                            Horario = datos[4],
                            Precio = decimal.Parse(datos[5]),
                        };

                        vuelosLista.Add(vuelo);

                        // Mostrar para debug
                        MessageBox.Show($"Cargado vuelo: {vuelo.Codigo}, Destino: {vuelo.Destino}, Fecha: {vuelo.Fecha.ToShortDateString()}");
                    }
                }
            }
            else
            {
                MessageBox.Show("No se encontró el archivo vuelos.txt");
            }

            return vuelosLista;
        }

        private void BtnSeleccionarVuelo_Click(object sender, EventArgs e)
        {
            if (DgvVuelosDisponibles.SelectedRows.Count > 0)
            {
                CLSVuelos vueloSeleccionado = (CLSVuelos)DgvVuelosDisponibles.SelectedRows[0].DataBoundItem;
                int cantidadAdultos = (int)NudCantidadBoletosA.Value;
                int cantidadNinios = (int)NudCantidadBoletosN.Value;

                FormButacas formButacas = new FormButacas(vueloSeleccionado, cantidadAdultos, cantidadNinios, IdClienteLogueado);


                ((FormMenu)this.ParentForm).OpenChildForm(formButacas);
                
            }
            else
            {
                MessageBox.Show("no se seleccionó ningún vuelo");
            }
        }

        private void RedondearBoton(IconButton boton, int radio)
        {
            Rectangle rect = boton.ClientRectangle;

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(rect.X, rect.Y, radio, radio, 180, 90);
                path.AddArc(rect.Right - radio, rect.Y, radio, radio, 270, 90);
                path.AddArc(rect.Right - radio, rect.Bottom - radio, radio, radio, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radio, radio, radio, 90, 90);
                path.CloseFigure();

                boton.Region = new Region(path);
            }
        }

        /*private void DgvVuelosDisponibles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }*/

        private void AplicarEstiloDgv()
        {
            var dgv = DgvVuelosDisponibles;

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
