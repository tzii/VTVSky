using Business_Logic_Layer;
using Data_Transfer_Objects;
using Guna.UI2.WinForms.Helpers;
using Presentation_Layer.FormDigital;
using Presentation_Layer.Properties;
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
    public partial class frmTuyenBay : CustomForm
    {

        private List<TuyenBay> tuyenBays;
        private SortableBindingList<TuyenBay> bl;
        private Color lastColor;
        public frmTuyenBay()
        {
            InitializeComponent();
        }
        #region Other functions
        private void UpdateHeightDgv()
        {
            pnContain.Height = Math.Min(40 + 24 * dgvTuyenBays.RowCount, Height - 38 - 50);
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
            dgvTuyenBays.Columns["MaTB"].Visible = false;
            dgvTuyenBays.Columns["SBDi"].Visible = false;
            dgvTuyenBays.Columns["SBDen"].Visible = false;

            dgvTuyenBays.Columns["strMaTB"].HeaderText = "Mã";
            dgvTuyenBays.Columns["strMaTB"].CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTuyenBays.Columns["strMaTB"].Width = 100;

            dgvTuyenBays.Columns["TenSBDi"].HeaderText = "Sân Bay Đi";
            dgvTuyenBays.Columns["TenSBDen"].HeaderText = "Sân Bay Đến";
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
        #region Chỉnh sửa hiển thị của dgvTuyenBays
        private void dgvTuyenBays_DataSourceChanged(object sender, EventArgs e)
        {
            UpdateHeightDgv();
        }

        private void dgvTuyenBays_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0) return;
            lastColor = dgvTuyenBays.Rows[e.RowIndex].DefaultCellStyle.BackColor;
            dgvTuyenBays.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(99, 191, 173);
        }

        private void dgvTuyenBays_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) dgvTuyenBays.Rows[e.RowIndex].DefaultCellStyle.BackColor = lastColor;
        }

        private void dgvTuyenBays_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0) dgvTuyenBays.Rows[e.RowIndex].Selected = true;
        }

        private void frmTuyenBay_SizeChanged(object sender, EventArgs e)
        {
            UpdateHeightDgv();
        }
        private void dgvTuyenBays_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTuyenBays.SelectedRows.Count > 0)
            {
                if (AppState.state != Actions.NOTHING)
                {
                    var dialog = new frmWarning("Cảnh Báo", "Bạn có muốn hủy bỏ chỉnh sửa?");
                    DialogResult res = dialog.ShowDialog();
                    if (res == DialogResult.OK)
                    {
                        DisablePanelEdit();
                    }
                    else if (res == DialogResult.Cancel)
                    {
                        return;
                    }
                }
                var sbDi = dgvTuyenBays.SelectedRows[0].Cells["SBDi"].Value as SanBay;
                var sbDen = dgvTuyenBays.SelectedRows[0].Cells["SBDen"].Value as SanBay;
                tbMaTB.Text = dgvTuyenBays.SelectedRows[0].Cells["strMaTB"].Value.ToString();
                cbSBDi.SelectedValue = sbDi.maSB;
                cbSBDen.SelectedValue = sbDen.maSB;
            }
        }
        #endregion
        private void frmTuyenBay_Load(object sender, EventArgs e)
        {
            cbSearch.DataSource = sources();
            cbSearch.DisplayMember = "Name";
            cbSearch.ValueMember = "ID";

            tuyenBays = BLL_TuyenBay.GetTuyenBays();
            bl = new SortableBindingList<TuyenBay>(tuyenBays);
            dgvTuyenBays.DataSource = bl;
            CustomDgv();

            cbSBDi.DataSource = BLL_SanBay.GetSanBays();
            cbSBDi.DisplayMember = "TenSB";
            cbSBDi.ValueMember = "MaSB";

            cbSBDen.DataSource = BLL_SanBay.GetSanBays();
            cbSBDen.DisplayMember = "TenSB";
            cbSBDen.ValueMember = "MaSB";
        }

        public override void RefreshData()
        {
            tuyenBays = BLL_TuyenBay.GetTuyenBays();
            bl = new SortableBindingList<TuyenBay>(tuyenBays);
            dgvTuyenBays.DataSource = bl;
            Notification.Show("Làm mới danh sách tuyến bay");
        }
        public override void SizeChange()
        {
            UpdateHeightDgv();
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (AppState.state != Actions.NOTHING)
            {
                var dialog = new frmWarning("Cảnh Báo", "Bạn có muốn hủy bỏ chỉnh sửa?");
                DialogResult res = dialog.ShowDialog();
                if (res == DialogResult.OK)
                {
                    DisablePanelEdit();
                }
                else if (res == DialogResult.Cancel)
                {
                    return;
                }
            }
            if (cbSearch.SelectedValue.ToString() == "MaSB") tuyenBays = BLL_TuyenBay.searchMaTB(tbSearch.Text);
            else if (cbSearch.SelectedValue.ToString() == "SBDi") tuyenBays = BLL_TuyenBay.searchTenSBDi(tbSearch.Text);
            else if (cbSearch.SelectedValue.ToString() == "SBDen") tuyenBays = BLL_TuyenBay.searchTenSBDen(tbSearch.Text);
            bl = new SortableBindingList<TuyenBay>(tuyenBays);
            dgvTuyenBays.DataSource = bl;
        }
        #region panel Edit
        private void ActivePanelEdit(Actions x)
        {
            AppState.state = x;

            cbSBDi.Enabled = true;
            cbSBDen.Enabled = true;

            btnAdd.Text = "OK";
            btnEdit.Text = "Cancel";

            btnAdd.Image = null;
            btnEdit.Image = null;
        }
        private void DisablePanelEdit()
        {
            AppState.state = Actions.NOTHING;

            cbSBDi.Enabled = false;
            cbSBDen.Enabled = false;

            btnAdd.Text = "Add";
            btnEdit.Text = "Edit";

            btnAdd.Image = Presentation_Layer.Properties.Resources.plus;
            btnEdit.Image = Presentation_Layer.Properties.Resources.edit;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (AppState.state == Actions.NOTHING)
            {
                ActivePanelEdit(Actions.ADD);
            }
            else if (AppState.state == Actions.ADD)
            {
                Notification.Show("Add");
                DisablePanelEdit();
            }
            else if (AppState.state == Actions.EDIT)
            {
                Notification.Show("Edit");
                DisablePanelEdit();
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (AppState.state == Actions.NOTHING)
            {
                ActivePanelEdit(Actions.EDIT);
            }
            else
            {
                DisablePanelEdit();
            }
        }
        #endregion
    }
}
