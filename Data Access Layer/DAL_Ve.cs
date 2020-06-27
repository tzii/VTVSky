using Data_Transfer_Objects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer
{
    public class DAL_Ve
    {
        public static List<Ve> GetVes()
        {
            string cmdText = @"select * from Ve";
            DataTable dt = DataProvider.ExecuteReader(cmdText);
            if (dt != null && dt.Rows.Count > 0)
            {
                List<Ve> Ve = new List<Ve>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Ve ve = new Ve((int)dt.Rows[i]["MaVe"], (int)dt.Rows[i]["MaCB"], dt.Rows[i]["TenHK"].ToString(), dt.Rows[i]["CMND"].ToString(), dt.Rows[i]["DienThoai"].ToString(), (DateTime)dt.Rows[i]["ThoiGian"], DAL_HangVe.GetHangVe((int)dt.Rows[i]["MaHV"]), (int)dt.Rows[i]["GiaVe"]);
                    Ve.Add(ve);
                }
                return Ve;
            }
            return null;
        }

        public static List<Ve> SearchMaVe(string maVe)
        {
            string cmdText = String.Format("select * from Ve where MaVe like '%{0}%'", maVe == "" ? maVe : DataProvider.ConvertToInt(maVe));
            DataTable dt = DataProvider.ExecuteReader(cmdText);
            if (dt != null && dt.Rows.Count > 0)
            {
                List<Ve> Ve = new List<Ve>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Ve ve = new Ve((int)dt.Rows[i]["MaVe"], (int)dt.Rows[i]["MaCB"], dt.Rows[i]["TenHK"].ToString(), dt.Rows[i]["CMND"].ToString(), dt.Rows[i]["DienThoai"].ToString(), (DateTime)dt.Rows[i]["ThoiGian"], DAL_HangVe.GetHangVe((int)dt.Rows[i]["MaHV"]), (int)dt.Rows[i]["GiaVe"]);
                    Ve.Add(ve);
                }
                return Ve;
            }
            return null;
        }

        public static List<Ve> SearchMaCB(string maCB)
        {
            string cmdText = String.Format("select * from Ve where MaCB like '%{0}%'", maCB == "" ? maCB : DataProvider.ConvertToInt(maCB));
            DataTable dt = DataProvider.ExecuteReader(cmdText);
            if (dt != null && dt.Rows.Count > 0)
            {
                List<Ve> Ve = new List<Ve>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Ve ve = new Ve((int)dt.Rows[i]["MaVe"], (int)dt.Rows[i]["MaCB"], dt.Rows[i]["TenHK"].ToString(), dt.Rows[i]["CMND"].ToString(), dt.Rows[i]["DienThoai"].ToString(), (DateTime)dt.Rows[i]["ThoiGian"], DAL_HangVe.GetHangVe((int)dt.Rows[i]["MaHV"]), (int)dt.Rows[i]["GiaVe"]);
                    Ve.Add(ve);
                }
                return Ve;
            }
            return null;
        }
        public static List<Ve> SearchTenHK(string tenHK)
        {
            string cmdText = String.Format("select * from Ve where TenHK like N'%{0}%'", tenHK);
            DataTable dt = DataProvider.ExecuteReader(cmdText);
            if (dt != null && dt.Rows.Count > 0)
            {
                List<Ve> Ve = new List<Ve>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Ve ve = new Ve((int)dt.Rows[i]["MaVe"], (int)dt.Rows[i]["MaCB"], dt.Rows[i]["TenHK"].ToString(), dt.Rows[i]["CMND"].ToString(), dt.Rows[i]["DienThoai"].ToString(), (DateTime)dt.Rows[i]["ThoiGian"], DAL_HangVe.GetHangVe((int)dt.Rows[i]["MaHV"]), (int)dt.Rows[i]["GiaVe"]);
                    Ve.Add(ve);
                }
                return Ve;
            }
            return null;
        }
        public static List<Ve> SearchCMND(string cMND)
        {
            string cmdText = String.Format("select * from Ve where CMND like '%{0}%'", cMND);
            DataTable dt = DataProvider.ExecuteReader(cmdText);
            if (dt != null && dt.Rows.Count > 0)
            {
                List<Ve> Ve = new List<Ve>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Ve ve = new Ve((int)dt.Rows[i]["MaVe"], (int)dt.Rows[i]["MaCB"], dt.Rows[i]["TenHK"].ToString(), dt.Rows[i]["CMND"].ToString(), dt.Rows[i]["DienThoai"].ToString(), (DateTime)dt.Rows[i]["ThoiGian"], DAL_HangVe.GetHangVe((int)dt.Rows[i]["MaHV"]), (int)dt.Rows[i]["GiaVe"]);
                    Ve.Add(ve);
                }
                return Ve;
            }
            return null;
        }
        public static List<Ve> SearchSDT(string dienThoai)
        {
            string cmdText = String.Format("select * from Ve where DienThoai like '%{0}%'", dienThoai);
            DataTable dt = DataProvider.ExecuteReader(cmdText);
            if (dt != null && dt.Rows.Count > 0)
            {
                List<Ve> Ve = new List<Ve>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Ve ve = new Ve((int)dt.Rows[i]["MaVe"], (int)dt.Rows[i]["MaCB"], dt.Rows[i]["TenHK"].ToString(), dt.Rows[i]["CMND"].ToString(), dt.Rows[i]["DienThoai"].ToString(), (DateTime)dt.Rows[i]["ThoiGian"], DAL_HangVe.GetHangVe((int)dt.Rows[i]["MaHV"]), (int)dt.Rows[i]["GiaVe"]);
                    Ve.Add(ve);
                }
                return Ve;
            }
            return null;
        }
        public static List<Ve> SearchMaHV(string maHV)
        {
            string cmdText = String.Format("select * from Ve where MaHV like '%{0}%'", maHV == "" ? maHV : DataProvider.ConvertToInt(maHV));
            DataTable dt = DataProvider.ExecuteReader(cmdText);
            if (dt != null && dt.Rows.Count > 0)
            {
                List<Ve> Ve = new List<Ve>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Ve ve = new Ve((int)dt.Rows[i]["MaVe"], (int)dt.Rows[i]["MaCB"], dt.Rows[i]["TenHK"].ToString(), dt.Rows[i]["CMND"].ToString(), dt.Rows[i]["DienThoai"].ToString(), (DateTime)dt.Rows[i]["ThoiGian"], DAL_HangVe.GetHangVe((int)dt.Rows[i]["MaHV"]), (int)dt.Rows[i]["GiaVe"]);
                    Ve.Add(ve);
                }
                return Ve;
            }
            return null;
        }
        public static List<Ve> SearchThoiGian(string thoiGian)
        {
            string cmdText = String.Format("select * from VE where day(ThoiGian) like '%{0}%' or month(ThoiGian) like '%{0}%' or year(ThoiGian) like '%{0}%'", thoiGian);
            DataTable dt = DataProvider.ExecuteReader(cmdText);
            if (dt != null && dt.Rows.Count > 0)
            {
                List<Ve> Ve = new List<Ve>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Ve ve = new Ve((int)dt.Rows[i]["MaVe"], (int)dt.Rows[i]["MaCB"], dt.Rows[i]["TenHK"].ToString(), dt.Rows[i]["CMND"].ToString(), dt.Rows[i]["DienThoai"].ToString(), (DateTime)dt.Rows[i]["ThoiGian"], DAL_HangVe.GetHangVe((int)dt.Rows[i]["MaHV"]), (int)dt.Rows[i]["GiaVe"]);
                    Ve.Add(ve);
                }
                return Ve;
            }
            return null;
        }
        public static List<Ve> SearchDonGia(string donGia)
        {
            string cmdText = String.Format("select * from VE where DonGia = @donGia");
            DataTable dt = DataProvider.ExecuteReader(cmdText);
            if (dt != null && dt.Rows.Count > 0)
            {
                List<Ve> Ve = new List<Ve>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Ve ve = new Ve((int)dt.Rows[i]["MaVe"], (int)dt.Rows[i]["MaCB"], dt.Rows[i]["TenHK"].ToString(), dt.Rows[i]["CMND"].ToString(), dt.Rows[i]["DienThoai"].ToString(), (DateTime)dt.Rows[i]["ThoiGian"], DAL_HangVe.GetHangVe((int)dt.Rows[i]["MaHV"]), (int)dt.Rows[i]["GiaVe"]);
                    Ve.Add(ve);
                }
                return Ve;
            }
            return null;
        }
        public static bool InsertVe(Ve ve, int maVe)
        {
            string cmdText = string.Format("INSERT INTO VE(MaVe,MaCB,TenHK,CMND,DienThoai,ThoiGian,MaHV,GiaVe) VALUES ({7},{0},N'{1}','{2}','{3}','{4}',{5},{6})", ve.maCB, ve.TenHK, ve.CMND, ve.DienThoai, ve.ThoiGian.ToString("MM/dd/yyyy HH:mm:ss"), ve.HV.maHV, ve.GiaVe,maVe);
            bool insert = DataProvider.ExecuteNonQuery(cmdText);
            return insert;
        }

        public static bool UpdateVe(Ve ve)
        {
            string cmdText = string.Format("UPDATE VE SET MaCB= {0},TenHK= N'{1}',CMND= '{2}',DienThoai= '{3}',ThoiGian= '{4}',MaHV= {5},GiaVe= {6} WHERE MaVe = {7}", ve.maCB, ve.TenHK, ve.CMND, ve.DienThoai, ve.ThoiGian.ToString("MM / dd / yyyy HH: mm:ss"), ve.HV.maHV, ve.GiaVe,ve.maVe);
            bool update = DataProvider.ExecuteNonQuery(cmdText);
            return update;
        }
    }
}
