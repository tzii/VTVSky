using Data_Transfer_Objects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Data_Transfer_Objects
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


            return true;
        }

        public static bool UpdateSanBay(SanBay sanBay)
        {
            return true;
        }
        public static bool DeleteSanBay(SanBay sanBay)
        {
            return true;
        }
    }
}
