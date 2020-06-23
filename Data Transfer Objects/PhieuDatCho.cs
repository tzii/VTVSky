using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Transfer_Objects
{
    public class PhieuDatCho
    {
        public int maVe { set; get; }
        public int maCB { set; get; }
        private string tenHK;
        private string cmnd;
        private string dienThoai;
        private DateTime thoiGian;
        public HangVe HV { set; get; }
        private int giaVe;
        public int tinhTrang { set; get; }
        public string strMaVe
        {
            get
            {
                return ConvertToString(maVe,"VE");
            }
        }
        public string strMaCB
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
                CMND = value;
            }
            get
            {
                return CMND;
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
                return HV.TenHV;
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
        public string strTinhTrang
        {
            get
            {
                if (tinhTrang == 1) return "Đặt";
                else if (tinhTrang == 2) return "Đã bán";
                else return "Đã hủy";
            }
        }
        public PhieuDatCho() { }
        public PhieuDatCho(int _maVe, int _maCB, string _tenHK, string _cmnd, string _dienThoai,DateTime _thoiGian, HangVe _hv, int _giaVe, int _tinhTrang)
        {
            maVe = _maVe;
            maCB = _maCB;
            tenHK = _tenHK;
            cmnd = _cmnd;
            dienThoai = _dienThoai;
            thoiGian = _thoiGian;
            HV = _hv;
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
