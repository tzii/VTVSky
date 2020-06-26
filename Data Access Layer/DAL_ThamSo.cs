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

        public static void LoadThamSo()
        {
            string cmdText = @"select * from THAMSO";
            DataTable dt = DataProvider.ExecuteReader(cmdText);
            if (dt != null && dt.Rows.Count > 0)
            {
                ThamSo.TGBayToiThieu = (int)dt.Rows[0]["TGBayToiThieu"];
                ThamSo.SLSBTG = (int)dt.Rows[0]["SLSBTG"];
                ThamSo.TGDungToiThieu = (int)dt.Rows[0]["TGDungToiThieu"];
                ThamSo.TGDungToiDa = (int)dt.Rows[0]["TGDungToiDa"];
                ThamSo.TGDatVeChamNhat = (int)dt.Rows[0]["TGDatVeChamNhat"];
                ThamSo.TGHuyDatVe = (int)dt.Rows[0]["TGHuyDatVe"];
            }
        }


        public static bool UpdateThamSo()
        {
            string cmdText = String.Format("update THAMSO set TGBayToiThieu = {0},SLSBTG={1},TGDungToiThieu={2},TGDungToiDa={3},TGDatVeChamNhat={4},TGHuyDatVe={5}", ThamSo.TGBayToiThieu, ThamSo.SLSBTG, ThamSo.TGDungToiThieu, ThamSo.TGDungToiDa, ThamSo.TGDatVeChamNhat, ThamSo.TGHuyDatVe);
            bool res = DataProvider.ExecuteNonQuery(cmdText);
            return res;
        }
    }
}
