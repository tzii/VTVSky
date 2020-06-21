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
        public static List<Ve> GetVe()
        {
            string cmdText = @"select * from Ve";
            DataTable dt = DataProvider.ExecuteReader(cmdText);
            if (dt != null && dt.Rows.Count > 0)
            {
                List<Ve> Ve = new List<Ve>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Ve ve = new Ve((int)dt.Rows[i]["MaVe"], (ChuyenBay)dt.Rows[i]["MaCB"], dt.Rows[i]["TenHK"].ToString(), dt.Rows[i]["CMND"].ToString(), dt.Rows[i]["DienThoai"].ToString(), (HangVe)dt.Rows[i]["MaHV"], (int)dt.Rows[i]["GiaVe"]);
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
                    Ve ve = new Ve((int)dt.Rows[i]["MaVe"], (ChuyenBay)dt.Rows[i]["MaCB"], dt.Rows[i]["TenHK"].ToString(), dt.Rows[i]["CMND"].ToString(), dt.Rows[i]["DienThoai"].ToString(), (HangVe)dt.Rows[i]["MaHV"], (int)dt.Rows[i]["GiaVe"]);
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
                    Ve ve = new Ve((int)dt.Rows[i]["MaVe"], (ChuyenBay)dt.Rows[i]["MaCB"], dt.Rows[i]["TenHK"].ToString(), dt.Rows[i]["CMND"].ToString(), dt.Rows[i]["DienThoai"].ToString(), (HangVe)dt.Rows[i]["MaHV"], (int)dt.Rows[i]["GiaVe"]);
                    Ve.Add(ve);
                }
                return Ve;
            }
            return null;
        }
        public static List<Ve> SearchTenHK(string tenHK)
        {
            string cmdText = String.Format("select * from Ve where TenHK like '%{0}%'", tenHK == "" ? tenHK : DataProvider.ConvertToInt(tenHK));
            DataTable dt = DataProvider.ExecuteReader(cmdText);
            if (dt != null && dt.Rows.Count > 0)
            {
                List<Ve> Ve = new List<Ve>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Ve ve = new Ve((int)dt.Rows[i]["MaVe"], (ChuyenBay)dt.Rows[i]["MaCB"], dt.Rows[i]["TenHK"].ToString(), dt.Rows[i]["CMND"].ToString(), dt.Rows[i]["DienThoai"].ToString(), (HangVe)dt.Rows[i]["MaHV"], (int)dt.Rows[i]["GiaVe"]);
                    Ve.Add(ve);
                }
                return Ve;
            }
            return null;
        }
        public static List<Ve> SearchCMND(string cMND)
        {
            string cmdText = String.Format("select * from Ve where CMND like '%{0}%'", cMND == "" ? cMND : DataProvider.ConvertToInt(cMND));
            DataTable dt = DataProvider.ExecuteReader(cmdText);
            if (dt != null && dt.Rows.Count > 0)
            {
                List<Ve> Ve = new List<Ve>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Ve ve = new Ve((int)dt.Rows[i]["MaVe"], (ChuyenBay)dt.Rows[i]["MaCB"], dt.Rows[i]["TenHK"].ToString(), dt.Rows[i]["CMND"].ToString(), dt.Rows[i]["DienThoai"].ToString(), (HangVe)dt.Rows[i]["MaHV"], (int)dt.Rows[i]["GiaVe"]);
                    Ve.Add(ve);
                }
                return Ve;
            }
            return null;
        }
        public static List<Ve> SearchDienThoai(string dienThoai)
        {
            string cmdText = String.Format("select * from Ve where DienThoai like '%{0}%'", dienThoai == "" ? dienThoai : DataProvider.ConvertToInt(dienThoai));
            DataTable dt = DataProvider.ExecuteReader(cmdText);
            if (dt != null && dt.Rows.Count > 0)
            {
                List<Ve> Ve = new List<Ve>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Ve ve = new Ve((int)dt.Rows[i]["MaVe"], (ChuyenBay)dt.Rows[i]["MaCB"], dt.Rows[i]["TenHK"].ToString(), dt.Rows[i]["CMND"].ToString(), dt.Rows[i]["DienThoai"].ToString(), (HangVe)dt.Rows[i]["MaHV"], (int)dt.Rows[i]["GiaVe"]);
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
                    Ve ve = new Ve((int)dt.Rows[i]["MaVe"], (ChuyenBay)dt.Rows[i]["MaCB"], dt.Rows[i]["TenHK"].ToString(), dt.Rows[i]["CMND"].ToString(), dt.Rows[i]["DienThoai"].ToString(), (HangVe)dt.Rows[i]["MaHV"], (int)dt.Rows[i]["GiaVe"]);
                    Ve.Add(ve);
                }
                return Ve;
            }
            return null;
        }
        
    }
}
