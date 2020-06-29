using Business_Logic_Layer;
using Data_Transfer_Objects;
using Guna.UI2.WinForms.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation_Layer.FormDigital
{
    public partial class frmFlightEditing : Form
    {
        public ChuyenBay chuyenBay;
        public List<CTHV> cthvs;
        public TuyenBay currentTB
        {
            get
            {
                return BLL_TuyenBay.GetTuyenBay((int)cbSBDi.SelectedValue, (int)cbSBDen.SelectedValue);
            }
        }
        public CTCB currentCTCB
        {
            get
            {
                int maCB = 0;
                if (ctcbs.Count>0) maCB = (int)dgvCTCB.SelectedRows[0].Cells["MaCB"].Value;
                SanBay sb = BLL_SanBay.GetSanBay((int)cbSBTG.SelectedValue);
                int tgDung = Convert.ToInt32(nTGDung.Value);
                string gc = tbGhiChu.Text;
                return new CTCB(maCB, sb, tgDung, gc);
            }
        }
        public CTCB lastCTCB
        {
            get
            {
                int maCB = (int)dgvCTCB.SelectedRows[0].Cells["MaCB"].Value;
                int sb = ((SanBay)dgvCTCB.SelectedRows[0].Cells["SBTG"].Value).maSB;
                for (int i = 0; i < ctcbs.Count; i++)
                {
                    if (ctcbs[i].maCB == maCB && ctcbs[i].SBTG.maSB == sb)
                    {
                        return ctcbs[i];
                    }
                }
                return null;
            }
        }
        public List<CTCB> ctcbs;
        private DataGridViewScrollHelper scrollHelper;
        private List<SanBay> dsSBDi;
        private List<SanBay> dsSBDen;
        private List<SanBay> sbtgs;
        private bool onloading;
        private Actions state;
        private List<HangVe> hvs;
        #region Other Function
        private void checkState()
        {
            if (AppState.state != Actions.EDIT && AppState.state != Actions.ADD)
            {
                Notification.Show(AppState.state.ToString());
                nGiaVe.Enabled = false;
                cbSBDi.Enabled = false;
                cbSBDen.Enabled = false;
                dtpNgay.Enabled = false;
                dtpGio.Enabled = false;
                nSLGhe1.Enabled = false;
                nSLGhe2.Enabled = false;
                nTGBayH.Enabled = false;
                nTGBayM.Enabled = false;
                btnAdd.Enabled = false;

            }
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
        private void activeEdit()
        {
            cbSBTG.Enabled = true;
            nTGDung.Enabled = true;
            tbGhiChu.Enabled = true;
            btnCC.Enabled = true;
            btnAdd.Text = "OK";
        }
        private void disableEdit()
        {
            cbSBTG.Enabled = false;
            nTGDung.Enabled = false;
            tbGhiChu.Enabled = false;
            btnCC.Enabled = false;
            btnAdd.Text = "Add";
        }
        private bool checkSBTG(int maSB)
        {
            if (ctcbs.Count == 0) return false;
            if (state == Actions.ADD)
            {
                for (int i = 0; i < ctcbs.Count; i++)
                {
                    if (ctcbs[i].SBTG.maSB == maSB) return true;
                }
                return false;
            }
            else
            {
                for (int i = 0; i < ctcbs.Count; i++)
                {
                    if (ctcbs[i].SBTG.maSB == maSB && ctcbs[i].SBTG.maSB != ((SanBay)dgvCTCB.SelectedRows[0].Cells["SBTG"].Value).maSB) return true;
                }
                return false;
            }
        }
        #endregion
        public frmFlightEditing()
        {
            onloading = true;
            InitializeComponent();
            checkState();
            loadData();
            cthvs = BLL_CTHV.GetNewCTHVs();
            ctcbs = new List<CTCB>();
            loaddgv();
        }
        public frmFlightEditing(ChuyenBay cb)
        {
            onloading = true;
            chuyenBay = cb;
            InitializeComponent();
            checkState();
            loadData();
            cthvs = BLL_CTHV.GetCTHVs(chuyenBay.maCB);
            ctcbs = BLL_CTCB.GetCTCBs(chuyenBay.maCB);

            tbMaCB.Text = chuyenBay.strMaCB;
            nGiaVe.Value = chuyenBay.DonGia;
            cbSBDi.SelectedValue = chuyenBay.TB.SBDi.maSB;
            cbSBDen.SelectedValue = chuyenBay.TB.SBDen.maSB;
            dtpNgay.Value = chuyenBay.ThoiGian;
            dtpGio.Value = chuyenBay.ThoiGian;
            nTGBayH.Value = chuyenBay.ThoiLuong / 60;
            nTGBayM.Value = chuyenBay.ThoiLuong % 60;
            nSLGhe1.Value = cthvs[0].SLGhe;
            nSLGhe2.Value = cthvs[1].SLGhe;

            // thông tin chuyến bay trung gian
            loaddgv();

            //TuyenBay tb = new TuyenBay();
            //int donGia = Convert.ToInt32(nGiaVe.Value);
            //DateTime tg = dtpNgay.Value.Date + dtpGio.Value.TimeOfDay;
            //int tl = Convert.ToInt32(nTGBayH.Value * 60 + nTGBayM.Value);
            //int sg = Convert.ToInt32(nSLGhe1.Value + nSLGhe2.Value);
        }

        private void frmFlightEditing_Load(object sender, EventArgs e)
        {
            scrollHelper = new DataGridViewScrollHelper(dgvCTCB, sb, true);
            guna2ShadowForm1.SetShadowForm(this);
            scrollHelper.UpdateScrollBar();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (chuyenBay == null) chuyenBay = new ChuyenBay();
            chuyenBay.TB = currentTB;
            chuyenBay.DonGia = Convert.ToInt32(nGiaVe.Value);
            chuyenBay.ThoiGian = new DateTime(dtpNgay.Value.Year, dtpNgay.Value.Month, dtpNgay.Value.Day, dtpGio.Value.Hour, dtpGio.Value.Minute, 0);
            chuyenBay.ThoiLuong = Convert.ToInt32(nTGBayH.Value * 60 + nTGBayM.Value);
            chuyenBay.SoGheTrong = Convert.ToInt32(nSLGhe1.Value + nSLGhe2.Value);
            
            if (chuyenBay.DonGia <=10000)
            {
                lbNoti.Text = "Giá vé phải lớn hơn 10000";
                lbNoti.Visible = true;
                return;
            }
            if (chuyenBay.TB == null)
            {
                lbNoti.Text = "Bạn cần phải chọn sân bay đi và sân bay đến";
                lbNoti.Visible = true;
                return;
            }
            if (chuyenBay.ThoiGian < DateTime.Now)
            {
                lbNoti.Text = "Thời gian xuất phát không hợp lệ";
                lbNoti.Visible = true;
                return;
            }
            if (chuyenBay.ThoiLuong < ThamSo.TGBayToiThieu)
            {
                lbNoti.Text = "Thời gian bay tối thiểu là " + ThamSo.TGBayToiThieu+ " phút";
                lbNoti.Visible = true;
                return;
            }


            cthvs[0].SLGheTrong = Convert.ToInt32(nSLGhe1.Value);
            cthvs[1].SLGheTrong = Convert.ToInt32(nSLGhe2.Value);
            
            cthvs[0].GiaVe = Convert.ToInt32(chuyenBay.DonGia * hvs[0].TiLe);
            cthvs[1].GiaVe = Convert.ToInt32(chuyenBay.DonGia * hvs[1].TiLe);

            cthvs[0].SLGhe = Convert.ToInt32(nSLGhe1.Value);
            cthvs[1].SLGhe = Convert.ToInt32(nSLGhe2.Value);

            button1.PerformClick();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            button2.PerformClick();
        }
        private void loadData()
        {
            hvs = BLL_HangVe.GetHangVes();
            dsSBDi = BLL_SanBay.GetSanBays();
            if (chuyenBay == null) dsSBDen = BLL_SanBay.GetSanBays();
            else dsSBDen = BLL_TuyenBay.GetSanBaysFrom(chuyenBay.TB.SBDi.maSB);
            sbtgs = BLL_SanBay.GetSanBays();

            cbSBDi.DisplayMember = "TenSB";
            cbSBDi.ValueMember = "MaSB";
            cbSBDen.DisplayMember = "TenSB";
            cbSBDen.ValueMember = "MaSB";
            cbSBTG.DisplayMember = "TenSB";
            cbSBTG.ValueMember = "MaSB";

            cbSBTG.DataSource = sbtgs;
            cbSBDi.DataSource = dsSBDi;
            cbSBDen.DataSource = dsSBDen;

            onloading = false;
            state = Actions.NOTHING;

            dtpNgay.Value = DateTime.Now;
        }

        private void cbSBDi_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (onloading) return;
            dsSBDen = BLL_TuyenBay.GetSanBaysFrom((int)cbSBDi.SelectedValue);
            cbSBDen.DataSource = dsSBDen;
        }
        private void cbSBDen_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (onloading) return;
            sbtgs = BLL_SanBay.GetSanBaysExcept(currentTB);
            cbSBTG.DataSource = sbtgs;
        }
        private void loaddgv()
        {
            dgvCTCB.DataSource = ctcbs;
            dgvCTCB.Columns["MaCB"].Visible = false;
            dgvCTCB.Columns["strMaCB"].Visible = false;
            dgvCTCB.Columns["SBTG"].Visible = false;

            dgvCTCB.Columns["TenSBTG"].HeaderText = "Sân bay trung gian";
            dgvCTCB.Columns["TGDung"].HeaderText = "Thời gian dừng\n(m)";
            dgvCTCB.Columns["GhiChu"].HeaderText = "Ghi Chú";

            dgvCTCB.Columns["TGDung"].Width = 150;
            dgvCTCB.Columns["TGDung"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            if (AppState.state == Actions.EDIT || AppState.state == Actions.ADD)
            {
                dgvCTCB.Columns.Add(ButtonColumn("Edit"));
                dgvCTCB.Columns.Add(ButtonColumn("Delete"));
            }
        }

        private void dgvCTCB_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 0 && state == Actions.NOTHING)
            {
                Notification.Show(ctcbs[0].TGDung + "");
                state = Actions.EDIT;
                activeEdit();
            }
            else if (e.ColumnIndex ==1 && state == Actions.NOTHING)
            {
                int x = e.RowIndex;
                CTCB y = ctcbs[x];
                ctcbs.Remove(ctcbs[x]);
                List<CTCB> listctcb = new List<CTCB>();
                listctcb.AddRange(ctcbs);
                ctcbs = listctcb;
                dgvCTCB.DataSource = ctcbs;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (state == Actions.NOTHING)
            {
                if (ctcbs.Count > ThamSo.SLSBTG)
                {
                    lbNoti.Text = "Số lượng sân bay trung gian là " + ThamSo.SLSBTG;
                    lbNoti.Visible = true;
                    return;
                }
                state = Actions.ADD;
                activeEdit();
            }
            else if (state == Actions.EDIT)
            {
                if (checkSBTG((int)cbSBTG.SelectedValue))
                {
                    lbNoti.Text = "Sân bay này đã có trong bảng";
                    lbNoti.Visible = true;
                    return;
                }
                if (nTGDung.Value<ThamSo.TGDungToiThieu || nTGDung.Value > ThamSo.TGDungToiDa)
                {
                    lbNoti.Text = "Thời gian dừng từ " + ThamSo.TGDungToiThieu + " đến " + ThamSo.TGDungToiDa + " phút";
                    lbNoti.Visible = true;
                    return;
                }
                state = Actions.NOTHING;
                lastCTCB.SBTG = cbSBTG.SelectedItem as SanBay;
                lastCTCB.TGDung = Convert.ToInt32(nTGDung.Value);
                lastCTCB.GhiChu = tbGhiChu.Text;
                dgvCTCB.Refresh();

                disableEdit();

            }
            else if (state == Actions.ADD)
            {
                if (checkSBTG((int)cbSBTG.SelectedValue))
                {
                    lbNoti.Text = "Sân bay này đã có trong bảng";
                    lbNoti.Visible = true;
                    return;
                }
                if (nTGDung.Value < ThamSo.TGDungToiThieu || nTGDung.Value > ThamSo.TGDungToiDa)
                {
                    lbNoti.Text = "Thời gian dừng từ " + ThamSo.TGDungToiThieu + " đến " + ThamSo.TGDungToiDa + " phút";
                    lbNoti.Visible = true;
                    return;
                }
                state = Actions.NOTHING;
                ctcbs.Add(currentCTCB);
                List<CTCB> listctcb = new List<CTCB>();
                listctcb.AddRange(ctcbs);
                ctcbs = listctcb;
                dgvCTCB.DataSource = ctcbs;
                dgvCTCB.Refresh();
                Notification.Show(dgvCTCB.RowCount + "");
                disableEdit();
            }
        }

        private void dgvCTCB_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCTCB.SelectedRows != null && dgvCTCB.SelectedRows.Count > 0)
            {
                try
                {
                    //cbSBTG.SelectedValue = ((SanBay)dgvCTCB.SelectedRows[0].Cells["SBTG"].Value).maSB;
                }
                catch (Exception ex)
                {
                    Notification.Show(ex.Message);

                }
                nTGDung.Value = (int)dgvCTCB.SelectedRows[0].Cells["TGDung"].Value;
                tbGhiChu.Text = dgvCTCB.SelectedRows[0].Cells["GhiChu"].Value.ToString();
            }
        }
        private void cbSBTG_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (onloading || state == Actions.NOTHING) return;
            if (checkSBTG((int)cbSBTG.SelectedValue))
            {
                lbNoti.Text = "Sân bay này đã có trong bảng";
                lbNoti.Visible = true;
            }
            else lbNoti.Visible = false;
        }

        private void btnCC_Click(object sender, EventArgs e)
        {
            state = Actions.NOTHING;
            disableEdit();
        }
    }
}
