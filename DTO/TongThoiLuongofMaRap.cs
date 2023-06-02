using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TongThoiLuongofMaRap
    {
        public TongThoiLuongofMaRap(string marap,int tongthoiluong)
        {
            this.Marap = marap;
            this.Tongthoiluong = tongthoiluong;
        }
        public TongThoiLuongofMaRap(DataRow row)
        {
            this.Marap = (string)row["MaRap"];
            this.Tongthoiluong = (int)row["TongThoiLuong"];
        }
        private string marap;
        public string Marap
        {
            get { return marap; }
            set { marap = value; }
        }
        private int tongthoiluong;
        public int Tongthoiluong
        {
            get { return tongthoiluong; }
            set {  tongthoiluong = value;}
        }
    }
}
