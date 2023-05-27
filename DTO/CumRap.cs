using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CumRap
    {
        public CumRap(string macum,string tencum,string diachi) { 
            this.Macum = macum;
            this.Tencum = tencum;
            this.Diachi = diachi;
        }
        public CumRap(DataRow row) {
            this.Macum = (string)row["MaCum"];
            this.Tencum = (string)row["TenCum"];
            this.Diachi = (string)row["DiaChi"];
        }
        private string macum;
        public string Macum
        {
            get { return macum; }
            set { macum = value; }
        }
        private string tencum;
        public string Tencum
        {
            get { return tencum; }
            set { tencum = value; }
        }
        private string diachi;
        public string Diachi
        {
            get { return diachi; }
            set { diachi = value; }
        }
    }
}
