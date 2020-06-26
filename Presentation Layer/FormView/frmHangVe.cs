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
    public partial class frmHangVe : CustomForm
    {

        private List<HangVe> hangVes;
        private SortableBindingList<HangVe> bl;
        private Color lastColor;
        private HangVe currentHV
        {
            get
            {
                try
                {
                    int maHV = (int)dgvHangVe.SelectedRows[0].Cells["MaHV"].Value;
                    string tenHV = tbTenHV.Text;
                    double tiLe = Convert.ToDouble(tbTiLe.Text);
                    return new HangVe(maHV,tenHV,tiLe);
                }
                catch (Exception ex)
                {
                    Notification.Show(ex.Message);
                    return new HangVe();
                }
            }
        }
        public frmHangVe()
        {
            InitializeComponent();
        }
        #region Other functions
        private void UpdateHeightDgv()
        {
            pnContain.Height = Math.Min(40 + 24 * dgvHangVe.RowCount, Height - 38 - 50);
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
            dgvHangVe.Columns["MaHV"].Visible = false;

            dgvHangVe.Columns["strMaHV"].HeaderText = "Mã";
            dgvHangVe.Columns["strMaHV"].CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvHangVe.Columns["strMaHV"].Width = 100;

            dgvHangVe.Columns["TenHV"].HeaderText = "Tên Sân Bay";
            dgvHangVe.Columns["TiLe"].HeaderText = "Tỉ Lệ";
        }

        private List<CBSource> sources()
        {
            var res = new List<CBSource>();
            CBSource i = new CBSource("MaHV", "Mã");
            res.Add(i);
            i = new CBSource("TenHV", "Tên Hạng Vé");
            res.Add(i);
            return res;
        }
        private void reloadData()
        {
            hangVes = BLL_HangVe.GetHangVes();
            bl = new SortableBindingList<HangVe>(hangVes);
            dgvHangVe.DataSource = bl;
        }
        #endregion
        #region Chỉnh sửa hiển thị của dgvHangVe
        private void dgvHangVe_DataSourceChanged(object sender, EventArgs e)
        {
            UpdateHeightDgv();
        }

        private void dgvHangVe_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0) return;
            lastColor = dgvHangVe.Rows[e.RowIndex].DefaultCellStyle.BackColor;
            dgvHangVe.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(99, 191, 173);
        }

        private void dgvHangVe_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) dgvHangVe.Rows[e.RowIndex].DefaultCellStyle.BackColor = lastColor;
        }

        private void dgvHangVe_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0) dgvHangVe.Rows[e.RowIndex].Selected = true;
        }

        private void frmHangVe_SizeChanged(object sender, EventArgs e)
        {
            UpdateHeightDgv();
        }
        private void dgvHangVe_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvHangVe.SelectedRows.Count > 0)
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
                loadEdit();
            }
        }
        #endregion
        private void frmHangVe_Load(object sender, EventArgs e)
        {
            cbSearch.DataSource = sources();
            cbSearch.DisplayMember = "Name";
            cbSearch.ValueMember = "ID";

            hangVes = BLL_HangVe.GetHangVes();
            bl = new SortableBindingList<HangVe>(hangVes);
            dgvHangVe.DataSource = bl;
            CustomDgv();

            AppState.state = Actions.NOTHING;
        }

        public override void RefreshData()
        {
            reloadData();
            Notification.Show("Làm mới danh sách Hạng vé");
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
            if (cbSearch.SelectedValue.ToString() == "MaHV") hangVes = BLL_HangVe.SearchMaHV(tbSearch.Text);
            else if (cbSearch.SelectedValue.ToString() == "TenHV") hangVes = BLL_HangVe.SearchTenHV(tbSearch.Text);
            bl = new SortableBindingList<HangVe>(hangVes);
            dgvHangVe.DataSource = bl;
        }
        #region panel Edit
        private void ActivePanelEdit(Actions x)
        {
            AppState.state = x;
            tbTenHV.Enabled = true;
            tbTiLe.Enabled = true;
            btnDelete.Enabled = false;

            btnAdd.Text = "OK";
            btnEdit.Text = "Cancel";

            btnAdd.Image = null;
            btnEdit.Image = null;
        }
        private void DisablePanelEdit()
        {
            AppState.state = Actions.NOTHING;
            tbTenHV.Enabled = false;
            tbTiLe.Enabled = false;
            btnDelete.Enabled = true;

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
            else
            {
                try
                {
                    double x = Convert.ToDouble(tbTiLe.Text);
                    if (AppState.state == Actions.ADD)
                    {
                        DisablePanelEdit();
                        BLL_HangVe.InsertHangVe(currentHV);
                        reloadData();
                    }
                    else if (AppState.state == Actions.EDIT)
                    {
                        DisablePanelEdit();
                        BLL_HangVe.UpdateHangVe(currentHV);
                        reloadData();
                    }
                }
                catch (Exception ex)
                {
                    Notification.Show(ex.Message);
                    var dialog = new frmWarning("Sai Định Dạng", "Bạn cần nhập đúng định dạng số thập phân trong TiLe");
                    dialog.ShowDialog();
                }
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
                loadEdit();
                DisablePanelEdit();
            }
        }
        private void loadEdit()
        {
            tbMaHV.Text = dgvHangVe.SelectedRows[0].Cells["strMaHV"].Value.ToString();
            tbTenHV.Text = dgvHangVe.SelectedRows[0].Cells["TenHV"].Value.ToString();
            tbTiLe.Text = dgvHangVe.SelectedRows[0].Cells["TiLe"].Value.ToString();
        }
        #endregion

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var dialog = new frmWarning("Cảnh báo!!!", "Bạn có muốn xóa hạng vé không?");
            DialogResult res = dialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                Notification.Show("Xóa hạng vé thành công");
                BLL_HangVe.DeleteHangVe(currentHV);
                reloadData();
            }
        }
    }
}
