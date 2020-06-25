using Data_Transfer_Objects;
using Data_Access_Layer;
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
    public class DAL_SanBay
    {
        public static List<SanBay> GetSanBays()
        {
            string cmdText = @"select * from SANBAY";
            DataTable dt = DataProvider.ExecuteReader(cmdText);
            if (dt != null && dt.Rows.Count > 0)
            {
                List<SanBay> sanBays = new List<SanBay>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    SanBay sb = new SanBay((int)dt.Rows[i]["MaSB"], dt.Rows[i]["TenSB"].ToString());
                    sanBays.Add(sb);
                }
                return sanBays;
            }
            return null;
        }

        public static SanBay GetSanBay(int MaSB)
        {
            string cmdText = String.Format("select * from SANBAY Where MaSB={0}",MaSB);
            DataTable dt = DataProvider.ExecuteReader(cmdText);
            if (dt != null&&dt.Rows.Count > 0)
            {
                SanBay sb = new SanBay((int)dt.Rows[0]["MaSB"], dt.Rows[0]["TenSB"].ToString());
                return sb;
            }
            return null;
        }

        public static List<SanBay> SearchMaSB(string maSB)
        {
            string cmdText = String.Format("select * from SANBAY where MaSB like '%{0}%'",maSB ==""?maSB:DataProvider.ConvertToInt(maSB));
            DataTable dt = DataProvider.ExecuteReader(cmdText);
            if (dt != null && dt.Rows.Count > 0)
            {
                List<SanBay> sanBays = new List<SanBay>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    SanBay sb = new SanBay((int)dt.Rows[i]["MaSB"], dt.Rows[i]["TenSB"].ToString());
                    sanBays.Add(sb);
                }
                return sanBays;
            }
            return null;
        }

        public static List<SanBay> SearchTenSB(string tenSB)
        {
            string cmdText = String.Format("select * from SANBAY where TenSB like N'%{0}%'", tenSB);
            DataTable dt = DataProvider.ExecuteReader(cmdText);
            if (dt != null && dt.Rows.Count > 0)
            {
                List<SanBay> sanBays = new List<SanBay>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    SanBay sb = new SanBay((int)dt.Rows[i]["MaSB"], dt.Rows[i]["TenSB"].ToString());
                    sanBays.Add(sb);
                }
                return sanBays;
            }
            return null;
        }
        public static bool InsertSanBay(SanBay sanBay)
        {
            string cmdText = string.Format("INSERT INTO SANBAY(TenSB) VALUES (N'{0}')", sanBay.TenSB);
            bool insert = DataProvider.ExecuteNonQuery(cmdText);
            return insert;
        }

        public static bool UpdateSanBay(SanBay sanBay)
        {
            string cmdText = string.Format("UPDATE SANBAY SET TenSB = N'{0}' WHERE MaSB = {1}", sanBay.TenSB,sanBay.maSB);
            bool update = DataProvider.ExecuteNonQuery(cmdText);
            return update;
        }
        public static bool DeleteSanBay(SanBay sanBay)
        {
            string cmdText = string.Format("DELETE FROM SANBAY WHERE MaSB = {0})", sanBay.maSB);
            bool delete = DataProvider.ExecuteNonQuery(cmdText);
            return delete;
        }
    }
}
