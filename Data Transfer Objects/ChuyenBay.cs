using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Data_Transfer_Objects
{
    public class ChuyenBay
    {
        public int maCB { set; get; }
        public TuyenBay TB { set; get; }
        private int donGia;
        private DateTime thoiGian;
        private int thoiLuong;
        private int soGheTrong;
        private int soGheDat;
        public string strMaCB 
        {
            get
            {
                return ConvertToString(maCB);
            }
        }
        public string TenSBDi
        {
            get
            {
                return TB.TenSBDi;
            }
        }
        public string TenSBDen
        {
            get
            {
                return TB.TenSBDen;
            }
        }
        public int DonGia
        {
            set
            {
                donGia = value;
            }
            get
            {
                return donGia;
            }
        }
        public DateTime ThoiGian 
        {
            set
            {
                thoiGian = value;
            }
            get
            {
                return thoiGian;
            }
        }
        public int ThoiLuong 
        {
            set
            {
                thoiLuong = value;
            }
            get
            {
                return thoiLuong;
            }
        }
        public int SoGheTrong
        {
            set
            {
                soGheTrong = value;
            }
            get
            {
                return soGheTrong;
            }
        }
        public int SoGheDat
        {
            set
            {
                soGheDat = value;
            }
            get
            {
                return soGheDat;
            }
        }
        public ChuyenBay() { }
        public ChuyenBay(int _maCB,TuyenBay _tb, int _donGia, DateTime _thoiGian,int _thoiLuong, int _soGheTrong, int _soGheDat)
        {
            maCB = _maCB;
            TB = _tb;
            donGia = _donGia;
            thoiGian = _thoiGian;
            thoiLuong = _thoiLuong;
            soGheTrong = _soGheTrong;
            soGheDat = _soGheDat;
        }
        private string ConvertToString(int x)
        {
            string res = "CB000000";
            string s = x.ToString();
            return res.Remove(res.Length - s.Length) + s;
        }
    }
}
