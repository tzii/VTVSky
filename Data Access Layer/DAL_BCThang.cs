using Data_Transfer_Objects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer
{
    public class DAL_BCThang
    {
        public static DataSet GetDataSet(int thang, int nam)
        {
            string cmdText = string.Format("select * from CTBCTHANG where THANG = {0} and NAM = {1}", thang,nam);
            return DataProvider.getDataSet(cmdText);
        }
    }
}
