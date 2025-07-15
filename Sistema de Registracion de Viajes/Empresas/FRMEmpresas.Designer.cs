namespace Sistema_de_Registracion_de_Viajes
{
    partial class FRMEmpresas
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.agregarEmpresasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verListaDeEmpresasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarEmpresasToolStripMenuItem,
            this.verListaDeEmpresasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(873, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // agregarEmpresasToolStripMenuItem
            // 
            this.agregarEmpresasToolStripMenuItem.Name = "agregarEmpresasToolStripMenuItem";
            this.agregarEmpresasToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.agregarEmpresasToolStripMenuItem.Text = "Gestion Empresas";
            // 
            // verListaDeEmpresasToolStripMenuItem
            // 
            this.verListaDeEmpresasToolStripMenuItem.Name = "verListaDeEmpresasToolStripMenuItem";
            this.verListaDeEmpresasToolStripMenuItem.Size = new System.Drawing.Size(166, 24);
            this.verListaDeEmpresasToolStripMenuItem.Text = "Ver Lista de Empresas";
            this.verListaDeEmpresasToolStripMenuItem.Click += new System.EventHandler(this.verListaDeEmpresasToolStripMenuItem_Click);
            // 
            // FRMEmpresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 520);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FRMEmpresas";
            this.Text = "FRMEmpresas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem agregarEmpresasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verListaDeEmpresasToolStripMenuItem;
    }
}