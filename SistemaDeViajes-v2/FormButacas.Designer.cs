namespace SistemaDeViajes_v2
{
    partial class FormButacas
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
            BtnConfirmarAsientos = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // BtnConfirmarAsientos
            // 
            BtnConfirmarAsientos.BackColor = Color.FromArgb(108, 60, 152);
            BtnConfirmarAsientos.Cursor = Cursors.Hand;
            BtnConfirmarAsientos.FlatAppearance.BorderSize = 0;
            BtnConfirmarAsientos.FlatStyle = FlatStyle.Flat;
            BtnConfirmarAsientos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnConfirmarAsientos.ForeColor = Color.WhiteSmoke;
            BtnConfirmarAsientos.IconChar = FontAwesome.Sharp.IconChar.Chair;
            BtnConfirmarAsientos.IconColor = Color.WhiteSmoke;
            BtnConfirmarAsientos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnConfirmarAsientos.IconSize = 30;
            BtnConfirmarAsientos.ImageAlign = ContentAlignment.MiddleLeft;
            BtnConfirmarAsientos.Location = new Point(484, 30);
            BtnConfirmarAsientos.Name = "BtnConfirmarAsientos";
            BtnConfirmarAsientos.Padding = new Padding(10, 0, 20, 0);
            BtnConfirmarAsientos.Size = new Size(186, 41);
            BtnConfirmarAsientos.TabIndex = 0;
            BtnConfirmarAsientos.Text = "Confirmar Asientos";
            BtnConfirmarAsientos.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnConfirmarAsientos.UseVisualStyleBackColor = false;
            BtnConfirmarAsientos.Click += BtnConfirmarAsientos_Click;
            // 
            // FormButacas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(682, 469);
            Controls.Add(BtnConfirmarAsientos);
            Name = "FormButacas";
            Text = "FormButacas";
            Load += FormButacas_Load;
            ResumeLayout(false);
        }

        #endregion

        private FontAwesome.Sharp.IconButton BtnConfirmarAsientos;
    }
}