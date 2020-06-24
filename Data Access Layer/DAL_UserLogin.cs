using Data_Transfer_Objects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer
{
    public class DAL_UserLogin
    {
        public static string GetPassword(string username)
        {
            string cmdText = String.Format("Select PASS from USER_LOGIN where USERNAME = '{0}'", username);
            return DataProvider.ExecuteScalar(cmdText);
        }
        public static void LoadUserLogin(string username, string password)
        {
            string cmdText = String.Format("Select ID from USER_LOGIN where USERNAME = '{0}'", username);
            User.id = Convert.ToInt32(DataProvider.ExecuteScalar(cmdText));
            User.Username = username;
            User.Password = password;
        }
        public static void LoadUserPer()
        {
            if (User.Username == "#########") return;
            string cmdText = String.Format("select * from USER_PER where ID = {0}",User.id);
            DataTable dt = DataProvider.ExecuteReader(cmdText);
            if (dt != null && dt.Rows.Count > 0)
            {
                User.Per = dt.Rows[0]["Per"].ToString();
            }
        }
        public static void LoadUserInfor()
        {
            if (User.Username == "#########") return;
            string cmdText = String.Format("select * from USER_INFOR where ID = {0}", User.id);
            DataTable dt = DataProvider.ExecuteReader(cmdText);
            if (dt != null && dt.Rows.Count > 0)
            {
                User.Name = dt.Rows[0]["Name"].ToString();
                User.NgaySinh = (DateTime)dt.Rows[0]["NgaySinh"];
                User.QueQuan = dt.Rows[0]["QueQuan"].ToString();
                User.DienThoai = dt.Rows[0]["DienThoai"].ToString();
            }
        }
        public static bool UpdateUserLogin()
        {
            string cmdText = String.Format("UPDATE USER_LOGIN SET Password = '{0}' WHERE ID = {1}", User.Password,User.id);
            bool update = DataProvider.ExecuteNonQuery(cmdText);
            if (update == true)
                return true;
            return false;
        }
        public static bool UpdateUserPer()
        {
            string cmdText = String.Format("UPDATE USER_PER SET Per = '{0}' WHERE ID = {1}", User.Per, User.id);
            bool update = DataProvider.ExecuteNonQuery(cmdText);
            if (update == true)
                return true;
            return false;
        }
        public static bool UpdateUserInFor()
        {
            string cmdText = String.Format("UPDATE USER_INFOR SET Name='{0}',NgaySinh='{1}',QueQuan='{2}',DienThoai='{3}' WHERE ID = {4}", User.Name,User.NgaySinh,User.QueQuan,User.DienThoai, User.id);
            bool update = DataProvider.ExecuteNonQuery(cmdText);
            if (update == true)
                return true;
            return false;
        }
        public static bool CheckUsername(string username)
        {
            return false;
        }

    }
}
