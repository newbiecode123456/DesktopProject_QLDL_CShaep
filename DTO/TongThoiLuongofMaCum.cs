using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TongThoiLuongofMaCum
    {
        public TongThoiLuongofMaCum(string macum,int tongthoiluong) {
            this.Macum = macum;
            this.Tongthoiluong = tongthoiluong;
        }
        public TongThoiLuongofMaCum(DataRow row) {
            this.Macum = (string)row["MaCum"];
            this.Tongthoiluong = (int)row["TongThoiLuong"];
        }
        private string macum;
        public string Macum
        {
            get { return macum; }
            set { macum = value; }
        }
        private int tongthoiluong;
        public int Tongthoiluong
        {
            get { return tongthoiluong; }
            set { tongthoiluong = value; }
        }
    }
}
