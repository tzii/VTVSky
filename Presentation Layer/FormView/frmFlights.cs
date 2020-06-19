using Data_Transfer_Objects;
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
    public partial class frmFlights : Form
    {
        private Form currentChildForm;
        public frmFlights()
        {
            InitializeComponent();
            currentChildForm = new frmFlightsList();
            currentChildForm.TopLevel = false;
            currentChildForm.Dock = DockStyle.Fill;
            pnView.Controls.Add(currentChildForm);
            currentChildForm.BringToFront();
            currentChildForm.Show();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            var frm = new frmSuccess();
            DialogResult res = frm.ShowDialog();
            if (res == DialogResult.OK)
            {
                Notification.Show("OK");
            }
            else if (res == DialogResult.Cancel)
            {
                Notification.Show("Cancel");
            }
        }

        private void licensing1_Load(object sender, EventArgs e)
        {

        }
    }
}
