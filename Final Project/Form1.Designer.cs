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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblMenu = new System.Windows.Forms.Label();
            this.pnMakanan = new System.Windows.Forms.Panel();
            this.btnMakanan = new System.Windows.Forms.Button();
            this.pnMinuman = new System.Windows.Forms.Panel();
            this.btnMinuman = new System.Windows.Forms.Button();
            this.pnCemilan = new System.Windows.Forms.Panel();
            this.btnCemilan = new System.Windows.Forms.Button();
            this.pnKeranjang = new System.Windows.Forms.Panel();
            this.btnKeranjang = new System.Windows.Forms.Button();
            this.pnAboutUs = new System.Windows.Forms.Panel();
            this.btnAboutUs = new System.Windows.Forms.Button();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.minimizeButton = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.maximizeButton = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.closeButton = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.menuButton = new System.Windows.Forms.PictureBox();
            this.bunifuFormResizer1 = new Bunifu.UI.WinForms.BunifuFormResizer(this.components);
            this.bunifuFormDrag1 = new Bunifu.UI.WinForms.BunifuFormDrag();
            this.pnWelcome = new Bunifu.UI.WinForms.BunifuPanel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.bunifuFormResizeIcon1 = new Bunifu.UI.WinForms.BunifuFormResizeIcon();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.sidebar.SuspendLayout();
            this.bunifuPanel1.SuspendLayout();
            this.pnMakanan.SuspendLayout();
            this.pnMinuman.SuspendLayout();
            this.pnCemilan.SuspendLayout();
            this.pnKeranjang.SuspendLayout();
            this.pnAboutUs.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            this.pnWelcome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.sidebar.Controls.Add(this.bunifuPanel1);
            this.sidebar.Controls.Add(this.pnMakanan);
            this.sidebar.Controls.Add(this.pnMinuman);
            this.sidebar.Controls.Add(this.pnCemilan);
            this.sidebar.Controls.Add(this.pnKeranjang);
            this.sidebar.Controls.Add(this.pnAboutUs);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.sidebar.Location = new System.Drawing.Point(0, 62);
            this.sidebar.MaximumSize = new System.Drawing.Size(246, 1000);
            this.sidebar.MinimumSize = new System.Drawing.Size(83, 588);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(246, 588);
            this.sidebar.TabIndex = 0;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.lblMenu);
            this.bunifuPanel1.Location = new System.Drawing.Point(3, 3);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(243, 82);
            this.bunifuPanel1.TabIndex = 5;
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Rockwell Extra Bold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.ForeColor = System.Drawing.Color.White;
            this.lblMenu.Location = new System.Drawing.Point(57, 24);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(107, 32);
            this.lblMenu.TabIndex = 1;
            this.lblMenu.Text = "MENU";
            // 
            // pnMakanan
            // 
            this.pnMakanan.Controls.Add(this.btnMakanan);
            this.pnMakanan.Location = new System.Drawing.Point(3, 91);
            this.pnMakanan.Name = "pnMakanan";
            this.pnMakanan.Size = new System.Drawing.Size(243, 62);
            this.pnMakanan.TabIndex = 1;
            // 
            // btnMakanan
            // 
            this.btnMakanan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMakanan.Font = new System.Drawing.Font("Rockwell Extra Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.pnMinuman.Location = new System.Drawing.Point(3, 159);
            this.pnMinuman.Name = "pnMinuman";
            this.pnMinuman.Size = new System.Drawing.Size(243, 62);
            this.pnMinuman.TabIndex = 2;
            // 
            // btnMinuman
            // 
            this.btnMinuman.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinuman.Font = new System.Drawing.Font("Rockwell Extra Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.pnCemilan.Location = new System.Drawing.Point(3, 227);
            this.pnCemilan.Name = "pnCemilan";
            this.pnCemilan.Size = new System.Drawing.Size(243, 62);
            this.pnCemilan.TabIndex = 3;
            // 
            // btnCemilan
            // 
            this.btnCemilan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCemilan.Font = new System.Drawing.Font("Rockwell Extra Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // pnKeranjang
            // 
            this.pnKeranjang.Controls.Add(this.btnKeranjang);
            this.pnKeranjang.Location = new System.Drawing.Point(3, 295);
            this.pnKeranjang.Name = "pnKeranjang";
            this.pnKeranjang.Size = new System.Drawing.Size(243, 62);
            this.pnKeranjang.TabIndex = 5;
            // 
            // btnKeranjang
            // 
            this.btnKeranjang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeranjang.Font = new System.Drawing.Font("Rockwell Extra Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeranjang.ForeColor = System.Drawing.Color.White;
            this.btnKeranjang.Image = global::Final_Project.Properties.Resources.btnKeranjang;
            this.btnKeranjang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKeranjang.Location = new System.Drawing.Point(-8, -9);
            this.btnKeranjang.Name = "btnKeranjang";
            this.btnKeranjang.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnKeranjang.Size = new System.Drawing.Size(260, 78);
            this.btnKeranjang.TabIndex = 1;
            this.btnKeranjang.Text = "                 Keranjang";
            this.btnKeranjang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKeranjang.UseVisualStyleBackColor = true;
            this.btnKeranjang.Click += new System.EventHandler(this.btnKeranjang_Click);
            // 
            // pnAboutUs
            // 
            this.pnAboutUs.Controls.Add(this.btnAboutUs);
            this.pnAboutUs.Location = new System.Drawing.Point(3, 363);
            this.pnAboutUs.Name = "pnAboutUs";
            this.pnAboutUs.Size = new System.Drawing.Size(243, 62);
            this.pnAboutUs.TabIndex = 4;
            // 
            // btnAboutUs
            // 
            this.btnAboutUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAboutUs.Font = new System.Drawing.Font("Rockwell Extra Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.minimizeButton);
            this.panel1.Controls.Add(this.maximizeButton);
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Controls.Add(this.menuButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1155, 62);
            this.panel1.TabIndex = 1;
            // 
            // minimizeButton
            // 
            this.minimizeButton.AllowFocused = false;
            this.minimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeButton.AutoSizeHeight = true;
            this.minimizeButton.BorderRadius = 12;
            this.minimizeButton.Image = ((System.Drawing.Image)(resources.GetObject("minimizeButton.Image")));
            this.minimizeButton.IsCircle = true;
            this.minimizeButton.Location = new System.Drawing.Point(1056, 12);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(25, 25);
            this.minimizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizeButton.TabIndex = 3;
            this.minimizeButton.TabStop = false;
            this.minimizeButton.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // maximizeButton
            // 
            this.maximizeButton.AllowFocused = false;
            this.maximizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizeButton.AutoSizeHeight = true;
            this.maximizeButton.BorderRadius = 12;
            this.maximizeButton.Image = ((System.Drawing.Image)(resources.GetObject("maximizeButton.Image")));
            this.maximizeButton.IsCircle = true;
            this.maximizeButton.Location = new System.Drawing.Point(1087, 12);
            this.maximizeButton.Name = "maximizeButton";
            this.maximizeButton.Size = new System.Drawing.Size(25, 25);
            this.maximizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.maximizeButton.TabIndex = 2;
            this.maximizeButton.TabStop = false;
            this.maximizeButton.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            this.maximizeButton.Click += new System.EventHandler(this.maximizeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.AllowFocused = false;
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.AutoSizeHeight = true;
            this.closeButton.BorderRadius = 12;
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.IsCircle = true;
            this.closeButton.Location = new System.Drawing.Point(1118, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(25, 25);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeButton.TabIndex = 1;
            this.closeButton.TabStop = false;
            this.closeButton.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
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
            // bunifuFormResizer1
            // 
            this.bunifuFormResizer1.ContainerControl = this;
            this.bunifuFormResizer1.Enabled = true;
            this.bunifuFormResizer1.ParentForm = this;
            this.bunifuFormResizer1.ResizeHandlesWidth = 20;
            // 
            // bunifuFormDrag1
            // 
            this.bunifuFormDrag1.AllowOpacityChangesWhileDragging = false;
            this.bunifuFormDrag1.ContainerControl = this;
            this.bunifuFormDrag1.DockIndicatorsOpacity = 0.5D;
            this.bunifuFormDrag1.DockingIndicatorsColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(215)))), ((int)(((byte)(233)))));
            this.bunifuFormDrag1.DockingOptions.DockAll = true;
            this.bunifuFormDrag1.DockingOptions.DockBottomLeft = true;
            this.bunifuFormDrag1.DockingOptions.DockBottomRight = true;
            this.bunifuFormDrag1.DockingOptions.DockFullScreen = true;
            this.bunifuFormDrag1.DockingOptions.DockLeft = true;
            this.bunifuFormDrag1.DockingOptions.DockRight = true;
            this.bunifuFormDrag1.DockingOptions.DockTopLeft = true;
            this.bunifuFormDrag1.DockingOptions.DockTopRight = true;
            this.bunifuFormDrag1.DragOpacity = 0.9D;
            this.bunifuFormDrag1.Enabled = true;
            this.bunifuFormDrag1.ParentForm = this;
            this.bunifuFormDrag1.ShowCursorChanges = true;
            this.bunifuFormDrag1.ShowDockingIndicators = true;
            this.bunifuFormDrag1.TitleBarOptions.BunifuFormDrag = this.bunifuFormDrag1;
            this.bunifuFormDrag1.TitleBarOptions.DoubleClickToExpandWindow = true;
            this.bunifuFormDrag1.TitleBarOptions.Enabled = true;
            this.bunifuFormDrag1.TitleBarOptions.TitleBarControl = null;
            this.bunifuFormDrag1.TitleBarOptions.UseBackColorOnDockingIndicators = false;
            // 
            // pnWelcome
            // 
            this.pnWelcome.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pnWelcome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnWelcome.BackgroundImage")));
            this.pnWelcome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnWelcome.BorderColor = System.Drawing.Color.Transparent;
            this.pnWelcome.BorderRadius = 3;
            this.pnWelcome.BorderThickness = 1;
            this.pnWelcome.Controls.Add(this.guna2PictureBox1);
            this.pnWelcome.Controls.Add(this.bunifuFormResizeIcon1);
            this.pnWelcome.Controls.Add(this.bunifuLabel1);
            this.pnWelcome.Controls.Add(this.bunifuLabel3);
            this.pnWelcome.Controls.Add(this.bunifuLabel2);
            this.pnWelcome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnWelcome.Location = new System.Drawing.Point(246, 62);
            this.pnWelcome.Name = "pnWelcome";
            this.pnWelcome.ShowBorders = true;
            this.pnWelcome.Size = new System.Drawing.Size(909, 588);
            this.pnWelcome.TabIndex = 5;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::Final_Project.Properties.Resources.Group_261;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(265, 57);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(472, 147);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 6;
            this.guna2PictureBox1.TabStop = false;
            // 
            // bunifuFormResizeIcon1
            // 
            this.bunifuFormResizeIcon1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuFormResizeIcon1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFormResizeIcon1.ForeColor = System.Drawing.Color.Black;
            this.bunifuFormResizeIcon1.IconSize = 16;
            this.bunifuFormResizeIcon1.Location = new System.Drawing.Point(888, 567);
            this.bunifuFormResizeIcon1.Name = "bunifuFormResizeIcon1";
            this.bunifuFormResizeIcon1.Size = new System.Drawing.Size(21, 21);
            this.bunifuFormResizeIcon1.TabIndex = 5;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("Rockwell Extra Bold", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.ForeColor = System.Drawing.Color.Red;
            this.bunifuLabel1.Location = new System.Drawing.Point(194, 266);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(558, 62);
            this.bunifuLabel1.TabIndex = 3;
            this.bunifuLabel1.Text = "SELAMAT DATANG";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Font = new System.Drawing.Font("Rockwell Extra Bold", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel3.ForeColor = System.Drawing.Color.Red;
            this.bunifuLabel3.Location = new System.Drawing.Point(424, 354);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(70, 62);
            this.bunifuLabel3.TabIndex = 2;
            this.bunifuLabel3.Text = "DI";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Rockwell Extra Bold", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel2.ForeColor = System.Drawing.Color.Red;
            this.bunifuLabel2.Location = new System.Drawing.Point(220, 443);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(517, 62);
            this.bunifuLabel2.TabIndex = 1;
            this.bunifuLabel2.Text = "RESTORAN MR.B";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1155, 650);
            this.Controls.Add(this.pnWelcome);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(1155, 650);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.sidebar.ResumeLayout(false);
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            this.pnMakanan.ResumeLayout(false);
            this.pnMinuman.ResumeLayout(false);
            this.pnCemilan.ResumeLayout(false);
            this.pnKeranjang.ResumeLayout(false);
            this.pnAboutUs.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            this.pnWelcome.ResumeLayout(false);
            this.pnWelcome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
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
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnKeranjang;
        private System.Windows.Forms.Button btnKeranjang;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private System.Windows.Forms.Label lblMenu;
        private Bunifu.UI.WinForms.BunifuPictureBox minimizeButton;
        private Bunifu.UI.WinForms.BunifuPictureBox maximizeButton;
        private Bunifu.UI.WinForms.BunifuPictureBox closeButton;
        private Bunifu.UI.WinForms.BunifuFormResizer bunifuFormResizer1;
        private Bunifu.UI.WinForms.BunifuFormDrag bunifuFormDrag1;
        private Bunifu.UI.WinForms.BunifuPanel pnWelcome;
        private Bunifu.UI.WinForms.BunifuFormResizeIcon bunifuFormResizeIcon1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}

