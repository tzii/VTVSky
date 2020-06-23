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
    public class DAL_PhieuDatCho
    {
        public static List<PhieuDatCho> GetPhieuDatCho()
        {
            string cmdText = @"select * from PHIEUDATCHO";
            DataTable dt = DataProvider.ExecuteReader(cmdText);
            if (dt != null && dt.Rows.Count > 0)
            {
                List<PhieuDatCho> phieudatcho = new List<PhieuDatCho>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    PhieuDatCho pdc = new PhieuDatCho((int)dt.Rows[i]["MaVe"],(int)dt.Rows[i]["MaCB"], dt.Rows[i]["TenHK"].ToString(), dt.Rows[i]["CMND"].ToString(), dt.Rows[i]["DienThoai"].ToString(), (DateTime)dt.Rows[i]["ThoiGian"],(HangVe)dt.Rows[i]["MaHV"], (int)dt.Rows[i]["GiaVe"], (int)dt.Rows[i]["TinhTrang"]);
                    phieudatcho.Add(pdc);
                }
                return phieudatcho;
            }
            return null;
        }

        public static List<PhieuDatCho> SearchMaVe(string maVe)
        {
            string cmdText = String.Format("select * from PHIEUDATCHO where MaVe like '%{0}%'", maVe == "" ? maVe : DataProvider.ConvertToInt(maVe));
            DataTable dt = DataProvider.ExecuteReader(cmdText);
            if (dt != null && dt.Rows.Count > 0)
            {
                List<PhieuDatCho> phieudatcho = new List<PhieuDatCho>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    PhieuDatCho pdc = new PhieuDatCho((int)dt.Rows[i]["MaVe"], (int)dt.Rows[i]["MaCB"], dt.Rows[i]["TenHK"].ToString(), dt.Rows[i]["CMND"].ToString(), dt.Rows[i]["DienThoai"].ToString(), (DateTime)dt.Rows[i]["ThoiGian"], (HangVe)dt.Rows[i]["MaHV"], (int)dt.Rows[i]["GiaVe"], (int)dt.Rows[i]["TinhTrang"]);
                    phieudatcho.Add(pdc);
                }
                return phieudatcho;
            }
            return null;
        }

        public static List<PhieuDatCho> SearchMaCB(string maCB)
        {
            string cmdText = String.Format("select * from PHIEUDATCHO where MaCB like '%{0}%'", maCB == "" ? maCB : DataProvider.ConvertToInt(maCB));
            DataTable dt = DataProvider.ExecuteReader(cmdText);
            if (dt != null && dt.Rows.Count > 0)
            {
                List<PhieuDatCho> phieudatcho = new List<PhieuDatCho>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    PhieuDatCho pdc = new PhieuDatCho((int)dt.Rows[i]["MaVe"], (int)dt.Rows[i]["MaCB"], dt.Rows[i]["TenHK"].ToString(), dt.Rows[i]["CMND"].ToString(), dt.Rows[i]["DienThoai"].ToString(), (DateTime)dt.Rows[i]["ThoiGian"], (HangVe)dt.Rows[i]["MaHV"], (int)dt.Rows[i]["GiaVe"], (int)dt.Rows[i]["TinhTrang"]);
                    phieudatcho.Add(pdc);
                }
                return phieudatcho;
            }
            return null;
        }
        public static List<PhieuDatCho> SearchTenHK(string tenHK)
        {
            string cmdText = String.Format("select * from PHIEUDATCHO where TenHK like '%{0}%'", tenHK == "" ? tenHK : DataProvider.ConvertToInt(tenHK));
            DataTable dt = DataProvider.ExecuteReader(cmdText);
            if (dt != null && dt.Rows.Count > 0)
            {
                List<PhieuDatCho> phieudatcho = new List<PhieuDatCho>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    PhieuDatCho pdc = new PhieuDatCho((int)dt.Rows[i]["MaVe"], (int)dt.Rows[i]["MaCB"], dt.Rows[i]["TenHK"].ToString(), dt.Rows[i]["CMND"].ToString(), dt.Rows[i]["DienThoai"].ToString(), (DateTime)dt.Rows[i]["ThoiGian"], (HangVe)dt.Rows[i]["MaHV"], (int)dt.Rows[i]["GiaVe"], (int)dt.Rows[i]["TinhTrang"]);
                    phieudatcho.Add(pdc);
                }
                return phieudatcho;
            }
            return null;
        }
        public static List<PhieuDatCho> SearchCMND(string cMND)
        {
            string cmdText = String.Format("select * from PHIEUDATCHO where CMND like '%{0}%'", cMND == "" ? cMND : DataProvider.ConvertToInt(cMND));
            DataTable dt = DataProvider.ExecuteReader(cmdText);
            if (dt != null && dt.Rows.Count > 0)
            {
                List<PhieuDatCho> phieudatcho = new List<PhieuDatCho>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    PhieuDatCho pdc = new PhieuDatCho((int)dt.Rows[i]["MaVe"], (int)dt.Rows[i]["MaCB"], dt.Rows[i]["TenHK"].ToString(), dt.Rows[i]["CMND"].ToString(), dt.Rows[i]["DienThoai"].ToString(), (DateTime)dt.Rows[i]["ThoiGian"], (HangVe)dt.Rows[i]["MaHV"], (int)dt.Rows[i]["GiaVe"], (int)dt.Rows[i]["TinhTrang"]);
                    phieudatcho.Add(pdc);
                }
                return phieudatcho;
            }
            return null;
        }
        public static List<PhieuDatCho> SearchDienThoai(string dienThoai)
        {
            string cmdText = String.Format("select * from PHIEUDATCHO where DienThoai like '%{0}%'", dienThoai == "" ? dienThoai : DataProvider.ConvertToInt(dienThoai));
            DataTable dt = DataProvider.ExecuteReader(cmdText);
            if (dt != null && dt.Rows.Count > 0)
            {
                List<PhieuDatCho> phieudatcho = new List<PhieuDatCho>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    PhieuDatCho pdc = new PhieuDatCho((int)dt.Rows[i]["MaVe"], (int)dt.Rows[i]["MaCB"], dt.Rows[i]["TenHK"].ToString(), dt.Rows[i]["CMND"].ToString(), dt.Rows[i]["DienThoai"].ToString(), (DateTime)dt.Rows[i]["ThoiGian"], (HangVe)dt.Rows[i]["MaHV"], (int)dt.Rows[i]["GiaVe"], (int)dt.Rows[i]["TinhTrang"]);
                    phieudatcho.Add(pdc);
                }
                return phieudatcho;
            }
            return null;
        }
        public static List<PhieuDatCho> SearchMaHV(string maHV)
        {
            string cmdText = String.Format("select * from PHIEUDATCHO where MaHV like '%{0}%'", maHV == "" ? maHV : DataProvider.ConvertToInt(maHV));
            DataTable dt = DataProvider.ExecuteReader(cmdText);
            if (dt != null && dt.Rows.Count > 0)
            {
                List<PhieuDatCho> phieudatcho = new List<PhieuDatCho>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    PhieuDatCho pdc = new PhieuDatCho((int)dt.Rows[i]["MaVe"], (int)dt.Rows[i]["MaCB"], dt.Rows[i]["TenHK"].ToString(), dt.Rows[i]["CMND"].ToString(), dt.Rows[i]["DienThoai"].ToString(), (DateTime)dt.Rows[i]["ThoiGian"], (HangVe)dt.Rows[i]["MaHV"], (int)dt.Rows[i]["GiaVe"], (int)dt.Rows[i]["TinhTrang"]);
                    phieudatcho.Add(pdc);
                }
                return phieudatcho;
            }
            return null;
        }
        public static List<PhieuDatCho> SearchThoiGian(string thoiGian)
        {
            string cmdText = String.Format("select * from PHIEUDATCHO where ThoiGian=@thoiGian");
            DataTable dt = DataProvider.ExecuteReader(cmdText);
            if (dt != null && dt.Rows.Count > 0)
            {
                List<PhieuDatCho> phieudatcho = new List<PhieuDatCho>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    PhieuDatCho pdc = new PhieuDatCho((int)dt.Rows[i]["MaVe"], (int)dt.Rows[i]["MaCB"], dt.Rows[i]["TenHK"].ToString(), dt.Rows[i]["CMND"].ToString(), dt.Rows[i]["DienThoai"].ToString(), (DateTime)dt.Rows[i]["ThoiGian"], (HangVe)dt.Rows[i]["MaHV"], (int)dt.Rows[i]["GiaVe"], (int)dt.Rows[i]["TinhTrang"]);
                    phieudatcho.Add(pdc);
                }
                return phieudatcho;
            }
            return null;
        }
        public static List<PhieuDatCho> SearchTinhTrang(string tinhTrang)
        {
            string cmdText = String.Format("select * from PHIEUDATCHO where TinhTrang=@tinhTrang");
            DataTable dt = DataProvider.ExecuteReader(cmdText);
            if (dt != null && dt.Rows.Count > 0)
            {
                List<PhieuDatCho> phieudatcho = new List<PhieuDatCho>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    PhieuDatCho pdc = new PhieuDatCho((int)dt.Rows[i]["MaVe"], (int)dt.Rows[i]["MaCB"], dt.Rows[i]["TenHK"].ToString(), dt.Rows[i]["CMND"].ToString(), dt.Rows[i]["DienThoai"].ToString(), (DateTime)dt.Rows[i]["ThoiGian"], (HangVe)dt.Rows[i]["MaHV"], (int)dt.Rows[i]["GiaVe"], (int)dt.Rows[i]["TinhTrang"]);
                    phieudatcho.Add(pdc);
                }
                return phieudatcho;
            }
            return null;
        }

    }
}
