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
    public partial class frmInfo : CustomForm
    {
        public frmInfo()
        {
            InitializeComponent();
        }

        private void frmInfo_Load(object sender, EventArgs e)
        {
            string x = User.Name;
            lbChucVu.Text = User.Permission;
            tbHoTen.Text = User.Name;
            tbDienThoai.Text = User.DienThoai;
            tbNgaySinh.Text = User.NgaySinh.ToString("dd/MM/yyyy");
            tbQueQuan.Text = User.QueQuan;
        }
    }
}
