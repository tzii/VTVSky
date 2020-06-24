using Data_Access_Layer;
using Data_Transfer_Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_Layer
{
    public class BLL_SanBay
    {
        public static List<SanBay> GetSanBays()
        {
            List<SanBay> sanBays = DAL_SanBay.GetSanBays();
            if (sanBays == null) return new List<SanBay>();
            else return sanBays;
        }
        public static SanBay GetSanBay(int maSB)
        {
            return new SanBay();
        }
        public static bool InsertSanBay(SanBay sanBay)
        {
            return DAL_SanBay.InsertSanBay(sanBay);
        }
        public static List<SanBay> SearchMaSB(string maSB)
        {
            List<SanBay> sanBays = DAL_SanBay.SearchMaSB(maSB);
            if (sanBays == null) return new List<SanBay>();
            else return sanBays;
        }

        public static List<SanBay> SearchTenSB(string tenSB)
        {
            List<SanBay> sanBays = DAL_SanBay.SearchTenSB(tenSB);
            if (sanBays == null) return new List<SanBay>();
            else return sanBays;
        }
    }
}
