namespace Presentation_Layer.FormView
{
    partial class frmFlights
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
            this.btnCreateNew = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnChuyenBay = new Guna.UI2.WinForms.Guna2Button();
            this.pnDesktop = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnCreateNew);
            this.panel1.Controls.Add(this.btnChuyenBay);
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
            // btnCreateNew
            // 
            this.btnCreateNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateNew.Animated = true;
            this.btnCreateNew.BackColor = System.Drawing.Color.Transparent;
            this.btnCreateNew.BorderRadius = 8;
            this.btnCreateNew.CheckedState.Parent = this.btnCreateNew;
            this.btnCreateNew.CustomImages.Parent = this.btnCreateNew;
            this.btnCreateNew.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateNew.ForeColor = System.Drawing.Color.White;
            this.btnCreateNew.HoverState.Parent = this.btnCreateNew;
            this.btnCreateNew.Location = new System.Drawing.Point(832, 7);
            this.btnCreateNew.Name = "btnCreateNew";
            this.btnCreateNew.ShadowDecoration.BorderRadius = 8;
            this.btnCreateNew.ShadowDecoration.Enabled = true;
            this.btnCreateNew.ShadowDecoration.Parent = this.btnCreateNew;
            this.btnCreateNew.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.btnCreateNew.Size = new System.Drawing.Size(160, 31);
            this.btnCreateNew.TabIndex = 2;
            this.btnCreateNew.Text = "Create New";
            this.btnCreateNew.Click += new System.EventHandler(this.btnCreateNew_Click);
            // 
            // btnChuyenBay
            // 
            this.btnChuyenBay.BackColor = System.Drawing.Color.Transparent;
            this.btnChuyenBay.BorderRadius = 10;
            this.btnChuyenBay.CheckedState.Parent = this.btnChuyenBay;
            this.btnChuyenBay.CustomImages.Parent = this.btnChuyenBay;
            this.btnChuyenBay.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.btnChuyenBay.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuyenBay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.btnChuyenBay.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.btnChuyenBay.HoverState.Parent = this.btnChuyenBay;
            this.btnChuyenBay.Location = new System.Drawing.Point(22, 8);
            this.btnChuyenBay.Name = "btnChuyenBay";
            this.btnChuyenBay.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(46)))));
            this.btnChuyenBay.ShadowDecoration.BorderRadius = 10;
            this.btnChuyenBay.ShadowDecoration.Enabled = true;
            this.btnChuyenBay.ShadowDecoration.Parent = this.btnChuyenBay;
            this.btnChuyenBay.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.btnChuyenBay.Size = new System.Drawing.Size(180, 45);
            this.btnChuyenBay.TabIndex = 0;
            this.btnChuyenBay.TabStop = false;
            this.btnChuyenBay.Text = "Chuyến Bay";
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
            // frmFlights
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
            this.Name = "frmFlights";
            this.Text = "frmHome";
            this.Load += new System.EventHandler(this.frmFlights_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnChuyenBay;
        private System.Windows.Forms.Panel pnDesktop;
        private Guna.UI2.WinForms.Guna2GradientButton btnCreateNew;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
    }
}