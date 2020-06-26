using Data_Transfer_Objects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_Layer
{
    public class BLL_ThamSo
    {
        public static void LoadThamSo()
        {
            DAL_ThamSo.LoadThamSo();
        }
        public static bool UpdateThamSo()
        {
            return DAL_ThamSo.UpdateThamSo();
        }
    }
}
