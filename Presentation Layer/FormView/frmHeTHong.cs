using Business_Logic_Layer;
using Data_Transfer_Objects;
using Guna.UI2.WinForms;
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
using System.Windows.Forms.Design;

namespace Presentation_Layer.FormView
{
    public partial class frmHeTHong : CustomForm
    {
        Guna2Button currentEditButton;
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
        private void showWarning()
        {
            var dialog = new frmWarning("Sai Định Dạng", "Bạn cần phải nhập số vào ô");
            dialog.ShowDialog();
        }
        private void reload()
        {
            tbServerName.Text = Server.ServerName.ToString();
            tbTGBayToiThieu.Text = ThamSo.TGBayToiThieu.ToString();
            tbSLSBTG.Text = ThamSo.SLSBTG.ToString();
            tbTGDungToiThieu.Text = ThamSo.TGDungToiThieu.ToString();
            tbTGDungToiDa.Text = ThamSo.TGDungToiDa.ToString();
            tbTGDatVeChamNhat.Text = ThamSo.TGDatVeChamNhat.ToString();
            tbTGHuyDatVe.Text = ThamSo.TGHuyDatVe.ToString();
        }
        #endregion

        #region Edit Server
        private void btnEditServerName_Click(object sender, EventArgs e)
        {
            if (AppState.state != Actions.NOTHING) return;
            AppState.state = Actions.EDIT;
            showDBSetup(false);
            AppState.state = Actions.NOTHING;
        }

        private void frmHeTHong_Load(object sender, EventArgs e)
        {
            reload();
        }
        #endregion

        #region Edit Quy Định
        private void btnEditTGBayToiThieu_Click(object sender, EventArgs e)
        {
            if (AppState.state == Actions.NOTHING && currentEditButton==null)
            {
                currentEditButton = sender as Guna2Button;
                currentEditButton.Image = Presentation_Layer.Properties.Resources.accept;
                AppState.state = Actions.EDIT;
                tbTGBayToiThieu.Enabled = true;
            }
            else if (AppState.state == Actions.EDIT && currentEditButton == sender as Guna2Button)
            {
                try
                {
                    int x = Convert.ToInt32(tbTGBayToiThieu.Text);
                    tbTGBayToiThieu.Enabled = false;
                    currentEditButton.Image = Presentation_Layer.Properties.Resources.edit;
                    currentEditButton = null;
                    AppState.state = Actions.NOTHING;
                    ThamSo.TGBayToiThieu = x;
                    BLL_ThamSo.UpdateThamSo();
                }
                catch(Exception ex)
                {
                    Notification.Show(ex.Message);
                    showWarning();
                }
            }
        }

        private void btnEditSLSBTG_Click(object sender, EventArgs e)
        {
            if (AppState.state == Actions.NOTHING && currentEditButton == null)
            {
                currentEditButton = sender as Guna2Button;
                currentEditButton.Image = Presentation_Layer.Properties.Resources.accept;
                AppState.state = Actions.EDIT;
                tbSLSBTG.Enabled = true;
            }
            else if (AppState.state == Actions.EDIT && currentEditButton == sender as Guna2Button)
            {
                try
                {
                    int x = Convert.ToInt32(tbSLSBTG.Text);
                    tbSLSBTG.Enabled = false;
                    currentEditButton.Image = Presentation_Layer.Properties.Resources.edit;
                    currentEditButton = null;
                    AppState.state = Actions.NOTHING;
                    ThamSo.SLSBTG = x;
                    BLL_ThamSo.UpdateThamSo();
                }
                catch (Exception ex)
                {
                    Notification.Show(ex.Message);
                    showWarning();
                }
            }
        }

        private void btnEditTGDungToiThieu_Click(object sender, EventArgs e)
        {
            if (AppState.state == Actions.NOTHING && currentEditButton == null)
            {
                currentEditButton = sender as Guna2Button;
                currentEditButton.Image = Presentation_Layer.Properties.Resources.accept;
                AppState.state = Actions.EDIT;
                tbTGDungToiThieu.Enabled = true;
            }
            else if (AppState.state == Actions.EDIT && currentEditButton == sender as Guna2Button)
            {
                try
                {
                    int x = Convert.ToInt32(tbTGDungToiThieu.Text);
                    tbTGDungToiThieu.Enabled = false;
                    currentEditButton.Image = Presentation_Layer.Properties.Resources.edit;
                    currentEditButton = null;
                    AppState.state = Actions.NOTHING;
                    ThamSo.TGDungToiThieu = x;
                    BLL_ThamSo.UpdateThamSo();
                }
                catch (Exception ex)
                {
                    Notification.Show(ex.Message);
                    showWarning();
                }
            }
        }

        private void btnEditTGDungToiDa_Click(object sender, EventArgs e)
        {
            if (AppState.state == Actions.NOTHING && currentEditButton == null)
            {
                currentEditButton = sender as Guna2Button;
                currentEditButton.Image = Presentation_Layer.Properties.Resources.accept;
                AppState.state = Actions.EDIT;
                tbTGDungToiDa.Enabled = true;
            }
            else if (AppState.state == Actions.EDIT && currentEditButton == sender as Guna2Button)
            {
                try
                {
                    int x = Convert.ToInt32(tbTGDungToiDa.Text);
                    tbTGDungToiDa.Enabled = false;
                    currentEditButton.Image = Presentation_Layer.Properties.Resources.edit;
                    currentEditButton = null;
                    AppState.state = Actions.NOTHING;
                    ThamSo.TGDungToiDa = x;
                    BLL_ThamSo.UpdateThamSo();
                }
                catch (Exception ex)
                {
                    Notification.Show(ex.Message);
                    showWarning();
                }
            }
        }

        private void btnEditTGDatVeChamNhat_Click(object sender, EventArgs e)
        {
            if (AppState.state == Actions.NOTHING && currentEditButton == null)
            {
                currentEditButton = sender as Guna2Button;
                currentEditButton.Image = Presentation_Layer.Properties.Resources.accept;
                AppState.state = Actions.EDIT;
                tbTGDatVeChamNhat.Enabled = true;
            }
            else if (AppState.state == Actions.EDIT && currentEditButton == sender as Guna2Button)
            {
                try
                {
                    int x = Convert.ToInt32(tbTGDatVeChamNhat.Text);
                    tbTGDatVeChamNhat.Enabled = false;
                    currentEditButton.Image = Presentation_Layer.Properties.Resources.edit;
                    currentEditButton = null;
                    AppState.state = Actions.NOTHING;
                    ThamSo.TGDatVeChamNhat = x;
                    BLL_ThamSo.UpdateThamSo();
                }
                catch (Exception ex)
                {
                    Notification.Show(ex.Message);
                    showWarning();
                }
            }
        }

        private void btnEditTGHuyDatVe_Click(object sender, EventArgs e)
        {
            if (AppState.state == Actions.NOTHING && currentEditButton == null)
            {
                currentEditButton = sender as Guna2Button;
                currentEditButton.Image = Presentation_Layer.Properties.Resources.accept;
                AppState.state = Actions.EDIT;
                tbTGHuyDatVe.Enabled = true;
            }
            else if (AppState.state == Actions.EDIT && currentEditButton == sender as Guna2Button)
            {
                try
                {
                    int x = Convert.ToInt32(tbTGHuyDatVe.Text);
                    tbTGHuyDatVe.Enabled = false;
                    currentEditButton.Image = Presentation_Layer.Properties.Resources.edit;
                    currentEditButton = null;
                    AppState.state = Actions.NOTHING;
                    ThamSo.TGHuyDatVe = x;
                    BLL_ThamSo.UpdateThamSo();
                }
                catch (Exception ex)
                {
                    Notification.Show(ex.Message);
                    showWarning();
                }
            }
        }
        #endregion
        public override void RefreshData()
        {
            if (AppState.state != Actions.NOTHING) return;
            BLL_ThamSo.LoadThamSo();
            Notification.Show("Tải lại cài đặt hệ thống");
            reload();
        }
    }
}
