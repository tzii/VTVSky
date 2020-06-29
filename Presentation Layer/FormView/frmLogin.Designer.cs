namespace Presentation_Layer.FormView
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.btnLogin = new Guna.UI2.WinForms.Guna2GradientButton();
            this.DragForm = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lbDB = new System.Windows.Forms.LinkLabel();
            this.pbBG = new System.Windows.Forms.PictureBox();
            this.checkBox = new Guna.UI2.WinForms.Guna2CheckBox();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.gunaCirclePictureBox1 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.tbPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbNoti = new System.Windows.Forms.Label();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.Animated = true;
            this.btnLogin.AutoRoundedCorners = true;
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BorderRadius = 21;
            this.btnLogin.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(216)))), ((int)(((byte)(25)))));
            this.btnLogin.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.btnLogin.CheckedState.Parent = this.btnLogin;
            this.btnLogin.CustomImages.Parent = this.btnLogin;
            this.btnLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(193)))), ((int)(((byte)(99)))));
            this.btnLogin.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(67)))), ((int)(((byte)(19)))));
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.btnLogin.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(216)))), ((int)(((byte)(25)))));
            this.btnLogin.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.btnLogin.HoverState.Parent = this.btnLogin;
            this.btnLogin.Location = new System.Drawing.Point(544, 466);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(216)))), ((int)(((byte)(25)))));
            this.btnLogin.ShadowDecoration.BorderRadius = 21;
            this.btnLogin.ShadowDecoration.Enabled = true;
            this.btnLogin.ShadowDecoration.Parent = this.btnLogin;
            this.btnLogin.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.btnLogin.Size = new System.Drawing.Size(300, 45);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.TabStop = false;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // DragForm
            // 
            this.DragForm.DragEndTransparencyValue = 0.95D;
            this.DragForm.TargetControl = this.guna2GradientPanel1;
            this.DragForm.UseTransparentDrag = true;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel1.Controls.Add(this.lbDB);
            this.guna2GradientPanel1.Controls.Add(this.pbBG);
            this.guna2GradientPanel1.Controls.Add(this.checkBox);
            this.guna2GradientPanel1.Controls.Add(this.btnClose);
            this.guna2GradientPanel1.Controls.Add(this.gunaCirclePictureBox1);
            this.guna2GradientPanel1.Controls.Add(this.btnLogin);
            this.guna2GradientPanel1.Controls.Add(this.tbPassword);
            this.guna2GradientPanel1.Controls.Add(this.tbUsername);
            this.guna2GradientPanel1.Controls.Add(this.lbNoti);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(110)))), ((int)(((byte)(254)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(252)))), ((int)(((byte)(232)))));
            this.guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(900, 600);
            this.guna2GradientPanel1.TabIndex = 6;
            // 
            // lbDB
            // 
            this.lbDB.AutoSize = true;
            this.lbDB.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lbDB.Location = new System.Drawing.Point(539, 563);
            this.lbDB.Name = "lbDB";
            this.lbDB.Size = new System.Drawing.Size(93, 28);
            this.lbDB.TabIndex = 3;
            this.lbDB.TabStop = true;
            this.lbDB.Text = "Database";
            this.lbDB.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbDB_LinkClicked);
            // 
            // pbBG
            // 
            this.pbBG.BackgroundImage = global::Presentation_Layer.Properties.Resources.BGLogin;
            this.pbBG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbBG.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbBG.ImageLocation = "";
            this.pbBG.Location = new System.Drawing.Point(0, 0);
            this.pbBG.Name = "pbBG";
            this.pbBG.Size = new System.Drawing.Size(488, 600);
            this.pbBG.TabIndex = 6;
            this.pbBG.TabStop = false;
            // 
            // checkBox
            // 
            this.checkBox.Animated = true;
            this.checkBox.AutoSize = true;
            this.checkBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkBox.CheckedState.BorderRadius = 0;
            this.checkBox.CheckedState.BorderThickness = 0;
            this.checkBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkBox.Location = new System.Drawing.Point(556, 413);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(154, 32);
            this.checkBox.TabIndex = 2;
            this.checkBox.Text = "nhớ mật khẩu";
            this.checkBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkBox.UncheckedState.BorderRadius = 0;
            this.checkBox.UncheckedState.BorderThickness = 0;
            this.checkBox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
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
            this.btnClose.Location = new System.Drawing.Point(838, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.BorderRadius = 19;
            this.btnClose.ShadowDecoration.Enabled = true;
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.TabIndex = 5;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gunaCirclePictureBox1
            // 
            this.gunaCirclePictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaCirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaCirclePictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaCirclePictureBox1.BackgroundImage")));
            this.gunaCirclePictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gunaCirclePictureBox1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaCirclePictureBox1.Location = new System.Drawing.Point(574, 60);
            this.gunaCirclePictureBox1.Name = "gunaCirclePictureBox1";
            this.gunaCirclePictureBox1.Size = new System.Drawing.Size(240, 240);
            this.gunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaCirclePictureBox1.TabIndex = 2;
            this.gunaCirclePictureBox1.TabStop = false;
            this.gunaCirclePictureBox1.UseTransfarantBackground = true;
            // 
            // tbPassword
            // 
            this.tbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPassword.BackColor = System.Drawing.Color.Transparent;
            this.tbPassword.BorderRadius = 12;
            this.tbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPassword.DefaultText = "";
            this.tbPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPassword.DisabledState.Parent = this.tbPassword;
            this.tbPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tbPassword.FocusedState.Parent = this.tbPassword;
            this.tbPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tbPassword.HoverState.Parent = this.tbPassword;
            this.tbPassword.IconLeft = global::Presentation_Layer.Properties.Resources._lock;
            this.tbPassword.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.tbPassword.IconLeftSize = new System.Drawing.Size(25, 25);
            this.tbPassword.Location = new System.Drawing.Point(544, 359);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.PlaceholderText = "Password";
            this.tbPassword.SelectedText = "";
            this.tbPassword.ShadowDecoration.BorderRadius = 21;
            this.tbPassword.ShadowDecoration.Parent = this.tbPassword;
            this.tbPassword.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.tbPassword.Size = new System.Drawing.Size(300, 44);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.TextOffset = new System.Drawing.Point(8, 0);
            // 
            // tbUsername
            // 
            this.tbUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUsername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbUsername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.tbUsername.BackColor = System.Drawing.Color.Transparent;
            this.tbUsername.BorderRadius = 12;
            this.tbUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbUsername.DefaultText = "";
            this.tbUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbUsername.DisabledState.Parent = this.tbUsername;
            this.tbUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tbUsername.FocusedState.Parent = this.tbUsername;
            this.tbUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tbUsername.HoverState.Parent = this.tbUsername;
            this.tbUsername.IconLeft = global::Presentation_Layer.Properties.Resources.user;
            this.tbUsername.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.tbUsername.IconLeftSize = new System.Drawing.Size(25, 25);
            this.tbUsername.Location = new System.Drawing.Point(544, 301);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.PasswordChar = '\0';
            this.tbUsername.PlaceholderText = "Username";
            this.tbUsername.SelectedText = "";
            this.tbUsername.ShadowDecoration.BorderRadius = 21;
            this.tbUsername.ShadowDecoration.Parent = this.tbUsername;
            this.tbUsername.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.tbUsername.Size = new System.Drawing.Size(300, 44);
            this.tbUsername.TabIndex = 0;
            this.tbUsername.TextOffset = new System.Drawing.Point(8, 0);
            // 
            // lbNoti
            // 
            this.lbNoti.BackColor = System.Drawing.Color.Transparent;
            this.lbNoti.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNoti.ForeColor = System.Drawing.Color.Red;
            this.lbNoti.Location = new System.Drawing.Point(544, 513);
            this.lbNoti.Name = "lbNoti";
            this.lbNoti.Size = new System.Drawing.Size(300, 50);
            this.lbNoti.TabIndex = 4;
            this.lbNoti.Text = "Sai tài khoản hoặc mật khẩu";
            this.lbNoti.Visible = false;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // timer
            // 
            this.timer.Interval = 300;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DragEndTransparencyValue = 0.95D;
            this.guna2DragControl1.TargetControl = this.pbBG;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.TargetControl = this.gunaCirclePictureBox1;
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmLogin";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox tbUsername;
        private Guna.UI2.WinForms.Guna2TextBox tbPassword;
        private Guna.UI2.WinForms.Guna2GradientButton btnLogin;
        private Guna.UI2.WinForms.Guna2DragControl DragForm;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2CheckBox checkBox;
        private System.Windows.Forms.Label lbNoti;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Timer timer;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pbBG;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.LinkLabel lbDB;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
    }
}

