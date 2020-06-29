namespace Presentation_Layer.FormDigital
{
    partial class frmPhieuDatChoEditing
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
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbDaHuy = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbDaBan = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbDat = new Guna.UI2.WinForms.Guna2RadioButton();
            this.tbNgayGio = new System.Windows.Forms.Label();
            this.tbGiaVe = new System.Windows.Forms.Label();
            this.tbMaVe = new System.Windows.Forms.Label();
            this.tbTenHK = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbCMND = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbDienThoai = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbMaCB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbHangVe = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbDienThoai = new Guna.UI.WinForms.GunaLabel();
            this.lbHangVe = new Guna.UI.WinForms.GunaLabel();
            this.lbGiaVe = new Guna.UI.WinForms.GunaLabel();
            this.lbTinhTrang = new Guna.UI.WinForms.GunaLabel();
            this.lbCMND = new Guna.UI.WinForms.GunaLabel();
            this.lbTenHK = new Guna.UI.WinForms.GunaLabel();
            this.lbNgayGio = new Guna.UI.WinForms.GunaLabel();
            this.lbMaCB = new Guna.UI.WinForms.GunaLabel();
            this.lbMaVe = new Guna.UI.WinForms.GunaLabel();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.btnOK = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbNoti = new Guna.UI.WinForms.GunaLabel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Animated = true;
            this.btnClose.AutoRoundedCorners = true;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BorderRadius = 19;
            this.btnClose.CheckedState.Parent = this.btnClose;
            this.btnClose.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnClose.CustomImages.Parent = this.btnClose;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.Location = new System.Drawing.Point(748, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.BorderRadius = 19;
            this.btnClose.ShadowDecoration.Enabled = true;
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.TabIndex = 4;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.gunaLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 60);
            this.panel1.TabIndex = 5;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(0, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(800, 60);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Phiếu Đặt Chỗ";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbDaHuy);
            this.panel2.Controls.Add(this.rbDaBan);
            this.panel2.Controls.Add(this.rbDat);
            this.panel2.Controls.Add(this.tbNgayGio);
            this.panel2.Controls.Add(this.tbGiaVe);
            this.panel2.Controls.Add(this.tbMaVe);
            this.panel2.Controls.Add(this.tbTenHK);
            this.panel2.Controls.Add(this.tbCMND);
            this.panel2.Controls.Add(this.tbDienThoai);
            this.panel2.Controls.Add(this.cbMaCB);
            this.panel2.Controls.Add(this.cbHangVe);
            this.panel2.Controls.Add(this.lbDienThoai);
            this.panel2.Controls.Add(this.lbHangVe);
            this.panel2.Controls.Add(this.lbGiaVe);
            this.panel2.Controls.Add(this.lbTinhTrang);
            this.panel2.Controls.Add(this.lbCMND);
            this.panel2.Controls.Add(this.lbTenHK);
            this.panel2.Controls.Add(this.lbNgayGio);
            this.panel2.Controls.Add(this.lbMaCB);
            this.panel2.Controls.Add(this.lbMaVe);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 320);
            this.panel2.TabIndex = 0;
            // 
            // rbDaHuy
            // 
            this.rbDaHuy.Animated = true;
            this.rbDaHuy.AutoSize = true;
            this.rbDaHuy.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbDaHuy.CheckedState.BorderThickness = 0;
            this.rbDaHuy.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbDaHuy.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbDaHuy.CheckedState.InnerOffset = -4;
            this.rbDaHuy.Enabled = false;
            this.rbDaHuy.Location = new System.Drawing.Point(533, 258);
            this.rbDaHuy.Name = "rbDaHuy";
            this.rbDaHuy.Size = new System.Drawing.Size(97, 32);
            this.rbDaHuy.TabIndex = 4;
            this.rbDaHuy.Text = "Đã hủy";
            this.rbDaHuy.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbDaHuy.UncheckedState.BorderThickness = 2;
            this.rbDaHuy.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbDaHuy.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rbDaBan
            // 
            this.rbDaBan.Animated = true;
            this.rbDaBan.AutoSize = true;
            this.rbDaBan.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbDaBan.CheckedState.BorderThickness = 0;
            this.rbDaBan.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbDaBan.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbDaBan.CheckedState.InnerOffset = -4;
            this.rbDaBan.Enabled = false;
            this.rbDaBan.Location = new System.Drawing.Point(326, 258);
            this.rbDaBan.Name = "rbDaBan";
            this.rbDaBan.Size = new System.Drawing.Size(97, 32);
            this.rbDaBan.TabIndex = 4;
            this.rbDaBan.Text = "Đã bán";
            this.rbDaBan.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbDaBan.UncheckedState.BorderThickness = 2;
            this.rbDaBan.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbDaBan.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rbDat
            // 
            this.rbDat.Animated = true;
            this.rbDat.AutoSize = true;
            this.rbDat.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbDat.CheckedState.BorderThickness = 0;
            this.rbDat.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbDat.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbDat.CheckedState.InnerOffset = -4;
            this.rbDat.Enabled = false;
            this.rbDat.Location = new System.Drawing.Point(152, 258);
            this.rbDat.Name = "rbDat";
            this.rbDat.Size = new System.Drawing.Size(64, 32);
            this.rbDat.TabIndex = 4;
            this.rbDat.Text = "Đặt";
            this.rbDat.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbDat.UncheckedState.BorderThickness = 2;
            this.rbDat.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbDat.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // tbNgayGio
            // 
            this.tbNgayGio.AutoSize = true;
            this.tbNgayGio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNgayGio.Location = new System.Drawing.Point(508, 94);
            this.tbNgayGio.Name = "tbNgayGio";
            this.tbNgayGio.Size = new System.Drawing.Size(0, 28);
            this.tbNgayGio.TabIndex = 3;
            // 
            // tbGiaVe
            // 
            this.tbGiaVe.AutoSize = true;
            this.tbGiaVe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGiaVe.Location = new System.Drawing.Point(508, 38);
            this.tbGiaVe.Name = "tbGiaVe";
            this.tbGiaVe.Size = new System.Drawing.Size(0, 28);
            this.tbGiaVe.TabIndex = 3;
            // 
            // tbMaVe
            // 
            this.tbMaVe.AutoSize = true;
            this.tbMaVe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaVe.Location = new System.Drawing.Point(152, 38);
            this.tbMaVe.Name = "tbMaVe";
            this.tbMaVe.Size = new System.Drawing.Size(96, 28);
            this.tbMaVe.TabIndex = 3;
            this.tbMaVe.Text = "#######";
            // 
            // tbTenHK
            // 
            this.tbTenHK.BackColor = System.Drawing.Color.Transparent;
            this.tbTenHK.BorderRadius = 6;
            this.tbTenHK.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbTenHK.DefaultText = "";
            this.tbTenHK.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbTenHK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbTenHK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTenHK.DisabledState.Parent = this.tbTenHK;
            this.tbTenHK.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTenHK.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbTenHK.FocusedState.Parent = this.tbTenHK;
            this.tbTenHK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenHK.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbTenHK.HoverState.Parent = this.tbTenHK;
            this.tbTenHK.Location = new System.Drawing.Point(152, 142);
            this.tbTenHK.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.tbTenHK.Name = "tbTenHK";
            this.tbTenHK.PasswordChar = '\0';
            this.tbTenHK.PlaceholderText = "";
            this.tbTenHK.SelectedText = "";
            this.tbTenHK.ShadowDecoration.Parent = this.tbTenHK;
            this.tbTenHK.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.tbTenHK.Size = new System.Drawing.Size(229, 36);
            this.tbTenHK.TabIndex = 0;
            // 
            // tbCMND
            // 
            this.tbCMND.BackColor = System.Drawing.Color.Transparent;
            this.tbCMND.BorderRadius = 6;
            this.tbCMND.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCMND.DefaultText = "";
            this.tbCMND.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbCMND.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbCMND.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbCMND.DisabledState.Parent = this.tbCMND;
            this.tbCMND.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbCMND.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCMND.FocusedState.Parent = this.tbCMND;
            this.tbCMND.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCMND.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCMND.HoverState.Parent = this.tbCMND;
            this.tbCMND.Location = new System.Drawing.Point(152, 198);
            this.tbCMND.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.tbCMND.Name = "tbCMND";
            this.tbCMND.PasswordChar = '\0';
            this.tbCMND.PlaceholderText = "";
            this.tbCMND.SelectedText = "";
            this.tbCMND.ShadowDecoration.Parent = this.tbCMND;
            this.tbCMND.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.tbCMND.Size = new System.Drawing.Size(229, 36);
            this.tbCMND.TabIndex = 1;
            // 
            // tbDienThoai
            // 
            this.tbDienThoai.BackColor = System.Drawing.Color.Transparent;
            this.tbDienThoai.BorderRadius = 6;
            this.tbDienThoai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbDienThoai.DefaultText = "";
            this.tbDienThoai.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbDienThoai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbDienThoai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbDienThoai.DisabledState.Parent = this.tbDienThoai;
            this.tbDienThoai.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbDienThoai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbDienThoai.FocusedState.Parent = this.tbDienThoai;
            this.tbDienThoai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDienThoai.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbDienThoai.HoverState.Parent = this.tbDienThoai;
            this.tbDienThoai.Location = new System.Drawing.Point(508, 198);
            this.tbDienThoai.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.tbDienThoai.Name = "tbDienThoai";
            this.tbDienThoai.PasswordChar = '\0';
            this.tbDienThoai.PlaceholderText = "";
            this.tbDienThoai.SelectedText = "";
            this.tbDienThoai.ShadowDecoration.Parent = this.tbDienThoai;
            this.tbDienThoai.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.tbDienThoai.Size = new System.Drawing.Size(221, 36);
            this.tbDienThoai.TabIndex = 2;
            // 
            // cbMaCB
            // 
            this.cbMaCB.Animated = true;
            this.cbMaCB.BackColor = System.Drawing.Color.Transparent;
            this.cbMaCB.BorderRadius = 6;
            this.cbMaCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbMaCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaCB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMaCB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMaCB.FocusedState.Parent = this.cbMaCB;
            this.cbMaCB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbMaCB.HoverState.Parent = this.cbMaCB;
            this.cbMaCB.IntegralHeight = false;
            this.cbMaCB.ItemHeight = 30;
            this.cbMaCB.ItemsAppearance.Parent = this.cbMaCB;
            this.cbMaCB.Location = new System.Drawing.Point(152, 86);
            this.cbMaCB.MaxLength = 12;
            this.cbMaCB.Name = "cbMaCB";
            this.cbMaCB.ShadowDecoration.Parent = this.cbMaCB;
            this.cbMaCB.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.cbMaCB.Size = new System.Drawing.Size(229, 36);
            this.cbMaCB.TabIndex = 2;
            this.cbMaCB.TabStop = false;
            this.cbMaCB.SelectedIndexChanged += new System.EventHandler(this.cbMaCB_SelectedIndexChanged);
            // 
            // cbHangVe
            // 
            this.cbHangVe.Animated = true;
            this.cbHangVe.BackColor = System.Drawing.Color.Transparent;
            this.cbHangVe.BorderRadius = 6;
            this.cbHangVe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbHangVe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHangVe.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbHangVe.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbHangVe.FocusedState.Parent = this.cbHangVe;
            this.cbHangVe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHangVe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbHangVe.HoverState.Parent = this.cbHangVe;
            this.cbHangVe.IntegralHeight = false;
            this.cbHangVe.ItemHeight = 30;
            this.cbHangVe.ItemsAppearance.Parent = this.cbHangVe;
            this.cbHangVe.Location = new System.Drawing.Point(508, 142);
            this.cbHangVe.Name = "cbHangVe";
            this.cbHangVe.ShadowDecoration.Parent = this.cbHangVe;
            this.cbHangVe.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.cbHangVe.Size = new System.Drawing.Size(220, 36);
            this.cbHangVe.TabIndex = 2;
            this.cbHangVe.TabStop = false;
            this.cbHangVe.SelectedIndexChanged += new System.EventHandler(this.cbHangVe_SelectedIndexChanged);
            // 
            // lbDienThoai
            // 
            this.lbDienThoai.AutoSize = true;
            this.lbDienThoai.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDienThoai.Location = new System.Drawing.Point(390, 206);
            this.lbDienThoai.Name = "lbDienThoai";
            this.lbDienThoai.Size = new System.Drawing.Size(115, 28);
            this.lbDienThoai.TabIndex = 0;
            this.lbDienThoai.Text = "Điện Thoại:";
            // 
            // lbHangVe
            // 
            this.lbHangVe.AutoSize = true;
            this.lbHangVe.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHangVe.Location = new System.Drawing.Point(390, 150);
            this.lbHangVe.Name = "lbHangVe";
            this.lbHangVe.Size = new System.Drawing.Size(95, 28);
            this.lbHangVe.TabIndex = 0;
            this.lbHangVe.Text = "Hạng Vé:";
            // 
            // lbGiaVe
            // 
            this.lbGiaVe.AutoSize = true;
            this.lbGiaVe.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGiaVe.Location = new System.Drawing.Point(390, 38);
            this.lbGiaVe.Name = "lbGiaVe";
            this.lbGiaVe.Size = new System.Drawing.Size(75, 28);
            this.lbGiaVe.TabIndex = 0;
            this.lbGiaVe.Text = "Giá Vé:";
            // 
            // lbTinhTrang
            // 
            this.lbTinhTrang.AutoSize = true;
            this.lbTinhTrang.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTinhTrang.Location = new System.Drawing.Point(13, 262);
            this.lbTinhTrang.Name = "lbTinhTrang";
            this.lbTinhTrang.Size = new System.Drawing.Size(113, 28);
            this.lbTinhTrang.TabIndex = 0;
            this.lbTinhTrang.Text = "Tình Trạng:";
            // 
            // lbCMND
            // 
            this.lbCMND.AutoSize = true;
            this.lbCMND.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCMND.Location = new System.Drawing.Point(13, 206);
            this.lbCMND.Name = "lbCMND";
            this.lbCMND.Size = new System.Drawing.Size(76, 28);
            this.lbCMND.TabIndex = 0;
            this.lbCMND.Text = "CMND:";
            // 
            // lbTenHK
            // 
            this.lbTenHK.AutoSize = true;
            this.lbTenHK.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenHK.Location = new System.Drawing.Point(13, 150);
            this.lbTenHK.Name = "lbTenHK";
            this.lbTenHK.Size = new System.Drawing.Size(127, 28);
            this.lbTenHK.TabIndex = 0;
            this.lbTenHK.Text = "Hành Khách:";
            // 
            // lbNgayGio
            // 
            this.lbNgayGio.AutoSize = true;
            this.lbNgayGio.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayGio.Location = new System.Drawing.Point(390, 94);
            this.lbNgayGio.Name = "lbNgayGio";
            this.lbNgayGio.Size = new System.Drawing.Size(115, 28);
            this.lbNgayGio.TabIndex = 0;
            this.lbNgayGio.Text = "Ngày - Giờ:";
            // 
            // lbMaCB
            // 
            this.lbMaCB.AutoSize = true;
            this.lbMaCB.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaCB.Location = new System.Drawing.Point(13, 94);
            this.lbMaCB.Name = "lbMaCB";
            this.lbMaCB.Size = new System.Drawing.Size(158, 28);
            this.lbMaCB.TabIndex = 0;
            this.lbMaCB.Text = "Mã Chuyến Bay:";
            // 
            // lbMaVe
            // 
            this.lbMaVe.AutoSize = true;
            this.lbMaVe.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaVe.Location = new System.Drawing.Point(13, 38);
            this.lbMaVe.Name = "lbMaVe";
            this.lbMaVe.Size = new System.Drawing.Size(74, 28);
            this.lbMaVe.TabIndex = 0;
            this.lbMaVe.Text = "Mã Vé:";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BorderRadius = 6;
            this.btnCancel.CheckedState.Parent = this.btnCancel;
            this.btnCancel.CustomImages.Parent = this.btnCancel;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.HoverState.Parent = this.btnCancel;
            this.btnCancel.Location = new System.Drawing.Point(491, 397);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ShadowDecoration.Enabled = true;
            this.btnCancel.ShadowDecoration.Parent = this.btnCancel;
            this.btnCancel.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.btnCancel.Size = new System.Drawing.Size(180, 45);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.gunaLabel1;
            // 
            // btnOK
            // 
            this.btnOK.AllowDrop = true;
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOK.BackColor = System.Drawing.Color.Transparent;
            this.btnOK.BorderRadius = 6;
            this.btnOK.CheckedState.Parent = this.btnOK;
            this.btnOK.CustomImages.Parent = this.btnOK;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.FillColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnOK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.HoverState.Parent = this.btnOK;
            this.btnOK.Location = new System.Drawing.Point(130, 397);
            this.btnOK.Name = "btnOK";
            this.btnOK.ShadowDecoration.Enabled = true;
            this.btnOK.ShadowDecoration.Parent = this.btnOK;
            this.btnOK.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.btnOK.Size = new System.Drawing.Size(180, 45);
            this.btnOK.TabIndex = 0;
            this.btnOK.TabStop = false;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.TabStop = false;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(363, 219);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.TabStop = false;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lbNoti
            // 
            this.lbNoti.AutoSize = true;
            this.lbNoti.BackColor = System.Drawing.Color.Transparent;
            this.lbNoti.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbNoti.ForeColor = System.Drawing.Color.Red;
            this.lbNoti.Location = new System.Drawing.Point(20, 305);
            this.lbNoti.Name = "lbNoti";
            this.lbNoti.Size = new System.Drawing.Size(0, 20);
            this.lbNoti.TabIndex = 9;
            this.lbNoti.Visible = false;
            // 
            // frmPhieuDatChoEditing
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(800, 460);
            this.Controls.Add(this.lbNoti);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPhieuDatChoEditing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "v";
            this.Load += new System.EventHandler(this.frmPhieuDatChoEditing_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaLabel lbMaVe;
        private Guna.UI.WinForms.GunaLabel lbHangVe;
        private Guna.UI.WinForms.GunaLabel lbGiaVe;
        private Guna.UI.WinForms.GunaLabel lbTenHK;
        private Guna.UI.WinForms.GunaLabel lbNgayGio;
        private Guna.UI.WinForms.GunaLabel lbMaCB;
        private Guna.UI2.WinForms.Guna2ComboBox cbMaCB;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Button btnOK;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2ComboBox cbHangVe;
        private Guna.UI.WinForms.GunaLabel lbDienThoai;
        private Guna.UI.WinForms.GunaLabel lbCMND;
        private Guna.UI2.WinForms.Guna2TextBox tbTenHK;
        private Guna.UI2.WinForms.Guna2TextBox tbCMND;
        private Guna.UI2.WinForms.Guna2TextBox tbDienThoai;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label tbMaVe;
        private System.Windows.Forms.Label tbNgayGio;
        private System.Windows.Forms.Label tbGiaVe;
        private Guna.UI.WinForms.GunaLabel lbNoti;
        private Guna.UI.WinForms.GunaLabel lbTinhTrang;
        private Guna.UI2.WinForms.Guna2RadioButton rbDat;
        private Guna.UI2.WinForms.Guna2RadioButton rbDaHuy;
        private Guna.UI2.WinForms.Guna2RadioButton rbDaBan;
    }
}