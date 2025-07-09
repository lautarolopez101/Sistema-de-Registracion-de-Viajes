namespace SistemaDeViajes_v2
{
    partial class FormMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelMenu = new Panel();
            btnCerrarSesion = new FontAwesome.Sharp.IconButton();
            btnReservarVuelo = new FontAwesome.Sharp.IconButton();
            btnMisReservas = new FontAwesome.Sharp.IconButton();
            btnMisVuelos = new FontAwesome.Sharp.IconButton();
            btnHome = new FontAwesome.Sharp.IconButton();
            panelLogo = new Panel();
            BtnInicio = new PictureBox();
            panelTitleBar = new Panel();
            BtnMinimizar = new FontAwesome.Sharp.IconPictureBox();
            BtnAgrandar = new FontAwesome.Sharp.IconPictureBox();
            BtnClose = new FontAwesome.Sharp.IconPictureBox();
            LblTitleChildForm = new Label();
            iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            PanelShadow = new Panel();
            PanelDesktop = new Panel();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BtnInicio).BeginInit();
            panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BtnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnAgrandar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(31, 30, 68);
            panelMenu.Controls.Add(btnCerrarSesion);
            panelMenu.Controls.Add(btnReservarVuelo);
            panelMenu.Controls.Add(btnMisReservas);
            panelMenu.Controls.Add(btnMisVuelos);
            panelMenu.Controls.Add(btnHome);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 602);
            panelMenu.TabIndex = 0;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Cursor = Cursors.Hand;
            btnCerrarSesion.Dock = DockStyle.Bottom;
            btnCerrarSesion.FlatAppearance.BorderSize = 0;
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.ForeColor = Color.WhiteSmoke;
            btnCerrarSesion.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            btnCerrarSesion.IconColor = Color.WhiteSmoke;
            btnCerrarSesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCerrarSesion.IconSize = 32;
            btnCerrarSesion.ImageAlign = ContentAlignment.MiddleLeft;
            btnCerrarSesion.Location = new Point(0, 542);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Padding = new Padding(10, 0, 20, 0);
            btnCerrarSesion.Size = new Size(220, 60);
            btnCerrarSesion.TabIndex = 4;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.TextAlign = ContentAlignment.MiddleLeft;
            btnCerrarSesion.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += BtnCerrarSesion_Click;
            // 
            // btnReservarVuelo
            // 
            btnReservarVuelo.Cursor = Cursors.Hand;
            btnReservarVuelo.Dock = DockStyle.Top;
            btnReservarVuelo.FlatAppearance.BorderSize = 0;
            btnReservarVuelo.FlatStyle = FlatStyle.Flat;
            btnReservarVuelo.ForeColor = Color.WhiteSmoke;
            btnReservarVuelo.IconChar = FontAwesome.Sharp.IconChar.Plane;
            btnReservarVuelo.IconColor = Color.WhiteSmoke;
            btnReservarVuelo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnReservarVuelo.IconSize = 32;
            btnReservarVuelo.ImageAlign = ContentAlignment.MiddleLeft;
            btnReservarVuelo.Location = new Point(0, 320);
            btnReservarVuelo.Name = "btnReservarVuelo";
            btnReservarVuelo.Padding = new Padding(10, 0, 20, 0);
            btnReservarVuelo.Size = new Size(220, 60);
            btnReservarVuelo.TabIndex = 3;
            btnReservarVuelo.Text = "Reservar Vuelo";
            btnReservarVuelo.TextAlign = ContentAlignment.MiddleLeft;
            btnReservarVuelo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReservarVuelo.UseVisualStyleBackColor = true;
            btnReservarVuelo.Click += BtnReservarVuelo_Click;
            // 
            // btnMisReservas
            // 
            btnMisReservas.Cursor = Cursors.Hand;
            btnMisReservas.Dock = DockStyle.Top;
            btnMisReservas.FlatAppearance.BorderSize = 0;
            btnMisReservas.FlatStyle = FlatStyle.Flat;
            btnMisReservas.ForeColor = Color.WhiteSmoke;
            btnMisReservas.IconChar = FontAwesome.Sharp.IconChar.Ticket;
            btnMisReservas.IconColor = Color.WhiteSmoke;
            btnMisReservas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMisReservas.IconSize = 32;
            btnMisReservas.ImageAlign = ContentAlignment.MiddleLeft;
            btnMisReservas.Location = new Point(0, 260);
            btnMisReservas.Name = "btnMisReservas";
            btnMisReservas.Padding = new Padding(10, 0, 20, 0);
            btnMisReservas.Size = new Size(220, 60);
            btnMisReservas.TabIndex = 2;
            btnMisReservas.Text = "Mis Reservas";
            btnMisReservas.TextAlign = ContentAlignment.MiddleLeft;
            btnMisReservas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMisReservas.UseVisualStyleBackColor = true;
            btnMisReservas.Click += BtnMisReservas_Click;
            // 
            // btnMisVuelos
            // 
            btnMisVuelos.Cursor = Cursors.Hand;
            btnMisVuelos.Dock = DockStyle.Top;
            btnMisVuelos.FlatAppearance.BorderSize = 0;
            btnMisVuelos.FlatStyle = FlatStyle.Flat;
            btnMisVuelos.ForeColor = Color.WhiteSmoke;
            btnMisVuelos.IconChar = FontAwesome.Sharp.IconChar.Avianex;
            btnMisVuelos.IconColor = Color.WhiteSmoke;
            btnMisVuelos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMisVuelos.IconSize = 32;
            btnMisVuelos.ImageAlign = ContentAlignment.MiddleLeft;
            btnMisVuelos.Location = new Point(0, 200);
            btnMisVuelos.Name = "btnMisVuelos";
            btnMisVuelos.Padding = new Padding(10, 0, 20, 0);
            btnMisVuelos.Size = new Size(220, 60);
            btnMisVuelos.TabIndex = 1;
            btnMisVuelos.Text = "Mis Vuelos";
            btnMisVuelos.TextAlign = ContentAlignment.MiddleLeft;
            btnMisVuelos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMisVuelos.UseVisualStyleBackColor = true;
            btnMisVuelos.Click += BtnMisVuelos_Click;
            // 
            // btnHome
            // 
            btnHome.Cursor = Cursors.Hand;
            btnHome.Dock = DockStyle.Top;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.ForeColor = Color.WhiteSmoke;
            btnHome.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            btnHome.IconColor = Color.WhiteSmoke;
            btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnHome.IconSize = 32;
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(0, 140);
            btnHome.Name = "btnHome";
            btnHome.Padding = new Padding(10, 0, 20, 0);
            btnHome.Size = new Size(220, 60);
            btnHome.TabIndex = 0;
            btnHome.Text = "Inicio";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += BtnHome_Click;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(BtnInicio);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(220, 140);
            panelLogo.TabIndex = 0;
            // 
            // BtnInicio
            // 
            BtnInicio.Image = Properties.Resources.Logo_removebg_preview;
            BtnInicio.Location = new Point(12, 29);
            BtnInicio.Name = "BtnInicio";
            BtnInicio.Size = new Size(187, 85);
            BtnInicio.SizeMode = PictureBoxSizeMode.Zoom;
            BtnInicio.TabIndex = 0;
            BtnInicio.TabStop = false;
            BtnInicio.Click += BtnInicio_Click;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(26, 25, 62);
            panelTitleBar.Controls.Add(BtnMinimizar);
            panelTitleBar.Controls.Add(BtnAgrandar);
            panelTitleBar.Controls.Add(BtnClose);
            panelTitleBar.Controls.Add(LblTitleChildForm);
            panelTitleBar.Controls.Add(iconCurrentChildForm);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(220, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(698, 75);
            panelTitleBar.TabIndex = 1;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown;
            // 
            // BtnMinimizar
            // 
            BtnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnMinimizar.BackColor = Color.FromArgb(26, 25, 62);
            BtnMinimizar.ForeColor = Color.MediumSlateBlue;
            BtnMinimizar.IconChar = FontAwesome.Sharp.IconChar.MinusCircle;
            BtnMinimizar.IconColor = Color.MediumSlateBlue;
            BtnMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnMinimizar.IconSize = 20;
            BtnMinimizar.Location = new Point(614, 12);
            BtnMinimizar.Name = "BtnMinimizar";
            BtnMinimizar.Size = new Size(20, 24);
            BtnMinimizar.TabIndex = 4;
            BtnMinimizar.TabStop = false;
            BtnMinimizar.Click += BtnMinimizar_Click;
            // 
            // BtnAgrandar
            // 
            BtnAgrandar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnAgrandar.BackColor = Color.FromArgb(26, 25, 62);
            BtnAgrandar.ForeColor = Color.MediumSlateBlue;
            BtnAgrandar.IconChar = FontAwesome.Sharp.IconChar.Expand;
            BtnAgrandar.IconColor = Color.MediumSlateBlue;
            BtnAgrandar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnAgrandar.IconSize = 20;
            BtnAgrandar.Location = new Point(640, 12);
            BtnAgrandar.Name = "BtnAgrandar";
            BtnAgrandar.Size = new Size(20, 24);
            BtnAgrandar.TabIndex = 3;
            BtnAgrandar.TabStop = false;
            BtnAgrandar.Click += BtnAgrandar_Click;
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.BackColor = Color.FromArgb(26, 25, 62);
            BtnClose.ForeColor = Color.MediumSlateBlue;
            BtnClose.IconChar = FontAwesome.Sharp.IconChar.Close;
            BtnClose.IconColor = Color.MediumSlateBlue;
            BtnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnClose.IconSize = 20;
            BtnClose.Location = new Point(666, 12);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(20, 24);
            BtnClose.TabIndex = 2;
            BtnClose.TabStop = false;
            BtnClose.Click += BtnClose_Click;
            // 
            // LblTitleChildForm
            // 
            LblTitleChildForm.AutoSize = true;
            LblTitleChildForm.ForeColor = Color.WhiteSmoke;
            LblTitleChildForm.Location = new Point(69, 36);
            LblTitleChildForm.Name = "LblTitleChildForm";
            LblTitleChildForm.Size = new Size(36, 15);
            LblTitleChildForm.TabIndex = 1;
            LblTitleChildForm.Text = "Inicio";
            // 
            // iconCurrentChildForm
            // 
            iconCurrentChildForm.BackColor = Color.FromArgb(26, 25, 62);
            iconCurrentChildForm.ForeColor = Color.MediumSlateBlue;
            iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.House;
            iconCurrentChildForm.IconColor = Color.MediumSlateBlue;
            iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconCurrentChildForm.Location = new Point(29, 27);
            iconCurrentChildForm.Name = "iconCurrentChildForm";
            iconCurrentChildForm.Size = new Size(32, 32);
            iconCurrentChildForm.TabIndex = 0;
            iconCurrentChildForm.TabStop = false;
            // 
            // PanelShadow
            // 
            PanelShadow.BackColor = Color.FromArgb(26, 24, 58);
            PanelShadow.Dock = DockStyle.Top;
            PanelShadow.Location = new Point(220, 75);
            PanelShadow.Name = "PanelShadow";
            PanelShadow.Size = new Size(698, 9);
            PanelShadow.TabIndex = 2;
            // 
            // PanelDesktop
            // 
            PanelDesktop.BackColor = Color.FromArgb(34, 33, 74);
            PanelDesktop.Dock = DockStyle.Fill;
            PanelDesktop.Location = new Point(220, 84);
            PanelDesktop.Name = "PanelDesktop";
            PanelDesktop.Size = new Size(698, 518);
            PanelDesktop.TabIndex = 3;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 602);
            Controls.Add(PanelDesktop);
            Controls.Add(PanelShadow);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            Name = "FormMenu";
            Text = "Form1";
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BtnInicio).EndInit();
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BtnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnAgrandar).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnHome;
        private Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnCerrarSesion;
        private FontAwesome.Sharp.IconButton btnReservarVuelo;
        private FontAwesome.Sharp.IconButton btnMisReservas;
        private FontAwesome.Sharp.IconButton btnMisVuelos;
        private PictureBox BtnInicio;
        private Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private Label LblTitleChildForm;
        private Panel PanelShadow;
        private Panel PanelDesktop;
        private FontAwesome.Sharp.IconPictureBox BtnAgrandar;
        private FontAwesome.Sharp.IconPictureBox BtnClose;
        private FontAwesome.Sharp.IconPictureBox BtnMinimizar;
    }
}
