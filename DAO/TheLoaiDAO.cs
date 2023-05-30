using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class TheLoaiDAO
    {
        private static TheLoaiDAO instance;
        public static TheLoaiDAO Instance
        {
            get { if (instance == null) instance = new TheLoaiDAO(); return instance; }
            set { instance = value; }
        }
        private TheLoaiDAO() { }

        public List<TheLoai> GetAllTheLoai() {
            List<TheLoai> theloais = new List<TheLoai>();
            string query = "USP_GetAllTheLoai";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                TheLoai theloai = new TheLoai(item);
                theloais.Add(theloai);
            }
            return theloais;
        }
        public List<TheLoai> GetAllTheLoaiofPhim(string MaPhim)
        {
            List<TheLoai> TLofP = new List<TheLoai>();
            string query = "USP_GetAllTheLoaiofPhim @MaPhim";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { MaPhim });
            foreach (DataRow item in result.Rows)
            {
                TheLoai tl = new TheLoai(item);
                TLofP.Add(tl);
            }
            return TLofP;
        }
        public TheLoai GetTheLoaiChinhofPhim(string MaTheLoaiChinh)
        {
            TheLoai TLCofP = null;
            string query = "USP_GetTheLoaiChinhofPhim @MaTheLoaiChinh";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] {MaTheLoaiChinh});
            foreach (DataRow item in result.Rows)
            {
                TLCofP = new TheLoai(item);
                return TLCofP;
            }
            return TLCofP;
        }

        public List<TheLoai> GetAllTheLoaiPhuofPhim(string MaPhim)
        {
            List<TheLoai> theLoaiofPhims = new List<TheLoai>();
            string query = "USP_GetAllTheLoaiPhuoffPhim @MaPhim";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { MaPhim });
            foreach(DataRow item in data.Rows)
            {
                TheLoai theloai = new TheLoai(item);
                theLoaiofPhims.Add(theloai);
            }
            return theLoaiofPhims;
        }
        public bool InsertTheLoai(string MaTheLoai,string TenTheLoai)
        {
            string query = "USP_InsertTheLoai @MaTheLoai , @TenTheLoai";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaTheLoai, TenTheLoai });
            return result > 0;
        }
        public bool UpdateTheLoai(string MaTheLoai,string TenTheLoai)
        {
            string query = "USP_UpdateTheLoai @MaTheLoai , @TenTheLoai ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaTheLoai, TenTheLoai });
            return result > 0;
        }
        public bool DeleteTheLoai(string MaTheLoai)
        {
            PhimDAO.Instance.DeletePhimofTheLoai(MaTheLoai);
            PhimTheLoaiPhuDAO.Instance.DeletePhimTheLoaiPhuofTheLoai(MaTheLoai);
            string query = "USP_DeleteTheLoai @MaTheLoai";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaTheLoai });
            return result > 0;
        }
    }
}
