using Business_Logic_Layer;
using Data_Transfer_Objects;
using Guna.UI2.WinForms.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation_Layer.FormDigital
{
    public partial class frmFlightEditing : Form
    {
        public ChuyenBay cb
        {
            set
            {
                cb = value;
            }
            get
            {
                TuyenBay tb = new TuyenBay();
                int donGia = Convert.ToInt32(nGiaVe.Value);
                DateTime tg = dtpNgay.Value.Date + dtpGio.Value.TimeOfDay;
                int tl = Convert.ToInt32(nTGBayH.Value * 60 + nTGBayM.Value);
                int sg = Convert.ToInt32(nSLGhe1.Value + nSLGhe2.Value);
                return new ChuyenBay(0, tb, donGia, tg, tl, sg, 0);
            }
        }
        public List<CTCB> ctcbs
        {
            set
            {
                ctcbs = value;
            }
            get
            {
                if (ctcbs != null) return ctcbs;
                List<CTCB> res = new List<CTCB>();
                for (int i = 0; i < dgvCTCB.RowCount; i++)
                {
                    CTCB x = new CTCB(0, BLL_SanBay.GetSanBay((int)dgvCTCB.Rows[i].Cells["MaSB"].Value), (int)nTGDung.Value, tbGhiChu.Text);
                    res.Add(x);
                }
                return res;
            }
        }
        public List<CTHV> cthvs
        {
            set
            {
                cthvs = value;
            }
            get
            {
                if (cthvs != null) return cthvs;
                List<HangVe> hv = BLL_HangVe.GetHangVes();
                List<CTHV> res = new List<CTHV>();
                CTHV i = new CTHV(0, hv[0], Convert.ToInt32(cb.DonGia * hv[0].TiLe), (int)nSLGhe1.Value, (int)nSLGhe1.Value, 0);
                res.Add(i);
                i = new CTHV(0, hv[1], Convert.ToInt32(cb.DonGia * hv[1].TiLe), (int)nSLGhe2.Value, (int)nSLGhe2.Value, 0);
                res.Add(i);
                return res;
            }
        }
        private DataGridViewScrollHelper scrollHelper;
        public frmFlightEditing()
        {
            InitializeComponent();
            dgvCTCB.Columns["STT"].Width = 50;
            dgvCTCB.Columns["TGDung"].Width = 200;
            dgvCTCB.Columns["SBTG"].Width = 200;
            dgvCTCB.Columns["Edit"].Width = 50;
        }

        private void frmFlightEditing_Load(object sender, EventArgs e)
        {
            scrollHelper = new DataGridViewScrollHelper(dgvCTCB, sb, true);
            guna2ShadowForm1.SetShadowForm(this);
            scrollHelper.UpdateScrollBar();
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
