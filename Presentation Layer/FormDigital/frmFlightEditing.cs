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

namespace Presentation_Layer.FormDigital
{
    public partial class frmFlightEditing : Form
    {
        private DataGridViewScrollHelper scrollHelper;
        public frmFlightEditing()
        {
            InitializeComponent();
            dgvFlights.Columns["STT"].Width = 50;
            dgvFlights.Columns["TGDung"].Width = 200;
            dgvFlights.Columns["SBTG"].Width = 200;
            dgvFlights.Columns["Edit"].Width = 50;
        }

        private void frmFlightEditing_Load(object sender, EventArgs e)
        {
            scrollHelper = new DataGridViewScrollHelper(dgvFlights, sb, true);
            guna2ShadowForm1.SetShadowForm(this);
            scrollHelper.UpdateScrollBar();
        }

        private void guna2NumericUpDown4_Enter(object sender, EventArgs e)
        {
            //guna2NumericUpDown4.
            //textBox1.SelectAll();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void guna2NumericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void gunaLabel3_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gunaLabel14_Click(object sender, EventArgs e)
        {

        }
    }
}
