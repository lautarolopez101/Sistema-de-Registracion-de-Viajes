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
    public partial class FormButacas : Form
    {
        private CLSVuelos vuelo;

        private int idCliente;
        private int cantidadAdultos;
        private int cantidadNinios;
        private int cantidadBoletos;

        private List<int> butacasSeleccionadas = new List<int>();
        public FormButacas(CLSVuelos vueloSeleccionado, int cantidadAdultos, int cantidadNinios, int idCliente)
        {
            InitializeComponent();
            BtnConfirmarAsientos.Click -= BtnConfirmarAsientos_Click;
            BtnConfirmarAsientos.Click += BtnConfirmarAsientos_Click;

            vuelo = vueloSeleccionado;

            this.idCliente = idCliente;

            this.cantidadAdultos = cantidadAdultos;
            this.cantidadNinios = cantidadNinios;
            this.cantidadBoletos = cantidadAdultos + cantidadNinios;
        }

        private void FormButacas_Load(object sender, EventArgs e)
        {
            GenerarButacas();
        }

        private void GenerarButacas()
        {
            int filas = 8;
            int columnas = 6;
            int nroButaca = 1;

            int anchoButaca = 50;
            int altoButaca = 50;
            int espacio = 5;
            int pasilloExtra = 35;

            Panel panelButacas = new Panel
            {
                Size = new Size(698, 508),
                //Dock = DockStyle.Fill,
                Location = new Point(100, 30),
                AutoScroll = true,
            };

            Controls.Add(panelButacas);

            List<int> butacasOcupadas = ObtenerButacasReservadas();


            for (int i = 0; i < filas; i++)
            {
                int x = 0;

                for (int j = 0; j < columnas; j++)
                {
                    Button btn = new Button();
                    btn.Text = nroButaca.ToString();
                    btn.Tag = nroButaca;
                    btn.Size = new Size(anchoButaca, altoButaca);
                    btn.Location = new Point(x, i * (altoButaca + espacio));
                    
                    if (butacasOcupadas.Contains(nroButaca))
                    {
                        btn.BackColor = Color.Red;
                        btn.Enabled = false;
                    }
                    else
                    {
                        btn.BackColor = Color.LightGreen;
                        btn.Click += BtnButaca_Click;
                    }


                    panelButacas.Controls.Add(btn);
                    nroButaca++;

                    // Calcular posición X para la próxima butaca
                    x += anchoButaca + espacio;

                    // Agregar espacio adicional después de la columna 3 (índice 2)
                    if (j == 2)
                        x += pasilloExtra;
                }
            }
        }

        private List<int> ObtenerButacasReservadas()
        {
            List<int> ocupadas = new List<int>();
            string archivo = "butacas_vuelo.txt";

            if (File.Exists(archivo))
            {
                string[] lineas = File.ReadAllLines(archivo);

                foreach (string linea in lineas)
                {
                    string[] partes = linea.Split(',');
                    if (partes.Length == 2 && partes[0] == vuelo.Codigo)
                    {
                        if (int.TryParse(partes[1], out int nro))
                        {
                            ocupadas.Add(nro);
                        }
                    }
                }
            }

            return ocupadas;
        }


        private void BtnButaca_Click(object? sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int nro = (int)btn.Tag;

            if (butacasSeleccionadas.Contains(nro))
            {
                butacasSeleccionadas.Remove(nro);
                btn.BackColor = Color.LightGreen;
            }
            else
            {
                if (butacasSeleccionadas.Count >= cantidadBoletos)
                {
                    MessageBox.Show("Ya seleccionaste todas las butacas. ");
                    return;
                }

                butacasSeleccionadas.Add(nro);
                btn.BackColor = Color.LightBlue;
            }
        }

        private void BtnConfirmarAsientos_Click(object sender, EventArgs e)
        {
            int precioAdulto = 10000;
            int precioNinio = 5000;

            if (butacasSeleccionadas.Count < cantidadBoletos)
            {
                MessageBox.Show("Faltan seleccionar asientos");
                return;
            }

            CLSReserva reserva = new CLSReserva
            {
                IdReserva = GenerarNuevoIdReserva(),
                IdCliente = idCliente,
                IdViaje = vuelo.Codigo,
                AsientosSeleccionados = butacasSeleccionadas.Count,
                CantidadAdultos = cantidadAdultos,
                CantidadNinios = cantidadNinios,
                Estado = 1,
                FechaReserva = DateTime.Now,
            };

            reserva.CalcularMontoTotal(precioAdulto, precioNinio);
            GuardarReserva(reserva);
            GuardarButacasReservadas(butacasSeleccionadas);

            MessageBox.Show("Asientos reservados con Éxito");

            this.Close();

        }

        private void GuardarReserva(CLSReserva reserva)
        {
            string ruta = "reservas.txt";
            string butacas = string.Join(";", butacasSeleccionadas);

            string linea = $"{reserva.IdReserva},{reserva.IdCliente},{reserva.IdViaje},{reserva.AsientosSeleccionados}," +
                           $"{reserva.CantidadAdultos},{reserva.CantidadNinios},{reserva.ImporteTotal},{reserva.FechaReserva},{reserva.Estado},{butacas}";

            File.AppendAllText(ruta, linea + Environment.NewLine);
        }

        private void GuardarButacasReservadas(List<int> butacas)
        {
            using (StreamWriter sw = File.AppendText("butacas_vuelo.txt"))
            {
                foreach (int nro in butacas)
                {
                    sw.WriteLine($"{vuelo.Codigo},{nro}");
                }
            }
        }

        private int GenerarNuevoIdReserva()
        {
            string ruta = "reservas.txt";

            if (!File.Exists(ruta))
                return 1;

            string[] lineas = File.ReadAllLines(ruta);
            if (lineas.Length == 0)
                return 1;

            string ultimaLinea = lineas.Last();
            string[] partes = ultimaLinea.Split(',');

            if (int.TryParse(partes[0], out int ultimoId))
                return ultimoId + 1;

            return 1;
        }


    }
}
