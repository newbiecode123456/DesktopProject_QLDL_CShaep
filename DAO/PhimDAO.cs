using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class PhimDAO
    {
        private static PhimDAO instance;
        public static PhimDAO Instance
        {
            get { if (instance == null) instance = new PhimDAO(); return instance; }
            set { instance = value; }
        }
        private PhimDAO() { }
        public List<Phim> GetAllPhim()
        {
            List<Phim> phims = new List<Phim>();
            string query = "USP_GetAllPhim";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in result.Rows)
            {
                Phim phim = new Phim(row);
                phims.Add(phim);
            }
            return phims;
        }

        public Phim GetPhimbyMaPhim(string MaPhim)
        {   //chưa có proc
            Phim phim = null;
            string query = "USP_GetPhimbyMaPhim @MaPhim";
            DataTable dataphim = DataProvider.Instance.ExecuteQuery(query,new object[] {phim});
            foreach(DataRow itemp in dataphim.Rows)
            {
                phim=new Phim(itemp);
            }
            return phim;
        }

        public int intGetThoiLuongPhim(string MaPhim)
        {   
            Phim phim = null;
            string query = "USP_GetPhimbyMaPhim @MaPhim";
            DataTable dataphim = DataProvider.Instance.ExecuteQuery(query,new object[] { MaPhim });
            foreach (DataRow itemp in dataphim.Rows)
            {
                phim = new Phim(itemp);
            }
            return (int)phim.Thoiluong;
        }

        public bool InsertPhim(string MaPhim, string TenPhim,string MaTheLoaiChinh,int ThoiLuong)
        {
            string query = "USP_InsertPhim @MaPhim , @TenPhim , @MaTheLoaiChinh , @ThoiLuong ";
            int result = DataProvider.Instance.ExecuteNonQuery(query,new object[] {MaPhim,TenPhim,MaTheLoaiChinh,ThoiLuong});
            return result > 0;
        }
        public bool UpdatePhim(string MaPhim,string TenPhim,string MaTheLoaiChinh,int ThoiLuong)
        {
            string query = "USP_UpdatePhim @MaPhim , @TenPhim , @MaTheLoaiChinh , @ThoiLuong";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] {MaPhim, TenPhim, MaTheLoaiChinh, ThoiLuong });
            return result > 0;
        }
        public bool DeletePhim(string MaPhim)
        {
            LichChieuDAO.Instance.DeleteLichChieuofPhim(MaPhim);
            KeHoachDAO.Instance.DeleteKeHoachofPhim(MaPhim);
            PhimTheLoaiPhuDAO.Instance.DeletePhimTheLoaiPhuofPhim(MaPhim);
            string query = "USP_DeletePhim @MaPhim";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaPhim });
            return result > 0;
        }
        public bool DeletePhimofTheLoai(string MaTheLoai)
        {
            string query = "USP_DeletePhimofTheLoai @MaTheLoai";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaTheLoai });
            return result > 0;
        }
    }
}
