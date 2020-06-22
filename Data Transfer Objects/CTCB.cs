using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Transfer_Objects
{
    public class CTCB
    {
        public int maCB { set; get; }
        public SanBay SBTG { set; get; }
        private int tgDung;
        private string ghiChu;
        public string strMaCB
        {
            get
            {
                return ConvertToString(maCB);
            }
        }
        public string TenSBTG
        {
            get
            {
                return SBTG.TenSB;
            }
        }
        public int TGDung
        {
            set
            {
                tgDung = value;
            }
            get
            {
                return tgDung;
            }
        }
        public string GhiChu
        {
            set
            {
                ghiChu = value;
            }
            get
            {
                return ghiChu;
            }
        }
        public CTCB() {}
        public CTCB(int _maCB, SanBay _sbtg, int _tgDung, string _ghiChu) 
        {
            maCB = _maCB;
            SBTG = _sbtg;
            tgDung = _tgDung;
            ghiChu = _ghiChu;
        }
        private string ConvertToString(int x)
        {
            string res = "CB000000";
            string s = x.ToString();
            return res.Remove(res.Length - s.Length) + s;
        }
    }
}
