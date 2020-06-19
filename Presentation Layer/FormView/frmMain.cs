using Data_Transfer_Objects;
using Guna.UI2.HtmlRenderer.Core;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation_Layer.FormView
{
    public partial class frmMain : Form
    {
        private Guna2Button currentButton;
        private Form currentChildForm;

        public frmMain()
        {
            InitializeComponent();
            //this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            Control.CheckForIllegalCrossThreadCalls = false;

        }
        #region Custom Control Box
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
                resizeControl.Hide();
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
                resizeControl.Show();
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion
        #region Button Control
        private void btnHome_Click(object sender, EventArgs e)
        {
            var btn = (Guna2Button)sender;
            if (btn.Checked == true) return;
            ActivateButton(sender);
            ShowChildForm(new frmHome());
        }

        private void btnManager_Click(object sender, EventArgs e)
        {
            Notification.Show("check Manager");
            var btn = (Guna2Button)sender;
            if (btn.Checked == true) return;
            ActivateButton(sender);
            ShowChildForm(new frmManager());
        }

        private void btnFlights_Click(object sender, EventArgs e)
        {
            var btn = (Guna2Button)sender;
            if (btn.Checked == true) return;
            ActivateButton(sender);
            ShowChildForm(new frmFlights());
        }

        private void btnTickets_Click(object sender, EventArgs e)
        {
            var btn = (Guna2Button)sender;
            if (btn.Checked == true) return;
            ActivateButton(sender);
            ShowChildForm(new frmTickets());
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            var btn = (Guna2Button)sender;
            if (btn.Checked == true) return;
            ActivateButton(sender);
            ShowChildForm(new frmReports());
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            var btn = (Guna2Button)sender;
            if (btn.Checked == true) return;
            ActivateButton(sender);
            ShowChildForm(new frmSettings());
        }
        #endregion
        #region Custom shadow in boderless
        private const int CS_dropShadow = 0x00020000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle = CS_dropShadow;
                return cp;
            }
        }
        #endregion
        #region Other Functions
        private void ActivateButton(object senderBtn)
        {
            if (senderBtn == null) return;
            DisableButton();
            
            currentButton = (Guna2Button)senderBtn;
            
            //Active current button
            currentButton.FillColor = Color.FromArgb(73, 90, 130);
            panel2.Location = currentButton.Location;
            currentButton.ImageAlign = HorizontalAlignment.Right;
            currentButton.Checked = true;
            //Change icon current child form
            pbChildForm.BackgroundImage = currentButton.Image;
            lbChildForm.Text = currentButton.Text;
        }
        private void DisableButton()
        {
            if (currentButton == null) return;
            currentButton.Checked = false;
            currentButton.FillColor = Color.FromArgb(44, 54, 79);
            currentButton.ImageAlign = HorizontalAlignment.Left;
        }
        private void ShowChildForm(Form senderForm)
        {
            if (senderForm == null) return;
            HideChildForm();
            currentChildForm = senderForm;
            currentChildForm.TopLevel = false;
            currentChildForm.Dock = DockStyle.Fill;
            pnDesktop.Controls.Add(currentChildForm);
            currentChildForm.BringToFront();
            currentChildForm.Show();
        }
        private void HideChildForm()
        {
            if (currentChildForm == null) return;
            currentChildForm.Close();
        }
        #endregion

        private void frmMain_Load(object sender, EventArgs e)
        {
            Notification.lbNoti = lbNoti;
            //Notification.Show("123");

            ActivateButton(btnHome);
            ShowChildForm(new frmHome());
        }

    }
}
