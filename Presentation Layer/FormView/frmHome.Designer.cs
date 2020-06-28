namespace Presentation_Layer.FormView
{
    partial class frmHome
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
            this.lbDay = new Guna.UI.WinForms.GunaLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lbHours = new Guna.UI.WinForms.GunaLabel();
            this.lbDay1 = new Guna.UI.WinForms.GunaLabel();
            this.SuspendLayout();
            // 
            // lbDay
            // 
            this.lbDay.BackColor = System.Drawing.Color.Transparent;
            this.lbDay.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbDay.Font = new System.Drawing.Font("Anurati", 49.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDay.Location = new System.Drawing.Point(0, 125);
            this.lbDay.Name = "lbDay";
            this.lbDay.Size = new System.Drawing.Size(1100, 120);
            this.lbDay.TabIndex = 1;
            this.lbDay.Text = "M O N D A Y";
            this.lbDay.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lbHours
            // 
            this.lbHours.BackColor = System.Drawing.Color.Transparent;
            this.lbHours.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbHours.Font = new System.Drawing.Font("Anurati", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHours.Location = new System.Drawing.Point(0, 0);
            this.lbHours.Name = "lbHours";
            this.lbHours.Size = new System.Drawing.Size(1100, 125);
            this.lbHours.TabIndex = 1;
            this.lbHours.Text = "00:00:00";
            this.lbHours.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lbDay1
            // 
            this.lbDay1.BackColor = System.Drawing.Color.Transparent;
            this.lbDay1.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbDay1.Font = new System.Drawing.Font("Anurati", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDay1.Location = new System.Drawing.Point(0, 245);
            this.lbDay1.Name = "lbDay1";
            this.lbDay1.Size = new System.Drawing.Size(1100, 42);
            this.lbDay1.TabIndex = 2;
            this.lbDay1.Text = "- 1 2  J u n e  2 0 2 0 -";
            this.lbDay1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.BackgroundImage = global::Presentation_Layer.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1100, 615);
            this.Controls.Add(this.lbDay1);
            this.Controls.Add(this.lbDay);
            this.Controls.Add(this.lbHours);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmHome";
            this.Text = "frmHome";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel lbDay;
        private System.Windows.Forms.Timer timer;
        private Guna.UI.WinForms.GunaLabel lbHours;
        private Guna.UI.WinForms.GunaLabel lbDay1;
    }
}