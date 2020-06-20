using Data_Transfer_Objects;
using Guna.UI2.WinForms;
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
    public partial class frmFlights : Form
    {
        private CustomForm currentChildForm;
        public frmFlights()
        {
            InitializeComponent();
        }

        private void frmFlights_Load(object sender, EventArgs e)
        {
            currentChildForm = new frmFlightsList();

            currentChildForm.TopLevel = false;
            currentChildForm.Dock = DockStyle.Fill;
            pnDesktop.Controls.Add(currentChildForm);
            currentChildForm.BringToFront();
            currentChildForm.Show();

            btnChuyenBay.Checked = true;
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            currentChildForm.RefreshData();
        }


    }
}
