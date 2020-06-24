﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Transfer_Objects
{
    public class ThamSo
    {
        public int TGBayToiThieu
        {
            set
            {
                TGBayToiThieu = value;
            }
            get
            {
                return TGBayToiThieu;
            }
        }
        public int SLSBTG
        {
            set
            {
                SLSBTG = value;
            }
            get
            {
                return SLSBTG;
            }
        }
        public int TGDungToiThieu
        {
            set
            {
                TGDungToiThieu = value;
            }
            get
            {
                return TGDungToiThieu;
            }
        }
        public int TGDungToiDa
        {
            set
            {
                TGDungToiDa = value;
            }
            get
            {
                return TGDungToiDa;
            }
        }
        public int TGDatVeChamNhat
        {
            set
            {
                TGDatVeChamNhat = value;
            }
            get
            {
                return TGDatVeChamNhat;
            }
        }
        public int TGHuyDatVe
        {
            set
            {
                TGHuyDatVe = value;
            }
            get
            {
                return TGHuyDatVe;
            }
        }
        public ThamSo(int _tGBayToiThieu,int _sLSBTG, int _tGDungToiThieu, int _tGDungToiDa, int _tGDatVeChamNhat, int _tGHuyDatVe)
        {
            TGBayToiThieu = _tGBayToiThieu;
            SLSBTG = _sLSBTG;
            TGDungToiThieu = _tGDungToiThieu;
            TGDungToiDa = _tGDungToiDa;
            TGDatVeChamNhat = _tGDatVeChamNhat;
            TGHuyDatVe = _tGHuyDatVe;
        }
    }
}
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