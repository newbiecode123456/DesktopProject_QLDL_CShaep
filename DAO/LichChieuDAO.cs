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
    }
}
