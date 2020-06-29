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
            this.cbThang = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbNam = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbNam = new System.Windows.Forms.Label();
            this.lbThang = new System.Windows.Forms.Label();
            this.btnBaoCao = new Guna.UI2.WinForms.Guna2Button();
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
            this.rpvBCThang.TabIndex = 1;
            this.rpvBCThang.TabStop = false;
            this.rpvBCThang.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbThang);
            this.panel1.Controls.Add(this.cbNam);
            this.panel1.Controls.Add(this.lbNam);
            this.panel1.Controls.Add(this.lbThang);
            this.panel1.Controls.Add(this.btnBaoCao);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 70);
            this.panel1.TabIndex = 0;
            // 
            // cbThang
            // 
            this.cbThang.BackColor = System.Drawing.Color.Transparent;
            this.cbThang.BorderRadius = 6;
            this.cbThang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbThang.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbThang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbThang.FocusedState.Parent = this.cbThang;
            this.cbThang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbThang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbThang.HoverState.Parent = this.cbThang;
            this.cbThang.ItemHeight = 30;
            this.cbThang.ItemsAppearance.Parent = this.cbThang;
            this.cbThang.Location = new System.Drawing.Point(626, 17);
            this.cbThang.Name = "cbThang";
            this.cbThang.ShadowDecoration.Parent = this.cbThang;
            this.cbThang.Size = new System.Drawing.Size(124, 36);
            this.cbThang.TabIndex = 3;
            // 
            // cbNam
            // 
            this.cbNam.BackColor = System.Drawing.Color.Transparent;
            this.cbNam.BorderRadius = 6;
            this.cbNam.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbNam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNam.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbNam.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbNam.FocusedState.Parent = this.cbNam;
            this.cbNam.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbNam.HoverState.Parent = this.cbNam;
            this.cbNam.ItemHeight = 30;
            this.cbNam.ItemsAppearance.Parent = this.cbNam;
            this.cbNam.Location = new System.Drawing.Point(415, 17);
            this.cbNam.Name = "cbNam";
            this.cbNam.ShadowDecoration.Parent = this.cbNam;
            this.cbNam.Size = new System.Drawing.Size(124, 36);
            this.cbNam.TabIndex = 3;
            this.cbNam.SelectedIndexChanged += new System.EventHandler(this.cbNam_SelectedIndexChanged);
            // 
            // lbNam
            // 
            this.lbNam.AutoSize = true;
            this.lbNam.Location = new System.Drawing.Point(350, 21);
            this.lbNam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNam.Name = "lbNam";
            this.lbNam.Size = new System.Drawing.Size(58, 28);
            this.lbNam.TabIndex = 2;
            this.lbNam.Text = "Năm:";
            // 
            // lbThang
            // 
            this.lbThang.AutoSize = true;
            this.lbThang.Location = new System.Drawing.Point(549, 21);
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
            this.btnBaoCao.Location = new System.Drawing.Point(881, 17);
            this.btnBaoCao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.ShadowDecoration.Parent = this.btnBaoCao;
            this.btnBaoCao.Size = new System.Drawing.Size(124, 36);
            this.btnBaoCao.TabIndex = 2;
            this.btnBaoCao.TabStop = false;
            this.btnBaoCao.Text = "Báo Cáo";
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
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
        private System.Windows.Forms.Label lbNam;
        private System.Windows.Forms.Label lbThang;
        private Guna.UI2.WinForms.Guna2ComboBox cbNam;
        private Guna.UI2.WinForms.Guna2ComboBox cbThang;
    }
}