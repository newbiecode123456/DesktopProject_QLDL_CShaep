using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Rap
    {
        public Rap(string marap,int tongghe,string macum) {
            this.Marap = marap;
            this.Tongghe = tongghe;
            this.Macum = macum;
        }
        public Rap(DataRow row)
        {
            this.Marap = (string)row["MaRap"];
            this.Tongghe = (int)row["TongGhe"];
            this.Macum = (string)row["MaCum"];
        }
        private string marap;
        public string Marap
        {
            get { return marap; }
            set { marap = value; }
        }
        private int tongghe;
        public int Tongghe
        {
            get { return tongghe; }
            set { tongghe = value; }
        }
        private string macum;
        public string Macum
        {
            get { return macum; }
            set { macum = value; }
        }
    }
}
