using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SuatChieu
    {
        public SuatChieu(string masuat,int giobatdau,int gioketthuc) { 
            this.Masuat = masuat;
            this.Giobatdau = giobatdau;
            this.Gioketthuc = gioketthuc;
        }
        public SuatChieu(DataRow row) {
            this.Masuat = (string)row["MaSuat"];
            this.Giobatdau = (int)row["GioBatDau"];
            this.Gioketthuc = (int)row["GioKetThuc"];
        }
        private string masuat;
        public string Masuat
        {
            get { return masuat; }
            set { masuat = value; }
        }
        private int giobatdau;
        public int Giobatdau
        {
            get { return giobatdau; }
            set { giobatdau = value; }
        }
        private int gioketthuc;
        public int Gioketthuc
        {
            get { return gioketthuc; }
            set { gioketthuc = value; }
        }
    }
}
