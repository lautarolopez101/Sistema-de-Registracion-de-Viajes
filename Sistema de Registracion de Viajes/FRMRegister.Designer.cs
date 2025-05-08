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
            this.txtNombre_Usuario = new System.Windows.Forms.TextBox();
            this.txtCorreo_Electronico = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DTPFecha_Nacimiento = new System.Windows.Forms.DateTimePicker();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrear_Cuenta
            // 
            this.btnCrear_Cuenta.Location = new System.Drawing.Point(292, 176);
            this.btnCrear_Cuenta.Name = "btnCrear_Cuenta";
            this.btnCrear_Cuenta.Size = new System.Drawing.Size(93, 27);
            this.btnCrear_Cuenta.TabIndex = 4;
            this.btnCrear_Cuenta.Text = "Crear Cuenta";
            this.btnCrear_Cuenta.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre de Usuario";
            // 
            // txtNombre_Usuario
            // 
            this.txtNombre_Usuario.Location = new System.Drawing.Point(68, 88);
            this.txtNombre_Usuario.Name = "txtNombre_Usuario";
            this.txtNombre_Usuario.Size = new System.Drawing.Size(118, 20);
            this.txtNombre_Usuario.TabIndex = 0;
            // 
            // txtCorreo_Electronico
            // 
            this.txtCorreo_Electronico.Location = new System.Drawing.Point(68, 144);
            this.txtCorreo_Electronico.Name = "txtCorreo_Electronico";
            this.txtCorreo_Electronico.Size = new System.Drawing.Size(118, 20);
            this.txtCorreo_Electronico.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Correo Electronico";
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.Location = new System.Drawing.Point(68, 207);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.Size = new System.Drawing.Size(118, 20);
            this.txtContrasenia.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Contrasenia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Fecha de Nacimiento";
            // 
            // DTPFecha_Nacimiento
            // 
            this.DTPFecha_Nacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPFecha_Nacimiento.Location = new System.Drawing.Point(68, 274);
            this.DTPFecha_Nacimiento.MaxDate = new System.DateTime(2026, 12, 31, 0, 0, 0, 0);
            this.DTPFecha_Nacimiento.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.DTPFecha_Nacimiento.Name = "DTPFecha_Nacimiento";
            this.DTPFecha_Nacimiento.Size = new System.Drawing.Size(130, 20);
            this.DTPFecha_Nacimiento.TabIndex = 3;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(292, 244);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 27);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FRMRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.DTPFecha_Nacimiento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtContrasenia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCorreo_Electronico);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre_Usuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCrear_Cuenta);
            this.Name = "FRMRegister";
            this.Text = "FRMRegister";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrear_Cuenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre_Usuario;
        private System.Windows.Forms.TextBox txtCorreo_Electronico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DTPFecha_Nacimiento;
        private System.Windows.Forms.Button btnCancelar;
    }
}