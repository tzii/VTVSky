using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Transfer_Objects
{
    public class DatCho
    {
        private int maVe;
        private int maCB;
        private string tenHK;
        private string cmnd;
        private string dienThoai;
        private DateTime thoiGian;
        private HangVe hv;
        private int giaVe;
        private int tinhTrang;

        public string MaVe
        {
            get
            {
                return ConvertToString(maVe, "VE");
            }
        }
        public string MaCB
        {
            get
            {
                return ConvertToString(maCB, "CB");
            }
        }
        public string TenHK
        {
            set
            {
                tenHK = value;
            }
            get
            {
                return tenHK;
            }
        }
        public string CMND
        {
            set
            {
                cmnd = value;
            }
            get
            {
                return cmnd;
            }
        }
        public string DienThoai
        {
            set
            {
                dienThoai = value;
            }
            get
            {
                return dienThoai;
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
        public string TenHV
        {
            get
            {
                return hv.TenHV;
            }
        }
        public int GiaVe
        {
            set
            {
                giaVe = value;
            }
            get
            {
                return giaVe;
            }
        }
        public string TinhTrang
        {
            get
            {
                if (tinhTrang == 1) return "Đặt";
                if (tinhTrang == 2) return "Đã bán";
                else return "Đã hủy";
            }
        }
        public int GetMaVe()
        {
            return maVe;
        }
        public int GetMaCB()
        {
            return maCB;
        }
        public DatCho() { }
        public DatCho(int _maVe, int _maCB, string _tenHK, string _cmnd, string _dienThoai, DateTime _thoiGian, HangVe _hv, int _giaVe, int _tinhTrang)
        {
            maVe = _maVe;
            maCB = _maCB;
            tenHK = _tenHK;
            cmnd = _cmnd;
            dienThoai = _dienThoai;
            thoiGian = _thoiGian;
            hv = _hv;
            giaVe = _giaVe;
            tinhTrang = _tinhTrang;
        }
        private string ConvertToString(int x, string pre)
        {
            string res = "000000";
            string s = x.ToString();
            return pre + res.Remove(res.Length - s.Length) + s;
        }
    }
}
