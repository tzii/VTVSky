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
        public static List<TuyenBay> GetTuyenBays()
        {
            string cmdText = @"select * from TuyenBay";
            DataTable dt = DataProvider.ExecuteReader(cmdText);
            if (dt != null && dt.Rows.Count > 0)
            {
                List<TuyenBay> TuyenBay = new List<TuyenBay>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    TuyenBay tb = new TuyenBay((int)dt.Rows[i]["MaTB"], DAL_SanBay.GetSanBay((int)dt.Rows[i]["MaSBDi"]), DAL_SanBay.GetSanBay((int)dt.Rows[i]["MaSBDen"]));
                    TuyenBay.Add(tb);
                }
                return TuyenBay;
            }
            return null;
        }

        public static TuyenBay GetTuyenBay(int MaTB)
        {
            string cmdText = String.Format("select * from TUYENBAY Where MaTB={0}",MaTB);
            DataTable dt = DataProvider.ExecuteReader(cmdText);
            if (dt != null && dt.Rows.Count > 0)
            {
                TuyenBay tb = new TuyenBay((int)dt.Rows[0]["MaTB"], DAL_SanBay.GetSanBay((int)dt.Rows[0]["MaSBDi"]), DAL_SanBay.GetSanBay((int)dt.Rows[0]["MaSBDen"]));
                return tb;
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
                    TuyenBay tb = new TuyenBay((int)dt.Rows[i]["MaTB"], DAL_SanBay.GetSanBay ((int)dt.Rows[i]["MaSBDi"]), DAL_SanBay.GetSanBay((int)dt.Rows[i]["MaSBDen"]));
                    TuyenBay.Add(tb);
                }
                return TuyenBay;
            }
            return null;
        }
        public static List<TuyenBay> SearchTenSBDi(string tenSBDi)
        {
            string cmdText = String.Format("select * from TUYENBAY where MaSBDi like '%{0}%'", tenSBDi == "" ? tenSBDi : DataProvider.ConvertToInt(tenSBDi));
            DataTable dt = DataProvider.ExecuteReader(cmdText);
            if (dt != null && dt.Rows.Count > 0)
            {
                List<TuyenBay> TuyenBay = new List<TuyenBay>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    TuyenBay tb = new TuyenBay((int)dt.Rows[i]["MaTB"], DAL_SanBay.GetSanBay((int)dt.Rows[i]["MaSBDi"]), DAL_SanBay.GetSanBay((int)dt.Rows[i]["MaSBDen"]));
                    TuyenBay.Add(tb);
                }
                return TuyenBay;
            }
            return null;
        }
        public static List<TuyenBay> SearchTenSBDen(string tenSBDen)
        {
            string cmdText = String.Format("select * from TUYENBAY where MaSBDen like '%{0}%'", tenSBDen == "" ? tenSBDen : DataProvider.ConvertToInt(tenSBDen));
            DataTable dt = DataProvider.ExecuteReader(cmdText);
            if (dt != null && dt.Rows.Count > 0)
            {
                List<TuyenBay> TuyenBay = new List<TuyenBay>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    TuyenBay tb = new TuyenBay((int)dt.Rows[i]["MaTB"], DAL_SanBay.GetSanBay((int)dt.Rows[i]["MaSBDi"]), DAL_SanBay.GetSanBay((int)dt.Rows[i]["MaSBDen"]));
                    TuyenBay.Add(tb);
                }
                return TuyenBay;
            }
            return null;
        }

        public static bool InsertTuyenBay(TuyenBay tuyenBay)
        {
            string cmdText = string.Format("INSERT INTO TUYENBAY(MaSBDi,MaSBDen) VALUES ({0},{1})", tuyenBay.SBDi,tuyenBay.SBDen);
            bool insert = DataProvider.ExecuteNonQuery(cmdText);
            return insert;
        }

        public static bool UpdateTuyenBay(TuyenBay tuyenBay)
        {
            string cmdText = string.Format("UPDATE TUYENBAY SET MaSBDi = {0},MaSBDen={1} WHERE MaTB = {2}",tuyenBay.SBDen,tuyenBay.SBDen,tuyenBay.maTB);
            bool update = DataProvider.ExecuteNonQuery(cmdText);
            return update;
        }
    }
}
