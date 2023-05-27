using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TheLoai
    {
        public TheLoai(string matheloai, string tentheloai) {
            this.Matheloai = matheloai;
            this.Tentheloai = tentheloai;
        }
        public TheLoai(DataRow row) {
            this.Matheloai = (string)row["MaTheLoai"];
            this.Tentheloai = (string)row["TenTheLoai"];
        }
        private string matheloai;
        public string Matheloai
        {
            get { return matheloai; }
            set { matheloai = value; }
        }
        private string tentheloai;
        public string Tentheloai
        {
            get { return tentheloai; }
            set { tentheloai = value; }
        }
    }
}
