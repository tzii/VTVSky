namespace Presentation_Layer.FormView
{
    partial class frmMain
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
            this.pnStatusBar = new System.Windows.Forms.Panel();
            this.lbNoti = new System.Windows.Forms.Label();
            this.pbNoti = new System.Windows.Forms.PictureBox();
            this.resizeControl = new Guna.UI2.WinForms.Guna2ResizeBox();
            this.pnControl = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSetting = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReports = new Guna.UI2.WinForms.Guna2Button();
            this.btnTickets = new Guna.UI2.WinForms.Guna2Button();
            this.btnFlights = new Guna.UI2.WinForms.Guna2Button();
            this.btnManager = new Guna.UI2.WinForms.Guna2Button();
            this.btnHome = new Guna.UI2.WinForms.Guna2Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnDrag = new System.Windows.Forms.Panel();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2Button();
            this.btnMaximize = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.pbChildForm = new System.Windows.Forms.PictureBox();
            this.lbChildForm = new Guna.UI.WinForms.GunaLabel();
            this.DragPanel = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.pnDesktop = new System.Windows.Forms.Panel();
            this.pnShadow = new System.Windows.Forms.Panel();
            this.pnShadow1 = new System.Windows.Forms.Panel();
            this.pnStatusBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNoti)).BeginInit();
            this.pnControl.SuspendLayout();
            this.pnDrag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbChildForm)).BeginInit();
            this.SuspendLayout();
            // 
            // pnStatusBar
            // 
            this.pnStatusBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(173)))), ((int)(((byte)(182)))));
            this.pnStatusBar.Controls.Add(this.lbNoti);
            this.pnStatusBar.Controls.Add(this.pbNoti);
            this.pnStatusBar.Controls.Add(this.resizeControl);
            this.pnStatusBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnStatusBar.Location = new System.Drawing.Point(0, 675);
            this.pnStatusBar.Name = "pnStatusBar";
            this.pnStatusBar.Size = new System.Drawing.Size(1300, 25);
            this.pnStatusBar.TabIndex = 0;
            // 
            // lbNoti
            // 
            this.lbNoti.AutoSize = true;
            this.lbNoti.Location = new System.Drawing.Point(36, 3);
            this.lbNoti.Name = "lbNoti";
            this.lbNoti.Size = new System.Drawing.Size(65, 28);
            this.lbNoti.TabIndex = 2;
            this.lbNoti.Text = "Ready";
            // 
            // pbNoti
            // 
            this.pbNoti.BackgroundImage = global::Presentation_Layer.Properties.Resources.Home;
            this.pbNoti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbNoti.Location = new System.Drawing.Point(0, 2);
            this.pbNoti.Name = "pbNoti";
            this.pbNoti.Size = new System.Drawing.Size(30, 20);
            this.pbNoti.TabIndex = 1;
            this.pbNoti.TabStop = false;
            // 
            // resizeControl
            // 
            this.resizeControl.BackColor = System.Drawing.Color.Transparent;
            this.resizeControl.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.resizeControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.resizeControl.FillColor = System.Drawing.Color.WhiteSmoke;
            this.resizeControl.ForeColor = System.Drawing.Color.Empty;
            this.resizeControl.Location = new System.Drawing.Point(1280, 0);
            this.resizeControl.Name = "resizeControl";
            this.resizeControl.Size = new System.Drawing.Size(20, 25);
            this.resizeControl.TabIndex = 0;
            this.resizeControl.TargetControl = this;
            // 
            // pnControl
            // 
            this.pnControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.pnControl.Controls.Add(this.panel2);
            this.pnControl.Controls.Add(this.btnSetting);
            this.pnControl.Controls.Add(this.panel1);
            this.pnControl.Controls.Add(this.btnReports);
            this.pnControl.Controls.Add(this.btnTickets);
            this.pnControl.Controls.Add(this.btnFlights);
            this.pnControl.Controls.Add(this.btnManager);
            this.pnControl.Controls.Add(this.btnHome);
            this.pnControl.Controls.Add(this.panel3);
            this.pnControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnControl.Location = new System.Drawing.Point(0, 0);
            this.pnControl.Name = "pnControl";
            this.pnControl.Size = new System.Drawing.Size(200, 675);
            this.pnControl.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.panel2.Location = new System.Drawing.Point(0, 207);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(8, 45);
            this.panel2.TabIndex = 8;
            // 
            // btnSetting
            // 
            this.btnSetting.CheckedState.Parent = this.btnSetting;
            this.btnSetting.CustomImages.Parent = this.btnSetting;
            this.btnSetting.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSetting.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.btnSetting.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.btnSetting.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(90)))), ((int)(((byte)(130)))));
            this.btnSetting.HoverState.Parent = this.btnSetting;
            this.btnSetting.Image = global::Presentation_Layer.Properties.Resources.Setting;
            this.btnSetting.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSetting.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnSetting.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSetting.Location = new System.Drawing.Point(0, 620);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(46)))));
            this.btnSetting.ShadowDecoration.Parent = this.btnSetting;
            this.btnSetting.Size = new System.Drawing.Size(200, 45);
            this.btnSetting.TabIndex = 5;
            this.btnSetting.TabStop = false;
            this.btnSetting.Text = "Settings";
            this.btnSetting.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSetting.TextOffset = new System.Drawing.Point(20, 0);
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 665);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 10);
            this.panel1.TabIndex = 7;
            // 
            // btnReports
            // 
            this.btnReports.CheckedState.Parent = this.btnReports;
            this.btnReports.CustomImages.Parent = this.btnReports;
            this.btnReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReports.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.btnReports.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.btnReports.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(90)))), ((int)(((byte)(130)))));
            this.btnReports.HoverState.Parent = this.btnReports;
            this.btnReports.Image = global::Presentation_Layer.Properties.Resources.Report;
            this.btnReports.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnReports.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnReports.ImageSize = new System.Drawing.Size(30, 30);
            this.btnReports.Location = new System.Drawing.Point(0, 387);
            this.btnReports.Name = "btnReports";
            this.btnReports.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(46)))));
            this.btnReports.ShadowDecoration.Parent = this.btnReports;
            this.btnReports.Size = new System.Drawing.Size(200, 45);
            this.btnReports.TabIndex = 6;
            this.btnReports.TabStop = false;
            this.btnReports.Text = "Reports";
            this.btnReports.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnReports.TextOffset = new System.Drawing.Point(20, 0);
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnTickets
            // 
            this.btnTickets.CheckedState.Parent = this.btnTickets;
            this.btnTickets.CustomImages.Parent = this.btnTickets;
            this.btnTickets.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTickets.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.btnTickets.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTickets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.btnTickets.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(90)))), ((int)(((byte)(130)))));
            this.btnTickets.HoverState.Parent = this.btnTickets;
            this.btnTickets.Image = global::Presentation_Layer.Properties.Resources.Ticket;
            this.btnTickets.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTickets.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnTickets.ImageSize = new System.Drawing.Size(30, 30);
            this.btnTickets.Location = new System.Drawing.Point(0, 342);
            this.btnTickets.Name = "btnTickets";
            this.btnTickets.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(46)))));
            this.btnTickets.ShadowDecoration.Parent = this.btnTickets;
            this.btnTickets.Size = new System.Drawing.Size(200, 45);
            this.btnTickets.TabIndex = 4;
            this.btnTickets.TabStop = false;
            this.btnTickets.Text = "Tickets";
            this.btnTickets.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTickets.TextOffset = new System.Drawing.Point(20, 0);
            this.btnTickets.Click += new System.EventHandler(this.btnTickets_Click);
            // 
            // btnFlights
            // 
            this.btnFlights.CheckedState.Parent = this.btnFlights;
            this.btnFlights.CustomImages.Parent = this.btnFlights;
            this.btnFlights.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFlights.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.btnFlights.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFlights.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.btnFlights.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(90)))), ((int)(((byte)(130)))));
            this.btnFlights.HoverState.Parent = this.btnFlights;
            this.btnFlights.Image = global::Presentation_Layer.Properties.Resources.Flight;
            this.btnFlights.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnFlights.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnFlights.ImageSize = new System.Drawing.Size(30, 30);
            this.btnFlights.Location = new System.Drawing.Point(0, 297);
            this.btnFlights.Name = "btnFlights";
            this.btnFlights.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(46)))));
            this.btnFlights.ShadowDecoration.Parent = this.btnFlights;
            this.btnFlights.Size = new System.Drawing.Size(200, 45);
            this.btnFlights.TabIndex = 3;
            this.btnFlights.TabStop = false;
            this.btnFlights.Text = "Flights";
            this.btnFlights.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnFlights.TextOffset = new System.Drawing.Point(20, 0);
            this.btnFlights.Click += new System.EventHandler(this.btnFlights_Click);
            // 
            // btnManager
            // 
            this.btnManager.CheckedState.Parent = this.btnManager;
            this.btnManager.CustomImages.Parent = this.btnManager;
            this.btnManager.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManager.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.btnManager.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManager.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.btnManager.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(90)))), ((int)(((byte)(130)))));
            this.btnManager.HoverState.Parent = this.btnManager;
            this.btnManager.Image = global::Presentation_Layer.Properties.Resources.Dashboard;
            this.btnManager.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnManager.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnManager.ImageSize = new System.Drawing.Size(30, 30);
            this.btnManager.Location = new System.Drawing.Point(0, 252);
            this.btnManager.Name = "btnManager";
            this.btnManager.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(46)))));
            this.btnManager.ShadowDecoration.Parent = this.btnManager;
            this.btnManager.Size = new System.Drawing.Size(200, 45);
            this.btnManager.TabIndex = 2;
            this.btnManager.TabStop = false;
            this.btnManager.Text = "Manager";
            this.btnManager.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnManager.TextOffset = new System.Drawing.Point(20, 0);
            this.btnManager.Click += new System.EventHandler(this.btnManager_Click);
            // 
            // btnHome
            // 
            this.btnHome.Checked = true;
            this.btnHome.CheckedState.Parent = this.btnHome;
            this.btnHome.CustomImages.Parent = this.btnHome;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(90)))), ((int)(((byte)(130)))));
            this.btnHome.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.btnHome.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(90)))), ((int)(((byte)(130)))));
            this.btnHome.HoverState.Parent = this.btnHome;
            this.btnHome.Image = global::Presentation_Layer.Properties.Resources.Home;
            this.btnHome.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnHome.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnHome.ImageSize = new System.Drawing.Size(30, 30);
            this.btnHome.Location = new System.Drawing.Point(0, 207);
            this.btnHome.Name = "btnHome";
            this.btnHome.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(46)))));
            this.btnHome.ShadowDecoration.Parent = this.btnHome;
            this.btnHome.Size = new System.Drawing.Size(200, 45);
            this.btnHome.TabIndex = 1;
            this.btnHome.TabStop = false;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHome.TextOffset = new System.Drawing.Point(20, 0);
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 207);
            this.panel3.TabIndex = 0;
            // 
            // pnDrag
            // 
            this.pnDrag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.pnDrag.Controls.Add(this.btnMinimize);
            this.pnDrag.Controls.Add(this.btnMaximize);
            this.pnDrag.Controls.Add(this.btnClose);
            this.pnDrag.Controls.Add(this.pbChildForm);
            this.pnDrag.Controls.Add(this.lbChildForm);
            this.pnDrag.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnDrag.Location = new System.Drawing.Point(200, 0);
            this.pnDrag.Name = "pnDrag";
            this.pnDrag.Size = new System.Drawing.Size(1100, 60);
            this.pnDrag.TabIndex = 2;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.Animated = true;
            this.btnMinimize.AutoRoundedCorners = true;
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.BorderRadius = 14;
            this.btnMinimize.CheckedState.Parent = this.btnMinimize;
            this.btnMinimize.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnMinimize.CustomImages.Parent = this.btnMinimize;
            this.btnMinimize.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.HoverState.Parent = this.btnMinimize;
            this.btnMinimize.Location = new System.Drawing.Point(995, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.ShadowDecoration.BorderRadius = 19;
            this.btnMinimize.ShadowDecoration.Enabled = true;
            this.btnMinimize.ShadowDecoration.Parent = this.btnMinimize;
            this.btnMinimize.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.Animated = true;
            this.btnMaximize.AutoRoundedCorners = true;
            this.btnMaximize.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximize.BorderRadius = 14;
            this.btnMaximize.CheckedState.Parent = this.btnMaximize;
            this.btnMaximize.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnMaximize.CustomImages.Parent = this.btnMaximize;
            this.btnMaximize.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnMaximize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMaximize.ForeColor = System.Drawing.Color.White;
            this.btnMaximize.HoverState.Parent = this.btnMaximize;
            this.btnMaximize.Location = new System.Drawing.Point(1031, 3);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.ShadowDecoration.BorderRadius = 19;
            this.btnMaximize.ShadowDecoration.Enabled = true;
            this.btnMaximize.ShadowDecoration.Parent = this.btnMaximize;
            this.btnMaximize.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.btnMaximize.Size = new System.Drawing.Size(30, 30);
            this.btnMaximize.TabIndex = 4;
            this.btnMaximize.TabStop = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Animated = true;
            this.btnClose.AutoRoundedCorners = true;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BorderRadius = 14;
            this.btnClose.CheckedState.Parent = this.btnClose;
            this.btnClose.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnClose.CustomImages.Parent = this.btnClose;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.HoverState.FillColor = System.Drawing.Color.Firebrick;
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.Location = new System.Drawing.Point(1067, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.BorderRadius = 19;
            this.btnClose.ShadowDecoration.Enabled = true;
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 4;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pbChildForm
            // 
            this.pbChildForm.BackgroundImage = global::Presentation_Layer.Properties.Resources.Home;
            this.pbChildForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbChildForm.Location = new System.Drawing.Point(16, 10);
            this.pbChildForm.Name = "pbChildForm";
            this.pbChildForm.Size = new System.Drawing.Size(40, 40);
            this.pbChildForm.TabIndex = 3;
            this.pbChildForm.TabStop = false;
            // 
            // lbChildForm
            // 
            this.lbChildForm.AutoSize = true;
            this.lbChildForm.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.lbChildForm.Location = new System.Drawing.Point(57, 20);
            this.lbChildForm.Name = "lbChildForm";
            this.lbChildForm.Size = new System.Drawing.Size(96, 38);
            this.lbChildForm.TabIndex = 2;
            this.lbChildForm.Text = "Home";
            // 
            // DragPanel
            // 
            this.DragPanel.TargetControl = this.pnDrag;
            this.DragPanel.UseTransparentDrag = true;
            // 
            // pnDesktop
            // 
            this.pnDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.pnDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDesktop.Location = new System.Drawing.Point(200, 60);
            this.pnDesktop.Name = "pnDesktop";
            this.pnDesktop.Size = new System.Drawing.Size(1100, 615);
            this.pnDesktop.TabIndex = 3;
            // 
            // pnShadow
            // 
            this.pnShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnShadow.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnShadow.Location = new System.Drawing.Point(200, 60);
            this.pnShadow.Name = "pnShadow";
            this.pnShadow.Size = new System.Drawing.Size(3, 615);
            this.pnShadow.TabIndex = 0;
            // 
            // pnShadow1
            // 
            this.pnShadow1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnShadow1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnShadow1.Location = new System.Drawing.Point(203, 60);
            this.pnShadow1.Name = "pnShadow1";
            this.pnShadow1.Size = new System.Drawing.Size(1097, 3);
            this.pnShadow1.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.pnShadow1);
            this.Controls.Add(this.pnShadow);
            this.Controls.Add(this.pnDesktop);
            this.Controls.Add(this.pnDrag);
            this.Controls.Add(this.pnControl);
            this.Controls.Add(this.pnStatusBar);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "v";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnStatusBar.ResumeLayout(false);
            this.pnStatusBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNoti)).EndInit();
            this.pnControl.ResumeLayout(false);
            this.pnDrag.ResumeLayout(false);
            this.pnDrag.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbChildForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnStatusBar;
        private System.Windows.Forms.Panel pnControl;
        private System.Windows.Forms.Panel pnDrag;
        private Guna.UI2.WinForms.Guna2DragControl DragPanel;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Button btnHome;
        private Guna.UI2.WinForms.Guna2Button btnTickets;
        private Guna.UI2.WinForms.Guna2Button btnFlights;
        private Guna.UI2.WinForms.Guna2Button btnManager;
        private Guna.UI2.WinForms.Guna2Button btnSetting;
        private Guna.UI2.WinForms.Guna2Button btnReports;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbChildForm;
        private Guna.UI.WinForms.GunaLabel lbChildForm;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnMinimize;
        private Guna.UI2.WinForms.Guna2Button btnMaximize;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2ResizeBox resizeControl;
        private System.Windows.Forms.Panel pnDesktop;
        private System.Windows.Forms.Panel pnShadow;
        private System.Windows.Forms.Panel pnShadow1;
        public System.Windows.Forms.PictureBox pbNoti;
        public System.Windows.Forms.Label lbNoti;
    }
}