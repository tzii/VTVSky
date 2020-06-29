using Data_Access_Layer;
using Data_Transfer_Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_Layer
{
    public class BLL_CTHV
    {
        public static List<CTHV> GetCTHVs(int maCB)
        {
            var cthvs = DAL_CTHV.GetCTHVs(maCB);
            if (cthvs == null) return new List<CTHV>();
            return cthvs;
        }
        public static bool InsertCTHV(CTHV cTHV, int maCB)
        {
            return DAL_CTHV.InsertCTHV(cTHV, maCB);
        }

        public static bool UpdateCTHV(CTHV cTHV)
        {
            return DAL_CTHV.UpdateCTHV(cTHV);
        }
        public static List<CTHV> GetNewCTHVs()
        {
            var cthvs = DAL_CTHV.GetNewCTHVs();
            if (cthvs == null) return new List<CTHV>();
            return cthvs;
        }
        public static bool DeleteCTHV(int maCB)
        {
            return DAL_CTHV.DeleteCTHV(maCB);
        }
        public static bool CheckGhe(int maCB, int MaHV)
        {
            return DAL_CTHV.CheckGhe(maCB, MaHV);
        }
    }
}
