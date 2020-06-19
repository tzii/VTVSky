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
    public partial class frmFlightsList : Form
    {
        
        public IList<ChuyenBay> chuyenBays;
        private PanelScrollHelper scrollHelper;
        public frmFlightsList()
        {
            InitializeComponent();
        }
        #region Other functions
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
        #endregion
        private void frmFlightsList_Load(object sender, EventArgs e)
        {
            chuyenBays = new List<ChuyenBay>();
            for (int i = 0; i < 10; i++)
            {
                ChuyenBay temp = new ChuyenBay(i, new TuyenBay(1, new SanBay(1, "Nội Bài"), new SanBay(2, "Cam Ranh")), new DateTime(2020, 12, 1), 60,20,20);
                chuyenBays.Add(temp);
            }

            SortableBindingList<ChuyenBay> dddd = new SortableBindingList<ChuyenBay>(chuyenBays);
            dgvFlights.DataSource = dddd;
            dgvFlights.Columns.Add(ButtonColumn("Detail"));
            dgvFlights.Columns.Add(ButtonColumn("Edit"));
            dgvFlights.Columns.Add(ButtonColumn("Delete"));

            //Update ScrollBar
            scrollHelper = new PanelScrollHelper(pnScroll, sb, false);
            scrollHelper.UpdateScrollBar();
        }
        
        private void dgvFlights_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0) dgvFlights.Rows[e.RowIndex].Selected = true;
        }

        private void pnScroll_Resize(object sender, EventArgs e)
        {
            if (scrollHelper != null)
                scrollHelper.UpdateScrollBar();
        }
    }
}
