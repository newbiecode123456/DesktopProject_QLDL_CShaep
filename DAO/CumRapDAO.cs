using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class CumRapDAO
    {
        private static CumRapDAO instance;
        public static CumRapDAO Instance
        {
            get { if (instance == null) instance = new CumRapDAO(); return instance; }
            set { instance = value; }
        }
        private CumRapDAO() { }
        public List<CumRap> GetAllCumRap()
        {
            List<CumRap> cumraps=new List<CumRap>();
            string query = "exec USP_GetAllCumRap";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                CumRap cumrap = new CumRap(row);
                cumraps.Add(cumrap);
            }
            return cumraps;
        }
        public CumRap GetCumRapofRap(string MaCum){
            CumRap CR = null;
            string query = "USP_GetCumRapofRap @MaCum";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { MaCum });
            foreach (DataRow item in data.Rows)
            {
                CR = new CumRap(item);
            }
            return CR;
        }
        public bool InsertCumRap(string MaCum,string TenCum,string DiaChi)
        {
            string query = "USP_InsertCumRap @MaCum , @TenCum , @DiaChi ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaCum, TenCum, DiaChi });
            return result > 0;
        }
        public bool UpdateCumRap(string MaCum,string TenCum,string DiaChi)
        {
            string query = "USP_UpdateCumRap @MaCum , @TenCum , @DiaChi ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaCum, TenCum, DiaChi });
            return result > 0;
        }

        public bool DeleteCumRap(string MaCum)
        {
            KeHoachDAO.Instance.DeletekeHoachofCumRap(MaCum);
            RapDAO.Instance.DeleteRapofCumRap(MaCum);
            string query = "USP_DeleteCumRap @MaCum";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaCum });
            return result > 0;
        }
    }
}
