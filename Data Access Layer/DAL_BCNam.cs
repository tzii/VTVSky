using Data_Transfer_Objects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer
{
    public class DAL_BCNam
    {
        public static DataSet GetDataSet(int nam)
        {
            string cmdText = string.Format("select * from BCTHANG where NAM = {0}", nam);
            return DataProvider.getDataSet(cmdText);
        }
    }
}
