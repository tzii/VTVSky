using Business_Logic_Layer;
using Data_Transfer_Objects;
using Guna.UI2.WinForms.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation_Layer.FormView
{
    public partial class frmAirports : CustomForm
    {
        private PanelScrollHelper scrollHelper;
        private List<SanBay> sanBays;
        SortableBindingList<SanBay> bl;
        private Color lastColor;
        public frmAirports()
        {
            InitializeComponent();
        }
        #region Other functions
        private void UpdateHeightDgv()
        {
            pnView.Height = 50 + 40 + 24 * dgvAirports.RowCount;
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
            dgvAirports.Columns.Add(ButtonColumn("Detail"));
            dgvAirports.Columns.Add(ButtonColumn("Edit"));
            dgvAirports.Columns.Add(ButtonColumn("Delete"));

            dgvAirports.Columns["MaSB"].HeaderText = "Mã";
            dgvAirports.Columns["MaSB"].CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAirports.Columns["MaSB"].Width = 200;

            dgvAirports.Columns["TenSB"].HeaderText = "Tên Sân Bay";
        }

        private List<CBSource> sources()
        {
            var res = new List<CBSource>();
            CBSource i = new CBSource("MaSB", "Mã");
            res.Add(i);
            i = new CBSource("TenSB", "Tên Sân Bay");
            res.Add(i);
            return res;
        }
        #endregion


        private void frmAirports_Load(object sender, EventArgs e)
        {
            cbSearch.DataSource = sources();
            cbSearch.DisplayMember = "Name";
            cbSearch.ValueMember = "ID";

            List<SanBay> sanBays = BLL_SanBay.GetSanBays();
            SortableBindingList<SanBay> bl = new SortableBindingList<SanBay>(sanBays);
            dgvAirports.DataSource = bl;
            CustomDgv();

            //if (sanBays == null) Notification.Show(Status.ACCESS, "NULL");

            //Update scrollbar
            scrollHelper = new PanelScrollHelper(pnScroll, sb, false);
            scrollHelper.UpdateScrollBar();
        }

        private void pnScroll_Resize(object sender, EventArgs e)
        {
            if (scrollHelper != null)
                scrollHelper.UpdateScrollBar();
        }

        public override void RefreshData()
        {
            sanBays = BLL_SanBay.GetSanBays();
            bl = new SortableBindingList<SanBay>(sanBays);
            dgvAirports.DataSource = bl;
            Notification.Show("Làm mới danh sách sân bay");
        }

        public override void Create()
        {
            //var frm = new f
        }
        #region Chỉnh sửa hiển thị của dgvAirports
        private void dgvAirports_DataSourceChanged(object sender, EventArgs e)
        {
            UpdateHeightDgv();
        }

        private void dgvAirports_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex <= 0) return;
            lastColor = dgvAirports.Rows[e.RowIndex].DefaultCellStyle.BackColor;
            dgvAirports.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(99, 191, 173);
        }

        private void dgvAirports_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) dgvAirports.Rows[e.RowIndex].DefaultCellStyle.BackColor = lastColor;
        }

        private void dgvAirports_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >=0) dgvAirports.Rows[e.RowIndex].Selected = true;
        }
        #endregion

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cbSearch.SelectedValue.ToString() == "MaSB") sanBays = BLL_SanBay.SearchMaSB(tbSearch.Text);
            else if (cbSearch.SelectedValue.ToString() == "TenSB") sanBays = BLL_SanBay.SearchTenSB(tbSearch.Text);
            bl = new SortableBindingList<SanBay>(sanBays);
            dgvAirports.DataSource = bl;
        }
    }
}
