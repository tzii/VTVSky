using Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_Layer
{
    public class BLL_IdenMaVe
    {
        public static int GetNewMaVe()
        {
            return DAL_IdenMaVe.GetNewMaVe();
        }
        public static bool ClearIden()
        {
            return DAL_IdenMaVe.ClearIden();
        }
    }
}
