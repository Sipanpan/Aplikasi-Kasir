namespace Final_Project.View
{
    partial class frmPembayaran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPembayaran));
            Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnQR = new Guna.UI2.WinForms.Guna2Button();
            this.txtCash = new System.Windows.Forms.Label();
            this.txtQR = new System.Windows.Forms.Label();
            this.btnX = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel2.Location = new System.Drawing.Point(12, 12);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(254, 29);
            this.bunifuLabel2.TabIndex = 3;
            this.bunifuLabel2.Text = "Metode Pembayaran";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
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
            this.btnQR.Location = new System.Drawing.Point(335, 79);
            this.btnQR.Name = "btnQR";
            this.btnQR.Size = new System.Drawing.Size(100, 100);
            this.btnQR.TabIndex = 4;
            this.btnQR.Text = "guna2Button1";
            this.btnQR.Click += new System.EventHandler(this.btnQR_Click);
            // 
            // txtCash
            // 
            this.txtCash.AutoSize = true;
            this.txtCash.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCash.Location = new System.Drawing.Point(172, 203);
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
            this.txtQR.Location = new System.Drawing.Point(353, 203);
            this.txtQR.Name = "txtQR";
            this.txtQR.Size = new System.Drawing.Size(64, 25);
            this.txtQR.TabIndex = 7;
            this.txtQR.Text = "QRIS";
            // 
            // btnX
            // 
            this.btnX.AllowAnimations = true;
            this.btnX.AllowBorderColorChanges = true;
            this.btnX.AllowMouseEffects = true;
            this.btnX.AnimationSpeed = 200;
            this.btnX.BackColor = System.Drawing.Color.Transparent;
            this.btnX.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnX.BorderColor = System.Drawing.Color.Transparent;
            this.btnX.BorderRadius = 1;
            this.btnX.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderStyles.Solid;
            this.btnX.BorderThickness = 1;
            this.btnX.ColorContrastOnClick = 30;
            this.btnX.ColorContrastOnHover = 30;
            this.btnX.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnX.CustomizableEdges = borderEdges2;
            this.btnX.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnX.Image = ((System.Drawing.Image)(resources.GetObject("btnX.Image")));
            this.btnX.ImageMargin = new System.Windows.Forms.Padding(0);
            this.btnX.Location = new System.Drawing.Point(532, 12);
            this.btnX.Name = "btnX";
            this.btnX.RoundBorders = true;
            this.btnX.ShowBorders = true;
            this.btnX.Size = new System.Drawing.Size(44, 44);
            this.btnX.Style = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.ButtonStyles.Round;
            this.btnX.TabIndex = 9;
            this.btnX.Click += new System.EventHandler(this.btnX_Click_1);
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BackColor = System.Drawing.Color.White;
            this.guna2PictureBox2.Image = global::Final_Project.Properties.Resources.Qr_Code__1_;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(348, 93);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(74, 72);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 5;
            this.guna2PictureBox2.TabStop = false;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 20;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.White;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(153, 79);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(100, 100);
            this.guna2Button1.TabIndex = 10;
            this.guna2Button1.Text = "guna2Button1";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.White;
            this.guna2PictureBox1.Image = global::Final_Project.Properties.Resources.Cash__1_;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(168, 93);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(74, 72);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 4;
            this.guna2PictureBox1.TabStop = false;
            // 
            // frmPembayaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 269);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.txtQR);
            this.Controls.Add(this.txtCash);
            this.Controls.Add(this.guna2PictureBox2);
            this.Controls.Add(this.btnQR);
            this.Controls.Add(this.bunifuLabel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPembayaran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pembayaran";
            this.Load += new System.EventHandler(this.frmPembayaran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2Button btnQR;
        private System.Windows.Forms.Label txtCash;
        private System.Windows.Forms.Label txtQR;
        private Bunifu.UI.WinForms.BunifuButton.BunifuIconButton btnX;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}