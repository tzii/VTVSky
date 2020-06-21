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
    public class DAL_TuyenBay
    {
        public static List<TuyenBay> GetTuyenBay()
        {
            string cmdText = @"select * from TuyenBay";
            DataTable dt = DataProvider.ExecuteReader(cmdText);
            if (dt != null && dt.Rows.Count > 0)
            {
                List<TuyenBay> TuyenBay = new List<TuyenBay>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    TuyenBay tb = new TuyenBay((int)dt.Rows[i]["MaTB"], (SanBay)dt.Rows[i]["MaSBDi"], (SanBay)dt.Rows[i]["MaSBDen"]);
                    TuyenBay.Add(tb);
                }
                return TuyenBay;
            }
            return null;
        }

        public static List<TuyenBay> SearchMaTB(string maTB)
        {
            string cmdText = String.Format("select * from TUYENBAY where MaTB like '%{0}%'", maTB == "" ? maTB : DataProvider.ConvertToInt(maTB));
            DataTable dt = DataProvider.ExecuteReader(cmdText);
            if (dt != null && dt.Rows.Count > 0)
            {
                List<TuyenBay> TuyenBay = new List<TuyenBay>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    TuyenBay tb = new TuyenBay((int)dt.Rows[i]["MaTB"], (SanBay)dt.Rows[i]["MaSBDi"], (SanBay)dt.Rows[i]["MaSBDen"]);
                    TuyenBay.Add(tb);
                }
                return TuyenBay;
            }
            return null;
        }
        public static List<TuyenBay> SearchMaSBDi(string maSBDi)
        {
            string cmdText = String.Format("select * from TUYENBAY where MaSBDi like '%{0}%'", maSBDi == "" ? maSBDi : DataProvider.ConvertToInt(maSBDi));
            DataTable dt = DataProvider.ExecuteReader(cmdText);
            if (dt != null && dt.Rows.Count > 0)
            {
                List<TuyenBay> TuyenBay = new List<TuyenBay>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    TuyenBay tb = new TuyenBay((int)dt.Rows[i]["MaTB"], (SanBay)dt.Rows[i]["MaSBDi"], (SanBay)dt.Rows[i]["MaSBDen"]);
                    TuyenBay.Add(tb);
                }
                return TuyenBay;
            }
            return null;
        }
        public static List<TuyenBay> SearchMaSBDen(string maSBDen)
        {
            string cmdText = String.Format("select * from TUYENBAY where MaSBDen like '%{0}%'", maSBDen == "" ? maSBDen : DataProvider.ConvertToInt(maSBDen));
            DataTable dt = DataProvider.ExecuteReader(cmdText);
            if (dt != null && dt.Rows.Count > 0)
            {
                List<TuyenBay> TuyenBay = new List<TuyenBay>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    TuyenBay tb = new TuyenBay((int)dt.Rows[i]["MaTB"], (SanBay)dt.Rows[i]["MaSBDi"], (SanBay)dt.Rows[i]["MaSBDen"]);
                    TuyenBay.Add(tb);
                }
                return TuyenBay;
            }
            return null;
        }
    }
}
