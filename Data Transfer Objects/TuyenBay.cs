using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Transfer_Objects
{
    public class TuyenBay
    {
        public int maTB { set; get; }
        public SanBay SBDi { set; get; }
        public SanBay SBDen { set; get; }
        public string strMaTB 
        {
            get
            {
                return ConvertToString(maTB);
            }
        }
        public string TenSBDi
        {
            get
            {
                return SBDi.TenSB;
            }
        }
        public string TenSBDen
        {
            get
            {
                return SBDen.TenSB;
            }
        }
        public TuyenBay() { } 
        public TuyenBay(int _maTB,SanBay _sbDi, SanBay _sbDen)
        {
            maTB = _maTB;
            SBDi = _sbDi;
            SBDen = _sbDen;
        }
        private string ConvertToString(int x)
        {
            string res = "TB000000";
            string s = x.ToString();
            return res.Remove(res.Length - s.Length) + s;
        }
    }
}
