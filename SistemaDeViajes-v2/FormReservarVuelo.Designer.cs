namespace SistemaDeViajes_v2
{
    partial class FormReservarVuelo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CbOrigen = new ComboBox();
            DtpFechaIda = new DateTimePicker();
            DtpFechaVuelta = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            DgvVuelosDisponibles = new DataGridView();
            BtnBuscarVuelosDisponibles = new FontAwesome.Sharp.IconButton();
            CbDestino = new ComboBox();
            label4 = new Label();
            NudCantidadBoletosA = new NumericUpDown();
            label5 = new Label();
            BtnSeleccionarVuelo = new FontAwesome.Sharp.IconButton();
            label6 = new Label();
            NudCantidadBoletosN = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)DgvVuelosDisponibles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NudCantidadBoletosA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NudCantidadBoletosN).BeginInit();
            SuspendLayout();
            // 
            // CbOrigen
            // 
            CbOrigen.FormattingEnabled = true;
            CbOrigen.Location = new Point(21, 54);
            CbOrigen.Name = "CbOrigen";
            CbOrigen.Size = new Size(193, 23);
            CbOrigen.TabIndex = 1;
            // 
            // DtpFechaIda
            // 
            DtpFechaIda.Location = new Point(21, 138);
            DtpFechaIda.Name = "DtpFechaIda";
            DtpFechaIda.Size = new Size(200, 23);
            DtpFechaIda.TabIndex = 2;
            // 
            // DtpFechaVuelta
            // 
            DtpFechaVuelta.Location = new Point(259, 138);
            DtpFechaVuelta.Name = "DtpFechaVuelta";
            DtpFechaVuelta.Size = new Size(200, 23);
            DtpFechaVuelta.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(21, 27);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 4;
            label1.Text = "Origen";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(21, 104);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 5;
            label2.Text = "Fecha de Ida";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(259, 104);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 6;
            label3.Text = "Fecha de Vuelta";
            // 
            // DgvVuelosDisponibles
            // 
            DgvVuelosDisponibles.BackgroundColor = Color.FromArgb(34, 33, 74);
            DgvVuelosDisponibles.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            DgvVuelosDisponibles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvVuelosDisponibles.Location = new Point(21, 178);
            DgvVuelosDisponibles.Name = "DgvVuelosDisponibles";
            DgvVuelosDisponibles.Size = new Size(642, 211);
            DgvVuelosDisponibles.TabIndex = 7;
            // 
            // BtnBuscarVuelosDisponibles
            // 
            BtnBuscarVuelosDisponibles.BackColor = Color.FromArgb(108, 60, 152);
            BtnBuscarVuelosDisponibles.Cursor = Cursors.Hand;
            BtnBuscarVuelosDisponibles.FlatAppearance.BorderSize = 0;
            BtnBuscarVuelosDisponibles.FlatStyle = FlatStyle.Flat;
            BtnBuscarVuelosDisponibles.ForeColor = Color.WhiteSmoke;
            BtnBuscarVuelosDisponibles.IconChar = FontAwesome.Sharp.IconChar.Plane;
            BtnBuscarVuelosDisponibles.IconColor = Color.WhiteSmoke;
            BtnBuscarVuelosDisponibles.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnBuscarVuelosDisponibles.IconSize = 32;
            BtnBuscarVuelosDisponibles.ImageAlign = ContentAlignment.MiddleLeft;
            BtnBuscarVuelosDisponibles.Location = new Point(90, 416);
            BtnBuscarVuelosDisponibles.Name = "BtnBuscarVuelosDisponibles";
            BtnBuscarVuelosDisponibles.Padding = new Padding(10, 0, 20, 0);
            BtnBuscarVuelosDisponibles.Size = new Size(219, 41);
            BtnBuscarVuelosDisponibles.TabIndex = 9;
            BtnBuscarVuelosDisponibles.Text = "Buscar Vuelos Disponibles";
            BtnBuscarVuelosDisponibles.TextAlign = ContentAlignment.MiddleLeft;
            BtnBuscarVuelosDisponibles.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnBuscarVuelosDisponibles.UseVisualStyleBackColor = false;
            BtnBuscarVuelosDisponibles.Click += BtnBuscarVuelosDisponibles_Click;
            // 
            // CbDestino
            // 
            CbDestino.FormattingEnabled = true;
            CbDestino.Location = new Point(259, 54);
            CbDestino.Name = "CbDestino";
            CbDestino.Size = new Size(193, 23);
            CbDestino.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(259, 27);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 11;
            label4.Text = "Destino";
            // 
            // NudCantidadBoletosA
            // 
            NudCantidadBoletosA.Location = new Point(481, 55);
            NudCantidadBoletosA.Name = "NudCantidadBoletosA";
            NudCantidadBoletosA.Size = new Size(120, 23);
            NudCantidadBoletosA.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(481, 27);
            label5.Name = "label5";
            label5.Size = new Size(117, 15);
            label5.TabIndex = 13;
            label5.Text = "Cantidad de Adultos";
            // 
            // BtnSeleccionarVuelo
            // 
            BtnSeleccionarVuelo.BackColor = Color.FromArgb(108, 60, 152);
            BtnSeleccionarVuelo.Cursor = Cursors.Hand;
            BtnSeleccionarVuelo.FlatAppearance.BorderSize = 0;
            BtnSeleccionarVuelo.FlatStyle = FlatStyle.Flat;
            BtnSeleccionarVuelo.ForeColor = Color.WhiteSmoke;
            BtnSeleccionarVuelo.IconChar = FontAwesome.Sharp.IconChar.Check;
            BtnSeleccionarVuelo.IconColor = Color.WhiteSmoke;
            BtnSeleccionarVuelo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnSeleccionarVuelo.IconSize = 32;
            BtnSeleccionarVuelo.ImageAlign = ContentAlignment.MiddleLeft;
            BtnSeleccionarVuelo.Location = new Point(366, 416);
            BtnSeleccionarVuelo.Name = "BtnSeleccionarVuelo";
            BtnSeleccionarVuelo.Padding = new Padding(10, 0, 20, 0);
            BtnSeleccionarVuelo.Size = new Size(179, 41);
            BtnSeleccionarVuelo.TabIndex = 9;
            BtnSeleccionarVuelo.Text = "Seleccionar Vuelo";
            BtnSeleccionarVuelo.TextAlign = ContentAlignment.MiddleLeft;
            BtnSeleccionarVuelo.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnSeleccionarVuelo.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.WhiteSmoke;
            label6.Location = new Point(481, 104);
            label6.Name = "label6";
            label6.Size = new Size(106, 15);
            label6.TabIndex = 15;
            label6.Text = "Cantidad de Niños";
            // 
            // NudCantidadBoletosN
            // 
            NudCantidadBoletosN.Location = new Point(481, 138);
            NudCantidadBoletosN.Name = "NudCantidadBoletosN";
            NudCantidadBoletosN.Size = new Size(120, 23);
            NudCantidadBoletosN.TabIndex = 14;
            // 
            // FormReservarVuelo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(682, 469);
            Controls.Add(label6);
            Controls.Add(NudCantidadBoletosN);
            Controls.Add(BtnSeleccionarVuelo);
            Controls.Add(label5);
            Controls.Add(NudCantidadBoletosA);
            Controls.Add(label4);
            Controls.Add(CbDestino);
            Controls.Add(BtnBuscarVuelosDisponibles);
            Controls.Add(DgvVuelosDisponibles);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DtpFechaVuelta);
            Controls.Add(DtpFechaIda);
            Controls.Add(CbOrigen);
            Name = "FormReservarVuelo";
            Text = "FormReservarVuelo";
            Load += FormReservarVuelo_Load;
            ((System.ComponentModel.ISupportInitialize)DgvVuelosDisponibles).EndInit();
            ((System.ComponentModel.ISupportInitialize)NudCantidadBoletosA).EndInit();
            ((System.ComponentModel.ISupportInitialize)NudCantidadBoletosN).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private ComboBox CbOrigen;
        private DateTimePicker DtpFechaIda;
        private DateTimePicker DtpFechaVuelta;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView DgvVuelosDisponibles;
        private FontAwesome.Sharp.IconButton BtnBuscarVuelosDisponibles;
        private ComboBox CbDestino;
        private Label label4;
        private NumericUpDown NudCantidadBoletosA;
        private Label label5;
        private FontAwesome.Sharp.IconButton BtnSeleccionarVuelo;
        private Label label6;
        private NumericUpDown NudCantidadBoletosN;
    }
}