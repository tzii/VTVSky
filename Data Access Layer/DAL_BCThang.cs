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
        public static List<CBSource> GetNams()
        {
            string cmdText = @"select distinct NAM from BCTHANG";
            DataTable dt = DataProvider.ExecuteReader(cmdText);
            if (dt != null && dt.Rows.Count > 0)
            {
                var nams = new List<CBSource>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    nams.Add(new CBSource(dt.Rows[i]["NAM"].ToString(), dt.Rows[i]["NAM"].ToString()));
                }
                return nams;
            }
            return null;
        }
        public static List<CBSource> GetThangs(int nam)
        {
            string cmdText = string.Format("select distinct THANG from BCTHANG where NAM = {0}", nam);
            DataTable dt = DataProvider.ExecuteReader(cmdText);
            if (dt != null && dt.Rows.Count > 0)
            {
                var thangs = new List<CBSource>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    thangs.Add(new CBSource(dt.Rows[i]["THANG"].ToString(), dt.Rows[i]["THANG"].ToString()));
                }
                return thangs;
            }
            return null;
        }
    }
}
