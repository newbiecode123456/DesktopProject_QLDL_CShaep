using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class SuatChieuDAO
    {
        private static SuatChieuDAO instance;
        public static SuatChieuDAO Instance
        {
            get { if (instance == null) instance = new SuatChieuDAO(); return instance; }
            set { instance = value; }
        }
        private SuatChieuDAO() { }

        public List<SuatChieu> GetAllSuatChieu()
        {
            List<SuatChieu> suatChieus = new List<SuatChieu>();
            string query = "USP_GetAllSuatChieu";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in dataTable.Rows)
            {
                SuatChieu suatChieu = new SuatChieu(item);
                suatChieus.Add(suatChieu);
            }
            return suatChieus;
        }
        public bool InsertSuatChieu(string MaSuat,int GioBatDau,int PhutBatDau)
        {
            string query = "USP_InsertSuatChieu @MaSuat , @GioBatDau , @PhutBatDau ";
            int result = DataProvider.Instance.ExecuteNonQuery(query , new object[] {MaSuat,GioBatDau,PhutBatDau});
            return result > 0;
        }
        public bool UpdateSuatChieu(string MaSuat,int GioBatDau,int PhutBatDau)
        {
            string query = "USP_UpdateSuatChieu @MaSuat , @GioBatDau , @PhutBatDau";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaSuat, GioBatDau, PhutBatDau });
            return result > 0;
        }
        public bool DeleteSuatChieu(string MaSuat)
        {
            string query = "USP_DeleteSuatChieu @MaSuat";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaSuat });
            return result > 0;

        }
    }
}
