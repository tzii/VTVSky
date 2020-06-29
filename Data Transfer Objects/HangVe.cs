using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Transfer_Objects
{
    public class HangVe
    {
        public int maHV { set; get; }
        private string tenHV;
        private double tiLe;
        public string strMaHV
        {
            get
            {
                return ConvertToString(maHV);
            }
        }
        public string TenHV 
        {
            set
            {
                tenHV = value;
            }
            get
            {
                return tenHV;
            }
        }
        public double TiLe
        {
            set
            {
                tiLe = value;
            }
            get
            {
                return tiLe;
            }
        }
        public HangVe() { }
        public HangVe(int _maHV, string _tenHV, double _tiLe)
        {
            maHV = _maHV;
            tenHV = _tenHV;
            tiLe = _tiLe;
        }
        private string ConvertToString(int x)
        {
            string res = "HV000000";
            string s = x.ToString();
            return res.Remove(res.Length - s.Length) + s;
        }
    }
}
