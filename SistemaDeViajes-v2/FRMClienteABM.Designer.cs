namespace SistemaDeViajes_v2
{
    partial class FRMClienteABM
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtNombreCliente = new TextBox();
            txtApellidoCliente = new TextBox();
            txtMailCliente = new TextBox();
            txtTelefonoCliente = new TextBox();
            txtPasswordCliente = new TextBox();
            txtDNICliente = new TextBox();
            dgvClientes = new DataGridView();
            btnRegistrarCliente = new Button();
            brnEliminarCliente = new Button();
            btnModificarCliente = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 43);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 113);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 183);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 2;
            label3.Text = "Mail";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 253);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 3;
            label4.Text = "Telefono";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 312);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 4;
            label5.Text = "Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(39, 370);
            label6.Name = "label6";
            label6.Size = new Size(27, 15);
            label6.TabIndex = 5;
            label6.Text = "DNI";
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new Point(120, 43);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(100, 23);
            txtNombreCliente.TabIndex = 6;
            // 
            // txtApellidoCliente
            // 
            txtApellidoCliente.Location = new Point(120, 113);
            txtApellidoCliente.Name = "txtApellidoCliente";
            txtApellidoCliente.Size = new Size(100, 23);
            txtApellidoCliente.TabIndex = 7;
            // 
            // txtMailCliente
            // 
            txtMailCliente.Location = new Point(120, 194);
            txtMailCliente.Name = "txtMailCliente";
            txtMailCliente.Size = new Size(100, 23);
            txtMailCliente.TabIndex = 8;
            // 
            // txtTelefonoCliente
            // 
            txtTelefonoCliente.Location = new Point(120, 245);
            txtTelefonoCliente.Name = "txtTelefonoCliente";
            txtTelefonoCliente.Size = new Size(100, 23);
            txtTelefonoCliente.TabIndex = 9;
            // 
            // txtPasswordCliente
            // 
            txtPasswordCliente.Location = new Point(120, 304);
            txtPasswordCliente.Name = "txtPasswordCliente";
            txtPasswordCliente.Size = new Size(100, 23);
            txtPasswordCliente.TabIndex = 10;
            // 
            // txtDNICliente
            // 
            txtDNICliente.Location = new Point(120, 370);
            txtDNICliente.Name = "txtDNICliente";
            txtDNICliente.Size = new Size(100, 23);
            txtDNICliente.TabIndex = 11;
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(270, 43);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.Size = new Size(492, 335);
            dgvClientes.TabIndex = 12;
            // 
            // btnRegistrarCliente
            // 
            btnRegistrarCliente.Location = new Point(39, 415);
            btnRegistrarCliente.Name = "btnRegistrarCliente";
            btnRegistrarCliente.Size = new Size(75, 23);
            btnRegistrarCliente.TabIndex = 13;
            btnRegistrarCliente.Text = "Registrar";
            btnRegistrarCliente.UseVisualStyleBackColor = true;
            btnRegistrarCliente.Click += btnRegistrarCliente_Click;
            // 
            // brnEliminarCliente
            // 
            brnEliminarCliente.Location = new Point(270, 415);
            brnEliminarCliente.Name = "brnEliminarCliente";
            brnEliminarCliente.Size = new Size(75, 23);
            brnEliminarCliente.TabIndex = 14;
            brnEliminarCliente.Text = "Eliminar";
            brnEliminarCliente.UseVisualStyleBackColor = true;
            brnEliminarCliente.Click += brnEliminarCliente_Click;
            // 
            // btnModificarCliente
            // 
            btnModificarCliente.Location = new Point(390, 415);
            btnModificarCliente.Name = "btnModificarCliente";
            btnModificarCliente.Size = new Size(75, 23);
            btnModificarCliente.TabIndex = 15;
            btnModificarCliente.Text = "Modificar";
            btnModificarCliente.UseVisualStyleBackColor = true;
            // 
            // FRMClienteABM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnModificarCliente);
            Controls.Add(brnEliminarCliente);
            Controls.Add(btnRegistrarCliente);
            Controls.Add(dgvClientes);
            Controls.Add(txtDNICliente);
            Controls.Add(txtPasswordCliente);
            Controls.Add(txtTelefonoCliente);
            Controls.Add(txtMailCliente);
            Controls.Add(txtApellidoCliente);
            Controls.Add(txtNombreCliente);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FRMClienteABM";
            Text = "FRMRegistrarCliente";
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtNombreCliente;
        private TextBox txtApellidoCliente;
        private TextBox txtMailCliente;
        private TextBox txtTelefonoCliente;
        private TextBox txtPasswordCliente;
        private TextBox txtDNICliente;
        private DataGridView dgvClientes;
        private Button btnRegistrarCliente;
        private Button brnEliminarCliente;
        private Button btnModificarCliente;
    }
}