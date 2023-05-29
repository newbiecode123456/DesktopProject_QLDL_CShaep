using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class KeHoachDAO
    {
        private static KeHoachDAO instance;
        public static KeHoachDAO Instance
        {
            get { if (instance == null) instance = new KeHoachDAO(); return instance; }
            set { instance = value; }
        }
        private KeHoachDAO() { }
        public List<KeHoach> GetAllKeHoach()
        {
            List<KeHoach> keHoaches = new List<KeHoach>();
            string query = "USP_GetAllKeHoach";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                KeHoach kehoach = new KeHoach(row);
                keHoaches.Add(kehoach);
            }
            return keHoaches;
        }
        public bool InsertKeHoach(string MaPhim, string MaCum, DateTime? NgayKhoiChieu, DateTime? NgayKetThuc, string GhiChu)
        {
            string query = "USP_InsertKeHoach @MaPhim , @MaCum , @NgayKhoiChieu , @NgayKetThuc , @GhiChu";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaPhim, MaCum, NgayKhoiChieu, NgayKetThuc, GhiChu });
            return result > 0;
        }
        public bool UpdateKeHoach(string MaPhim, string MaCum, DateTime? NgayKhoiChieu, DateTime? NgayKetThuc, string GhiChu)
        {
            string query = "USP_UpdateKeHoach @MaPhim , @MaCum , @NgayKhoiChieu , @NgayKetThuc , @GhiChu";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaPhim, MaCum, NgayKhoiChieu, NgayKetThuc, GhiChu });
            return result > 0;
        }
        public bool DeleteKeHoach(string MaPhim,string MaCum,DateTime? NgayKhoiChieu,DateTime? NgayKetThuc)
        {
            string query = "USP_DeleteKeHoach @MaPhim , @MaCum , @NgayKhoiChieu , @NgayKetThuc";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaPhim, MaCum, NgayKhoiChieu, NgayKetThuc });
            return result > 0;
        }
    }
}
