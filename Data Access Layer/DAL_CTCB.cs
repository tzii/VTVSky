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
        public static bool InsertCTCB(CTCB cTCB)
        {
            string cmdText = string.Format("INSERT INTO CTCB(MaCB,MaSBTG,TGDung,GhiChu) VALUES ('{0}','{1}','{2}','{3}')", cTCB.maCB,cTCB.SBTG,cTCB.TGDung,cTCB.GhiChu);
            bool insert = DataProvider.ExecuteNonQuery(cmdText);
            if (insert == true)
                return true;
            return false;
        }

        public static bool UpdateCTCB(CTCB cTCB)
        {
            string cmdText = string.Format("UPDATE CTCB SET TGDung= '{0}',GhiChu= '{1}' WHERE MaCB = {2} and MaSBTG = {3}", cTCB.TGDung, cTCB.GhiChu, cTCB.maCB, cTCB.SBTG);
            bool update = DataProvider.ExecuteNonQuery(cmdText);
            if (update == true)
                return true;
            return false;
        }
    }
}
