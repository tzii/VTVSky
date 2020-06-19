using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Transfer_Objects
{
    public class CTCB
    {
        private int maCB;
        private SanBay sbTG;
        private int tgDung;
        private string ghiChu;

        public string MaCB
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
                return sbTG.TenSB;
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
        public CTCB() { }
        public CTCB(int _maCB, SanBay _sbtg, int _tgDung, string _ghiChu) 
        {
            maCB = _maCB;
            sbTG = _sbtg;
            tgDung = _tgDung;
            ghiChu = _ghiChu;
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
