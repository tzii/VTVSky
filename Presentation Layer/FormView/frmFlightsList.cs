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
            pnView.Height = 50 + 40 + 24 * dgvFlightsList.RowCount;
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

            //dgvFlightsList.Columns["MaSB"].HeaderText = "Mã";
            //dgvFlightsList.Columns["MaSB"].CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgvFlightsList.Columns["MaSB"].Width = 200;

            //dgvFlightsList.Columns["TenSB"].HeaderText = "Tên Sân Bay";
        }

        private List<CBSource> sources()
        {
            var res = new List<CBSource>();
            CBSource i = new CBSource("MaSB", "Mã");
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

            //chuyenBays= BLL_ChuyenBay.GetSanBays();
            chuyenBays = new List<ChuyenBay>();
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

        }
        #region Chỉnh sửa hiển thị của dgvAirports
        private void dgvFlightsList_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) dgvFlightsList.Rows[e.RowIndex].DefaultCellStyle.BackColor = lastColor;

        }
        private void dgvFlightsList_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <= 0) return;
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
