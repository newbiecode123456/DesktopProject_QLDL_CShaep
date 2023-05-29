using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LichChieu
    {
        public LichChieu(string maphim,string marap,DateTime? ngaychieu,string chuoimasuat)
        {
            this.Maphim = maphim;
            this.Marap = marap;
            this.Ngaychieu = ngaychieu;
            this.Chuoimasuat = chuoimasuat;
        }

        public LichChieu(DataRow row) {
            this.Maphim = (string)row["MaPhim"];
            this.Marap = (string)row["MaRap"];
            this.Ngaychieu = (DateTime?)row["NgayChieu"];
            this.Chuoimasuat = (string)row["ChuoiMaSuat"];
        }

        private string maphim;
        public string Maphim
        {
            get { return maphim; }
            set { maphim = value; }
        }
        private string marap;
        public string Marap
        {
            get { return marap; }
            set { marap = value; }
        }
        private DateTime? ngaychieu;
        public DateTime? Ngaychieu
        {
            get { return ngaychieu; }
            set { ngaychieu = value; }
        }
        private string chuoimasuat;
        public string Chuoimasuat
        {
            get { return chuoimasuat; }
            set { chuoimasuat = value; }
        }
    }
}
