using Data_Access_Layer;
using Data_Transfer_Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_Layer
{
    public class BLL_TuyenBay
    {
        public static List<TuyenBay> GetTuyenBays()
        {
            var tuyenBays = DAL_TuyenBay.GetTuyenBays();
            if (tuyenBays == null) return new List<TuyenBay>();
            return tuyenBays;
        }
        public static List<SanBay> GetSanBaysFrom(int maSBDi)
        {
            var sanBays = DAL_TuyenBay.GetSanBaysFrom(maSBDi);
            if (sanBays == null) return new List<SanBay>();
            return sanBays;
        }
        public static List<SanBay> GetSanBaysTo(int maSBDen)
        {
            var sanBays = DAL_TuyenBay.GetSanBaysTo(maSBDen);
            if (sanBays == null) return new List<SanBay>();
            return sanBays;
        }
        public static TuyenBay GetTuyenBay(int maTB)
        {
            return DAL_TuyenBay.GetTuyenBay(maTB);
        }
        public static TuyenBay GetTuyenBay(int maSBDi, int maSBDen)
        {
            return DAL_TuyenBay.GetTuyenBay(maSBDi,maSBDen);
        }
        public static List<TuyenBay> searchMaTB (string maTB)
        {
            var tuyenBays = DAL_TuyenBay.SearchMaTB(maTB);
            if (tuyenBays == null) return new List<TuyenBay>();
            return tuyenBays;
        }
        public static List<TuyenBay> searchTenSBDi (string tenSB)
        {
            var tuyenBays = DAL_TuyenBay.SearchTenSBDi(tenSB);
            if (tuyenBays == null) return new List<TuyenBay>();
            return tuyenBays;
        }
        public static List<TuyenBay> searchTenSBDen (string tenSB)
        {
            var tuyenBays = DAL_TuyenBay.SearchTenSBDen(tenSB);
            if (tuyenBays == null) return new List<TuyenBay>();
            return tuyenBays;
        }
        public static bool InsertTuyenBay(TuyenBay tb)
        {
            return DAL_TuyenBay.InsertTuyenBay(tb);
        }
        public static bool UpdateTuyenBay(TuyenBay tb)
        {
            return DAL_TuyenBay.UpdateTuyenBay(tb);
        }
        public static bool CheckTuyenbay(TuyenBay tb)
        {
            return DAL_TuyenBay.CheckTuyenBay(tb);
        }
    }
}
