using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Transfer_Objects
{
    public class Ve
    {
        private int maVe;
        private ChuyenBay maCB;
        private string tenHK;
        private string cMND;
        private string dienThoai;
        private DateTime thoiGian;
        private HangVe maHV;
        private int giaVe;
        private bool tinhTrang;
        public string MaVe
        {
            get
            {
                return ConvertToString(maVe);
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
        public int MaHV
        {
           
            get
            {
                return maVe;
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
        
        //public PhieuDatcho() { }
        public Ve(int _maVe, ChuyenBay _maCB, string _tenHK, string _cMND, string _dienThoai, HangVe _maHV, int _giaVe)
        {
            maVe = _maVe;
            maCB = _maCB;
            tenHK = _tenHK;
            cMND = _cMND;
            dienThoai = _dienThoai;
            maHV = _maHV;
            giaVe = _giaVe;
           
        }
        private string ConvertToString(int x)
        {
            string res = "SB000000";
            string s = x.ToString();
            return res.Remove(res.Length - s.Length) + s;
        }
        public int getMaVe()
        {
            return maVe;
        }
    }
}
