using Data_Transfer_Objects;
using System;
using System.Collections.Generic;
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
    }
}
