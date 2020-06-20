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
        private List<DatCho> datChos;
        private SortableBindingList<DatCho> bl;
        private Color lastColor;
        public frmBookTicket()
        {
            InitializeComponent();
        }
        #region Other functions
        private void UpdateHeightDgv()
        {
            pnView.Height = 50 + 40 + 24 * dgvBookTicket.RowCount;
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

            dgvBookTicket.Columns["MaVe"].HeaderText = "Mã Vé";
            dgvBookTicket.Columns["MaVe"].CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBookTicket.Columns["MaVe"].Width = 100;

            dgvBookTicket.Columns["MaCB"].HeaderText = "Mã Chuyến Bay";
            dgvBookTicket.Columns["MaCB"].CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBookTicket.Columns["MaCB"].Width = 100;

            dgvBookTicket.Columns["TenHK"].HeaderText = "Tên Hành Khách";
            dgvBookTicket.Columns["CMND"].HeaderText = "CMND";
            dgvBookTicket.Columns["DienThoai"].HeaderText = "Số Điện Thoại";
            dgvBookTicket.Columns["ThoiGian"].HeaderText = "Thời Gian";
            dgvBookTicket.Columns["TenHV"].HeaderText = "Hạng Vé";
            dgvBookTicket.Columns["GiaVe"].HeaderText = "Giá Vé";
            dgvBookTicket.Columns["TinhTrang"].HeaderText = "Tình Trạng";

        }

        private List<CBSource> sources()
        {
            var res = new List<CBSource>();
            CBSource i = new CBSource("MaVe", "Mã Vé");
            res.Add(i);
            i = new CBSource("CB", "Mã Chuyến Bay");
            res.Add(i);
            i = new CBSource("TenHK", "Tên Hành Khách");
            res.Add(i);
            i = new CBSource("CMND", "CMND");
            res.Add(i);
            i = new CBSource("DT", "Số Điện Thoại");
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

            //datChos= BLL_ChuyenBay.GetSanBays();
            datChos = new List<DatCho>();
            bl = new SortableBindingList<DatCho>(datChos);
            dgvBookTicket.DataSource = bl;
            CustomDgv();

            //if (sanBays == null) Notification.Show(Status.ACCESS, "NULL");

            //Update scrollbar
            scrollHelper = new PanelScrollHelper(pnScroll, sb, false);
            scrollHelper.UpdateScrollBar();
        }

        private void dgvFlights_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
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
            //datChos = BLL_ChuyenBay.GetSanBays();
            bl = new SortableBindingList<DatCho>(datChos);
            dgvBookTicket.DataSource = bl;
            Notification.Show("Làm mới danh sách sân bay");
        }
        public override void Create()
        {
            //var frm = new f
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
        #region Chỉnh sửa hiển thị của dgvAirports
        private void dgvFlightsList_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) dgvBookTicket.Rows[e.RowIndex].DefaultCellStyle.BackColor = lastColor;

        }
        private void dgvFlightsList_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <= 0) return;
            lastColor = dgvBookTicket.Rows[e.RowIndex].DefaultCellStyle.BackColor;
            dgvBookTicket.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(99, 191, 173);
        }

        private void dgvFlightsList_DataSourceChanged(object sender, EventArgs e)
        {
            UpdateHeightDgv();
        }
        #endregion
    }
}
