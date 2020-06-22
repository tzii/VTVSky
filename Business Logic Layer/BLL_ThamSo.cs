using Data_Transfer_Objects;
using System;
using System.Collections.Generic;
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
    }
}
