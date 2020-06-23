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
    public partial class frmPhieuDatChoEditing : Form
    {
        public frmPhieuDatChoEditing()
        {
            InitializeComponent();
        }

        private void frmPhieuDatChoEditing_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
