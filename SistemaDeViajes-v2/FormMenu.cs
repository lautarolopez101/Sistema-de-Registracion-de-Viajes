using FontAwesome.Sharp;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
namespace SistemaDeViajes_v2
{
    public partial class FormMenu : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        private CLSCliente clienteLogueado;
        public FormMenu(CLSCliente cliente)
        {
            InitializeComponent();
            clienteLogueado = cliente;
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);

            //form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        //estructura de colores RGB
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        private void BotonActivado(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                //Botón y borde izquierdo
                BotonDesactivado();

                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //panel izquierdo del botón

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                //icono de inicio en el header
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }

        private void BotonDesactivado()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.WhiteSmoke;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.WhiteSmoke;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        public void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                //si se abre un form hijo se cierra el anterior
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PanelDesktop.Controls.Add(childForm);
            PanelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            LblTitleChildForm.Text = childForm.Text;
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            Reset();
            currentChildForm.Close();
        }

        private void BtnMisReservas_Click(object sender, EventArgs e)
        {
            // Lógica que querés que pase cuando se hace clic en el botón.
            BotonActivado(sender, RGBColors.color2);
            OpenChildForm(new FormMisReservas(clienteLogueado.ID));
        }

        private void BtnMisVuelos_Click(object sender, EventArgs e)
        {
            // Lógica que querés que pase cuando se hace clic en el botón.
            BotonActivado(sender, RGBColors.color3);
            OpenChildForm(new FormMisVuelos());
        }

        private void BtnReservarVuelo_Click(object sender, EventArgs e)
        {
            // Lógica que querés que pase cuando se hace clic en el botón.
            BotonActivado(sender, RGBColors.color4);
            FormReservarVuelo formReserva = new FormReservarVuelo();
            formReserva.IdClienteLogueado = clienteLogueado.ID; // pasás el ID
            OpenChildForm(formReserva);

        }

        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            // Lógica que querés que pase cuando se hace clic en el botón.
            BotonActivado(sender, RGBColors.color5);
        }

        private void BtnInicio_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            BotonDesactivado();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.MediumSlateBlue;
            LblTitleChildForm.Text = "Inicio";
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnAgrandar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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

    }
}
