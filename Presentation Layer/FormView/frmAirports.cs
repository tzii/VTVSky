using Business_Logic_Layer;
using Data_Transfer_Objects;
using Guna.UI2.WinForms.Helpers;
using Presentation_Layer.FormDigital;
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

        private List<SanBay> sanBays;
        private SortableBindingList<SanBay> bl;
        private Color lastColor;
        public frmAirports()
        {
            InitializeComponent();
        }
        #region Other functions
        private void UpdateHeightDgv()
        {
            pnContain.Height = Math.Min(40 + 24 * dgvAirports.RowCount, Height - 38 - 50);
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
            dgvAirports.Columns["MaSB"].Visible = false;
            dgvAirports.Columns["strMaSB"].HeaderText = "Mã";
            dgvAirports.Columns["strMaSB"].CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAirports.Columns["strMaSB"].Width = 100;

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
        #region Chỉnh sửa hiển thị của dgvAirports
        private void dgvAirports_DataSourceChanged(object sender, EventArgs e)
        {
            UpdateHeightDgv();
        }

        private void dgvAirports_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0) return;
            lastColor = dgvAirports.Rows[e.RowIndex].DefaultCellStyle.BackColor;
            dgvAirports.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(99, 191, 173);
        }

        private void dgvAirports_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) dgvAirports.Rows[e.RowIndex].DefaultCellStyle.BackColor = lastColor;
        }

        private void dgvAirports_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0) dgvAirports.Rows[e.RowIndex].Selected = true;
        }

        private void frmAirports_SizeChanged(object sender, EventArgs e)
        {
            UpdateHeightDgv();
        }
        private void dgvAirports_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAirports.SelectedRows.Count > 0)
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
                tbMaSB.Text = dgvAirports.SelectedRows[0].Cells["strMaSB"].Value.ToString();
                tbTenSB.Text = dgvAirports.SelectedRows[0].Cells["TenSB"].Value.ToString();
            }
        }
        #endregion
        private void frmAirports_Load(object sender, EventArgs e)
        {
            cbSearch.DataSource = sources();
            cbSearch.DisplayMember = "Name";
            cbSearch.ValueMember = "ID";

            sanBays = BLL_SanBay.GetSanBays();
            bl = new SortableBindingList<SanBay>(sanBays);
            dgvAirports.DataSource = bl;
            CustomDgv();

            AppState.state = Actions.NOTHING;
        }

        public override void RefreshData()
        {
            sanBays = BLL_SanBay.GetSanBays();
            bl = new SortableBindingList<SanBay>(sanBays);
            dgvAirports.DataSource = bl;
            Notification.Show("Làm mới danh sách sân bay");
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
            if (cbSearch.SelectedValue.ToString() == "MaSB") sanBays = BLL_SanBay.SearchMaSB(tbSearch.Text);
            else if (cbSearch.SelectedValue.ToString() == "TenSB") sanBays = BLL_SanBay.SearchTenSB(tbSearch.Text);
            bl = new SortableBindingList<SanBay>(sanBays);
            dgvAirports.DataSource = bl;
        }
        #region panel Edit
        private void ActivePanelEdit(Actions x)
        {
            AppState.state = x;
            tbTenSB.Enabled = true;
            btnAdd.Text = "OK";
            btnEdit.Text = "Cancel";

            btnAdd.Image = null;
            btnEdit.Image = null;
            
        }
        private void DisablePanelEdit()
        {
            AppState.state = Actions.NOTHING;
            tbTenSB.Enabled = false;
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
