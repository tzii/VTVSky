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
    public partial class frmBuyTicket : CustomForm
    {
        private PanelScrollHelper scrollHelper;
        private List<Ve> ves;
        private SortableBindingList<Ve> bl;
        private Color lastColor;
        public frmBuyTicket()
        {
            InitializeComponent();
        }
        #region Other functions
        private void UpdateHeightDgv()
        {
            pnView.Height = 50 + 60 + 24 * dgvBuyTicket.RowCount;
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
            dgvBuyTicket.Columns.Add(ButtonColumn("Detail"));
            dgvBuyTicket.Columns.Add(ButtonColumn("Edit"));
            dgvBuyTicket.Columns.Add(ButtonColumn("Delete"));

            dgvBuyTicket.Columns["MaVe"].Visible = false;
            dgvBuyTicket.Columns["MaCB"].Visible = false;
            dgvBuyTicket.Columns["HV"].Visible = false;

            dgvBuyTicket.Columns["strMaVe"].Width = 80;
            dgvBuyTicket.Columns["strMaCB"].Width = 90;
            dgvBuyTicket.Columns["CMND"].Width = 90;
            dgvBuyTicket.Columns["DienThoai"].Width = 90;
            dgvBuyTicket.Columns["ThoiGian"].Width = 80;
            dgvBuyTicket.Columns["TenHV"].Width = 120;
            dgvBuyTicket.Columns["GiaVe"].Width = 90;

            dgvBuyTicket.Columns["strMaVe"].HeaderText = "Mã Vé";
            dgvBuyTicket.Columns["strMaCB"].HeaderText = "Mã\nChuyến Bay";
            dgvBuyTicket.Columns["TenHK"].HeaderText = "Tên\nHành Khách";
            dgvBuyTicket.Columns["CMND"].HeaderText = "CMND";
            dgvBuyTicket.Columns["DienThoai"].HeaderText = "Số\nĐiện Thoại";
            dgvBuyTicket.Columns["ThoiGian"].HeaderText = "Thời Gian";
            dgvBuyTicket.Columns["TenHV"].HeaderText = "Hạng Vé";
            dgvBuyTicket.Columns["GiaVe"].HeaderText = "Giá\n(VND)";

            dgvBuyTicket.Columns["GiaVe"].DefaultCellStyle.Format = "### ### ###";

            dgvBuyTicket.Columns["strMaVe"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBuyTicket.Columns["strMaCB"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBuyTicket.Columns["CMND"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBuyTicket.Columns["DienThoai"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBuyTicket.Columns["ThoiGian"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBuyTicket.Columns["GiaVe"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

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
            return res;
        }
        #endregion
        private void frmBuyTicket_Load(object sender, EventArgs e)
        {
            cbSearch.DataSource = sources();
            cbSearch.DisplayMember = "Name";
            cbSearch.ValueMember = "ID";

            ves = BLL_Ve.GetVes();
            bl = new SortableBindingList<Ve>(ves);
            dgvBuyTicket.DataSource = bl;
            CustomDgv();

            //Update scrollbar
            scrollHelper = new PanelScrollHelper(pnScroll, sb, false);
            scrollHelper.UpdateScrollBar();
        }

        private void dgvFlights_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0) dgvBuyTicket.Rows[e.RowIndex].Selected = true;
        }

        private void pnScroll_Resize(object sender, EventArgs e)
        {
            if (scrollHelper != null)
                scrollHelper.UpdateScrollBar();
        }
        public override void RefreshData()
        {
            //ves = BLL_ChuyenBay.GetSanBays();
            bl = new SortableBindingList<Ve>(ves);
            dgvBuyTicket.DataSource = bl;
            Notification.Show("Làm mới danh sách sân bay");
        }
        public override void Create()
        {
            //var frm = new f
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cbSearch.SelectedValue.ToString() == "MaVe") ves = BLL_Ve.SearchMaVe(tbSearch.Text);
            else if (cbSearch.SelectedValue.ToString() == "MaCB") ves = BLL_Ve.SearchMaCB(tbSearch.Text);
            else if (cbSearch.SelectedValue.ToString() == "TenHK") ves = BLL_Ve.SearchTenHK(tbSearch.Text);
            else if (cbSearch.SelectedValue.ToString() == "CMND") ves = BLL_Ve.SearchCMND(tbSearch.Text);
            else if (cbSearch.SelectedValue.ToString() == "SDT") ves = BLL_Ve.SearchSDT(tbSearch.Text);
            else if (cbSearch.SelectedValue.ToString() == "TG") ves = BLL_Ve.SearchThoiGian(tbSearch.Text);
            bl = new SortableBindingList<Ve>(ves);
            dgvBuyTicket.DataSource = bl;
        }
        #region Chỉnh sửa hiển thị của dgvAirports
        private void dgvFlightsList_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) dgvBuyTicket.Rows[e.RowIndex].DefaultCellStyle.BackColor = lastColor;
        }
        private void dgvFlightsList_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            lastColor = dgvBuyTicket.Rows[e.RowIndex].DefaultCellStyle.BackColor;
            dgvBuyTicket.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(99, 191, 173);
        }

        private void dgvFlightsList_DataSourceChanged(object sender, EventArgs e)
        {
            UpdateHeightDgv();
        }
        #endregion
    }
}
