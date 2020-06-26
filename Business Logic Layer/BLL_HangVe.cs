using Data_Access_Layer;
using Data_Transfer_Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_Layer
{
    public class BLL_HangVe
    {
        public static List<HangVe> GetHangVes()
        {
            var hangves = DAL_HangVe.GetHangVes();
            if (hangves == null) return new List<HangVe>();
            return hangves;
        }
        public static HangVe GetHangVe(int maHV)
        {
            return DAL_HangVe.GetHangVe(maHV);
        }
        public static List<HangVe> SearchMaHV(string maHV)
        {
            var hangves = DAL_HangVe.SearchMaHV(maHV);
            if (hangves == null) return new List<HangVe>();
            return hangves;
        }
        public static List<HangVe> SearchTenHV(string tenHV)
        {
            var hangves = DAL_HangVe.SearchTenHV(tenHV);
            if (hangves == null) return new List<HangVe>();
            return hangves;
        }
        public static bool InsertHangVe(HangVe hangVe)
        {
            return DAL_HangVe.InsertHangVe(hangVe);
        }

        public static bool UpdateHangVe(HangVe hangVe)
        {
            return DAL_HangVe.UpdateHangVe(hangVe);
        }
        public static bool DeleteHangVe (HangVe hv)
        {
            return DAL_HangVe.DeleteHangVe(hv);
        }
    }
}
