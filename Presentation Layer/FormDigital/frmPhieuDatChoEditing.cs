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
        private List<ChuyenBay> chuyenBays = BLL_ChuyenBay.GetChuyenBays();
        private List<HangVe> hangVes = BLL_HangVe.GetHangVes();
        public PhieuDatCho pdc;
        private void Loadcb()
        {
            chuyenBays = BLL_ChuyenBay.GetChuyenBays();
            hangVes = BLL_HangVe.GetHangVes();

            cbMaCB.DataSource = chuyenBays;
            cbMaCB.DisplayMember = "strMaCB";
            cbMaCB.ValueMember = "MaCB";

            cbHangVe.DataSource = hangVes;
            cbHangVe.DisplayMember = "TenHV";
            cbHangVe.ValueMember = "MaHV";
        }
        private void checkState()
        {
            if (AppState.state == Actions.EDIT|| AppState.state == Actions.ADD)
            {
                cbMaCB.Enabled = true;
                tbTenHK.Enabled = true;
                cbHangVe.Enabled = true;
                tbCMND.Enabled = true;
                tbDienThoai.Enabled = true;
            }
            else
            {

                cbMaCB.Enabled = false;
                tbTenHK.Enabled = false;
                cbHangVe.Enabled = false;
                tbCMND.Enabled = false;
                tbDienThoai.Enabled = false;
            }
        }
        public frmPhieuDatChoEditing()
        {
            InitializeComponent();
            pdc = new PhieuDatCho();
            Loadcb();
            checkState();
            PanelTT();
        }
        public frmPhieuDatChoEditing(PhieuDatCho x)
        {
            InitializeComponent();
            pdc = x;
            Loadcb();
            checkState();
            PanelTT();
            tbMaVe.Text = pdc.strMaVe;
            cbMaCB.SelectedValue = pdc.maCB;
            tbGiaVe.Text = pdc.GiaVe.ToString("###,###,### VND");
            tbNgayGio.Text = pdc.ThoiGian.ToString("hh:mm tt dd/MM/yyyy");
            tbTenHK.Text = pdc.TenHK;
            cbHangVe.SelectedValue = pdc.HV.maHV;
            tbCMND.Text = pdc.CMND;
            tbDienThoai.Text = pdc.DienThoai;

            if (pdc.tinhTrang == 1) rbDat.Checked = true;
            else if (pdc.tinhTrang == 2) rbDaBan.Checked = true;
            else if (pdc.tinhTrang == 3) rbDaHuy.Checked = true;
            
        }
        private void frmPhieuDatChoEditing_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!BLL_ChuyenBay.CheckGhe((int)cbMaCB.SelectedValue))
            {
                lbNoti.Text = "Chuyến bay này đã hết ghế";
                lbNoti.Show();
                return;
            }
            if (!BLL_CTHV.CheckGhe((int)cbMaCB.SelectedValue,(int)cbHangVe.SelectedValue))
            {
                lbNoti.Text = "Hạng vé này đã hết ghế";
                lbNoti.Show();
                return;
            }
            if ((((ChuyenBay)cbMaCB.SelectedItem).ThoiGian - DateTime.Now).Days < ThamSo.TGDatVeChamNhat)
            {
                lbNoti.Text = "Chỉ được đặt vé chậm nhất trước "+ThamSo.TGDatVeChamNhat+" ngày trước ngày xuất phát";
                lbNoti.Show();
                return;
            }
            if (tbTenHK.Text == "")
            {
                lbNoti.Text = "Tên khách hàng không được bỏ trống";
                lbNoti.Show();
                return;
            }
            if (tbCMND.Text == "")
            {
                lbNoti.Text = "CMND không được bỏ trống";
                lbNoti.Show();
                return;
            }
            if (tbDienThoai.Text == "")
            {
                lbNoti.Text = "Điện thoại không được bỏ trống";
                lbNoti.Show();
                return;
            }

            pdc.maCB = (int)cbMaCB.SelectedValue;
            pdc.GiaVe = Convert.ToInt32(((ChuyenBay)cbMaCB.SelectedItem).DonGia * ((HangVe)cbHangVe.SelectedItem).TiLe);
            pdc.ThoiGian = DateTime.ParseExact(tbNgayGio.Text, "hh:mm tt dd/MM/yyyy", null);
            pdc.TenHK = tbTenHK.Text;
            pdc.HV = cbHangVe.SelectedItem as HangVe;
            pdc.CMND = tbCMND.Text;
            pdc.DienThoai=tbDienThoai.Text;

            if (rbDat.Checked) pdc.tinhTrang = 1;
            else if (rbDaBan.Checked)
            {
                pdc.tinhTrang = 2;
                var dialog = new frmWarning("Cảnh Báo!!!", "Bạn có muốn bán vé không?");
                var res = dialog.ShowDialog();
                if (res == DialogResult.OK)
                {
                    BLL_PhieuDatCho.SalePhieuDatCho(pdc);
                }
                else if (res == DialogResult.Cancel) return;
            }
            else if (rbDaHuy.Checked) 
            { 
                pdc.tinhTrang = 3;
                var dialog = new frmWarning("Cảnh Báo!!!", "Bạn có muốn hủy phiếu đặt ghế không?");
                var res = dialog.ShowDialog();
                if (res == DialogResult.OK)
                {
                    
                }
                else if (res == DialogResult.Cancel) return;
            }
            

            button1.PerformClick();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            button2.PerformClick();
        }

        private void cbMaCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMaCB.SelectedItem == null) return;
            tbNgayGio.Text = ((ChuyenBay)cbMaCB.SelectedItem).ThoiGian.ToString("hh:mm tt dd/MM/yyyy");
            if (cbHangVe.SelectedItem == null) return;
            tbGiaVe.Text = (((ChuyenBay)cbMaCB.SelectedItem).DonGia * ((HangVe)cbHangVe.SelectedItem).TiLe).ToString("###,###,### VND");
        }

        private void cbHangVe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbHangVe.SelectedItem == null) return;
            if (cbMaCB.SelectedItem == null) return;
            tbGiaVe.Text = (((ChuyenBay)cbMaCB.SelectedItem).DonGia * ((HangVe)cbHangVe.SelectedItem).TiLe).ToString("###,###,### VND");
        }
        private void PanelTT()
        {
            if (AppState.state == Actions.ADD)
            {
                lbTinhTrang.Hide();
                rbDat.Hide();
                rbDaBan.Hide();
                rbDaHuy.Hide();
                return;
            }
            if (AppState.state == Actions.EDIT)
            {
                if (pdc.tinhTrang == 1)
                {
                    rbDat.Enabled = true;
                    rbDaBan.Enabled = true;
                    rbDaHuy.Enabled = true;
                }
                if (pdc.tinhTrang == 2)
                {
                    rbDat.Enabled = false;
                    rbDaBan.Enabled = true;
                    rbDaHuy.Enabled = false;
                }
                else if (pdc.tinhTrang == 3) 
                {
                    rbDat.Enabled = false;
                    rbDaBan.Enabled = false;
                    rbDaHuy.Enabled = true;
                }
            }
        }
    }
}
