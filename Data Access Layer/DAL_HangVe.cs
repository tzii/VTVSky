using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Transfer_Objects;
using System.Data;
using System.Net;
using System.Runtime.InteropServices.WindowsRuntime;


namespace Data_Access_Layer
{
    public class DAL_HangVe
    {
        public static List<HangVe> GetHangVes()
        {
            string cmdText = @"select * from HANGVE where ISDELETE = 0";
            DataTable dt = DataProvider.ExecuteReader(cmdText);
            if (dt != null && dt.Rows.Count > 0)
            {
                List<HangVe> HangVe = new List<HangVe>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    HangVe hv = new HangVe((int)dt.Rows[i]["MaHV"], dt.Rows[i]["TenHV"].ToString(), (double)dt.Rows[i]["TiLe"]);
                    HangVe.Add(hv);
                }
                return HangVe;
            }
            return null;
        }

        public static HangVe GetHangVe(int MaHV)
        {
            string cmdText = String.Format("select * from HANGVE Where MaHV={0}",MaHV);
            DataTable dt = DataProvider.ExecuteReader(cmdText);
            if (dt != null && dt.Rows.Count > 0)
            {
                HangVe hv = new HangVe((int)dt.Rows[0]["MaHV"], dt.Rows[0]["TenHV"].ToString(), (double)dt.Rows[0]["TiLe"]);
                return hv;
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
                    HangVe hv = new HangVe((int)dt.Rows[i]["MaHV"], dt.Rows[i]["TenHV"].ToString(), (double)dt.Rows[i]["TiLe"]);
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
                    HangVe hv = new HangVe((int)dt.Rows[i]["MaHV"], dt.Rows[i]["TenHV"].ToString(), (double)dt.Rows[i]["TiLe"]);
                    HangVe.Add(hv);
                }
                return HangVe;
            }
            return null;
        }
        public static bool InsertHangVe(HangVe hangVe)
        {
            string cmdText = string.Format("INSERT INTO HANGVE(TenHV,TiLe,ISDELETE) VALUES (N'{0}',{1},{2})", hangVe.TenHV,hangVe.TiLe,0);
            bool insert = DataProvider.ExecuteNonQuery(cmdText);
            return insert;
        }

        public static bool UpdateHangVe(HangVe hangVe)
        {
            string cmdText = string.Format("UPDATE HANGVE SET TenHV = N'{0}',TiLe={1} WHERE MaHV = {2}", hangVe.TenHV,hangVe.TiLe,hangVe.maHV);
            bool update = DataProvider.ExecuteNonQuery(cmdText);
            return update;
        }
        public static bool DeleteHangVe (HangVe hv)
        {
            string cmdText = string.Format("Update HANGVE set ISDELETE = 1 where MaHV = {0}", hv.maHV);
            bool res = DataProvider.ExecuteNonQuery(cmdText);
            return res;
        }
    }
}

