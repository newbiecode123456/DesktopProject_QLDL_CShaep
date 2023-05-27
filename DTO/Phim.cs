using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Phim
    {
        public Phim(string maphim, string tenphim, string matheloaichinh, int thoiluong) {
            this.Maphim = maphim;
            this.Tenphim = tenphim;
            this.Thoiluong = thoiluong;
            this.Matheloaichinh = matheloaichinh;
        }
        public Phim(DataRow row)
        {
            this.Maphim = (string)row["MaPhim"];
            this.Tenphim = (string)row["TenPhim"];
            this.Matheloaichinh = (string)row["MaTheLoaiChinh"];
            this.Thoiluong = (int)row["ThoiLuong"];
        }

        private string maphim;
        public string Maphim
        {
            get { return maphim; }
            set { maphim = value; }
        }
        private string tenphim;
        public string Tenphim
        {
            get { return tenphim; }
            set { tenphim = value; }
        }
        private string matheloaichinh;
        public string Matheloaichinh
        {
            get { return matheloaichinh; }
            set { matheloaichinh = value; }
        }
        private int thoiluong;
        public int Thoiluong
        {
            get { return thoiluong; }
            set { thoiluong = value; }
        }
    }
}
