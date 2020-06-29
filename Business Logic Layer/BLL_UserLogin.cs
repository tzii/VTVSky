using Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_Layer
{
    public class BLL_UserLogin
    {
        public static string GetPassword(string username)
        {
            return DAL_UserLogin.GetPassword(username);
        }
        public static void LoadUserLogin(string username, string password)
        {
            DAL_UserLogin.LoadUserLogin(username, password);
        }
        public static void LoadUserPer()
        {
            DAL_UserLogin.LoadUserPer();
        }
        public static void LoadUserInfor()
        {
            DAL_UserLogin.LoadUserInfor();
        }
        public static bool UpdateUserLogin()
        {
            return DAL_UserLogin.UpdateUserLogin();
        }
        public static bool UpdateUserPer()
        {
            return DAL_UserLogin.UpdateUserPer();
        }
        public static bool UpdateUserInFor()
        {
            return DAL_UserLogin.UpdateUserInFor();
        }
        public static bool CheckUsername(string username)
        {
            return DAL_UserLogin.CheckUsername(username);
        }
    }
}
