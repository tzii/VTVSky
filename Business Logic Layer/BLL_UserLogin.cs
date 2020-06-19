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
    }
}
