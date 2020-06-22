using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Transfer_Objects
{
    public class CTHV
    {
        public int maCB { set; get; }
        public HangVe HV { set; get; }
        private int giaVe;
        private int slGhe;
        private int slGheTrong;
        private int slGheBan;
        public string strMaCB
        {
            get
            {
                return ConvertToString(maCB);
            }
        }
        public string TenHV 
        {
            get
            {
                return HV.strMaHV;
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
        public int SLGhe
        {
            set
            {
                slGhe = value;
            }
            get
            {
                return slGhe;
            }
        }
        public int SLGheTrong
        {
            set
            {
                slGheTrong = value;
            }
            get
            {
                return slGheTrong;
            }
        }
        public int SLGheBan
        {
            set
            {
                SLGheBan = value;
            }
            get
            {
                return slGheBan;
            }
        }
        public CTHV() { }
        public CTHV(int _maCB,HangVe _hv,int _giaVe,int _slGhe,int _slGheTrong, int _slGheBan)
        {
            maCB = _maCB;
            HV = _hv;
            giaVe = _giaVe;
            slGhe = _slGhe;
            slGheTrong = _slGheTrong;
            slGheBan = _slGheBan;
        }
        private string ConvertToString(int x)
        {
            string res = "CB000000";
            string s = x.ToString();
            return res.Remove(res.Length - s.Length) + s;
        }
    }
}
