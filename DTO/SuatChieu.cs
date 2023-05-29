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
        public SuatChieu(string masuat,int giobatdau,int phutbatdau) { 
            this.Masuat = masuat;
            this.Giobatdau = giobatdau;
            this.Phutbatdau = phutbatdau;
        }
        public SuatChieu(DataRow row) {
            this.Masuat = (string)row["MaSuat"];
            this.Giobatdau = (int)row["GioBatDau"];
            this.Phutbatdau = (int)row["PhutBatDau"];
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
        private int phutbatdau;
        public int Phutbatdau
        {
            get { return phutbatdau; }
            set { phutbatdau = value; }
        }
    }
}
