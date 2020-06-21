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
    public class DAL_CTHV
    {
        public static List<CTHV> GetCTHV()
        {
            string cmdText = @"select * from CTHV";
            DataTable dt = DataProvider.ExecuteReader(cmdText);
            if (dt != null && dt.Rows.Count > 0)
            {
                List<CTHV> cTHV = new List<CTHV>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    CTHV cthv = new CTHV((int)dt.Rows[i]["MaCB"], (HangVe)dt.Rows[i]["MaHV"], (int)dt.Rows[i]["GiaVe"], (int)dt.Rows[i]["SLGhe"], (int)dt.Rows[i]["SLGheTrong"], (int)dt.Rows[i]["SLGheBan"]);
                    cTHV.Add(cthv);
                }
                return cTHV;
            }
            return null;
        }

        public static List<CTCB> SearchMaCB(string maCB)
        {
            string cmdText = String.Format("select * from CTHV where MaCB like '%{0}%'", maCB == "" ? maCB : DataProvider.ConvertToInt(maCB));
            DataTable dt = DataProvider.ExecuteReader(cmdText);
            if (dt != null && dt.Rows.Count > 0)
            {
                List<CTHV> cTHV = new List<CTHV>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    CTHV cthv = new CTHV((int)dt.Rows[i]["MaCB"], (HangVe)dt.Rows[i]["MaHV"], (int)dt.Rows[i]["GiaVe"], (int)dt.Rows[i]["SLGhe"], (int)dt.Rows[i]["SLGheTrong"], (int)dt.Rows[i]["SLGheBan"]);
                    cTHV.Add(cthv);
                }
                return cTHV;
            }
            return null;
        }
        public static List<CTCB> SearchMaHV(string maHV)
        {
            string cmdText = String.Format("select * from CTHV where MaCB like '%{0}%'", maHV == "" ? maHV : DataProvider.ConvertToInt(maHV));
            DataTable dt = DataProvider.ExecuteReader(cmdText);
            if (dt != null && dt.Rows.Count > 0)
            {
                List<CTHV> cTHV = new List<CTHV>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    CTHV cthv = new CTHV((int)dt.Rows[i]["MaCB"], (HangVe)dt.Rows[i]["MaHV"], (int)dt.Rows[i]["GiaVe"], (int)dt.Rows[i]["SLGhe"], (int)dt.Rows[i]["SLGheTrong"], (int)dt.Rows[i]["SLGheBan"]);
                    cTHV.Add(cthv);
                }
                return cTHV;
            }
            return null;
        }
    }
}
