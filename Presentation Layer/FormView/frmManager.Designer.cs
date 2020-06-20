namespace Presentation_Layer.FormView
{
    partial class frmManager
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.btnHangVe = new Guna.UI2.WinForms.Guna2Button();
            this.btnAirport = new Guna.UI2.WinForms.Guna2Button();
            this.btnTuyenBay = new Guna.UI2.WinForms.Guna2Button();
            this.pnDesktop = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnHangVe);
            this.panel1.Controls.Add(this.btnAirport);
            this.panel1.Controls.Add(this.btnTuyenBay);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 45);
            this.panel1.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.AutoRoundedCorners = true;
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.BorderRadius = 14;
            this.btnRefresh.CheckedState.Parent = this.btnRefresh;
            this.btnRefresh.CustomImages.Parent = this.btnRefresh;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.HoverState.Parent = this.btnRefresh;
            this.btnRefresh.Location = new System.Drawing.Point(1010, 7);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ShadowDecoration.BorderRadius = 14;
            this.btnRefresh.ShadowDecoration.Enabled = true;
            this.btnRefresh.ShadowDecoration.Parent = this.btnRefresh;
            this.btnRefresh.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.btnRefresh.Size = new System.Drawing.Size(31, 31);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnHangVe
            // 
            this.btnHangVe.BorderRadius = 10;
            this.btnHangVe.CheckedState.Parent = this.btnHangVe;
            this.btnHangVe.CustomImages.Parent = this.btnHangVe;
            this.btnHangVe.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(178)))), ((int)(((byte)(185)))));
            this.btnHangVe.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHangVe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btnHangVe.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.btnHangVe.HoverState.Parent = this.btnHangVe;
            this.btnHangVe.Location = new System.Drawing.Point(394, 8);
            this.btnHangVe.Name = "btnHangVe";
            this.btnHangVe.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(46)))));
            this.btnHangVe.ShadowDecoration.BorderRadius = 10;
            this.btnHangVe.ShadowDecoration.Parent = this.btnHangVe;
            this.btnHangVe.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.btnHangVe.Size = new System.Drawing.Size(180, 45);
            this.btnHangVe.TabIndex = 0;
            this.btnHangVe.TabStop = false;
            this.btnHangVe.Text = "Hạng Vé";
            this.btnHangVe.Click += new System.EventHandler(this.btnHangVe_Click);
            // 
            // btnAirport
            // 
            this.btnAirport.BorderRadius = 10;
            this.btnAirport.CheckedState.Parent = this.btnAirport;
            this.btnAirport.CustomImages.Parent = this.btnAirport;
            this.btnAirport.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(178)))), ((int)(((byte)(185)))));
            this.btnAirport.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAirport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btnAirport.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.btnAirport.HoverState.Parent = this.btnAirport;
            this.btnAirport.Location = new System.Drawing.Point(208, 8);
            this.btnAirport.Name = "btnAirport";
            this.btnAirport.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(46)))));
            this.btnAirport.ShadowDecoration.BorderRadius = 10;
            this.btnAirport.ShadowDecoration.Parent = this.btnAirport;
            this.btnAirport.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.btnAirport.Size = new System.Drawing.Size(180, 45);
            this.btnAirport.TabIndex = 0;
            this.btnAirport.TabStop = false;
            this.btnAirport.Text = "Sân Bay";
            this.btnAirport.Click += new System.EventHandler(this.btnAirport_Click);
            // 
            // btnTuyenBay
            // 
            this.btnTuyenBay.BackColor = System.Drawing.Color.Transparent;
            this.btnTuyenBay.BorderRadius = 10;
            this.btnTuyenBay.CheckedState.Parent = this.btnTuyenBay;
            this.btnTuyenBay.CustomImages.Parent = this.btnTuyenBay;
            this.btnTuyenBay.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.btnTuyenBay.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTuyenBay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.btnTuyenBay.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.btnTuyenBay.HoverState.Parent = this.btnTuyenBay;
            this.btnTuyenBay.Location = new System.Drawing.Point(22, 8);
            this.btnTuyenBay.Name = "btnTuyenBay";
            this.btnTuyenBay.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(46)))));
            this.btnTuyenBay.ShadowDecoration.BorderRadius = 10;
            this.btnTuyenBay.ShadowDecoration.Enabled = true;
            this.btnTuyenBay.ShadowDecoration.Parent = this.btnTuyenBay;
            this.btnTuyenBay.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.btnTuyenBay.Size = new System.Drawing.Size(180, 45);
            this.btnTuyenBay.TabIndex = 0;
            this.btnTuyenBay.TabStop = false;
            this.btnTuyenBay.Text = "Tuyến Bay";
            this.btnTuyenBay.Click += new System.EventHandler(this.btnTuyenBay_Click);
            // 
            // pnDesktop
            // 
            this.pnDesktop.BackColor = System.Drawing.Color.Transparent;
            this.pnDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDesktop.Location = new System.Drawing.Point(0, 45);
            this.pnDesktop.Name = "pnDesktop";
            this.pnDesktop.Size = new System.Drawing.Size(1100, 570);
            this.pnDesktop.TabIndex = 1;
            // 
            // frmManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1100, 615);
            this.Controls.Add(this.pnDesktop);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmManager";
            this.Text = "frmHome";
            this.Load += new System.EventHandler(this.frmManager_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnTuyenBay;
        private Guna.UI2.WinForms.Guna2Button btnAirport;
        private System.Windows.Forms.Panel pnDesktop;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private Guna.UI2.WinForms.Guna2Button btnHangVe;
    }
}