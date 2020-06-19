using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation_Layer.FormDigital
{
    public partial class frmSuccess : Form
    {
        public frmSuccess()
        {
            InitializeComponent();
        }
        public frmSuccess(string _title, string _message)
        {
            lbTitle.Text = _title;
            lbMessage.Text = _message;
        }
        private void frmWarning_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            button1.PerformClick();
        }
    }
}
