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
    public partial class frmServerSetup : Form
    {
        public string serverName
        {
            set
            {
                tbServerName.Text = value;
            }
            get
            {
                return tbServerName.Text;
            }
        }
        public string login
        {
            set
            {
                tbLogin.Text = value;
            }
            get
            {
                return tbLogin.Text;
            }
        }
        public string password
        {
            set
            {
                tbPassword.Text = value;
            }
            get
            {
                return tbPassword.Text;
            }
        }
        public string dbName
        {
            set
            {
                tbDBName.Text = value;
            }
            get
            {
                return tbDBName.Text;
            }
        }

        public frmServerSetup()
        {
            InitializeComponent();
            tbServerName.Focus();
        }
        public frmServerSetup(string _serverName, string _login,string _password, string _dbName)
        {
            InitializeComponent();
            serverName = _serverName;
            login = _login;
            password = _password;
            dbName = _dbName;
        }
        public frmServerSetup(string _serverName, string _login, string _password, string _dbName,bool _noti)
        {
            InitializeComponent();
            serverName = _serverName;
            login = _login;
            password = _password;
            dbName = _dbName;
            lbNoti.Visible = _noti;
        }
        private void frmServerEditing_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            button1.PerformClick();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            button2.PerformClick();
        }
    }
}
