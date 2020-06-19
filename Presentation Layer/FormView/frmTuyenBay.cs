using Data_Transfer_Objects;
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
    public partial class frmTuyenBay : CustomForm
    {
        public frmTuyenBay()
        {
            InitializeComponent();
        }
        public override void RefreshData()
        {
            Notification.Show("Refresh Tuyen Bay");
        }
    }
}
