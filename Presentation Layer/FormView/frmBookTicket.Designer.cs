namespace Presentation_Layer.FormView
{
    partial class frmBookTicket
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            Guna.UI2.AnimatorNS.Animation animation2 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBookTicket));
            this.dgvBuyTicket = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cmt = new Guna.UI.WinForms.GunaContextMenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.saleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnContain = new Guna.UI2.WinForms.Guna2Panel();
            this.pnView = new System.Windows.Forms.Panel();
            this.pnScroll = new System.Windows.Forms.Panel();
            this.pnSearch = new System.Windows.Forms.Panel();
            this.cbSearch = new Guna.UI2.WinForms.Guna2ComboBox();
            this.tbSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.sb = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.pnSrcollBar = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuyTicket)).BeginInit();
            this.cmt.SuspendLayout();
            this.pnContain.SuspendLayout();
            this.pnView.SuspendLayout();
            this.pnScroll.SuspendLayout();
            this.pnSearch.SuspendLayout();
            this.pnSrcollBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBuyTicket
            // 
            this.dgvBuyTicket.AllowUserToAddRows = false;
            this.dgvBuyTicket.AllowUserToDeleteRows = false;
            this.dgvBuyTicket.AllowUserToResizeColumns = false;
            this.dgvBuyTicket.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            this.dgvBuyTicket.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBuyTicket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBuyTicket.BackgroundColor = System.Drawing.Color.White;
            this.dgvBuyTicket.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBuyTicket.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBuyTicket.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBuyTicket.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvBuyTicket.ColumnHeadersHeight = 60;
            this.dgvBuyTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBuyTicket.ContextMenuStrip = this.cmt;
            this.guna2Transition1.SetDecoration(this.dgvBuyTicket, Guna.UI2.AnimatorNS.DecorationType.None);
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBuyTicket.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvBuyTicket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBuyTicket.EnableHeadersVisualStyles = false;
            this.dgvBuyTicket.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.dgvBuyTicket.Location = new System.Drawing.Point(0, 0);
            this.dgvBuyTicket.Margin = new System.Windows.Forms.Padding(3, 3, 3, 200);
            this.dgvBuyTicket.MultiSelect = false;
            this.dgvBuyTicket.Name = "dgvBuyTicket";
            this.dgvBuyTicket.ReadOnly = true;
            this.dgvBuyTicket.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvBuyTicket.RowHeadersVisible = false;
            this.dgvBuyTicket.RowHeadersWidth = 51;
            this.dgvBuyTicket.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvBuyTicket.RowTemplate.Height = 24;
            this.dgvBuyTicket.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBuyTicket.ShowCellToolTips = false;
            this.dgvBuyTicket.Size = new System.Drawing.Size(1048, 60);
            this.dgvBuyTicket.TabIndex = 2;
            this.dgvBuyTicket.TabStop = false;
            this.dgvBuyTicket.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.GreenSea;
            this.dgvBuyTicket.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            this.dgvBuyTicket.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvBuyTicket.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvBuyTicket.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvBuyTicket.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvBuyTicket.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvBuyTicket.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.dgvBuyTicket.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.dgvBuyTicket.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvBuyTicket.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBuyTicket.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvBuyTicket.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBuyTicket.ThemeStyle.HeaderStyle.Height = 60;
            this.dgvBuyTicket.ThemeStyle.ReadOnly = true;
            this.dgvBuyTicket.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            this.dgvBuyTicket.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBuyTicket.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBuyTicket.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvBuyTicket.ThemeStyle.RowsStyle.Height = 24;
            this.dgvBuyTicket.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            this.dgvBuyTicket.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvBuyTicket.DataSourceChanged += new System.EventHandler(this.dgvFlightsList_DataSourceChanged);
            this.dgvBuyTicket.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvFlights_CellMouseDown);
            this.dgvBuyTicket.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFlightsList_CellMouseEnter);
            this.dgvBuyTicket.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFlightsList_CellMouseLeave);
            // 
            // cmt
            // 
            this.guna2Transition1.SetDecoration(this.cmt, Guna.UI2.AnimatorNS.DecorationType.None);
            this.cmt.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmt.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.refreshToolStripMenuItem,
            this.toolStripMenuItem4,
            this.editToolStripMenuItem,
            this.editToolStripMenuItem1,
            this.toolStripMenuItem3,
            this.saleToolStripMenuItem,
            this.cancelToolStripMenuItem});
            this.cmt.Name = "cmt";
            this.cmt.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.cmt.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.cmt.RenderStyle.ColorTable = null;
            this.cmt.RenderStyle.RoundedEdges = true;
            this.cmt.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.cmt.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmt.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.cmt.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.cmt.RenderStyle.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            this.cmt.Size = new System.Drawing.Size(166, 166);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(165, 24);
            this.toolStripMenuItem1.Text = "Create New";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(162, 6);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(162, 6);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.editToolStripMenuItem.Text = "Sale";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(165, 24);
            this.editToolStripMenuItem1.Text = "Cancel Ticket";
            this.editToolStripMenuItem1.Click += new System.EventHandler(this.editToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(162, 6);
            // 
            // saleToolStripMenuItem
            // 
            this.saleToolStripMenuItem.Name = "saleToolStripMenuItem";
            this.saleToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.saleToolStripMenuItem.Text = "Detail";
            this.saleToolStripMenuItem.Click += new System.EventHandler(this.saleToolStripMenuItem_Click);
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.cancelToolStripMenuItem.Text = "Edit";
            this.cancelToolStripMenuItem.Click += new System.EventHandler(this.cancelToolStripMenuItem_Click);
            // 
            // pnContain
            // 
            this.pnContain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnContain.BackColor = System.Drawing.Color.Transparent;
            this.pnContain.BorderRadius = 20;
            this.pnContain.Controls.Add(this.dgvBuyTicket);
            this.guna2Transition1.SetDecoration(this.pnContain, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnContain.Location = new System.Drawing.Point(0, 0);
            this.pnContain.Name = "pnContain";
            this.pnContain.ShadowDecoration.BorderRadius = 20;
            this.pnContain.ShadowDecoration.Enabled = true;
            this.pnContain.ShadowDecoration.Parent = this.pnContain;
            this.pnContain.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 7, 7);
            this.pnContain.Size = new System.Drawing.Size(1048, 60);
            this.pnContain.TabIndex = 3;
            // 
            // pnView
            // 
            this.pnView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnView.Controls.Add(this.pnContain);
            this.guna2Transition1.SetDecoration(this.pnView, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnView.Location = new System.Drawing.Point(23, 100);
            this.pnView.Name = "pnView";
            this.pnView.Size = new System.Drawing.Size(1055, 110);
            this.pnView.TabIndex = 4;
            // 
            // pnScroll
            // 
            this.pnScroll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnScroll.Controls.Add(this.pnView);
            this.pnScroll.Controls.Add(this.pnSearch);
            this.guna2Transition1.SetDecoration(this.pnScroll, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnScroll.Location = new System.Drawing.Point(0, 0);
            this.pnScroll.Name = "pnScroll";
            this.pnScroll.Size = new System.Drawing.Size(1100, 570);
            this.pnScroll.TabIndex = 3;
            this.pnScroll.Resize += new System.EventHandler(this.pnScroll_Resize);
            // 
            // pnSearch
            // 
            this.pnSearch.Controls.Add(this.cbSearch);
            this.pnSearch.Controls.Add(this.tbSearch);
            this.pnSearch.Controls.Add(this.btnSearch);
            this.guna2Transition1.SetDecoration(this.pnSearch, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSearch.Location = new System.Drawing.Point(0, 0);
            this.pnSearch.Name = "pnSearch";
            this.pnSearch.Size = new System.Drawing.Size(1100, 100);
            this.pnSearch.TabIndex = 5;
            // 
            // cbSearch
            // 
            this.cbSearch.BackColor = System.Drawing.Color.Transparent;
            this.cbSearch.BorderRadius = 6;
            this.guna2Transition1.SetDecoration(this.cbSearch, Guna.UI2.AnimatorNS.DecorationType.None);
            this.cbSearch.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearch.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSearch.FocusedState.Parent = this.cbSearch;
            this.cbSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbSearch.HoverState.Parent = this.cbSearch;
            this.cbSearch.ItemHeight = 30;
            this.cbSearch.ItemsAppearance.Parent = this.cbSearch;
            this.cbSearch.Location = new System.Drawing.Point(456, 38);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.ShadowDecoration.Enabled = true;
            this.cbSearch.ShadowDecoration.Parent = this.cbSearch;
            this.cbSearch.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.cbSearch.Size = new System.Drawing.Size(286, 36);
            this.cbSearch.TabIndex = 22;
            // 
            // tbSearch
            // 
            this.tbSearch.BackColor = System.Drawing.Color.Transparent;
            this.tbSearch.BorderRadius = 6;
            this.tbSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.tbSearch, Guna.UI2.AnimatorNS.DecorationType.None);
            this.tbSearch.DefaultText = "";
            this.tbSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearch.DisabledState.Parent = this.tbSearch;
            this.tbSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSearch.FocusedState.Parent = this.tbSearch;
            this.tbSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSearch.HoverState.Parent = this.tbSearch;
            this.tbSearch.Location = new System.Drawing.Point(23, 38);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.PasswordChar = '\0';
            this.tbSearch.PlaceholderText = "";
            this.tbSearch.SelectedText = "";
            this.tbSearch.ShadowDecoration.Enabled = true;
            this.tbSearch.ShadowDecoration.Parent = this.tbSearch;
            this.tbSearch.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.tbSearch.Size = new System.Drawing.Size(424, 36);
            this.tbSearch.TabIndex = 21;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BorderRadius = 6;
            this.btnSearch.CheckedState.Parent = this.btnSearch;
            this.btnSearch.CustomImages.Parent = this.btnSearch;
            this.guna2Transition1.SetDecoration(this.btnSearch, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.HoverState.Parent = this.btnSearch;
            this.btnSearch.Location = new System.Drawing.Point(753, 38);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ShadowDecoration.Enabled = true;
            this.btnSearch.ShadowDecoration.Parent = this.btnSearch;
            this.btnSearch.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.btnSearch.Size = new System.Drawing.Size(126, 36);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // sb
            // 
            this.sb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sb.AutoRoundedCorners = true;
            this.sb.BorderRadius = 8;
            this.guna2Transition1.SetDecoration(this.sb, Guna.UI2.AnimatorNS.DecorationType.None);
            this.sb.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.sb.HoverState.Parent = null;
            this.sb.LargeChange = 10;
            this.sb.Location = new System.Drawing.Point(1, 0);
            this.sb.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.sb.MouseWheelBarPartitions = 10;
            this.sb.Name = "sb";
            this.sb.PressedState.Parent = this.sb;
            this.sb.ScrollbarSize = 18;
            this.sb.Size = new System.Drawing.Size(18, 544);
            this.sb.TabIndex = 5;
            this.sb.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            // 
            // pnSrcollBar
            // 
            this.pnSrcollBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnSrcollBar.Controls.Add(this.sb);
            this.guna2Transition1.SetDecoration(this.pnSrcollBar, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnSrcollBar.Location = new System.Drawing.Point(1080, 0);
            this.pnSrcollBar.Name = "pnSrcollBar";
            this.pnSrcollBar.Size = new System.Drawing.Size(20, 570);
            this.pnSrcollBar.TabIndex = 5;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this.dgvBuyTicket;
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.guna2Transition1.DefaultAnimation = animation2;
            // 
            // frmBookTicket
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1100, 570);
            this.Controls.Add(this.pnSrcollBar);
            this.Controls.Add(this.pnScroll);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmBookTicket";
            this.Text = "frmHome";
            this.Load += new System.EventHandler(this.frmBookTicket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuyTicket)).EndInit();
            this.cmt.ResumeLayout(false);
            this.pnContain.ResumeLayout(false);
            this.pnView.ResumeLayout(false);
            this.pnScroll.ResumeLayout(false);
            this.pnSearch.ResumeLayout(false);
            this.pnSrcollBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvBuyTicket;
        private Guna.UI2.WinForms.Guna2Panel pnContain;
        private System.Windows.Forms.Panel pnView;
        private System.Windows.Forms.Panel pnScroll;
        private Guna.UI2.WinForms.Guna2VScrollBar sb;
        private System.Windows.Forms.Panel pnSrcollBar;
        private Guna.UI.WinForms.GunaContextMenuStrip cmt;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private System.Windows.Forms.Panel pnSearch;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2ComboBox cbSearch;
        private Guna.UI2.WinForms.Guna2TextBox tbSearch;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem saleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
    }
}