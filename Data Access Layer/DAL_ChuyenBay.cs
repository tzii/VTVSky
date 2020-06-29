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
    public class DAL_ChuyenBay
    {
        public static List<ChuyenBay> GetChuyenBays()
        {
            string cmdText = @"select * from CHUYENBAY";
            DataTable dt = DataProvider.ExecuteReader(cmdText);
            if (dt != null && dt.Rows.Count > 0)
            {
                List<ChuyenBay> chuyenBay = new List<ChuyenBay>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ChuyenBay cb = new ChuyenBay((int)dt.Rows[i]["MaCB"], DAL_TuyenBay.GetTuyenBay((int)dt.Rows[i]["MaTB"]), (int)dt.Rows[i]["DonGia"],(DateTime)dt.Rows[i]["ThoiGian"], (int)dt.Rows[i]["ThoiLuong"], (int)dt.Rows[i]["SLGheTrong"], (int)dt.Rows[i]["SLGheDat"]);
                    chuyenBay.Add(cb);
                }
                return chuyenBay;
            }
            return null;
        }

        public static List<ChuyenBay> SearchMaCB(string maCB)
        {
            string cmdText = String.Format("select * from CHUYENBAY where MaCB like '%{0}%'", maCB == "" ? maCB : DataProvider.ConvertToInt(maCB));
            DataTable dt = DataProvider.ExecuteReader(cmdText);
            if (dt != null && dt.Rows.Count > 0)
            {
                List<ChuyenBay> chuyenBay = new List<ChuyenBay>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ChuyenBay cb = new ChuyenBay((int)dt.Rows[i]["MaCB"], DAL_TuyenBay.GetTuyenBay((int)dt.Rows[i]["MaTB"]), (int)dt.Rows[i]["DonGia"], (DateTime)dt.Rows[i]["ThoiGian"], (int)dt.Rows[i]["ThoiLuong"], (int)dt.Rows[i]["SLGheTrong"], (int)dt.Rows[i]["SLGheDat"]);
                    chuyenBay.Add(cb);
                }
                return chuyenBay;
            }
            return null;
        }

        public static List<ChuyenBay> SearchTenSBDi(string tenSBDi)
        {
            string cmdText = String.Format("select * from CHUYENBAY inner join TUYENBAY on CHUYENBAY.MATB = TUYENBAY.MATB inner join SANBAY on TUYENBAY.MASBDI = SANBAY.MASB where SANBAY.TENSB like N'%{0}%'", tenSBDi);
            DataTable dt = DataProvider.ExecuteReader(cmdText);
            if (dt != null && dt.Rows.Count > 0)
            {
                List<ChuyenBay> chuyenBay = new List<ChuyenBay>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ChuyenBay cb = new ChuyenBay((int)dt.Rows[i]["MaCB"], DAL_TuyenBay.GetTuyenBay((int)dt.Rows[i]["MaTB"]), (int)dt.Rows[i]["DonGia"], (DateTime)dt.Rows[i]["ThoiGian"], (int)dt.Rows[i]["ThoiLuong"], (int)dt.Rows[i]["SLGheTrong"], (int)dt.Rows[i]["SLGheDat"]);
                    chuyenBay.Add(cb);
                }
                return chuyenBay;
            }
            return null;
        }

        public static List<ChuyenBay> SearchTenSBDen(string tenSBDen)
        {
            string cmdText = String.Format("select * from CHUYENBAY inner join TUYENBAY on CHUYENBAY.MATB = TUYENBAY.MATB inner join SANBAY on TUYENBAY.MASBDEN = SANBAY.MASB where SANBAY.TENSB like N'%{0}%'", tenSBDen);
            DataTable dt = DataProvider.ExecuteReader(cmdText);
            if (dt != null && dt.Rows.Count > 0)
            {
                List<ChuyenBay> chuyenBay = new List<ChuyenBay>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ChuyenBay cb = new ChuyenBay((int)dt.Rows[i]["MaCB"], DAL_TuyenBay.GetTuyenBay((int)dt.Rows[i]["MaTB"]), (int)dt.Rows[i]["DonGia"], (DateTime)dt.Rows[i]["ThoiGian"], (int)dt.Rows[i]["ThoiLuong"], (int)dt.Rows[i]["SLGheTrong"], (int)dt.Rows[i]["SLGheDat"]);
                    chuyenBay.Add(cb);
                }
                return chuyenBay;
            }
            return null;
        }
        public static List<ChuyenBay> SearchThoiLuong(string thoiLuong)
        {
            string cmdText = String.Format("select * from CHUYENBAY where ThoiLuong like '%{0}%'", thoiLuong == "" ? thoiLuong : DataProvider.ConvertToInt(thoiLuong));
            DataTable dt = DataProvider.ExecuteReader(cmdText);
            if (dt != null && dt.Rows.Count > 0)
            {
                List<ChuyenBay> chuyenBay = new List<ChuyenBay>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ChuyenBay cb = new ChuyenBay((int)dt.Rows[i]["MaCB"], DAL_TuyenBay.GetTuyenBay((int)dt.Rows[i]["MaTB"]), (int)dt.Rows[i]["DonGia"], (DateTime)dt.Rows[i]["ThoiGian"], (int)dt.Rows[i]["ThoiLuong"], (int)dt.Rows[i]["SoGheTrong"], (int)dt.Rows[i]["SoGheDat"]);
                    chuyenBay.Add(cb);
                }
                return chuyenBay;
            }
            return null;
        }
        public static bool InsertChuyenBay(ChuyenBay chuyenBay)
        {
            string cmdText = string.Format("INSERT INTO CHUYENBAY(MaTB,DonGia,ThoiGian,ThoiLuong,SLGheTrong,SLGheDat) VALUES ({0},{1},'{2}',{3},{4},{5})", chuyenBay.TB.maTB,chuyenBay.DonGia,chuyenBay.ThoiGian.ToString("MM/dd/yyyy HH:mm:ss"),chuyenBay.ThoiLuong,0,chuyenBay.SoGheDat);
            bool insert = DataProvider.ExecuteNonQuery(cmdText);
            return insert;
        }

        public static bool UpdateChuyenBay(ChuyenBay chuyenBay)
        {
            string cmdText = string.Format("UPDATE CHUYENBAY SET MaTB= {0},DonGia= {1},ThoiGian= '{2}',ThoiLuong= {3},SLGheTrong= {4},SLGheDat= {5} WHERE MaCB = {6}", chuyenBay.TB.maTB, chuyenBay.DonGia, chuyenBay.ThoiGian.ToString("MM/dd/yyyy HH:mm:ss"), chuyenBay.ThoiLuong, chuyenBay.SoGheTrong, chuyenBay.SoGheDat,chuyenBay.maCB);
            bool update = DataProvider.ExecuteNonQuery(cmdText);
            return update;
        }
        public static int GetLastMaCB()
        {
            string cmdText = string.Format("select top(1) MACB from CHUYENBAY order by MACB desc");
            string res = DataProvider.ExecuteScalar(cmdText);
            try
            {
                int x = Convert.ToInt32(res);
                return x;
            }
            catch (Exception ex)
            {
                Notification.Show(ex.Message,Status.WARNING);
                return 0;
            }
        }
        public static bool CheckGhe(int maCB)
        {
            string cmdText = string.Format("select * from CHUYENBAY where MaCB = {0}",maCB);
            DataTable dt = DataProvider.ExecuteReader(cmdText);
            if (dt != null && dt.Rows.Count > 0)
            {
                if ((int)dt.Rows[0]["SLGheTrong"] > 0) return true;
                return false;
            }
            return false;
        }
    }
}
