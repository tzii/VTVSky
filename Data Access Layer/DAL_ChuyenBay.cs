﻿using Data_Transfer_Objects;
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
                    ChuyenBay cb = new ChuyenBay((int)dt.Rows[i]["MaCB"], DAL_TuyenBay.GetTuyenBay((int)dt.Rows[i]["MaTB"]), (int)dt.Rows[i]["DonGia"],(DateTime)dt.Rows[i]["ThoiGian"], (int)dt.Rows[i]["ThoiLuong"], (int)dt.Rows[i]["SoGheTrong"], (int)dt.Rows[i]["SoGheDat"]);
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
                    ChuyenBay cb = new ChuyenBay((int)dt.Rows[i]["MaCB"], DAL_TuyenBay.GetTuyenBay((int)dt.Rows[i]["MaTB"]), (int)dt.Rows[i]["DonGia"], (DateTime)dt.Rows[i]["ThoiGian"], (int)dt.Rows[i]["ThoiLuong"], (int)dt.Rows[i]["SoGheTrong"], (int)dt.Rows[i]["SoGheDat"]);
                    chuyenBay.Add(cb);
                }
                return chuyenBay;
            }
            return null;
        }

        public static List<ChuyenBay> SearchMaSBDi(string maSBDi)
        {
            string cmdText = String.Format("select * from CHUYENBAY where MaSBDI like '%{0}%'", maSBDi == "" ? maSBDi : DataProvider.ConvertToInt(maSBDi));
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

        public static List<ChuyenBay> SearchMaSBDen(string maSBDen)
        {
            string cmdText = String.Format("select * from CHUYENBAY where MaSBDen like '%{0}%'", maSBDen == "" ? maSBDen : DataProvider.ConvertToInt(maSBDen));
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
       
    }
}
