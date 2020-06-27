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
        public static List<CTHV> GetCTHVs(int maCB)
        {
            string cmdText = String.Format("select * from CTHV where MaCB = {0}",maCB);
            DataTable dt = DataProvider.ExecuteReader(cmdText);
            if (dt != null && dt.Rows.Count > 0)
            {
                List<CTHV> cTHV = new List<CTHV>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    CTHV cthv = new CTHV((int)dt.Rows[i]["MaCB"], DAL_HangVe.GetHangVe((int)dt.Rows[i]["MaHV"]), (int)dt.Rows[i]["GiaVe"], (int)dt.Rows[i]["SLGhe"], (int)dt.Rows[i]["SLGheTrong"], (int)dt.Rows[i]["SLGheBan"]);
                    cTHV.Add(cthv);
                }
                return cTHV;
            }
            return null;
        }

        public static List<CTHV> SearchMaCB(string maCB)
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
        public static List<CTHV> SearchMaHV(string maHV)
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
        public static bool InsertCTHV(CTHV cTHV,int maCB)
        {
            string cmdText = string.Format("INSERT INTO CTHV(MaCB,MaHV,GiaVe,SLGhe,SLGheTrong,SLGheBan) VALUES ({0},{1},{2},{3},{4},{5})", maCB,cTHV.HV.maHV,cTHV.GiaVe,cTHV.SLGhe,cTHV.SLGheTrong,cTHV.SLGheBan);
            bool insert = DataProvider.ExecuteNonQuery(cmdText);
            return insert;
        }

        public static bool UpdateCTHV(CTHV cTHV)
        {
            string cmdText = string.Format("UPDATE CTHV SET GiaVe = {0},SLGhe = {1},SLGheTrong = {2},SLGheBan = {3} WHERE MaCB = {4} and MaHV = {5}", cTHV.GiaVe, cTHV.SLGhe, cTHV.SLGheTrong, cTHV.SLGheBan, cTHV.maCB, cTHV.HV.maHV);
            bool update = DataProvider.ExecuteNonQuery(cmdText);
            return update;
        }
        public static List<CTHV> GetNewCTHVs()
        {
            var hvs = DAL_HangVe.GetHangVes();
            var CTHVs = new List<CTHV>();
            for (int i = 0; i < hvs.Count; i++)
            {
                CTHV cthv = new CTHV(0, hvs[i], 0, 0, 0, 0);
                CTHVs.Add(cthv);
            }
            return CTHVs;
        }
        public static bool DeleteCTHV(int maCB)
        {
            string cmdText = string.Format("delete from CTHV where MaCB = {0}", maCB);
            bool update = DataProvider.ExecuteNonQuery(cmdText);
            return update;
        }
    }
}
