using Data_Access_Layer;
using Data_Transfer_Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_Layer
{
    public class BLL_PhieuDatCho
    {
        public static List<PhieuDatCho> GetPhieuDatChos()
        {
            var phieuDatChos = DAL_PhieuDatCho.GetPhieuDatChos();
            if (phieuDatChos == null) return new List<PhieuDatCho>();
            return phieuDatChos;
        }
        public static List<PhieuDatCho> SearchMaVe(string maVe)
        {
            var phieuDatChos = DAL_PhieuDatCho.SearchMaVe(maVe);
            if (phieuDatChos == null) return new List<PhieuDatCho>();
            return phieuDatChos;
        }
        public static List<PhieuDatCho> SearchMaCB(string maCB)
        {
            var phieuDatChos = DAL_PhieuDatCho.SearchMaCB(maCB);
            if (phieuDatChos == null) return new List<PhieuDatCho>();
            return phieuDatChos;
        }
        public static List<PhieuDatCho> SearchTenHK(string tenHK)
        {
            var phieuDatChos = DAL_PhieuDatCho.SearchTenHK(tenHK);
            if (phieuDatChos == null) return new List<PhieuDatCho>();
            return phieuDatChos;
        }
        public static List<PhieuDatCho> SearchCMND(string cmnd)
        {
            var phieuDatChos = DAL_PhieuDatCho.SearchCMND(cmnd);
            if (phieuDatChos == null) return new List<PhieuDatCho>();
            return phieuDatChos;
        }
        public static List<PhieuDatCho> SearchSDT(string sdt)
        {
            var phieuDatChos = DAL_PhieuDatCho.SearchDienThoai(sdt);
            if (phieuDatChos == null) return new List<PhieuDatCho>();
            return phieuDatChos;
        }
        public static List<PhieuDatCho> SearchThoiGian(string thoiGian)
        {
            var phieuDatChos = DAL_PhieuDatCho.SearchThoiGian(thoiGian);
            if (phieuDatChos == null) return new List<PhieuDatCho>();
            return phieuDatChos;
        }
        public static List<PhieuDatCho> SearchTinhTrang(string tinhTrang)
        {
            int temp = 0;
            if (tinhTrang == "Đặt") temp = 1;
            else if (tinhTrang == "Đã Bán") temp = 2;
            else if (tinhTrang == "Đã Hủy") temp = 3;
            var phieuDatChos = DAL_PhieuDatCho.SearchTinhTrang(temp);
            if (phieuDatChos == null) return new List<PhieuDatCho>();
            return phieuDatChos;
        }
        public static bool InsertPhieuDatCho(PhieuDatCho phieuDatCho, int maVe)
        {
            return DAL_PhieuDatCho.InsertPhieuDatCho(phieuDatCho, maVe);
        }

        public static bool UpdatePhieuDatCho(PhieuDatCho phieuDatCho)
        {
            return DAL_PhieuDatCho.UpdatePhieuDatCho(phieuDatCho);
        }
        public static bool SalePhieuDatCho(PhieuDatCho pdc)
        {
            return DAL_PhieuDatCho.SalePhieuDatCho(pdc);
        }
    }
}
