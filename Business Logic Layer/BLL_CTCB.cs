using Data_Access_Layer;
using Data_Transfer_Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_Layer
{
    public class BLL_CTCB
    {
        public static List<CTCB> GetCTCBs(int maCB)
        {
            var ctcbs = DAL_CTCB.SearchMaCB(maCB);
            if (ctcbs == null) return new List<CTCB>();
            return ctcbs;
        }
    }
}
