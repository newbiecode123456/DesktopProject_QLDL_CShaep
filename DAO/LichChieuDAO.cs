using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class LichChieuDAO
    {
        private static LichChieuDAO instance;
        public static LichChieuDAO Instance
        {
            get { if (instance == null) instance = new LichChieuDAO(); return instance; }
            set { instance = value; }
        }
        private LichChieuDAO() { }
        public List<LichChieu> GetAllLichChieu()
        {
            List<LichChieu> lichChieus = new List<LichChieu>();
            string query = "USP_GetAllLichChieu";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows) {
                LichChieu lichchieu = new LichChieu(row);
                lichChieus.Add(lichchieu);
            }
            return lichChieus;
        }
        public bool InsertLichChieu(string MaPhim,string MaRap,DateTime? NgayChieu,string ChuoiMaSuat)
        {
            string query = "USP_InsertLichChieu @MaPhim , @MaRap , @NgayChieu , @ChuoiMaSuat ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaPhim, MaRap, NgayChieu, ChuoiMaSuat });
            return result > 0;
        }
        public bool UpdateLichChieu(string MaPhim, string MaRap, DateTime? NgayChieu, string ChuoiMaSuat)
        {
            string query = "USP_UpdateLichChieu @MaPhim , @MaRap , @NgayChieu , @ChuoiMaSuat";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaPhim, MaRap, NgayChieu, ChuoiMaSuat });        
            return result > 0;
        }
        public bool DeleteLichChieu(string MaPhim,string MaRap,DateTime? NgayChieu)
        {
            string query = "USP_DeleteLichChieu @MaPhim , @MaRap , @NgayChieu";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaPhim, MaRap, NgayChieu });
            return result > 0;
        }

        public bool CheckExistLichChieu(string MaRap, DateTime? NgayChieu)
        {
            string query = "USP_CheckExistLichChieu @MaRap , @NgayChieu";
            int dem = (int)DataProvider.Instance.ExecuteScalar(query, new object[] {MaRap , NgayChieu});
            return dem > 1;
        }

        public bool CheckIfExistLichChieu(string MaRap,DateTime? NgayChieu,string ChuoiMaSuat)
        {
            string query = "USP_CheckIfExistLichChieu @MaRap , @NgayChieu , @ChuoiMaSuat";
            int dem = (int)DataProvider.Instance.ExecuteScalar(query, new object[] { MaRap, NgayChieu, ChuoiMaSuat });
            return dem > 0;
        }

        public bool DeleteLichChieuofPhim(string MaPhim)
        {
            string query = "USP_DeleteLichChieuofPhim @MaPhim";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaPhim });
            return result > 0;
        }
        public bool DeleteLichChieuofRap(string MaRap)
        {
            string query = "USP_DeleteLichChieuofRap @MaRap";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaRap });
            return result > 0;
        }

    }
}
