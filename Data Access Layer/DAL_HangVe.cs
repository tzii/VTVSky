using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Transfer_Objects;
using System.Data;
using System.Net;
using System.Runtime.InteropServices.WindowsRuntime;


namespace namespace Data_Access_Layer
{
    public class DAL_HangVe
    {
        public static List<HangVe> GetHangVe()
        {
            string cmdText = @"select * from HANGVE";
            DataTable dt = DataProvider.ExecuteReader(cmdText);
            if (dt != null && dt.Rows.Count > 0)
            {
                List<HangVe> HangVe = new List<HangVe>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    HangVe hv = new HangVe((int)dt.Rows[i]["MaHV"], dt.Rows[i]["TenHV"].ToString(), (float)dt.Rows[i]["TiLe"]);
                    HangVe.Add(hv);
                }
                return HangVe;
            }
            return null;
        }

        public static List<HangVe> SearchMaHV(string maHV)
        {
            string cmdText = String.Format("select * from HangVe where MaHV like '%{0}%'", maHV == "" ? maHV : DataProvider.ConvertToInt(maHV));
            DataTable dt = DataProvider.ExecuteReader(cmdText);
            if (dt != null && dt.Rows.Count > 0)
            {
                List<HangVe> HangVe = new List<HangVe>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    HangVe hv = new HangVe((int)dt.Rows[i]["MaHV"], dt.Rows[i]["TenHV"].ToString(), (float)dt.Rows[i]["TiLe"]);
                    HangVe.Add(hv);
                }
                return HangVe;
            }
            return null;
        }

        public static List<HangVe> SearchTenHV(string tenHV)
        {
            string cmdText = String.Format("select * from HangVe where TenHV like N'%{0}%'", tenHV);
            DataTable dt = DataProvider.ExecuteReader(cmdText);
            if (dt != null && dt.Rows.Count > 0)
            {
                List<HangVe> HangVe = new List<HangVe>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    HangVe hv = new HangVe((int)dt.Rows[i]["MaHV"], dt.Rows[i]["TenHV"].ToString(), (float)dt.Rows[i]["TiLe"]);
                    HangVe.Add(hv);
                }
                return HangVe;
            }
            return null;
        }
    }
}

