using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Transfer_Objects
{
    public class Ve
    {
        public int maVe { set; get; }
        public int maCB { set; get; }
        private string tenHK;
        private string cmnd;
        private string dienThoai;
        private DateTime thoiGian;
        public HangVe HV { set; get; }
        private int giaVe;
        public string strMaVe
        {
            get
            {
                return ConvertToString(maVe, "VE");
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
                if (HV == null) return "#";
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
        public Ve() { }
        public Ve(int _maVe, int _maCB, string _tenHK, string _cmnd, string _dienThoai, DateTime _thoiGian, HangVe _hv, int _giaVe)
        {
            maVe = _maVe;
            maCB = _maCB;
            tenHK = _tenHK;
            cmnd = _cmnd;
            dienThoai = _dienThoai;
            thoiGian = _thoiGian;
            HV = _hv;
            giaVe = _giaVe;

        }
        private string ConvertToString(int x, string pre)
        {
            string res = "000000";
            string s = x.ToString();
            return pre + res.Remove(res.Length - s.Length) + s;
        }
    }
}
