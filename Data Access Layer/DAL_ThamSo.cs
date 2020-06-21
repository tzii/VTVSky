using Data_Transfer_Objects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Data_Transfer_Objects
{
    public class DAL_ThamSo
    {
        public static ThamSo GetThamSo()
        {
            string cmdText = @"select * from THAMSO";
            DataTable dt = DataProvider.ExecuteReader(cmdText);
            ThamSo thamSo = new ThamSo();
            ThamSo ts = new ThamSo((int)dt.Rows[0]["TGBayToiThieu"], (int)dt.Rows[0]["SLSBTG"], (int)dt.Rows[0]["TGDungToiThieu"], (int)dt.Rows[0]["TGDungToiDa"], (int)dt.Rows[0]["TGDatVeChamNhat"], (int)dt.Rows[0]["TGHuyDatVe"]);
            thamSo.Add(ts);
            return thamSo;
        }
   
}
}
