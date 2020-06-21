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
            var chuyenBays = DAL_ChuyenBay.GetChuyenBay();
            if (chuyenBays == null) return new List<ChuyenBay>();
            return chuyenBays;
        }
        public static List<ChuyenBay> SearchMaCB(string maCB)
        {
            var chuyenBays = DAL_ChuyenBay.SearchMaCB(maCB);
            if (chuyenBays == null) return new List<ChuyenBay>();
            return chuyenBays;
        }
    }
}
