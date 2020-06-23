using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Transfer_Objects
{
    public class SanBay
    {
        public int maSB { set; get; }
        private string tenSB;
        public string strMaSB
        {
            get
            {
                return ConvertToString(maSB);
            }
        }
        public string TenSB
        {
            set
            {
                tenSB = value;
            }
            get
            {
                return tenSB;
            }
        }
        public SanBay() { }
        public SanBay(int _maSB, string _tenSB)
        {
            maSB = _maSB;
            tenSB = _tenSB;
        }
        private string ConvertToString(int x)
        {
            string res = "SB000000";
            string s = x.ToString();
            return res.Remove(res.Length - s.Length) + s;
        }
    }
}
