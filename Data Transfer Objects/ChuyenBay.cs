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
        private int maCB;
        public TuyenBay TB;
        private DateTime thoiGian;
        private int thoiLuong;
        private int soGheTrong;
        private int soGheDat;
        private int donGia;
        public string MaCB 
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
        public ChuyenBay(int _maCB,TuyenBay _tb,DateTime _thoiGian,int _thoiLuong, int _soGheTrong, int _soGheDat,int _donGia)
        {
            maCB = _maCB;
            TB = _tb;
            thoiGian = _thoiGian;
            thoiLuong = _thoiLuong;
            soGheTrong = _soGheTrong;
            soGheDat = _soGheDat;
            donGia = _donGia;
        }

        private string ConvertToString(int x)
        {
            string res = "CB000000";
            string s = x.ToString();
            return res.Remove(res.Length - s.Length) + s;
        }
        public int getMaCB()
        {
            return maCB;
        }
    }
}
