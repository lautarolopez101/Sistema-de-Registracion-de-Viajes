namespace Sistema_de_Registracion_de_Viajes.Admin
{
    partial class FRMAdmin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMAdmin));
            this.mainpanel = new System.Windows.Forms.Panel();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menubutton = new System.Windows.Forms.PictureBox();
            this.ManageContainer = new System.Windows.Forms.Panel();
            this.btnManage = new System.Windows.Forms.Button();
            this.btnEmployeerManage = new System.Windows.Forms.Button();
            this.btnAccoutnsManage = new System.Windows.Forms.Button();
            this.btnClientManage = new System.Windows.Forms.Button();
            this.btnTripManage = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.ManagerTimer = new System.Windows.Forms.Timer(this.components);
            this.bar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menubutton)).BeginInit();
            this.ManageContainer.SuspendLayout();
            this.bar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainpanel
            // 
            this.mainpanel.Location = new System.Drawing.Point(200, 32);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(800, 525);
            this.mainpanel.TabIndex = 2;
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.ManageContainer);
            this.sidebar.Controls.Add(this.btnLogout);
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(200, 557);
            this.sidebar.MinimumSize = new System.Drawing.Size(47, 557);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(200, 557);
            this.sidebar.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.menubutton);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 12;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(46, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Menu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // menubutton
            // 
            this.menubutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menubutton.Image = ((System.Drawing.Image)(resources.GetObject("menubutton.Image")));
            this.menubutton.Location = new System.Drawing.Point(7, 35);
            this.menubutton.Name = "menubutton";
            this.menubutton.Size = new System.Drawing.Size(31, 30);
            this.menubutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menubutton.TabIndex = 12;
            this.menubutton.TabStop = false;
            this.menubutton.Click += new System.EventHandler(this.menubutton_Click);
            // 
            // ManageContainer
            // 
            this.ManageContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ManageContainer.Controls.Add(this.btnManage);
            this.ManageContainer.Controls.Add(this.btnEmployeerManage);
            this.ManageContainer.Controls.Add(this.btnAccoutnsManage);
            this.ManageContainer.Controls.Add(this.btnClientManage);
            this.ManageContainer.Controls.Add(this.btnTripManage);
            this.ManageContainer.Controls.Add(this.button1);
            this.ManageContainer.Location = new System.Drawing.Point(3, 109);
            this.ManageContainer.MaximumSize = new System.Drawing.Size(200, 230);
            this.ManageContainer.MinimumSize = new System.Drawing.Size(200, 40);
            this.ManageContainer.Name = "ManageContainer";
            this.ManageContainer.Size = new System.Drawing.Size(200, 230);
            this.ManageContainer.TabIndex = 13;
            // 
            // btnManage
            // 
            this.btnManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnManage.FlatAppearance.BorderSize = 0;
            this.btnManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManage.ForeColor = System.Drawing.Color.White;
            this.btnManage.Image = ((System.Drawing.Image)(resources.GetObject("btnManage.Image")));
            this.btnManage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManage.Location = new System.Drawing.Point(-3, 0);
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(200, 30);
            this.btnManage.TabIndex = 5;
            this.btnManage.Text = "Manager";
            this.btnManage.UseVisualStyleBackColor = false;
            this.btnManage.Click += new System.EventHandler(this.btnManage_Click);
            // 
            // btnEmployeerManage
            // 
            this.btnEmployeerManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(82)))), ((int)(((byte)(100)))));
            this.btnEmployeerManage.FlatAppearance.BorderSize = 0;
            this.btnEmployeerManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeerManage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeerManage.ForeColor = System.Drawing.Color.White;
            this.btnEmployeerManage.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployeerManage.Image")));
            this.btnEmployeerManage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployeerManage.Location = new System.Drawing.Point(0, 48);
            this.btnEmployeerManage.Name = "btnEmployeerManage";
            this.btnEmployeerManage.Size = new System.Drawing.Size(200, 30);
            this.btnEmployeerManage.TabIndex = 7;
            this.btnEmployeerManage.Text = "   Employeer Manager";
            this.btnEmployeerManage.UseVisualStyleBackColor = false;
            this.btnEmployeerManage.Click += new System.EventHandler(this.btnEmployeerManage_Click);
            // 
            // btnAccoutnsManage
            // 
            this.btnAccoutnsManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(82)))), ((int)(((byte)(100)))));
            this.btnAccoutnsManage.FlatAppearance.BorderSize = 0;
            this.btnAccoutnsManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccoutnsManage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccoutnsManage.ForeColor = System.Drawing.Color.White;
            this.btnAccoutnsManage.Image = ((System.Drawing.Image)(resources.GetObject("btnAccoutnsManage.Image")));
            this.btnAccoutnsManage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccoutnsManage.Location = new System.Drawing.Point(0, 156);
            this.btnAccoutnsManage.Name = "btnAccoutnsManage";
            this.btnAccoutnsManage.Size = new System.Drawing.Size(200, 30);
            this.btnAccoutnsManage.TabIndex = 9;
            this.btnAccoutnsManage.Text = "Account Manager";
            this.btnAccoutnsManage.UseVisualStyleBackColor = false;
            this.btnAccoutnsManage.Click += new System.EventHandler(this.btnAccoutnsManage_Click);
            // 
            // btnClientManage
            // 
            this.btnClientManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(82)))), ((int)(((byte)(100)))));
            this.btnClientManage.FlatAppearance.BorderSize = 0;
            this.btnClientManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientManage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientManage.ForeColor = System.Drawing.Color.White;
            this.btnClientManage.Image = ((System.Drawing.Image)(resources.GetObject("btnClientManage.Image")));
            this.btnClientManage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientManage.Location = new System.Drawing.Point(0, 84);
            this.btnClientManage.Name = "btnClientManage";
            this.btnClientManage.Size = new System.Drawing.Size(200, 30);
            this.btnClientManage.TabIndex = 6;
            this.btnClientManage.Text = "Clients Manager";
            this.btnClientManage.UseVisualStyleBackColor = false;
            this.btnClientManage.Click += new System.EventHandler(this.btnClientManage_Click);
            // 
            // btnTripManage
            // 
            this.btnTripManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(82)))), ((int)(((byte)(100)))));
            this.btnTripManage.FlatAppearance.BorderSize = 0;
            this.btnTripManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTripManage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTripManage.ForeColor = System.Drawing.Color.White;
            this.btnTripManage.Image = ((System.Drawing.Image)(resources.GetObject("btnTripManage.Image")));
            this.btnTripManage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTripManage.Location = new System.Drawing.Point(0, 120);
            this.btnTripManage.Name = "btnTripManage";
            this.btnTripManage.Size = new System.Drawing.Size(200, 30);
            this.btnTripManage.TabIndex = 8;
            this.btnTripManage.Text = "Trip Manager";
            this.btnTripManage.UseVisualStyleBackColor = false;
            this.btnTripManage.Click += new System.EventHandler(this.btnTripManage_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(82)))), ((int)(((byte)(100)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 30);
            this.button1.TabIndex = 10;
            this.button1.Text = "    Companies Manager";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnCompaniesManage_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(3, 345);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(200, 30);
            this.btnLogout.TabIndex = 12;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // ManagerTimer
            // 
            this.ManagerTimer.Interval = 10;
            this.ManagerTimer.Tick += new System.EventHandler(this.ManagerTimer_Tick);
            // 
            // bar
            // 
            this.bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.bar.Controls.Add(this.pictureBox1);
            this.bar.Location = new System.Drawing.Point(200, 0);
            this.bar.Name = "bar";
            this.bar.Size = new System.Drawing.Size(800, 32);
            this.bar.TabIndex = 0;
            this.bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bar_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(762, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FRMAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(999, 557);
            this.Controls.Add(this.bar);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRMAdmin";
            this.Text = "Administrator";
            this.sidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menubutton)).EndInit();
            this.ManageContainer.ResumeLayout(false);
            this.bar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Button btnManage;
        private System.Windows.Forms.Button btnAccoutnsManage;
        private System.Windows.Forms.Button btnTripManage;
        private System.Windows.Forms.Button btnEmployeerManage;
        private System.Windows.Forms.Button btnClientManage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox menubutton;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Panel ManageContainer;
        private System.Windows.Forms.Timer ManagerTimer;
        private System.Windows.Forms.Panel bar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}