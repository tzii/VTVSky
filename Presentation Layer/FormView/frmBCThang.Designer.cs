namespace Presentation_Layer.FormView
{
    partial class frmBCThang
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
            this.rpvBCThang = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbNam = new System.Windows.Forms.Label();
            this.lbThang = new System.Windows.Forms.Label();
            this.btnBaoCao = new Guna.UI2.WinForms.Guna2Button();
            this.tbNam = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbThang = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rpvBCThang
            // 
            this.rpvBCThang.AutoSize = true;
            this.rpvBCThang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvBCThang.LocalReport.ReportPath = "";
            this.rpvBCThang.Location = new System.Drawing.Point(0, 70);
            this.rpvBCThang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rpvBCThang.Name = "rpvBCThang";
            this.rpvBCThang.ServerReport.BearerToken = null;
            this.rpvBCThang.ShowZoomControl = false;
            this.rpvBCThang.Size = new System.Drawing.Size(1100, 500);
            this.rpvBCThang.TabIndex = 0;
            this.rpvBCThang.TabStop = false;
            this.rpvBCThang.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbNam);
            this.panel1.Controls.Add(this.lbThang);
            this.panel1.Controls.Add(this.btnBaoCao);
            this.panel1.Controls.Add(this.tbNam);
            this.panel1.Controls.Add(this.tbThang);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 70);
            this.panel1.TabIndex = 1;
            // 
            // lbNam
            // 
            this.lbNam.AutoSize = true;
            this.lbNam.Location = new System.Drawing.Point(379, 23);
            this.lbNam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNam.Name = "lbNam";
            this.lbNam.Size = new System.Drawing.Size(58, 28);
            this.lbNam.TabIndex = 2;
            this.lbNam.Text = "Năm:";
            // 
            // lbThang
            // 
            this.lbThang.AutoSize = true;
            this.lbThang.Location = new System.Drawing.Point(100, 23);
            this.lbThang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbThang.Name = "lbThang";
            this.lbThang.Size = new System.Drawing.Size(70, 28);
            this.lbThang.TabIndex = 2;
            this.lbThang.Text = "Tháng:";
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.BorderRadius = 6;
            this.btnBaoCao.CheckedState.Parent = this.btnBaoCao;
            this.btnBaoCao.CustomImages.Parent = this.btnBaoCao;
            this.btnBaoCao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoCao.ForeColor = System.Drawing.Color.White;
            this.btnBaoCao.HoverState.Parent = this.btnBaoCao;
            this.btnBaoCao.Location = new System.Drawing.Point(804, 17);
            this.btnBaoCao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.ShadowDecoration.Parent = this.btnBaoCao;
            this.btnBaoCao.Size = new System.Drawing.Size(201, 36);
            this.btnBaoCao.TabIndex = 2;
            this.btnBaoCao.TabStop = false;
            this.btnBaoCao.Text = "Báo Cáo";
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // tbNam
            // 
            this.tbNam.BorderRadius = 6;
            this.tbNam.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNam.DefaultText = "";
            this.tbNam.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbNam.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbNam.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbNam.DisabledState.Parent = this.tbNam;
            this.tbNam.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbNam.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNam.FocusedState.Parent = this.tbNam;
            this.tbNam.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNam.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNam.HoverState.Parent = this.tbNam;
            this.tbNam.Location = new System.Drawing.Point(461, 17);
            this.tbNam.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.tbNam.Name = "tbNam";
            this.tbNam.PasswordChar = '\0';
            this.tbNam.PlaceholderText = "";
            this.tbNam.SelectedText = "";
            this.tbNam.ShadowDecoration.Parent = this.tbNam;
            this.tbNam.Size = new System.Drawing.Size(164, 36);
            this.tbNam.TabIndex = 1;
            // 
            // tbThang
            // 
            this.tbThang.BorderRadius = 6;
            this.tbThang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbThang.DefaultText = "";
            this.tbThang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbThang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbThang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbThang.DisabledState.Parent = this.tbThang;
            this.tbThang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbThang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbThang.FocusedState.Parent = this.tbThang;
            this.tbThang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbThang.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbThang.HoverState.Parent = this.tbThang;
            this.tbThang.Location = new System.Drawing.Point(182, 17);
            this.tbThang.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.tbThang.Name = "tbThang";
            this.tbThang.PasswordChar = '\0';
            this.tbThang.PlaceholderText = "";
            this.tbThang.SelectedText = "";
            this.tbThang.ShadowDecoration.Parent = this.tbThang;
            this.tbThang.Size = new System.Drawing.Size(164, 36);
            this.tbThang.TabIndex = 0;
            // 
            // frmBCThang
            // 
            this.AcceptButton = this.btnBaoCao;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 570);
            this.Controls.Add(this.rpvBCThang);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmBCThang";
            this.Text = "frmBCThang";
            this.Load += new System.EventHandler(this.frmBCThang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvBCThang;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnBaoCao;
        private Guna.UI2.WinForms.Guna2TextBox tbThang;
        private System.Windows.Forms.Label lbThang;
        private System.Windows.Forms.Label lbNam;
        private Guna.UI2.WinForms.Guna2TextBox tbNam;
    }
}