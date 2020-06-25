using Business_Logic_Layer;
using Data_Transfer_Objects;
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
        public PhieuDatCho PDC
        {
            set
            {
                PDC = value;
            }
            get
            {
                if (PDC != null) return PDC;
                

                TuyenBay tb = new TuyenBay();
                return new PhieuDatCho();

            }
        }
        public frmPhieuDatChoEditing()
        {
            InitializeComponent();
        }

        private void frmPhieuDatChoEditing_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            cbMaCB.DataSource = BLL_ChuyenBay.GetChuyenBays();
            cbMaCB.DisplayMember = "strMaCB";
            cbMaCB.ValueMember = "MaCB";

            cbHangVe.DataSource = BLL_HangVe.GetHangVes();
            cbHangVe.DisplayMember = "TenHV";
            cbHangVe.ValueMember = "MaHV";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            button1.PerformClick();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            button2.PerformClick();
        }
    }
}
