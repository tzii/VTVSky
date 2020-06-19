using Data_Transfer_Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation_Layer.FormView
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
            lbHours.Text = DateTime.Now.ToString("HH:mm:ss");
            lbDay.Text = Fix(DateTime.Now.ToString("dddd").ToUpper());
            lbDay1.Text = "--  "+Fix(DateTime.Now.ToString("dd MMM yyy"))+"  --";
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lbHours.Text = DateTime.Now.ToString("HH:mm:ss");
            lbDay.Text = Fix(DateTime.Now.ToString("dddd").ToUpper());
            lbDay1.Text = "--  " + Fix(DateTime.Now.ToString("dd MMM yyy")) + "  --";
        }
        private string Fix(string s)
        {
            string pattern = @"[\w{1}\s](?=([\w{1}\s])+(?![\w\s]))";
            return Regex.Replace(s, pattern, "$& ");
        }
    }
}
