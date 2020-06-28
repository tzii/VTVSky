using Data_Access_Layer;
using Data_Transfer_Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_Layer
{
    public class BLL_ChuyenBay
    {
        public static List<ChuyenBay> GetChuyenBays()
        {
            var chuyenBays = DAL_ChuyenBay.GetChuyenBays();
            if (chuyenBays == null) return new List<ChuyenBay>();
            return chuyenBays;
        }
        public static List<ChuyenBay> SearchMaCB(string maCB)
        {
            var chuyenBays = DAL_ChuyenBay.SearchMaCB(maCB);
            if (chuyenBays == null) return new List<ChuyenBay>();
            return chuyenBays;
        }
        public static List<ChuyenBay> SearchTenSBDi(string tenSB)
        {
            var chuyenBays = DAL_ChuyenBay.SearchTenSBDi(tenSB);
            if (chuyenBays == null) return new List<ChuyenBay>();
            return chuyenBays;
        }
        public static List<ChuyenBay> SearchTenSBDen(string tenSB)
        {
            var chuyenBays = DAL_ChuyenBay.SearchTenSBDen(tenSB);
            if (chuyenBays == null) return new List<ChuyenBay>();
            return chuyenBays;
        }
        public static bool InsertChuyenBay(ChuyenBay chuyenBay)
        {
            return DAL_ChuyenBay.InsertChuyenBay(chuyenBay);
        }

        public static bool UpdateChuyenBay(ChuyenBay chuyenBay)
        {
            return DAL_ChuyenBay.UpdateChuyenBay(chuyenBay);
        }
        public static int GetLastMaCB()
        {
            return DAL_ChuyenBay.GetLastMaCB();
        }
        public static bool CheckGhe(int maCB)
        {
            return DAL_ChuyenBay.CheckGhe(maCB);
        }
    }
}
