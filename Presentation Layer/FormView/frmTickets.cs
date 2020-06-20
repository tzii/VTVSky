using Data_Transfer_Objects;
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
        private CustomForm currentChildForm;
        private CustomForm formBookTicket;
        private CustomForm formBuyTicket;
        public frmTickets()
        {
            InitializeComponent();
        }

        private void frmTickets_Load(object sender, EventArgs e)
        {
            formBookTicket = new frmBookTicket();
            formBuyTicket = new frmBuyTicket();

            formBookTicket.TopLevel = false;
            formBookTicket.Dock = DockStyle.Fill;
            pnDesktop.Controls.Add(formBookTicket);

            formBuyTicket.TopLevel = false;
            formBuyTicket.Dock = DockStyle.Fill;
            pnDesktop.Controls.Add(formBuyTicket);


            ActivateButton(btnDatVe);
            ShowChildForm(formBookTicket);
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
            currentBtn.ShadowDecoration.Enabled = true;
        }
        private void DisableButton()
        {
            if (currentBtn == null) return;
            currentBtn.Checked = false;
            currentBtn.FillColor = Color.FromArgb(170, 178, 185);
            currentBtn.ShadowDecoration.Enabled = false;
        }
        private void ShowChildForm(Form senderForm)
        {
            if (senderForm == null) return;
            HideChildForm();
            currentChildForm = senderForm as CustomForm;
            currentChildForm.BringToFront();
            currentChildForm.Show();
        }
        private void HideChildForm()
        {
            if (currentChildForm == null) return;
            currentChildForm.Hide();
        }
        #endregion

        #region Tab control
        private void btnBanVe_Click(object sender, EventArgs e)
        {
            var btn = (Guna2Button)sender;
            if (btn.Checked == true) return;
            ActivateButton(sender);
            ShowChildForm(formBuyTicket);
        }

        private void btnDatVe_Click(object sender, EventArgs e)
        {
            var btn = (Guna2Button)sender;
            if (btn.Checked == true) return;
            ActivateButton(sender);
            ShowChildForm(formBookTicket);
        }
        #endregion

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            currentChildForm.RefreshData();
        }

        
    }
}
