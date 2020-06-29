using Business_Logic_Layer;
using Data_Transfer_Objects;
using Guna.UI2.WinForms;
using Presentation_Layer.FormDigital;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation_Layer.FormView
{
    public partial class frmInfo : CustomForm
    {
        Guna2Button currentEditButton;
        public frmInfo()
        {
            InitializeComponent();
        }
        #region Other function
        private void showWarning(string title, string mess)
        {
            var dialog = new frmWarning(title, mess);
            dialog.ShowDialog();
        }
        private void reload()
        {
            lbChucVu.Text = User.Permission;
            tbHoTen.Text = User.Name;
            tbDienThoai.Text = User.DienThoai;
            tbNgaySinh.Text = User.NgaySinh.ToString("dd/MM/yyyy");
            tbQueQuan.Text = User.QueQuan;
        }
        #endregion
        private void frmInfo_Load(object sender, EventArgs e)
        {
            reload();
        }
        #region Edit Ifor
        private void btnEditHoTen_Click(object sender, EventArgs e)
        {
            if (AppState.state == Actions.NOTHING && currentEditButton == null)
            {
                currentEditButton = sender as Guna2Button;
                currentEditButton.Image = Presentation_Layer.Properties.Resources.accept;
                AppState.state = Actions.EDIT;
                tbHoTen.Enabled = true;

                this.AcceptButton = sender as Guna2Button;
            }
            else if (AppState.state == Actions.EDIT && currentEditButton == sender as Guna2Button)
            {
                try
                {
                    string x = tbHoTen.Text;
                    tbHoTen.Enabled = false;
                    currentEditButton.Image = Presentation_Layer.Properties.Resources.edit;
                    currentEditButton = null;
                    AppState.state = Actions.NOTHING;
                    User.Name = x;
                    if (BLL_UserLogin.UpdateUserInFor()) Notification.Show("Cập nhật thông tin thành công", Status.SUCCESS);

                    this.AcceptButton = null;
                }
                catch (Exception ex)
                {
                    Notification.Show(ex.Message, Status.WARNING);
                }
            }
        }

        private void btnEditSDT_Click(object sender, EventArgs e)
        {
            if (AppState.state == Actions.NOTHING && currentEditButton == null)
            {
                currentEditButton = sender as Guna2Button;
                currentEditButton.Image = Presentation_Layer.Properties.Resources.accept;
                AppState.state = Actions.EDIT;
                tbDienThoai.Enabled = true;

                this.AcceptButton = sender as Guna2Button;
            }
            else if (AppState.state == Actions.EDIT && currentEditButton == sender as Guna2Button)
            {
                try
                {
                    string x = tbDienThoai.Text;
                    string pattern = @"\d+";
                    if (Regex.IsMatch(x,pattern))
                    {
                        tbDienThoai.Enabled = false;
                        currentEditButton.Image = Presentation_Layer.Properties.Resources.edit;
                        currentEditButton = null;
                        AppState.state = Actions.NOTHING;
                        User.DienThoai = x;
                        if (BLL_UserLogin.UpdateUserInFor()) Notification.Show("Cập nhật thông tin thành công", Status.SUCCESS);

                        this.AcceptButton = null;
                    }
                    else
                    {
                        Notification.Show("Sai định dạng số điện thoại", Status.WARNING);
                        showWarning("Sai Định Dạng", "Bạn cần nhập đúng định dạng số điện thoại");
                    }
                }
                catch (Exception ex)
                {
                    Notification.Show(ex.Message, Status.WARNING);
                }
            }
        }

        private void btnEditNgaySinh_Click(object sender, EventArgs e)
        {
            if (AppState.state == Actions.NOTHING && currentEditButton == null)
            {
                currentEditButton = sender as Guna2Button;
                currentEditButton.Image = Presentation_Layer.Properties.Resources.accept;
                AppState.state = Actions.EDIT;
                tbNgaySinh.Enabled = true;

                this.AcceptButton = sender as Guna2Button;
            }
            else if (AppState.state == Actions.EDIT && currentEditButton == sender as Guna2Button)
            {
                try
                {
                    string x = tbNgaySinh.Text;
                    string pattern = @"^(?:(?:31(\/|-|\.)(?:0?[13578]|1[02]))\1|(?:(?:29|30)(\/|-|\.)(?:0?[1,3-9]|1[0-2])\2))(?:(?:1[6-9]|[2-9]\d)?\d{2})$|^(?:29(\/|-|\.)0?2\3(?:(?:(?:1[6-9]|[2-9]\d)?(?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00))))$|^(?:0?[1-9]|1\d|2[0-8])(\/|-|\.)(?:(?:0?[1-9])|(?:1[0-2]))\4(?:(?:1[6-9]|[2-9]\d)?\d{2})$";
                    if (Regex.IsMatch(x, pattern))
                    {
                        tbNgaySinh.Enabled = false;
                        currentEditButton.Image = Presentation_Layer.Properties.Resources.edit;
                        currentEditButton = null;
                        AppState.state = Actions.NOTHING;
                        User.NgaySinh = DateTime.ParseExact(x, "dd/MM/yyyy", null);
                        if (BLL_UserLogin.UpdateUserInFor()) Notification.Show("Cập nhật thông tin thành công", Status.SUCCESS);

                        this.AcceptButton = null;
                    }
                    else
                    {
                        Notification.Show("Sai định dạng ngày tháng", Status.WARNING);
                        showWarning("Sai Định Dạng", "Bạn cần nhập đúng định dạng ngày tháng");
                    }
                }
                catch (Exception ex)
                {
                    Notification.Show(ex.Message, Status.WARNING);
                    showWarning("Sai Định Dạng", "Bạn cần nhập đúng định dạng ngày tháng");
                }
            }
        }

        private void btnEditQueQuan_Click(object sender, EventArgs e)
        {
            if (AppState.state == Actions.NOTHING && currentEditButton == null)
            {
                currentEditButton = sender as Guna2Button;
                currentEditButton.Image = Presentation_Layer.Properties.Resources.accept;
                AppState.state = Actions.EDIT;
                tbQueQuan.Enabled = true;

                this.AcceptButton = sender as Guna2Button;
            }
            else if (AppState.state == Actions.EDIT && currentEditButton == sender as Guna2Button)
            {
                try
                {
                    string x = tbQueQuan.Text;
                    tbQueQuan.Enabled = false;
                    currentEditButton.Image = Presentation_Layer.Properties.Resources.edit;
                    currentEditButton = null;
                    AppState.state = Actions.NOTHING;
                    User.QueQuan = x;
                    if (BLL_UserLogin.UpdateUserInFor()) Notification.Show("Cập nhật thông tin thành công", Status.SUCCESS);

                    this.AcceptButton = null;
                }
                catch (Exception ex)
                {
                    Notification.Show(ex.Message, Status.WARNING);
                }
            }
        }
        #endregion

        public override void RefreshData()
        {
            if (AppState.state != Actions.NOTHING) return;
            BLL_UserLogin.LoadUserInfor();
            Notification.Show("Tải lại thông tin người dùng",Status.SUCCESS);
            reload();
        }
    }
}
