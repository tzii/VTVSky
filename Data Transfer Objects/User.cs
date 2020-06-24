using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Transfer_Objects
{
    public class User
    {
        public static int id;
        public static string Username;
        public static string Password;
        public static string Per;
        public static string Name;
        public static DateTime NgaySinh;
        public static string QueQuan;
        public static string DienThoai;

        public static string Permission
        {
            get
            {
                if (Per == "ADMIN") return "Admin";
                if (Per == "MANAGER") return "Quản Lý";
                if (Per == "STAFF") return "Nhân Viên";
                return "#########";
            }
        }
        public static void setDefault()
        {
            id = 0;
            Username = "#########";
            Password = "#########";
            Per = "#########";
            Name = "#########";
            NgaySinh = DateTime.Today;
            QueQuan = "#########";
            DienThoai = "#########";
        }
    }
}
