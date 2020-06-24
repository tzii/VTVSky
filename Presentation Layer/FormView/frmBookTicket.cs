using Business_Logic_Layer;
using Data_Transfer_Objects;
using Guna.UI2.WinForms.Helpers;
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
    public partial class frmBookTicket : CustomForm
    {
        private PanelScrollHelper scrollHelper;
        private List<PhieuDatCho> phieuDatChos;
        private SortableBindingList<PhieuDatCho> bl;
        private Color lastColor;
        public frmBookTicket()
        {
            InitializeComponent();
        }
        #region Other functions
        private void UpdateHeightDgv()
        {
            pnView.Height = 50 + 60 + 24 * dgvBookTicket.RowCount;
        }
        private DataGridViewButtonColumn ButtonColumn(string text)
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Name = text;
            btn.Text = text;
            btn.HeaderText = "";
            btn.UseColumnTextForButtonValue = true;
            btn.FlatStyle = FlatStyle.Flat;
            btn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            btn.Width = 50;
            return btn;
        }
        private void CustomDgv()
        {
            dgvBookTicket.Columns.Add(ButtonColumn("Detail"));
            dgvBookTicket.Columns.Add(ButtonColumn("Edit"));
            dgvBookTicket.Columns.Add(ButtonColumn("Delete"));

            dgvBookTicket.Columns["MaVe"].Visible = false;
            dgvBookTicket.Columns["MaCB"].Visible = false;
            dgvBookTicket.Columns["HV"].Visible = false;
            dgvBookTicket.Columns["TinhTrang"].Visible = false;

            dgvBookTicket.Columns["strMaVe"].Width = 80;
            dgvBookTicket.Columns["strMaCB"].Width = 90;
            dgvBookTicket.Columns["CMND"].Width = 90;
            dgvBookTicket.Columns["DienThoai"].Width = 90;
            dgvBookTicket.Columns["ThoiGian"].Width = 80;
            dgvBookTicket.Columns["TenHV"].Width = 120;
            dgvBookTicket.Columns["GiaVe"].Width = 90;
            dgvBookTicket.Columns["strTinhTrang"].Width = 80;

            dgvBookTicket.Columns["strMaVe"].HeaderText = "Mã Vé";
            dgvBookTicket.Columns["strMaCB"].HeaderText = "Mã\nChuyến Bay";
            dgvBookTicket.Columns["TenHK"].HeaderText = "Tên\nHành Khách";
            dgvBookTicket.Columns["CMND"].HeaderText = "CMND";
            dgvBookTicket.Columns["DienThoai"].HeaderText = "Số\nĐiện Thoại";
            dgvBookTicket.Columns["ThoiGian"].HeaderText = "Thời Gian";
            dgvBookTicket.Columns["TenHV"].HeaderText = "Hạng Vé";
            dgvBookTicket.Columns["GiaVe"].HeaderText = "Giá\n(VND)";
            dgvBookTicket.Columns["strTinhTrang"].HeaderText = "Tình Trạng";

            dgvBookTicket.Columns["GiaVe"].DefaultCellStyle.Format = "### ### ###";

            dgvBookTicket.Columns["strMaVe"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBookTicket.Columns["strMaCB"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBookTicket.Columns["CMND"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBookTicket.Columns["DienThoai"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBookTicket.Columns["ThoiGian"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBookTicket.Columns["GiaVe"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBookTicket.Columns["strTinhTrang"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private List<CBSource> sources()
        {
            var res = new List<CBSource>();
            CBSource i = new CBSource("MaVe", "Mã Vé");
            res.Add(i);
            i = new CBSource("MaCB", "Mã Chuyến Bay");
            res.Add(i);
            i = new CBSource("TenHK", "Tên Hành Khách");
            res.Add(i);
            i = new CBSource("CMND", "CMND");
            res.Add(i);
            i = new CBSource("SDT", "Số Điện Thoại");
            res.Add(i);
            i = new CBSource("TG", "Thời Gian");
            res.Add(i);
            i = new CBSource("TT", "Tình Trạng");
            res.Add(i);
            return res;
        }
        #endregion
        private void frmBookTicket_Load(object sender, EventArgs e)
        {
            cbSearch.DataSource = sources();
            cbSearch.DisplayMember = "Name";
            cbSearch.ValueMember = "ID";

            phieuDatChos = BLL_PhieuDatCho.GetPhieuDatChos();
            bl = new SortableBindingList<PhieuDatCho>(phieuDatChos);
            dgvBookTicket.DataSource = bl;
            CustomDgv();

            //Update scrollbar
            scrollHelper = new PanelScrollHelper(pnScroll, sb, false);
            scrollHelper.UpdateScrollBar();
        }

        private void dgvBookTicket_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0) dgvBookTicket.Rows[e.RowIndex].Selected = true;
        }

        private void pnScroll_Resize(object sender, EventArgs e)
        {
            if (scrollHelper != null)
                scrollHelper.UpdateScrollBar();
        }
        public override void RefreshData()
        {
            phieuDatChos = BLL_PhieuDatCho.GetPhieuDatChos();
            bl = new SortableBindingList<PhieuDatCho>(phieuDatChos);
            dgvBookTicket.DataSource = bl;
            Notification.Show("Làm mới danh sách sân bay");
        }
        public override void Create()
        {
            //var frm = new f
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cbSearch.SelectedValue.ToString() == "MaVe") phieuDatChos = BLL_PhieuDatCho.SearchMaVe(tbSearch.Text);
            else if (cbSearch.SelectedValue.ToString() == "MaCB") phieuDatChos = BLL_PhieuDatCho.SearchMaCB(tbSearch.Text);
            else if (cbSearch.SelectedValue.ToString() == "TenHK") phieuDatChos = BLL_PhieuDatCho.SearchTenHK(tbSearch.Text);
            else if (cbSearch.SelectedValue.ToString() == "CMND") phieuDatChos = BLL_PhieuDatCho.SearchCMND(tbSearch.Text);
            else if (cbSearch.SelectedValue.ToString() == "SDT") phieuDatChos = BLL_PhieuDatCho.SearchSDT(tbSearch.Text);
            else if (cbSearch.SelectedValue.ToString() == "TG") phieuDatChos = BLL_PhieuDatCho.SearchThoiGian(tbSearch.Text);
            else if (cbSearch.SelectedValue.ToString() == "TT") phieuDatChos = BLL_PhieuDatCho.SearchTinhTrang(tbSearch.Text);
            bl = new SortableBindingList<PhieuDatCho>(phieuDatChos);
            dgvBookTicket.DataSource = bl;
        }
        #region Chỉnh sửa hiển thị của dgvBookTicket
        private void dgvBookTicket_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) dgvBookTicket.Rows[e.RowIndex].DefaultCellStyle.BackColor = lastColor;
        }
        private void dgvBookTicket_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            lastColor = dgvBookTicket.Rows[e.RowIndex].DefaultCellStyle.BackColor;
            dgvBookTicket.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(99, 191, 173);
        }

        private void dgvBookTicket_DataSourceChanged(object sender, EventArgs e)
        {
            UpdateHeightDgv();
        }
        #endregion
    }
}
