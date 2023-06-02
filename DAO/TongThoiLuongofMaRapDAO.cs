using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class TongThoiLuongofMaRapDAO
    {
        private static TongThoiLuongofMaRapDAO instance;
        public static TongThoiLuongofMaRapDAO Instance
        {
            get { if (instance == null) instance = new TongThoiLuongofMaRapDAO(); return instance; }
            set { instance = value; }
        }
        private TongThoiLuongofMaRapDAO() { }

        public int intGetTongThoiLuongbyMaRap(string MaRap,DateTime? NgayChieu)
        {   //chưa tạo proc
            TongThoiLuongofMaRap ttlbymr = null;
            string query = "intGetTongThoiLuongbyMaRap @MaRap , @NgayChieu";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query, new object[] { MaRap, NgayChieu });
            foreach(DataRow row in dataTable.Rows)
            {
                ttlbymr = new TongThoiLuongofMaRap(row);
            }
            if (ttlbymr != null)
                return (int)ttlbymr.Tongthoiluong;
            else return 0;
        }
    }
}
