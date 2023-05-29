using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KeHoach
    {
        public KeHoach(string maphim,string macum,DateTime? ngaykhoichieu,DateTime? ngayketthuc,string ghichu) {
            this.Maphim = maphim;
            this.Macum = macum;
            this.Ngaykhoichieu = ngaykhoichieu;
            this.Ngayketthuc = ngayketthuc;
            this.Ghichu = ghichu;
        }

        public KeHoach(DataRow row) {
            this.Maphim = (string)row["MaPhim"];
            this.Macum = (string)row["MaCum"];
            this.Ngaykhoichieu = (DateTime?)row["NgayKhoiChieu"];
            this.Ngayketthuc = (DateTime?)row["NgayKetThuc"];
            this.Ghichu = (string)row["GhiChu"];
        }

        private string maphim;
        public string Maphim
        {
            get { return maphim; }
            set { maphim = value; }
        }
        private string macum;
        public string Macum
        {
            get { return macum; }
            set { macum = value; }
        }
        private DateTime? ngaykhoichieu;
        public DateTime? Ngaykhoichieu
        {
            get { return ngaykhoichieu; }
            set { ngaykhoichieu = value; }
        }
        private DateTime? ngayketthuc;
        public DateTime? Ngayketthuc
        {
            get { return ngayketthuc; }
            set { ngayketthuc = value; }
        }
        private string ghichu;
        public string Ghichu
        {
            get { return ghichu; }
            set { ghichu = value; }
        }
    }
}
