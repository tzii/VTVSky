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
            var hangves = DAL_HangVe.GetHangVe();
            if (hangves == null) return new List<HangVe>();
            return hangves;
        }
    }
}
