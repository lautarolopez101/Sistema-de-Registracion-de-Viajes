﻿namespace SistemaDeViajes_v2
{
    partial class FormMisVuelos
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
            button1 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(269, 200);
            button1.Name = "button1";
            button1.Size = new Size(158, 23);
            button1.TabIndex = 0;
            button1.Text = "Mis Vuelos";
            button1.UseVisualStyleBackColor = true;
            // 
            // FormMisVuelos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Name = "FormMisVuelos";
            Text = "FormMisVuelos";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
    }
}