using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class PhimTheLoaiPhuDAO
    {
        private static PhimTheLoaiPhuDAO instance;
        public static PhimTheLoaiPhuDAO Instance
        {
            get { if (instance == null) instance = new PhimTheLoaiPhuDAO(); return instance; }
            set { instance = value; }
        }
        public bool DeletePhimTheLoaiPhuofPhim(string MaPhim)
        {
            string query = "USP_DeletePhimTheLoaiPhuofPhim @MaPhim";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaPhim });
            return result > 0;
        }

        public bool DeletePhimTheLoaiPhuofTheLoai(string MaTheLoai)
        {
            string query = "USP_DeletePhimTheLoaiPhuofTheLoai @MaTheLoai";
            int result = DataProvider.Instance.ExecuteNonQuery(query,new object[] { MaTheLoai });
            return result > 0;
        }
        public bool CheckorUncheckPhimTheLoaiPhu(string MaPhim,string MaTheLoai)
        {
            string query = "USP_CheckorUncheckPhimTheLoaiPhu @MaPhim , @MaTheLoai";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaPhim , MaTheLoai });
            return result > 0;
        }
    }
}
