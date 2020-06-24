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
    public partial class frmFlightsList : CustomForm
    {
        private PanelScrollHelper scrollHelper;
        private List<ChuyenBay> chuyenBays;
        private SortableBindingList<ChuyenBay> bl;
        private Color lastColor;
        public frmFlightsList()
        {
            InitializeComponent();
        }
        #region Other functions
        private void UpdateHeightDgv()
        {
            pnView.Height = 50 + 60 + 24 * dgvFlightsList.RowCount;
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
            //dgvFlightsList.Columns.Add(ButtonColumn("Detail"));
            //dgvFlightsList.Columns.Add(ButtonColumn("Edit"));
            //dgvFlightsList.Columns.Add(ButtonColumn("Delete"));

            dgvFlightsList.Columns["MaCB"].Visible = false;
            dgvFlightsList.Columns["TB"].Visible = false;

            
            dgvFlightsList.Columns["strMaCB"].Width = 100;
            dgvFlightsList.Columns["DonGia"].Width = 100;
            dgvFlightsList.Columns["ThoiGian"].Width = 80;
            dgvFlightsList.Columns["ThoiLuong"].Width = 80;
            dgvFlightsList.Columns["SoGheTrong"].Width = 80;
            dgvFlightsList.Columns["SoGheDat"].Width = 80;

            dgvFlightsList.Columns["strMaCB"].HeaderText = "Mã";
            dgvFlightsList.Columns["TenSBDi"].HeaderText = "Sân Bay Đi";
            dgvFlightsList.Columns["TenSBDen"].HeaderText = "Sân Bay Đến";
            dgvFlightsList.Columns["DonGia"].HeaderText = "Đơn giá\n(VND)";
            dgvFlightsList.Columns["ThoiGian"].HeaderText = "Khởi hành";
            dgvFlightsList.Columns["ThoiLuong"].HeaderText = "Thời lượng\n(m)";
            dgvFlightsList.Columns["SoGheTrong"].HeaderText = "Số ghế trống";
            dgvFlightsList.Columns["SoGheDat"].HeaderText = "Số ghế đặt";

            dgvFlightsList.Columns["DonGia"].DefaultCellStyle.Format = "### ### ###";

            dgvFlightsList.Columns["strMaCB"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvFlightsList.Columns["DonGia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvFlightsList.Columns["ThoiGian"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvFlightsList.Columns["ThoiLuong"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvFlightsList.Columns["SoGheTrong"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvFlightsList.Columns["SoGheDat"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }

        private List<CBSource> sources()
        {
            var res = new List<CBSource>();
            CBSource i = new CBSource("MaCB", "Mã");
            res.Add(i);
            i = new CBSource("SBDi", "Sân Bay Đi");
            res.Add(i);
            i = new CBSource("SBDen", "Sân Bay Đến");
            res.Add(i);
            return res;
        }
        #endregion
        private void frmFlightsList_Load(object sender, EventArgs e)
        {
            cbSearch.DataSource = sources();
            cbSearch.DisplayMember = "Name";
            cbSearch.ValueMember = "ID";

            chuyenBays = BLL_ChuyenBay.GetChuyenBays();
            bl = new SortableBindingList<ChuyenBay>(chuyenBays);
            dgvFlightsList.DataSource = bl;
            CustomDgv();

            //if (sanBays == null) Notification.Show(Status.ACCESS, "NULL");

            //Update scrollbar
            scrollHelper = new PanelScrollHelper(pnScroll, sb, false);
            scrollHelper.UpdateScrollBar();
        }
        
        private void dgvFlights_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0) dgvFlightsList.Rows[e.RowIndex].Selected = true;
        }

        private void pnScroll_Resize(object sender, EventArgs e)
        {
            if (scrollHelper != null)
                scrollHelper.UpdateScrollBar();
        }
        public override void RefreshData()
        {
            //chuyenBays = BLL_ChuyenBay.GetSanBays();
            bl = new SortableBindingList<ChuyenBay>(chuyenBays);
            dgvFlightsList.DataSource = bl;
            Notification.Show("Làm mới danh sách sân bay");
        }
        public override void Create()
        {
            //var frm = new f
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cbSearch.SelectedValue.ToString() == "MaCB") chuyenBays = BLL_ChuyenBay.SearchMaCB(tbSearch.Text);
            else if (cbSearch.SelectedValue.ToString() == "SBDi") chuyenBays = BLL_ChuyenBay.SearchTenSBDi(tbSearch.Text);
            else if (cbSearch.SelectedValue.ToString() == "SBDen") chuyenBays = BLL_ChuyenBay.SearchTenSBDen(tbSearch.Text);
            bl = new SortableBindingList<ChuyenBay> (chuyenBays);
            dgvFlightsList.DataSource = bl;
        }
        #region Chỉnh sửa hiển thị của dgvAirports
        private void dgvFlightsList_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) dgvFlightsList.Rows[e.RowIndex].DefaultCellStyle.BackColor = lastColor;

        }
        private void dgvFlightsList_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            lastColor = dgvFlightsList.Rows[e.RowIndex].DefaultCellStyle.BackColor;
            dgvFlightsList.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(99, 191, 173);
        }

        private void dgvFlightsList_DataSourceChanged(object sender, EventArgs e)
        {
            UpdateHeightDgv();
        }
        #endregion
    }
}
