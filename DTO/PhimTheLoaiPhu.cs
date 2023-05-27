using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhimTheLoaiPhu
    {

        public PhimTheLoaiPhu(string maphim,string matheloai) { 
            this.Maphim = maphim;
            this.Matheloai = matheloai;
        }
        public PhimTheLoaiPhu(DataRow row) {
            this.Maphim = (string)row["MaPhim"];
            this.Matheloai = (string)row["MaTheLoai"];
        }
        private string matheloai;
        public string Matheloai
        {
            get { return matheloai; }
            set { matheloai = value; }
        }
        private string maphim;
        public string Maphim
        {
            get { return maphim; }
            set { maphim = value; }
        }
    }
}
