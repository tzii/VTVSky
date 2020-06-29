using Data_Transfer_Objects;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer
{
     public class DAL_IdenMaVe
    {
        public static int GetNewMaVe()
        {
            string cmdText = string.Format("select top(1) MaVe from IDENMAVE order by mave desc");
            string x = DataProvider.ExecuteScalar(cmdText);
            try
            {
                int res = Convert.ToInt32(x);
                return res;
            }
            catch (Exception ex)
            {
                Notification.Show(ex.Message,Status.WARNING);
                return 0;
            }
        }
        public static bool ClearIden()
        {
            string cmdText = string.Format("delete from IDENMAVE");
            bool res = DataProvider.ExecuteNonQuery(cmdText);

            cmdText = string.Format("insert into IDENMAVE(A) values(0)");
            res = DataProvider.ExecuteNonQuery(cmdText) && res;

            return res;
        }
    }
}
