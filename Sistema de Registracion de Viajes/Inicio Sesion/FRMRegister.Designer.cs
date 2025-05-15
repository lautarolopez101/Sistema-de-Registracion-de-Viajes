namespace Sistema_de_Registracion_de_Viajes
{
    partial class FRMRegister
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
            this.btnCrear_Cuenta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DTPFecha_Nacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtNombre_Usuario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPassword_Confirm = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCrear_Cuenta
            // 
            this.btnCrear_Cuenta.Location = new System.Drawing.Point(356, 315);
            this.btnCrear_Cuenta.Margin = new System.Windows.Forms.Padding(4);
            this.btnCrear_Cuenta.Name = "btnCrear_Cuenta";
            this.btnCrear_Cuenta.Size = new System.Drawing.Size(124, 33);
            this.btnCrear_Cuenta.TabIndex = 7;
            this.btnCrear_Cuenta.Text = "Crear Cuenta";
            this.btnCrear_Cuenta.UseVisualStyleBackColor = true;
            this.btnCrear_Cuenta.Click += new System.EventHandler(this.btnCrear_Cuenta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(91, 108);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(156, 22);
            this.txtNombre.TabIndex = 0;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(91, 177);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(156, 22);
            this.txtApellido.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 154);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Apellido";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(91, 255);
            this.txtDNI.Margin = new System.Windows.Forms.Padding(4);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(156, 22);
            this.txtDNI.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 231);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "DNI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 315);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Fecha de Nacimiento";
            // 
            // DTPFecha_Nacimiento
            // 
            this.DTPFecha_Nacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPFecha_Nacimiento.Location = new System.Drawing.Point(91, 337);
            this.DTPFecha_Nacimiento.Margin = new System.Windows.Forms.Padding(4);
            this.DTPFecha_Nacimiento.MaxDate = new System.DateTime(2026, 12, 31, 0, 0, 0, 0);
            this.DTPFecha_Nacimiento.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.DTPFecha_Nacimiento.Name = "DTPFecha_Nacimiento";
            this.DTPFecha_Nacimiento.Size = new System.Drawing.Size(172, 22);
            this.DTPFecha_Nacimiento.TabIndex = 3;
            // 
            // txtNombre_Usuario
            // 
            this.txtNombre_Usuario.Location = new System.Drawing.Point(357, 99);
            this.txtNombre_Usuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre_Usuario.Name = "txtNombre_Usuario";
            this.txtNombre_Usuario.Size = new System.Drawing.Size(156, 22);
            this.txtNombre_Usuario.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(353, 76);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nombre de Usuario";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(358, 165);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(156, 22);
            this.txtPassword.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(354, 142);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Password";
            // 
            // txtPassword_Confirm
            // 
            this.txtPassword_Confirm.Location = new System.Drawing.Point(546, 165);
            this.txtPassword_Confirm.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword_Confirm.Name = "txtPassword_Confirm";
            this.txtPassword_Confirm.Size = new System.Drawing.Size(156, 22);
            this.txtPassword_Confirm.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(542, 142);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Password Confirmed";
            // 
            // FRMRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.txtPassword_Confirm);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNombre_Usuario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DTPFecha_Nacimiento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCrear_Cuenta);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRMRegister";
            this.Text = "FRMRegister";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrear_Cuenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DTPFecha_Nacimiento;
        private System.Windows.Forms.TextBox txtNombre_Usuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPassword_Confirm;
        private System.Windows.Forms.Label label7;
    }
}