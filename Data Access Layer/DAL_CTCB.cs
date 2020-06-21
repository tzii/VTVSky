using Data_Transfer_Objects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer
{
    public class DAL_CTCB
    {
        public static List<CTCB> GetCTCB()
        {
            string cmdText = @"select * from CTCB";
            DataTable dt = DataProvider.ExecuteReader(cmdText);
            if (dt != null && dt.Rows.Count > 0)
            {
                List<CTCB> cTCB = new List<CTCB>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    CTCB ctcb = new CTCB((int)dt.Rows[i]["MaCB"], (SanBay)dt.Rows[i]["MaSBTG"], (int)dt.Rows[i]["TGDung"], dt.Rows[i]["GhiChu"].ToString());
                    cTCB.Add(ctcb);
                }
                return cTCB;
            }
            return null;
        }

        public static List<CTCB> SearchMaCB(int maCB)
        {
            string cmdText = String.Format("select * from CTCB where MaCB = %{0}%", maCB);
            DataTable dt = DataProvider.ExecuteReader(cmdText);
            if (dt != null && dt.Rows.Count > 0)
            {
                List<CTCB> cTCB = new List<CTCB>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    CTCB ctcb = new CTCB((int)dt.Rows[i]["MaCB"], (SanBay)dt.Rows[i]["MaSBTG"], (int)dt.Rows[i]["TGDung"], dt.Rows[i]["GhiChu"].ToString());
                    cTCB.Add(ctcb);
                }
                return cTCB;
            }
            return null;
        }
    }
}
