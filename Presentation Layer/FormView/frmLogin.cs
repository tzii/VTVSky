using Business_Logic_Layer;
using Guna.UI2.AnimatorNS;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation_Layer.FormView
{
    public partial class frmLogin : Form
    {
        private List<string> ls;
        private int pos;
        #region Custom rounder boder
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        #endregion
        #region Custom shadow in boderless
        private const int CS_dropShadow = 0x00020000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle = CS_dropShadow;
                return cp;
            }
        }
        #endregion

        #region other functions
        private void saveLogin(string s, string t, bool x)
        {
            Presentation_Layer.Properties.Settings.Default.Username = s;
            Presentation_Layer.Properties.Settings.Default.Password = t;
            Presentation_Layer.Properties.Settings.Default.SaveLogin = x;
            Presentation_Layer.Properties.Settings.Default.Save();
        }
        void ResetBtnLogin()
        {
            btnLogin.Checked = false;
            btnLogin.Text = ls[0];
        }
        #endregion
        public frmLogin()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (btnLogin.Checked) return;
            btnLogin.Checked = true;
            btnLogin.Text = ls[1];
            if (tbUsername.Text == "" || tbPassword.Text == "")
            {
                lbNoti.Text = "Vui lòng nhập đầy đủ tài khoản và mật khẩu";
                lbNoti.Show();
                btnLogin.Checked = false;
                btnLogin.Text = ls[0];
                return;
            }
            if (!InvalidInfo())
            {
                lbNoti.Text = "Tài khoản và mật khẩu chỉ chứa các kí tự a-z, A-Z và 0-9";
                lbNoti.Show();
                btnLogin.Checked = false;
                btnLogin.Text = ls[0];
                return;
            }
            timer.Start();
            if (tbPassword.Text != BLL_UserLogin.GetPassword(tbUsername.Text))
            {
                saveLogin(tbUsername.Text, "", false);
                lbNoti.Text = "Sai tài khoản hoặc mật khẩu";
                lbNoti.Show();
                timer.Stop();
                btnLogin.Checked = false;
                btnLogin.Text = ls[0];
            }
            else
            {

                if (checkBox.Checked) saveLogin(tbUsername.Text, tbPassword.Text, checkBox.Checked);
                else saveLogin(tbUsername.Text, "", checkBox.Checked);

                //lbNoti.Text = "Đăng nhập thành công!";
                //lbNoti.Show();
                frmMain frm = new frmMain();
                frm.Show();
                this.BringToFront();
                backgroundWorker.RunWorkerAsync();
            }
        }
        private bool InvalidInfo()
        {
            string patternUsername = "^[a-z0-9]{3,16}$";
            string patternPassword = "^[a-z0-9]{1,20}$";
            bool resu = Regex.IsMatch(tbUsername.Text, patternUsername);
            bool resp = Regex.IsMatch(tbPassword.Text, patternPassword);
            if (Regex.IsMatch(tbUsername.Text, patternUsername) && Regex.IsMatch(tbPassword.Text, patternPassword)) return true;
            return false;
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(1000);
            int i = Convert.ToInt32(this.Opacity * 100);
            while (i >= 0)
            {
                backgroundWorker.ReportProgress(i);
                Thread.Sleep(50);
                i -= 5;
            }

        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage == 0) this.Hide();
            this.Opacity = e.ProgressPercentage / (double)100;
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            timer.Stop();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            pos = 1;
            ls = new List<string>();
            ls.Add("Login");
            ls.Add("Login .");
            ls.Add("Login . .");
            ls.Add("Login . . .");

            tbUsername.Text = global::Presentation_Layer.Properties.Settings.Default.Username;
            tbPassword.Text = global::Presentation_Layer.Properties.Settings.Default.Password;
            checkBox.Checked = global::Presentation_Layer.Properties.Settings.Default.SaveLogin;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            btnLogin.Text = ls[pos];
            pos = (pos + 1) % ls.Count;
        }
    }
}
