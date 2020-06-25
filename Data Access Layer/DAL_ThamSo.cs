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

        public static List<ThamSo> GetThamSo()
        {
            string cmdText = @"select * from THAMSO";
            DataTable dt = DataProvider.ExecuteReader(cmdText);
            if (dt != null && dt.Rows.Count > 0)
            {
                List<ThamSo> Ve = new List<ThamSo>();
                ThamSo ve = new ThamSo((int)dt.Rows[0]["TGBayToiThieu"], (int)dt.Rows[0]["SLSBTG"], (int)dt.Rows[0]["TGDungToiThieu"], (int)dt.Rows[0]["TGDungToiDa"], (int)dt.Rows[0]["TGDatVeChamNhat"], (int)dt.Rows[0]["TGHuyDatVe"]);
                Ve.Add(ve);
                return Ve;
            }
            return null;
        }
       

        public static bool UpdateThamSo(ThamSo thamSo)
        {
            string cmdText = string.Format("UPDATE THAMSO SET TGBayToiThieu = {0},SLSBTG = {1},TGDungToiThieu = {2},TGDungToiDa = {3},TGDatVeChamNhat = {4},TGHuyDatVe = {5} WHERE TGBayToiThieu>0",thamSo.TGBayToiThieu,thamSo.SLSBTG,thamSo.TGDungToiThieu,thamSo.TGDungToiDa,thamSo.TGDatVeChamNhat,thamSo.TGHuyDatVe,thamSo.TGBayToiThieu);
            bool update = DataProvider.ExecuteNonQuery(cmdText);
            return update;
        }
    }
}
