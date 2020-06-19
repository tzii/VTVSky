using Guna.UI2.WinForms;
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
    public partial class frmTickets : Form
    {
        private Guna2Button currentBtn;
        private Form currentChildForm;
        public frmTickets()
        {
            InitializeComponent();
        }

        #region Other Functions
        private void ActivateButton(object senderBtn)
        {
            if (senderBtn == null) return;
            DisableButton();

            currentBtn = (Guna2Button)senderBtn;

            //Active current button
            currentBtn.FillColor = Color.FromArgb(96, 141, 188);
            currentBtn.Checked = true;
        }
        private void DisableButton()
        {
            if (currentBtn == null) return;
            currentBtn.Checked = false;
            currentBtn.FillColor = Color.FromArgb(170, 178, 185);
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

        #region Tab control
        private void btnBookTicket_Click(object sender, EventArgs e)
        {
            var btn = (Guna2Button)sender;
            if (btn.Checked == true) return;
            ActivateButton(sender);
            ShowChildForm(new frmBookTicket());
        }

        private void btnBuyTicket_Click(object sender, EventArgs e)
        {
            var btn = (Guna2Button)sender;
            if (btn.Checked == true) return;
            ActivateButton(sender);
            ShowChildForm(new frmBuyTicket());
        }
        #endregion

        private void frmTickets_Load(object sender, EventArgs e)
        {
            ShowChildForm(new frmBookTicket());
        }
    }
}
