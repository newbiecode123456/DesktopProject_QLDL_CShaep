using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class TongThoiLuongofMaCumDAO
    {
        private static TongThoiLuongofMaCumDAO instance;
        public static TongThoiLuongofMaCumDAO Instance
        {
            get { if (instance == null) instance = new TongThoiLuongofMaCumDAO(); return instance; }
            set { instance = value; }
        }
        private TongThoiLuongofMaCumDAO() { }
        public List<TongThoiLuongofMaCum> GetAllTongThoiLongofCum()
        {
            List<TongThoiLuongofMaCum> tongThoiLuongofMaCums = new List<TongThoiLuongofMaCum>();
            string query = "USP_GetAllTongThoiLongofCum";
            DataTable dataTTL = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in dataTTL.Rows)
            {
                TongThoiLuongofMaCum ttl = new TongThoiLuongofMaCum(row);
                tongThoiLuongofMaCums.Add(ttl);
            }
            return tongThoiLuongofMaCums;
        }
        public TongThoiLuongofMaCum GetTongThoiLongbyMaCum(string MaCum)
        {
            TongThoiLuongofMaCum ttlbymc = null;
            string query = "USP_GetTongThoiLongbyMaCum @MaCum";
            DataTable datattlbymc = DataProvider.Instance.ExecuteQuery(query,new object[] {MaCum});
            foreach(DataRow row in datattlbymc.Rows)
            {
                ttlbymc = new TongThoiLuongofMaCum(row);
            }
            return ttlbymc;
        }

        public int intGetTongThoiLongbyMaCum(string MaCum)
        {
            TongThoiLuongofMaCum ttlbymc = null;
            string query = "USP_GetTongThoiLongbyMaCum @MaCum";
            DataTable datattlbymc = DataProvider.Instance.ExecuteQuery(query, new object[] { MaCum });
            foreach (DataRow row in datattlbymc.Rows)
            {
                ttlbymc = new TongThoiLuongofMaCum(row);
            }
            if (ttlbymc != null)
                return (int)ttlbymc.Tongthoiluong;
            else 
                return 0;
        }
    }
}
