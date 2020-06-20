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
    public partial class frmReports : Form
    {
        private Guna2Button currentBtn;
        private CustomForm currentChildForm;
        private CustomForm formBCThang;
        private CustomForm formBCNam;
        public frmReports()
        {
            InitializeComponent();
        }

        private void frmReports_Load(object sender, EventArgs e)
        {
            formBCThang = new frmBCThang();
            formBCNam = new frmBCNam();

            formBCThang.TopLevel = false;
            formBCThang.Dock = DockStyle.Fill;
            pnDesktop.Controls.Add(formBCThang);

            formBCNam.TopLevel = false;
            formBCNam.Dock = DockStyle.Fill;
            pnDesktop.Controls.Add(formBCNam);


            ActivateButton(btnBCThang);
            ShowChildForm(formBCThang);
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
        private void btnBCThang_Click(object sender, EventArgs e)
        {
            var btn = (Guna2Button)sender;
            if (btn.Checked == true) return;
            ActivateButton(sender);
            ShowChildForm(formBCNam);
        }

        private void btnBCNam_Click(object sender, EventArgs e)
        {
            var btn = (Guna2Button)sender;
            if (btn.Checked == true) return;
            ActivateButton(sender);
            ShowChildForm(formBCThang);
        }
        #endregion

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            currentChildForm.RefreshData();
        }


    }
}
