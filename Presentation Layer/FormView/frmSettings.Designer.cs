namespace Presentation_Layer.FormView
{
    partial class frmSettings
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
            this.btnHeThong = new Guna.UI2.WinForms.Guna2Button();
            this.btnHoSo = new Guna.UI2.WinForms.Guna2Button();
            this.pnDesktop = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnHeThong);
            this.panel1.Controls.Add(this.btnHoSo);
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
            this.btnRefresh.Image = global::Presentation_Layer.Properties.Resources.refresh;
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
            // btnHeThong
            // 
            this.btnHeThong.BorderRadius = 10;
            this.btnHeThong.CheckedState.Parent = this.btnHeThong;
            this.btnHeThong.CustomImages.Parent = this.btnHeThong;
            this.btnHeThong.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(178)))), ((int)(((byte)(185)))));
            this.btnHeThong.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHeThong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btnHeThong.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.btnHeThong.HoverState.Parent = this.btnHeThong;
            this.btnHeThong.Location = new System.Drawing.Point(208, 8);
            this.btnHeThong.Name = "btnHeThong";
            this.btnHeThong.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(46)))));
            this.btnHeThong.ShadowDecoration.BorderRadius = 10;
            this.btnHeThong.ShadowDecoration.Parent = this.btnHeThong;
            this.btnHeThong.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.btnHeThong.Size = new System.Drawing.Size(180, 45);
            this.btnHeThong.TabIndex = 0;
            this.btnHeThong.TabStop = false;
            this.btnHeThong.Text = "Hệ Thống";
            this.btnHeThong.Click += new System.EventHandler(this.btnHeThong_Click);
            // 
            // btnHoSo
            // 
            this.btnHoSo.BackColor = System.Drawing.Color.Transparent;
            this.btnHoSo.BorderRadius = 10;
            this.btnHoSo.CheckedState.Parent = this.btnHoSo;
            this.btnHoSo.CustomImages.Parent = this.btnHoSo;
            this.btnHoSo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.btnHoSo.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoSo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.btnHoSo.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.btnHoSo.HoverState.Parent = this.btnHoSo;
            this.btnHoSo.Location = new System.Drawing.Point(22, 8);
            this.btnHoSo.Name = "btnHoSo";
            this.btnHoSo.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(46)))));
            this.btnHoSo.ShadowDecoration.BorderRadius = 10;
            this.btnHoSo.ShadowDecoration.Enabled = true;
            this.btnHoSo.ShadowDecoration.Parent = this.btnHoSo;
            this.btnHoSo.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.btnHoSo.Size = new System.Drawing.Size(180, 45);
            this.btnHoSo.TabIndex = 0;
            this.btnHoSo.TabStop = false;
            this.btnHoSo.Text = "Hồ Sơ";
            this.btnHoSo.Click += new System.EventHandler(this.btnHoSo_Click);
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
            // frmSettings
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
            this.Name = "frmSettings";
            this.Text = "frmHome";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnHoSo;
        private Guna.UI2.WinForms.Guna2Button btnHeThong;
        private System.Windows.Forms.Panel pnDesktop;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
    }
}