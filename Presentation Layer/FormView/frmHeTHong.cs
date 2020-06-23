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
    public partial class frmHeTHong : CustomForm
    {
        public frmHeTHong()
        {
            InitializeComponent();
        }
        #region Other functions
        private void showDBSetup(bool _noti)
        {
            var a = Presentation_Layer.Properties.Settings.Default.ServerName;
            var b = Presentation_Layer.Properties.Settings.Default.ServerLogin;
            var c = Presentation_Layer.Properties.Settings.Default.ServerPassword;
            var d = Presentation_Layer.Properties.Settings.Default.DatabaseName;
            var dbSetup = new frmServerSetup(a, b, c, d, _noti);
            DialogResult res = dbSetup.ShowDialog();
            if (res == DialogResult.OK)
            {
                Presentation_Layer.Properties.Settings.Default.ServerName = dbSetup.serverName;
                Presentation_Layer.Properties.Settings.Default.ServerLogin = dbSetup.login;
                Presentation_Layer.Properties.Settings.Default.ServerPassword = dbSetup.password;
                Presentation_Layer.Properties.Settings.Default.DatabaseName = dbSetup.dbName;
                Presentation_Layer.Properties.Settings.Default.Save();
                
                loadInforServer();
                tbServerName.Text = Server.ServerName;
            }
        }
        private void loadInforServer()
        {
            Server.ServerName = Presentation_Layer.Properties.Settings.Default.ServerName;
            Server.Login = Presentation_Layer.Properties.Settings.Default.ServerLogin;
            Server.Password = Presentation_Layer.Properties.Settings.Default.ServerPassword;
            Server.DBName = Presentation_Layer.Properties.Settings.Default.DatabaseName;
        }
        #endregion
        private void btnEditServerName_Click(object sender, EventArgs e)
        {
            showDBSetup(false);
        }

        private void frmHeTHong_Load(object sender, EventArgs e)
        {
            tbServerName.Text = Server.ServerName;
        }
    }
}
