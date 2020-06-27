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
    public partial class frmVeEditing : Form
    {
        private List<ChuyenBay> chuyenBays = BLL_ChuyenBay.GetChuyenBays();
        private List<HangVe> hangVes = BLL_HangVe.GetHangVes();
        public Ve ve;
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
        public frmVeEditing()
        {
            InitializeComponent();
            ve = new Ve();
            Loadcb();
            checkState();
        }
        public frmVeEditing(Ve x)
        {
            InitializeComponent();
            Loadcb();
            checkState();
            ve = x;
            tbMaVe.Text = ve.strMaVe;
            cbMaCB.SelectedValue = ve.maCB;
            tbGiaVe.Text = ve.GiaVe.ToString("###,###,### VND");
            tbNgayGio.Text = ve.ThoiGian.ToString("hh:mm tt dd/MM/yyyy");
            tbTenHK.Text = ve.TenHK;
            cbHangVe.SelectedValue = ve.HV.maHV;
            tbCMND.Text = ve.CMND;
            tbDienThoai.Text = ve.DienThoai;
            
        }
        private void frmVeEditing_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
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

            ve.maCB = (int)cbMaCB.SelectedValue;
            ve.GiaVe = Convert.ToInt32(((ChuyenBay)cbMaCB.SelectedItem).DonGia * ((HangVe)cbHangVe.SelectedItem).TiLe);
            ve.ThoiGian = DateTime.ParseExact(tbNgayGio.Text, "hh:mm tt dd/MM/yyyy", null);
            ve.TenHK = tbTenHK.Text;
            ve.HV = cbHangVe.SelectedItem as HangVe;
            ve.CMND = tbCMND.Text;
            ve.DienThoai=tbDienThoai.Text;

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
    }
}
