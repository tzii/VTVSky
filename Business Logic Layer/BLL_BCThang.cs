using Data_Access_Layer;
using Data_Transfer_Objects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_Layer
{
    public class BLL_BCThang
    {
        public static DataSet GetDataSet(int thang, int nam)
        {
            return DAL_BCThang.GetDataSet(thang, nam);
        }
        public static List<CBSource> GetNams()
        {
            var nams = DAL_BCThang.GetNams();
            if (nams == null) return new List<CBSource>();
            return nams;
        }
        public static List<CBSource> GetThangs(int nam)
        {
            var thangs = DAL_BCThang.GetThangs(nam);
            if (thangs == null) return new List<CBSource>();
            return thangs;
        }
    }
}
