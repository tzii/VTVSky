using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Transfer_Objects
{
    public class ThamSo
    {
        public static int TGBayToiThieu { set; get; }
        public static int SLSBTG { set; get; }
        public static int TGDungToiThieu { set; get; }
        public static int TGDungToiDa { set; get; }
        public static int TGDatVeChamNhat { set; get; }
        public static int TGHuyDatVe { set; get; }
        public ThamSo() { }
        public ThamSo(int _TGBTT, int _SLSBTG,int _TGDTT,int _TGDTD,int _TGDVChamNhat,int _TGHuyDatVe)
        {
            TGBayToiThieu = _TGBTT;
            SLSBTG = _SLSBTG;
            TGDungToiThieu = _TGDTT;
            TGDungToiDa = _TGDTD;
            TGDatVeChamNhat = _TGDVChamNhat;
            TGHuyDatVe = _TGHuyDatVe;
        }
    }
}
