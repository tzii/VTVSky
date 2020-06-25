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
            string cmdText = String.Format("select * from CHUYENBAY where MaSBDI like '%{0}%'", tenSBDi == "" ? tenSBDi : DataProvider.ConvertToInt(tenSBDi));
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
            string cmdText = String.Format("select * from CHUYENBAY where MaSBDen like '%{0}%'", tenSBDen == "" ? tenSBDen : DataProvider.ConvertToInt(tenSBDen));
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
            string cmdText = string.Format("INSERT INTO CHUYENBAY(MaTB,DonGia,ThoiGian,ThoiLuong,SoGheTrong,SoGheDat) VALUES ({0},{1},'{2}',{3},{4},{5})", chuyenBay.TB,chuyenBay.DonGia,chuyenBay.ThoiGian,chuyenBay.ThoiLuong,chuyenBay.SoGheTrong,chuyenBay.SoGheDat);
            bool insert = DataProvider.ExecuteNonQuery(cmdText);
            return insert;
        }

        public static bool UpdateChuyenBay(ChuyenBay chuyenBay)
        {
            string cmdText = string.Format("UPDATE CHUYENBAY SET MaTB= {0},DonGia= {1},ThoiGian= '{2}',ThoiLuong= {3},SoGheTrong= {4},SoGheDat= {5} WHERE MaCB = {6}", chuyenBay.TB, chuyenBay.DonGia, chuyenBay.ThoiGian, chuyenBay.ThoiLuong, chuyenBay.SoGheTrong, chuyenBay.SoGheDat,chuyenBay.maCB);
            bool update = DataProvider.ExecuteNonQuery(cmdText);
            return update;
        }
    }
}
