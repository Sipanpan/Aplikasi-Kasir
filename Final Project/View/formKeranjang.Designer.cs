﻿namespace Final_Project
{
    partial class formKeranjang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formKeranjang));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges9 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges10 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges11 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges12 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.lblKeranjang = new System.Windows.Forms.Label();
            this.lvwBarang = new System.Windows.Forms.ListView();
            this.btnTambah = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnEdit = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnHapus = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnTampil = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblKeranjang
            // 
            this.lblKeranjang.AutoSize = true;
            this.lblKeranjang.Font = new System.Drawing.Font("Rockwell Extra Bold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeranjang.Location = new System.Drawing.Point(473, 32);
            this.lblKeranjang.Name = "lblKeranjang";
            this.lblKeranjang.Size = new System.Drawing.Size(255, 40);
            this.lblKeranjang.TabIndex = 0;
            this.lblKeranjang.Text = "KERANJANG";
            // 
            // lvwBarang
            // 
            this.lvwBarang.HideSelection = false;
            this.lvwBarang.Location = new System.Drawing.Point(12, 91);
            this.lvwBarang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvwBarang.Name = "lvwBarang";
            this.lvwBarang.Size = new System.Drawing.Size(1176, 436);
            this.lvwBarang.TabIndex = 1;
            this.lvwBarang.UseCompatibleStateImageBehavior = false;
            // 
            // btnTambah
            // 
            this.btnTambah.AllowAnimations = true;
            this.btnTambah.AllowMouseEffects = true;
            this.btnTambah.AllowToggling = false;
            this.btnTambah.AnimationSpeed = 200;
            this.btnTambah.AutoGenerateColors = false;
            this.btnTambah.AutoRoundBorders = false;
            this.btnTambah.AutoSizeLeftIcon = true;
            this.btnTambah.AutoSizeRightIcon = true;
            this.btnTambah.BackColor = System.Drawing.Color.Transparent;
            this.btnTambah.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnTambah.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTambah.BackgroundImage")));
            this.btnTambah.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnTambah.ButtonText = "Tambah";
            this.btnTambah.ButtonTextMarginLeft = 0;
            this.btnTambah.ColorContrastOnClick = 45;
            this.btnTambah.ColorContrastOnHover = 45;
            this.btnTambah.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges9.BottomLeft = true;
            borderEdges9.BottomRight = true;
            borderEdges9.TopLeft = true;
            borderEdges9.TopRight = true;
            this.btnTambah.CustomizableEdges = borderEdges9;
            this.btnTambah.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTambah.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnTambah.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnTambah.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnTambah.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnTambah.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTambah.ForeColor = System.Drawing.Color.White;
            this.btnTambah.IconLeft = null;
            this.btnTambah.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTambah.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnTambah.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnTambah.IconMarginLeft = 11;
            this.btnTambah.IconPadding = 10;
            this.btnTambah.IconRight = null;
            this.btnTambah.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTambah.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnTambah.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnTambah.IconSize = 25;
            this.btnTambah.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnTambah.IdleBorderRadius = 0;
            this.btnTambah.IdleBorderThickness = 0;
            this.btnTambah.IdleFillColor = System.Drawing.Color.Empty;
            this.btnTambah.IdleIconLeftImage = null;
            this.btnTambah.IdleIconRightImage = null;
            this.btnTambah.IndicateFocus = false;
            this.btnTambah.Location = new System.Drawing.Point(12, 613);
            this.btnTambah.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnTambah.OnDisabledState.BorderRadius = 1;
            this.btnTambah.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnTambah.OnDisabledState.BorderThickness = 1;
            this.btnTambah.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnTambah.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnTambah.OnDisabledState.IconLeftImage = null;
            this.btnTambah.OnDisabledState.IconRightImage = null;
            this.btnTambah.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnTambah.onHoverState.BorderRadius = 1;
            this.btnTambah.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnTambah.onHoverState.BorderThickness = 1;
            this.btnTambah.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnTambah.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnTambah.onHoverState.IconLeftImage = null;
            this.btnTambah.onHoverState.IconRightImage = null;
            this.btnTambah.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnTambah.OnIdleState.BorderRadius = 1;
            this.btnTambah.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnTambah.OnIdleState.BorderThickness = 1;
            this.btnTambah.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnTambah.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnTambah.OnIdleState.IconLeftImage = null;
            this.btnTambah.OnIdleState.IconRightImage = null;
            this.btnTambah.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnTambah.OnPressedState.BorderRadius = 1;
            this.btnTambah.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnTambah.OnPressedState.BorderThickness = 1;
            this.btnTambah.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnTambah.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnTambah.OnPressedState.IconLeftImage = null;
            this.btnTambah.OnPressedState.IconRightImage = null;
            this.btnTambah.Size = new System.Drawing.Size(149, 39);
            this.btnTambah.TabIndex = 5;
            this.btnTambah.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTambah.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnTambah.TextMarginLeft = 0;
            this.btnTambah.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnTambah.UseDefaultRadiusAndThickness = true;
            // 
            // btnEdit
            // 
            this.btnEdit.AllowAnimations = true;
            this.btnEdit.AllowMouseEffects = true;
            this.btnEdit.AllowToggling = false;
            this.btnEdit.AnimationSpeed = 200;
            this.btnEdit.AutoGenerateColors = false;
            this.btnEdit.AutoRoundBorders = false;
            this.btnEdit.AutoSizeLeftIcon = true;
            this.btnEdit.AutoSizeRightIcon = true;
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.BackgroundImage")));
            this.btnEdit.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEdit.ButtonText = "Edit";
            this.btnEdit.ButtonTextMarginLeft = 0;
            this.btnEdit.ColorContrastOnClick = 45;
            this.btnEdit.ColorContrastOnHover = 45;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges10.BottomLeft = true;
            borderEdges10.BottomRight = true;
            borderEdges10.TopLeft = true;
            borderEdges10.TopRight = true;
            this.btnEdit.CustomizableEdges = borderEdges10;
            this.btnEdit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEdit.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnEdit.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnEdit.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnEdit.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.IconLeft = null;
            this.btnEdit.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnEdit.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnEdit.IconMarginLeft = 11;
            this.btnEdit.IconPadding = 10;
            this.btnEdit.IconRight = null;
            this.btnEdit.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnEdit.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnEdit.IconSize = 25;
            this.btnEdit.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnEdit.IdleBorderRadius = 0;
            this.btnEdit.IdleBorderThickness = 0;
            this.btnEdit.IdleFillColor = System.Drawing.Color.Empty;
            this.btnEdit.IdleIconLeftImage = null;
            this.btnEdit.IdleIconRightImage = null;
            this.btnEdit.IndicateFocus = false;
            this.btnEdit.Location = new System.Drawing.Point(12, 658);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnEdit.OnDisabledState.BorderRadius = 1;
            this.btnEdit.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEdit.OnDisabledState.BorderThickness = 1;
            this.btnEdit.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnEdit.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnEdit.OnDisabledState.IconLeftImage = null;
            this.btnEdit.OnDisabledState.IconRightImage = null;
            this.btnEdit.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnEdit.onHoverState.BorderRadius = 1;
            this.btnEdit.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEdit.onHoverState.BorderThickness = 1;
            this.btnEdit.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnEdit.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnEdit.onHoverState.IconLeftImage = null;
            this.btnEdit.onHoverState.IconRightImage = null;
            this.btnEdit.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnEdit.OnIdleState.BorderRadius = 1;
            this.btnEdit.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEdit.OnIdleState.BorderThickness = 1;
            this.btnEdit.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnEdit.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnEdit.OnIdleState.IconLeftImage = null;
            this.btnEdit.OnIdleState.IconRightImage = null;
            this.btnEdit.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnEdit.OnPressedState.BorderRadius = 1;
            this.btnEdit.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEdit.OnPressedState.BorderThickness = 1;
            this.btnEdit.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnEdit.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnEdit.OnPressedState.IconLeftImage = null;
            this.btnEdit.OnPressedState.IconRightImage = null;
            this.btnEdit.Size = new System.Drawing.Size(149, 39);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEdit.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEdit.TextMarginLeft = 0;
            this.btnEdit.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnEdit.UseDefaultRadiusAndThickness = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.AllowAnimations = true;
            this.btnHapus.AllowMouseEffects = true;
            this.btnHapus.AllowToggling = false;
            this.btnHapus.AnimationSpeed = 200;
            this.btnHapus.AutoGenerateColors = false;
            this.btnHapus.AutoRoundBorders = false;
            this.btnHapus.AutoSizeLeftIcon = true;
            this.btnHapus.AutoSizeRightIcon = true;
            this.btnHapus.BackColor = System.Drawing.Color.Transparent;
            this.btnHapus.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnHapus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHapus.BackgroundImage")));
            this.btnHapus.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnHapus.ButtonText = "Hapus";
            this.btnHapus.ButtonTextMarginLeft = 0;
            this.btnHapus.ColorContrastOnClick = 45;
            this.btnHapus.ColorContrastOnHover = 45;
            this.btnHapus.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges11.BottomLeft = true;
            borderEdges11.BottomRight = true;
            borderEdges11.TopLeft = true;
            borderEdges11.TopRight = true;
            this.btnHapus.CustomizableEdges = borderEdges11;
            this.btnHapus.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnHapus.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnHapus.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnHapus.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnHapus.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnHapus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHapus.ForeColor = System.Drawing.Color.White;
            this.btnHapus.IconLeft = null;
            this.btnHapus.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHapus.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnHapus.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnHapus.IconMarginLeft = 11;
            this.btnHapus.IconPadding = 10;
            this.btnHapus.IconRight = null;
            this.btnHapus.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHapus.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnHapus.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnHapus.IconSize = 25;
            this.btnHapus.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnHapus.IdleBorderRadius = 0;
            this.btnHapus.IdleBorderThickness = 0;
            this.btnHapus.IdleFillColor = System.Drawing.Color.Empty;
            this.btnHapus.IdleIconLeftImage = null;
            this.btnHapus.IdleIconRightImage = null;
            this.btnHapus.IndicateFocus = false;
            this.btnHapus.Location = new System.Drawing.Point(168, 613);
            this.btnHapus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnHapus.OnDisabledState.BorderRadius = 1;
            this.btnHapus.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnHapus.OnDisabledState.BorderThickness = 1;
            this.btnHapus.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnHapus.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnHapus.OnDisabledState.IconLeftImage = null;
            this.btnHapus.OnDisabledState.IconRightImage = null;
            this.btnHapus.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnHapus.onHoverState.BorderRadius = 1;
            this.btnHapus.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnHapus.onHoverState.BorderThickness = 1;
            this.btnHapus.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnHapus.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnHapus.onHoverState.IconLeftImage = null;
            this.btnHapus.onHoverState.IconRightImage = null;
            this.btnHapus.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnHapus.OnIdleState.BorderRadius = 1;
            this.btnHapus.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnHapus.OnIdleState.BorderThickness = 1;
            this.btnHapus.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnHapus.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnHapus.OnIdleState.IconLeftImage = null;
            this.btnHapus.OnIdleState.IconRightImage = null;
            this.btnHapus.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnHapus.OnPressedState.BorderRadius = 1;
            this.btnHapus.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnHapus.OnPressedState.BorderThickness = 1;
            this.btnHapus.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnHapus.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnHapus.OnPressedState.IconLeftImage = null;
            this.btnHapus.OnPressedState.IconRightImage = null;
            this.btnHapus.Size = new System.Drawing.Size(149, 39);
            this.btnHapus.TabIndex = 7;
            this.btnHapus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHapus.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnHapus.TextMarginLeft = 0;
            this.btnHapus.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnHapus.UseDefaultRadiusAndThickness = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnTampil
            // 
            this.btnTampil.AllowAnimations = true;
            this.btnTampil.AllowMouseEffects = true;
            this.btnTampil.AllowToggling = false;
            this.btnTampil.AnimationSpeed = 200;
            this.btnTampil.AutoGenerateColors = false;
            this.btnTampil.AutoRoundBorders = false;
            this.btnTampil.AutoSizeLeftIcon = true;
            this.btnTampil.AutoSizeRightIcon = true;
            this.btnTampil.BackColor = System.Drawing.Color.Transparent;
            this.btnTampil.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnTampil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTampil.BackgroundImage")));
            this.btnTampil.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnTampil.ButtonText = "Tampilkan";
            this.btnTampil.ButtonTextMarginLeft = 0;
            this.btnTampil.ColorContrastOnClick = 45;
            this.btnTampil.ColorContrastOnHover = 45;
            this.btnTampil.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges12.BottomLeft = true;
            borderEdges12.BottomRight = true;
            borderEdges12.TopLeft = true;
            borderEdges12.TopRight = true;
            this.btnTampil.CustomizableEdges = borderEdges12;
            this.btnTampil.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTampil.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnTampil.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnTampil.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnTampil.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnTampil.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTampil.ForeColor = System.Drawing.Color.White;
            this.btnTampil.IconLeft = null;
            this.btnTampil.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTampil.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnTampil.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnTampil.IconMarginLeft = 11;
            this.btnTampil.IconPadding = 10;
            this.btnTampil.IconRight = null;
            this.btnTampil.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTampil.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnTampil.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnTampil.IconSize = 25;
            this.btnTampil.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnTampil.IdleBorderRadius = 0;
            this.btnTampil.IdleBorderThickness = 0;
            this.btnTampil.IdleFillColor = System.Drawing.Color.Empty;
            this.btnTampil.IdleIconLeftImage = null;
            this.btnTampil.IdleIconRightImage = null;
            this.btnTampil.IndicateFocus = false;
            this.btnTampil.Location = new System.Drawing.Point(1012, 636);
            this.btnTampil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTampil.Name = "btnTampil";
            this.btnTampil.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnTampil.OnDisabledState.BorderRadius = 1;
            this.btnTampil.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnTampil.OnDisabledState.BorderThickness = 1;
            this.btnTampil.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnTampil.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnTampil.OnDisabledState.IconLeftImage = null;
            this.btnTampil.OnDisabledState.IconRightImage = null;
            this.btnTampil.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnTampil.onHoverState.BorderRadius = 1;
            this.btnTampil.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnTampil.onHoverState.BorderThickness = 1;
            this.btnTampil.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnTampil.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnTampil.onHoverState.IconLeftImage = null;
            this.btnTampil.onHoverState.IconRightImage = null;
            this.btnTampil.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnTampil.OnIdleState.BorderRadius = 1;
            this.btnTampil.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnTampil.OnIdleState.BorderThickness = 1;
            this.btnTampil.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnTampil.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnTampil.OnIdleState.IconLeftImage = null;
            this.btnTampil.OnIdleState.IconRightImage = null;
            this.btnTampil.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnTampil.OnPressedState.BorderRadius = 1;
            this.btnTampil.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnTampil.OnPressedState.BorderThickness = 1;
            this.btnTampil.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnTampil.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnTampil.OnPressedState.IconLeftImage = null;
            this.btnTampil.OnPressedState.IconRightImage = null;
            this.btnTampil.Size = new System.Drawing.Size(149, 39);
            this.btnTampil.TabIndex = 8;
            this.btnTampil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTampil.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnTampil.TextMarginLeft = 0;
            this.btnTampil.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnTampil.UseDefaultRadiusAndThickness = true;
            this.btnTampil.Click += new System.EventHandler(this.btnTampil_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(845, 547);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(87, 42);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(938, 544);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(250, 48);
            this.txtTotal.TabIndex = 10;
            // 
            // formKeranjang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 710);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnTampil);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.lvwBarang);
            this.Controls.Add(this.lblKeranjang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "formKeranjang";
            this.Text = "formKeranjang";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKeranjang;
        private System.Windows.Forms.ListView lvwBarang;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnTambah;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnEdit;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnHapus;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnTampil;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
    }
}