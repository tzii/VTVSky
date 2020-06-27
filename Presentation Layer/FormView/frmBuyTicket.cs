using Business_Logic_Layer;
using Data_Transfer_Objects;
using Guna.UI2.WinForms.Helpers;
using Presentation_Layer.FormDigital;
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
            //dgvBuyTicket.Columns.Add(ButtonColumn("Delete"));

            dgvBuyTicket.Columns["MaVe"].Visible = false;
            dgvBuyTicket.Columns["MaCB"].Visible = false;
            dgvBuyTicket.Columns["DienThoai"].Visible = false;
            dgvBuyTicket.Columns["HV"].Visible = false;
            dgvBuyTicket.Columns["GiaVe"].Visible = false;

            dgvBuyTicket.Columns["strMaVe"].Width = 80;
            dgvBuyTicket.Columns["strMaCB"].Width = 90;
            dgvBuyTicket.Columns["CMND"].Width = 90;
            //dgvBuyTicket.Columns["DienThoai"].Width = 90;
            dgvBuyTicket.Columns["ThoiGian"].Width = 180;
            dgvBuyTicket.Columns["TenHV"].Width = 120;
            //dgvBuyTicket.Columns["GiaVe"].Width = 90;

            dgvBuyTicket.Columns["strMaVe"].HeaderText = "Mã Vé";
            dgvBuyTicket.Columns["strMaCB"].HeaderText = "Mã\nChuyến Bay";
            dgvBuyTicket.Columns["TenHK"].HeaderText = "Tên\nHành Khách";
            dgvBuyTicket.Columns["CMND"].HeaderText = "CMND";
            //dgvBuyTicket.Columns["DienThoai"].HeaderText = "Số\nĐiện Thoại";
            dgvBuyTicket.Columns["ThoiGian"].HeaderText = "Thời Gian";
            dgvBuyTicket.Columns["TenHV"].HeaderText = "Hạng Vé";
            //dgvBuyTicket.Columns["GiaVe"].HeaderText = "Giá\n(VND)";

            //dgvBuyTicket.Columns["DienThoai"].DefaultCellStyle.Format = "0";
            dgvBuyTicket.Columns["ThoiGian"].DefaultCellStyle.Format = "hh:mm tt dd/MM/yyyy";
            dgvBuyTicket.Columns["GiaVe"].DefaultCellStyle.Format = "###,###,###";

            dgvBuyTicket.Columns["strMaVe"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBuyTicket.Columns["strMaCB"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBuyTicket.Columns["CMND"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgvBuyTicket.Columns["DienThoai"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBuyTicket.Columns["ThoiGian"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgvBuyTicket.Columns["GiaVe"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
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
            i = new CBSource("TG", "Thời Gian");
            res.Add(i);
            return res;
        }
        private void reloadData()
        {
            ves = BLL_Ve.GetVes();
            bl = new SortableBindingList<Ve>(ves);
            dgvBuyTicket.DataSource = bl;
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
            if (e.RowIndex < 0) return;
            dgvBuyTicket.Rows[e.RowIndex].Selected = true;
            if (e.ColumnIndex == 0)
            {
                Detail(dgvBuyTicket.Rows[e.RowIndex]);
            }
            else if (e.ColumnIndex == 1)
            {
                Edit(dgvBuyTicket.Rows[e.RowIndex]);
            }
        }

        private void pnScroll_Resize(object sender, EventArgs e)
        {
            if (scrollHelper != null)
                scrollHelper.UpdateScrollBar();
        }
        public override void RefreshData()
        {
            reloadData();
            Notification.Show("Làm mới danh sách sân bay");
        }
        public override void Create()
        {
            AppState.state = Actions.ADD;
            var dialog = new frmVeEditing();
            DialogResult res = dialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                int newMave = BLL_IdenMaVe.GetNewMaVe();
                if (BLL_Ve.InsertVe(dialog.ve, newMave))
                {
                    BLL_IdenMaVe.ClearIden();
                }
                reloadData();
            }
            AppState.state = Actions.NOTHING;
        }
        private void Edit(DataGridViewRow row)
        {
            AppState.state = Actions.EDIT;
            int maVe = (int)row.Cells["MaVe"].Value;
            int maCB = (int)row.Cells["MaCB"].Value;
            string tenHK = (string)row.Cells["TenHK"].Value;
            string cmnd = (string)row.Cells["CMND"].Value;
            string dienThoai = (string)row.Cells["DienThoai"].Value;
            DateTime thoiGian = (DateTime)row.Cells["ThoiGian"].Value;
            HangVe hv = (HangVe)row.Cells["HV"].Value;
            int giaVe = (int)row.Cells["GiaVe"].Value;

            Ve ve = new Ve(maVe, maCB, tenHK, cmnd, dienThoai, thoiGian, hv, giaVe);

            var dialog = new frmVeEditing(ve);
            DialogResult res = dialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                BLL_Ve.UpdateVe(dialog.ve);
                reloadData();
            }
            AppState.state = Actions.NOTHING;
        }
        private void Detail(DataGridViewRow row)
        {
            int maVe = (int)row.Cells["MaVe"].Value;
            int maCB = (int)row.Cells["MaCB"].Value;
            string tenHK = (string)row.Cells["TenHK"].Value;
            string cmnd = (string)row.Cells["CMND"].Value;
            string dienThoai = (string)row.Cells["DienThoai"].Value;
            DateTime thoiGian = (DateTime)row.Cells["ThoiGian"].Value;
            HangVe hv = (HangVe)row.Cells["HV"].Value;
            int giaVe = (int)row.Cells["GiaVe"].Value;

            Ve ve = new Ve(maVe, maCB, tenHK, cmnd, dienThoai, thoiGian, hv, giaVe);

            var dialog = new frmVeEditing(ve);
            DialogResult res = dialog.ShowDialog();
            if (res == DialogResult.OK)
            {

            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cbSearch.SelectedValue.ToString() == "MaVe") ves = BLL_Ve.SearchMaVe(tbSearch.Text);
            else if (cbSearch.SelectedValue.ToString() == "MaCB") ves = BLL_Ve.SearchMaCB(tbSearch.Text);
            else if (cbSearch.SelectedValue.ToString() == "TenHK") ves = BLL_Ve.SearchTenHK(tbSearch.Text);
            else if (cbSearch.SelectedValue.ToString() == "CMND") ves = BLL_Ve.SearchCMND(tbSearch.Text);
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
        #region Tool strip
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Create();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvBuyTicket.SelectedRows.Count <= 0) return;
            Detail(dgvBuyTicket.SelectedRows[0]);
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dgvBuyTicket.SelectedRows.Count <= 0) return;
            Edit(dgvBuyTicket.SelectedRows[0]);
        }
        #endregion
    }
}
