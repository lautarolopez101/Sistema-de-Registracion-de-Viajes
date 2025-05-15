namespace Sistema_de_Registracion_de_Viajes.Empresas
{
    partial class FRMLista_Empresas
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
            this.dgvLista_Empresas = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medio_Transporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMedio_Transporte = new System.Windows.Forms.TextBox();
            this.CMBXOpciones_Destinos = new System.Windows.Forms.ComboBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.CMBXOpciones_Medio_Transporte = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista_Empresas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLista_Empresas
            // 
            this.dgvLista_Empresas.AllowUserToDeleteRows = false;
            this.dgvLista_Empresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista_Empresas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Destino,
            this.Medio_Transporte});
            this.dgvLista_Empresas.Location = new System.Drawing.Point(380, 12);
            this.dgvLista_Empresas.Name = "dgvLista_Empresas";
            this.dgvLista_Empresas.ReadOnly = true;
            this.dgvLista_Empresas.RowHeadersWidth = 51;
            this.dgvLista_Empresas.RowTemplate.Height = 24;
            this.dgvLista_Empresas.Size = new System.Drawing.Size(408, 426);
            this.dgvLista_Empresas.TabIndex = 7;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 125;
            // 
            // Destino
            // 
            this.Destino.HeaderText = "Destino";
            this.Destino.MinimumWidth = 6;
            this.Destino.Name = "Destino";
            this.Destino.ReadOnly = true;
            this.Destino.Width = 125;
            // 
            // Medio_Transporte
            // 
            this.Medio_Transporte.HeaderText = "Medio de Transporte";
            this.Medio_Transporte.MinimumWidth = 6;
            this.Medio_Transporte.Name = "Medio_Transporte";
            this.Medio_Transporte.ReadOnly = true;
            this.Medio_Transporte.Width = 125;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(25, 80);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 22);
            this.txtNombre.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(28, 350);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(116, 45);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Destinos";
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(25, 153);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(100, 22);
            this.txtDestino.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Medio de Transporte";
            // 
            // txtMedio_Transporte
            // 
            this.txtMedio_Transporte.Location = new System.Drawing.Point(25, 234);
            this.txtMedio_Transporte.Name = "txtMedio_Transporte";
            this.txtMedio_Transporte.Size = new System.Drawing.Size(100, 22);
            this.txtMedio_Transporte.TabIndex = 3;
            // 
            // CMBXOpciones_Destinos
            // 
            this.CMBXOpciones_Destinos.FormattingEnabled = true;
            this.CMBXOpciones_Destinos.Location = new System.Drawing.Point(153, 153);
            this.CMBXOpciones_Destinos.Name = "CMBXOpciones_Destinos";
            this.CMBXOpciones_Destinos.Size = new System.Drawing.Size(121, 24);
            this.CMBXOpciones_Destinos.TabIndex = 2;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(200, 350);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(116, 45);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Opciones de Destinos";
            // 
            // CMBXOpciones_Medio_Transporte
            // 
            this.CMBXOpciones_Medio_Transporte.FormattingEnabled = true;
            this.CMBXOpciones_Medio_Transporte.Location = new System.Drawing.Point(25, 288);
            this.CMBXOpciones_Medio_Transporte.Name = "CMBXOpciones_Medio_Transporte";
            this.CMBXOpciones_Medio_Transporte.Size = new System.Drawing.Size(121, 24);
            this.CMBXOpciones_Medio_Transporte.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Opcion de Medio de Transportes";
            // 
            // FRMLista_Empresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CMBXOpciones_Medio_Transporte);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.CMBXOpciones_Destinos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMedio_Transporte);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.dgvLista_Empresas);
            this.Name = "FRMLista_Empresas";
            this.Text = "Lista de Empresas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista_Empresas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLista_Empresas;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destino;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medio_Transporte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMedio_Transporte;
        private System.Windows.Forms.ComboBox CMBXOpciones_Destinos;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CMBXOpciones_Medio_Transporte;
        private System.Windows.Forms.Label label5;
    }
}