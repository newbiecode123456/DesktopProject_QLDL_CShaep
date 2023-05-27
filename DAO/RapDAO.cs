using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class RapDAO
    {
        private static RapDAO instance;
        public static RapDAO Instance
        {
            get { if (instance == null) instance = new RapDAO(); return instance; }
            set { instance = value; }
        }
        private RapDAO() { }

        public List<Rap> GetAllRap()
        {
            List<Rap> raps = new List<Rap>();
            string query = "USP_GetAllRap";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow dr in data.Rows)
            {
                Rap rap = new Rap(dr);
                raps.Add(rap);
            }
            return raps;
        }
        public bool InsertRap(string MaRap,int TongGhe,string MaCum)
        {
            string query = "USP_InsertRap @MaRap , @TongGhe , @MaCum ";
            int result = DataProvider.Instance.ExecuteNonQuery(query,new object[] {MaRap,TongGhe,MaCum});
            return result > 0;
        }
        public bool UpdateRap(string MaRap,int TongGhe,string MaCum)
        {
            string query = "USP_UpdateRap @MaRap , @TongGhe , @MaCum";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaRap, TongGhe, MaCum });
            return result > 0;
        }
        public bool DeleteRap(string MaRap)
        {
            string query = "USP_DeleteRap @MaRap";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaRap });
            return result > 0;
        }
        public bool DeleteRapofCumRap(string MaCum)
        {
            string query = "USP_DeleteRapofCumRap @MaCum";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaCum });
            return result > 0;
        }
    }
}