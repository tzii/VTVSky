using Data_Access_Layer;
using Data_Transfer_Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_Layer
{
    public class BLL_Ve
    {
        public static List<Ve> GetVes()
        {
            var Ves = DAL_Ve.GetVes();
            if (Ves == null) return new List<Ve>();
            return Ves;
        }
        public static List<Ve> SearchMaVe(string maVe)
        {
            var Ves = DAL_Ve.SearchMaVe(maVe);
            if (Ves == null) return new List<Ve>();
            return Ves;
        }
        public static List<Ve> SearchMaCB(string maCB)
        {
            var Ves = DAL_Ve.SearchMaCB(maCB);
            if (Ves == null) return new List<Ve>();
            return Ves;
        }
        public static List<Ve> SearchTenHK(string tenHK)
        {
            var Ves = DAL_Ve.SearchTenHK(tenHK);
            if (Ves == null) return new List<Ve>();
            return Ves;
        }
        public static List<Ve> SearchCMND(string cmnd)
        {
            var Ves = DAL_Ve.SearchCMND(cmnd);
            if (Ves == null) return new List<Ve>();
            return Ves;
        }
        public static List<Ve> SearchSDT(string sdt)
        {
            var Ves = DAL_Ve.SearchSDT(sdt);
            if (Ves == null) return new List<Ve>();
            return Ves;
        }
        public static List<Ve> SearchThoiGian(string thoiGian)
        {
            var Ves = DAL_Ve.SearchThoiGian(thoiGian);
            if (Ves == null) return new List<Ve>();
            return Ves;
        }
    }
}
