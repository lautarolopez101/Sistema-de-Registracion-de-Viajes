namespace SistemaDeViajes_v2
{
    partial class FormMisReservas
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
            DgvReservasCliente = new DataGridView();
            BtnCancelarViaje = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)DgvReservasCliente).BeginInit();
            SuspendLayout();
            // 
            // DgvReservasCliente
            // 
            DgvReservasCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvReservasCliente.Location = new Point(12, 111);
            DgvReservasCliente.Name = "DgvReservasCliente";
            DgvReservasCliente.Size = new Size(668, 150);
            DgvReservasCliente.TabIndex = 1;
            // 
            // BtnCancelarViaje
            // 
            BtnCancelarViaje.BackColor = Color.FromArgb(236, 64, 122);
            BtnCancelarViaje.FlatAppearance.BorderSize = 0;
            BtnCancelarViaje.FlatStyle = FlatStyle.Flat;
            BtnCancelarViaje.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCancelarViaje.ForeColor = Color.WhiteSmoke;
            BtnCancelarViaje.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            BtnCancelarViaje.IconColor = Color.WhiteSmoke;
            BtnCancelarViaje.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnCancelarViaje.IconSize = 32;
            BtnCancelarViaje.Location = new Point(244, 389);
            BtnCancelarViaje.Name = "BtnCancelarViaje";
            BtnCancelarViaje.Size = new Size(195, 53);
            BtnCancelarViaje.TabIndex = 2;
            BtnCancelarViaje.Text = "Cancelar Reserva";
            BtnCancelarViaje.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnCancelarViaje.UseVisualStyleBackColor = false;
            BtnCancelarViaje.Click += BtnCancelarViaje_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(244, 58);
            label1.Name = "label1";
            label1.Size = new Size(214, 30);
            label1.TabIndex = 3;
            label1.Text = "Mis Reservas Activas";
            // 
            // FormMisReservas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 13, 74);
            ClientSize = new Size(692, 479);
            Controls.Add(label1);
            Controls.Add(BtnCancelarViaje);
            Controls.Add(DgvReservasCliente);
            Name = "FormMisReservas";
            Text = "FormMisReservas";
            Load += FormMisReservas_Load;
            ((System.ComponentModel.ISupportInitialize)DgvReservasCliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DgvReservasCliente;
        private FontAwesome.Sharp.IconButton BtnCancelarViaje;
        private Label label1;
    }
}