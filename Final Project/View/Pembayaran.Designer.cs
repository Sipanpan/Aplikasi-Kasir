namespace Final_Project.View
{
    partial class Pembayaran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pembayaran));
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.panelBank = new Bunifu.UI.WinForms.BunifuPanel();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panelcash = new Bunifu.UI.WinForms.BunifuPanel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnQR = new Guna.UI2.WinForms.Guna2Button();
            this.txtCash = new System.Windows.Forms.Label();
            this.txtQR = new System.Windows.Forms.Label();
            this.txtBank = new System.Windows.Forms.Label();
            this.panelBank.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.panelcash.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel2.Location = new System.Drawing.Point(40, 24);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(254, 29);
            this.bunifuLabel2.TabIndex = 3;
            this.bunifuLabel2.Text = "Metode Pembayaran";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // panelBank
            // 
            this.panelBank.BackgroundColor = System.Drawing.Color.White;
            this.panelBank.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelBank.BackgroundImage")));
            this.panelBank.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBank.BorderColor = System.Drawing.Color.Transparent;
            this.panelBank.BorderRadius = 30;
            this.panelBank.BorderThickness = 1;
            this.panelBank.Controls.Add(this.guna2PictureBox3);
            this.panelBank.Location = new System.Drawing.Point(470, 92);
            this.panelBank.Name = "panelBank";
            this.panelBank.ShowBorders = true;
            this.panelBank.Size = new System.Drawing.Size(100, 100);
            this.panelBank.TabIndex = 1;
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.BackColor = System.Drawing.Color.White;
            this.guna2PictureBox3.Image = global::Final_Project.Properties.Resources.Bank_Cards__1_;
            this.guna2PictureBox3.ImageRotate = 0F;
            this.guna2PictureBox3.Location = new System.Drawing.Point(13, 14);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.Size = new System.Drawing.Size(74, 72);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox3.TabIndex = 6;
            this.guna2PictureBox3.TabStop = false;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BackColor = System.Drawing.Color.White;
            this.guna2PictureBox2.Image = global::Final_Project.Properties.Resources.Qr_Code__1_;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(293, 106);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(74, 72);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 5;
            this.guna2PictureBox2.TabStop = false;
            // 
            // panelcash
            // 
            this.panelcash.BackgroundColor = System.Drawing.Color.White;
            this.panelcash.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelcash.BackgroundImage")));
            this.panelcash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelcash.BorderColor = System.Drawing.Color.Transparent;
            this.panelcash.BorderRadius = 30;
            this.panelcash.BorderThickness = 1;
            this.panelcash.Controls.Add(this.guna2PictureBox1);
            this.panelcash.Location = new System.Drawing.Point(98, 92);
            this.panelcash.Name = "panelcash";
            this.panelcash.ShowBorders = true;
            this.panelcash.Size = new System.Drawing.Size(100, 100);
            this.panelcash.TabIndex = 0;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.White;
            this.guna2PictureBox1.Image = global::Final_Project.Properties.Resources.Cash__1_;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(13, 14);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(74, 72);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 4;
            this.guna2PictureBox1.TabStop = false;
            // 
            // btnQR
            // 
            this.btnQR.BorderRadius = 20;
            this.btnQR.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQR.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQR.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQR.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQR.FillColor = System.Drawing.Color.White;
            this.btnQR.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnQR.ForeColor = System.Drawing.Color.White;
            this.btnQR.Location = new System.Drawing.Point(280, 92);
            this.btnQR.Name = "btnQR";
            this.btnQR.Size = new System.Drawing.Size(100, 100);
            this.btnQR.TabIndex = 4;
            this.btnQR.Text = "guna2Button1";
            // 
            // txtCash
            // 
            this.txtCash.AutoSize = true;
            this.txtCash.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCash.Location = new System.Drawing.Point(117, 216);
            this.txtCash.Name = "txtCash";
            this.txtCash.Size = new System.Drawing.Size(63, 25);
            this.txtCash.TabIndex = 6;
            this.txtCash.Text = "Cash";
            this.txtCash.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtQR
            // 
            this.txtQR.AutoSize = true;
            this.txtQR.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQR.Location = new System.Drawing.Point(298, 216);
            this.txtQR.Name = "txtQR";
            this.txtQR.Size = new System.Drawing.Size(64, 25);
            this.txtQR.TabIndex = 7;
            this.txtQR.Text = "QRIS";
            // 
            // txtBank
            // 
            this.txtBank.AutoSize = true;
            this.txtBank.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBank.Location = new System.Drawing.Point(486, 216);
            this.txtBank.Name = "txtBank";
            this.txtBank.Size = new System.Drawing.Size(69, 25);
            this.txtBank.TabIndex = 8;
            this.txtBank.Text = "Bank ";
            // 
            // Pembayaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 284);
            this.Controls.Add(this.txtBank);
            this.Controls.Add(this.txtQR);
            this.Controls.Add(this.txtCash);
            this.Controls.Add(this.guna2PictureBox2);
            this.Controls.Add(this.btnQR);
            this.Controls.Add(this.panelBank);
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.panelcash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pembayaran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pembayaran";
            this.panelBank.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.panelcash.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel panelcash;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuPanel panelBank;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private Guna.UI2.WinForms.Guna2Button btnQR;
        private System.Windows.Forms.Label txtCash;
        private System.Windows.Forms.Label txtQR;
        private System.Windows.Forms.Label txtBank;
    }
}