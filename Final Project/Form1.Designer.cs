namespace Final_Project
{
    partial class Form1
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
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.pnMakanan = new System.Windows.Forms.Panel();
            this.btnMakanan = new System.Windows.Forms.Button();
            this.pnMinuman = new System.Windows.Forms.Panel();
            this.btnMinuman = new System.Windows.Forms.Button();
            this.pnCemilan = new System.Windows.Forms.Panel();
            this.btnCemilan = new System.Windows.Forms.Button();
            this.pnAboutUs = new System.Windows.Forms.Panel();
            this.btnAboutUs = new System.Windows.Forms.Button();
            this.lblMenu = new System.Windows.Forms.Label();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuButton = new System.Windows.Forms.PictureBox();
            this.sidebar.SuspendLayout();
            this.pnMakanan.SuspendLayout();
            this.pnMinuman.SuspendLayout();
            this.pnCemilan.SuspendLayout();
            this.pnAboutUs.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.sidebar.Controls.Add(this.pnMakanan);
            this.sidebar.Controls.Add(this.pnMinuman);
            this.sidebar.Controls.Add(this.pnCemilan);
            this.sidebar.Controls.Add(this.pnAboutUs);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.sidebar.Location = new System.Drawing.Point(0, 62);
            this.sidebar.MaximumSize = new System.Drawing.Size(246, 582);
            this.sidebar.MinimumSize = new System.Drawing.Size(83, 582);
            this.sidebar.Name = "sidebar";
            this.sidebar.Padding = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.sidebar.Size = new System.Drawing.Size(246, 582);
            this.sidebar.TabIndex = 0;
            // 
            // pnMakanan
            // 
            this.pnMakanan.Controls.Add(this.btnMakanan);
            this.pnMakanan.Location = new System.Drawing.Point(3, 53);
            this.pnMakanan.Name = "pnMakanan";
            this.pnMakanan.Size = new System.Drawing.Size(243, 62);
            this.pnMakanan.TabIndex = 1;
            // 
            // btnMakanan
            // 
            this.btnMakanan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMakanan.Font = new System.Drawing.Font("Rockwell Extra Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakanan.ForeColor = System.Drawing.Color.White;
            this.btnMakanan.Image = global::Final_Project.Properties.Resources.btnMakanan;
            this.btnMakanan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMakanan.Location = new System.Drawing.Point(-8, -9);
            this.btnMakanan.Name = "btnMakanan";
            this.btnMakanan.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnMakanan.Size = new System.Drawing.Size(260, 78);
            this.btnMakanan.TabIndex = 1;
            this.btnMakanan.Text = "                 Makanan";
            this.btnMakanan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMakanan.UseVisualStyleBackColor = true;
            this.btnMakanan.Click += new System.EventHandler(this.btnMakanan_Click);
            // 
            // pnMinuman
            // 
            this.pnMinuman.Controls.Add(this.btnMinuman);
            this.pnMinuman.Location = new System.Drawing.Point(3, 121);
            this.pnMinuman.Name = "pnMinuman";
            this.pnMinuman.Size = new System.Drawing.Size(243, 62);
            this.pnMinuman.TabIndex = 2;
            // 
            // btnMinuman
            // 
            this.btnMinuman.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinuman.Font = new System.Drawing.Font("Rockwell Extra Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinuman.ForeColor = System.Drawing.Color.White;
            this.btnMinuman.Image = global::Final_Project.Properties.Resources.btnMinuman;
            this.btnMinuman.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMinuman.Location = new System.Drawing.Point(-8, -9);
            this.btnMinuman.Name = "btnMinuman";
            this.btnMinuman.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnMinuman.Size = new System.Drawing.Size(260, 78);
            this.btnMinuman.TabIndex = 1;
            this.btnMinuman.Text = "                 Minuman";
            this.btnMinuman.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMinuman.UseVisualStyleBackColor = true;
            this.btnMinuman.Click += new System.EventHandler(this.btnMinuman_Click);
            // 
            // pnCemilan
            // 
            this.pnCemilan.Controls.Add(this.btnCemilan);
            this.pnCemilan.Location = new System.Drawing.Point(3, 189);
            this.pnCemilan.Name = "pnCemilan";
            this.pnCemilan.Size = new System.Drawing.Size(243, 62);
            this.pnCemilan.TabIndex = 3;
            // 
            // btnCemilan
            // 
            this.btnCemilan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCemilan.Font = new System.Drawing.Font("Rockwell Extra Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCemilan.ForeColor = System.Drawing.Color.White;
            this.btnCemilan.Image = global::Final_Project.Properties.Resources.btnCemilan;
            this.btnCemilan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCemilan.Location = new System.Drawing.Point(-8, -9);
            this.btnCemilan.Name = "btnCemilan";
            this.btnCemilan.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnCemilan.Size = new System.Drawing.Size(260, 78);
            this.btnCemilan.TabIndex = 1;
            this.btnCemilan.Text = "                 Cemilan";
            this.btnCemilan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCemilan.UseVisualStyleBackColor = true;
            this.btnCemilan.Click += new System.EventHandler(this.btnCemilan_Click);
            // 
            // pnAboutUs
            // 
            this.pnAboutUs.Controls.Add(this.btnAboutUs);
            this.pnAboutUs.Location = new System.Drawing.Point(3, 257);
            this.pnAboutUs.Name = "pnAboutUs";
            this.pnAboutUs.Size = new System.Drawing.Size(243, 62);
            this.pnAboutUs.TabIndex = 4;
            // 
            // btnAboutUs
            // 
            this.btnAboutUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAboutUs.Font = new System.Drawing.Font("Rockwell Extra Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAboutUs.ForeColor = System.Drawing.Color.White;
            this.btnAboutUs.Image = global::Final_Project.Properties.Resources.btnKami;
            this.btnAboutUs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAboutUs.Location = new System.Drawing.Point(-8, -9);
            this.btnAboutUs.Name = "btnAboutUs";
            this.btnAboutUs.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnAboutUs.Size = new System.Drawing.Size(260, 78);
            this.btnAboutUs.TabIndex = 1;
            this.btnAboutUs.Text = "                 About Us";
            this.btnAboutUs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAboutUs.UseVisualStyleBackColor = true;
            this.btnAboutUs.Click += new System.EventHandler(this.btnAboutUs_Click);
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Rockwell Extra Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.ForeColor = System.Drawing.Color.White;
            this.lblMenu.Location = new System.Drawing.Point(68, 22);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(67, 20);
            this.lblMenu.TabIndex = 1;
            this.lblMenu.Text = "Menu";
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.lblMenu);
            this.panel1.Controls.Add(this.menuButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1155, 62);
            this.panel1.TabIndex = 1;
            // 
            // menuButton
            // 
            this.menuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButton.Image = global::Final_Project.Properties.Resources.btnKeranjang;
            this.menuButton.Location = new System.Drawing.Point(12, 6);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(50, 50);
            this.menuButton.TabIndex = 0;
            this.menuButton.TabStop = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1155, 650);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.sidebar.ResumeLayout(false);
            this.pnMakanan.ResumeLayout(false);
            this.pnMinuman.ResumeLayout(false);
            this.pnCemilan.ResumeLayout(false);
            this.pnAboutUs.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel pnMakanan;
        private System.Windows.Forms.Button btnMakanan;
        private System.Windows.Forms.Panel pnMinuman;
        private System.Windows.Forms.Button btnMinuman;
        private System.Windows.Forms.Panel pnCemilan;
        private System.Windows.Forms.Button btnCemilan;
        private System.Windows.Forms.Panel pnAboutUs;
        private System.Windows.Forms.Button btnAboutUs;
        private System.Windows.Forms.PictureBox menuButton;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Panel panel1;
    }
}

