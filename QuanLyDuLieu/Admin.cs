﻿using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDuLieu
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
            LoadInit();
        }
        BindingSource BindingPhim = new BindingSource();
        BindingSource BindingTheLoai = new BindingSource();
        BindingSource BindingRap = new BindingSource();
        BindingSource BindingCumRap = new BindingSource();
        private void LoadInit()
        {
            DataGridViewPhim.DataSource = BindingPhim;
            GetAllPhim();
            GetBindingPhim();
            DataGridViewTheLoai.DataSource = BindingTheLoai;
            GetAllTheLoai();
            GetBindingTheLoai();
            DataGridViewRap.DataSource = BindingRap;
            GetAllRap();
            GetBindingRap();
            DataGridViewCumRap.DataSource = BindingCumRap;
            GetAllCumRap();
            GetBindingCumRap();
        }


        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        #region Phim
        private void GetAllPhim()
        {
            BindingPhim.DataSource = PhimDAO.Instance.GetAllPhim();
            ComboBoxMaTheLoaiChinh.DataSource = TheLoaiDAO.Instance.GetAllTheLoai();
            ComboBoxMaTheLoaiChinh.DisplayMember = "TenTheLoai";
        }
        private void GetBindingPhim()
        {
            txtMaPhim.DataBindings.Add(new Binding("Text", DataGridViewPhim.DataSource, "MaPhim", true, DataSourceUpdateMode.Never));
            txtTenPhim.DataBindings.Add(new Binding("Text", DataGridViewPhim.DataSource, "TenPhim", true, DataSourceUpdateMode.Never));
            txtThoiLuong.DataBindings.Add(new Binding("Text", DataGridViewPhim.DataSource, "ThoiLuong", true, DataSourceUpdateMode.Never));
            //CheckedListBoxTheLoai.Items.Add(new Binding("Value", DataGridViewPhim.DataSource, "MaTheLoaiChinh", true, DataSourceUpdateMode.Never));
            //CheckedListBoxTheLoai.Items.Add("a");
        }

        private void btnThemPhim_Click(object sender, EventArgs e)
        {
            string MaPhim = txtMaPhim.Text;
            string TenPhim = txtTenPhim.Text;
            string MaTheLoaiChinh = (ComboBoxMaTheLoaiChinh.SelectedItem as TheLoai).Matheloai;
            int ThoiLuong = Convert.ToInt32(txtThoiLuong.Text);
            if (PhimDAO.Instance.InsertPhim(MaPhim, TenPhim, MaTheLoaiChinh, ThoiLuong))
            {
                MessageBox.Show("Thêm phim mới thành công!!");
                GetAllPhim();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra!!!");
            }
        }

        private void btnSuaPhim_Click(object sender, EventArgs e)
        {
            string MaPhim = txtMaPhim.Text;
            string TenPhim = txtTenPhim.Text;
            string MaTheLoaiChinh = (ComboBoxMaTheLoaiChinh.SelectedItem as TheLoai).Matheloai;
            int ThoiLuong = Convert.ToInt32(txtThoiLuong.Text);
            if (PhimDAO.Instance.UpdatePhim(MaPhim, TenPhim, MaTheLoaiChinh, ThoiLuong))
            {
                MessageBox.Show("Cập nhật Thông tin Phim Thành công!!");
                GetAllPhim();
            } else
            {
                MessageBox.Show("Cập nhật Thông tin Thất bại!!");
            }
        }

        private void btnXoaPhim_Click(object sender, EventArgs e)
        {
            string MaPhim = txtMaPhim.Text;
            if (PhimDAO.Instance.DeletePhim(MaPhim))
            {
                MessageBox.Show("Đã xoá Phim!!");
                GetAllPhim();
            }
            else {
                MessageBox.Show("Xoá phim KHÔNG thành công!!!");
            }
        }
        private void btnXemPhim_Click(object sender, EventArgs e)
        {
            GetAllPhim();
        }
        #endregion

        #region TheLoai
        private void GetAllTheLoai()
        {
            BindingTheLoai.DataSource = TheLoaiDAO.Instance.GetAllTheLoai();
            
        }
        private void GetBindingTheLoai()
        {
            txtMaTheLoai.DataBindings.Add(new Binding("Text", DataGridViewTheLoai.DataSource, "MaTheLoai", true, DataSourceUpdateMode.Never));
            txtTenTheLoai.DataBindings.Add(new Binding("Text", DataGridViewTheLoai.DataSource, "TenTheLoai", true, DataSourceUpdateMode.Never));
        }

        private void btnThemTheLoai_Click(object sender, EventArgs e)
        {
            string MaTheLoai = txtMaTheLoai.Text;
            string TenTheLoai = txtTenTheLoai.Text;
            if (TheLoaiDAO.Instance.InsertTheLoai(MaTheLoai, TenTheLoai))
            {
                MessageBox.Show("Thêm Thể loại phim mới Thành công!!");
                GetAllTheLoai();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra!!");
            }
        }

        private void btnSuaTheLoai_Click(object sender, EventArgs e)
        {
            string MaTheLoai = txtMaTheLoai.Text;
            string TenTheLoai = txtTenTheLoai.Text;
            if (TheLoaiDAO.Instance.UpdateTheLoai(MaTheLoai, TenTheLoai))
            {
                MessageBox.Show("Cập nhật Thể loại thành công!!!");
                GetAllTheLoai();
            }
            else {
                MessageBox.Show("Cập nhật thể loại KHÔNG thành công!!!");
            }
        }

        private void btnXemTheLoai_Click(object sender, EventArgs e)
        {
            GetAllTheLoai();
        }
        private void btnXoaTheLoai_Click(object sender, EventArgs e)
        {
            string MaTheLoai = txtMaTheLoai.Text;
            if (TheLoaiDAO.Instance.DeleteTheLoai(MaTheLoai))
            {
                MessageBox.Show("Xoá Thể loại thành công!!");
                GetAllTheLoai();
            }
            else
            {
                MessageBox.Show("Xoá thể loại không thành công!!!");
            }
        }
        #endregion

        #region Rap

        private void GetAllRap()
        {
            BindingRap.DataSource = RapDAO.Instance.GetAllRap();
            ComboBoxMaCumRap.DataSource = CumRapDAO.Instance.GetAllCumRap();
            ComboBoxMaCumRap.DisplayMember = "TenCum";
        }

        private void GetBindingRap()
        {
            txtmaRap.DataBindings.Add(new Binding("Text", DataGridViewRap.DataSource, "MaRap", true, DataSourceUpdateMode.Never));
            txtTenRap.DataBindings.Add(new Binding("Text", DataGridViewRap.DataSource, "TongGhe", true, DataSourceUpdateMode.Never));
        }

        private void btnThemRap_Click(object sender, EventArgs e)
        {
            string MaRap = txtmaRap.Text;
            int TongGhe = Convert.ToInt32(txtTenRap.Text);
            string MaCum = (ComboBoxMaCumRap.SelectedItem as CumRap).Macum;
            if (RapDAO.Instance.InsertRap(MaRap, TongGhe, MaCum))
            {
                MessageBox.Show("Thêm Rạp mới Thành công!!");
                GetAllRap();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra!!");
            }
        }

        private void btnSuaRap_Click(object sender, EventArgs e)
        {
            string MaRap = txtmaRap.Text;
            int TongGhe = Convert.ToInt32(txtTenRap.Text);
            string MaCum = (ComboBoxMaCumRap.SelectedItem as CumRap).Macum;
            if (RapDAO.Instance.UpdateRap(MaRap, TongGhe, MaCum))
            {
                MessageBox.Show("Sửa Thông tin Rạp Thành công !!!!!");
                GetAllRap();
            }
            else {
                MessageBox.Show("Sửa Thông tin Rạp Thất bại!!!!");
            }
        }
        private void btnXoaRap_Click(object sender, EventArgs e)
        {
            string MaRap = txtmaRap.Text;
            if(MessageBox.Show("Xoá Rạp","Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                if (RapDAO.Instance.DeleteRap(MaRap))
                {
                    MessageBox.Show("Xoá Rạp thành công!!");
                    GetAllRap();
                }
                else {
                    MessageBox.Show("Xoá Rạp KHÔNG thành công!!");
                }
            }
        }
        private void btnXemRap_Click(object sender, EventArgs e)
        {
            GetAllRap();
        }
        #endregion

        #region CumRap
        private void GetAllCumRap()
        {
            BindingCumRap.DataSource = CumRapDAO.Instance.GetAllCumRap();
            Console.WriteLine();
        }
        private void GetBindingCumRap()
        {
            txtMaCumRap.DataBindings.Add(new Binding("Text", DataGridViewCumRap.DataSource, "MaCum", true, DataSourceUpdateMode.Never));
            txtTenCumRap.DataBindings.Add(new Binding("Text", DataGridViewCumRap.DataSource, "TenCum", true, DataSourceUpdateMode.Never));
            txtDiaChi.DataBindings.Add(new Binding("Text", DataGridViewCumRap.DataSource, "DiaChi", true, DataSourceUpdateMode.Never));
        }

        private void btnThemCumRap_Click(object sender, EventArgs e)
        {
            string MaCum = txtMaCumRap.Text;
            string TenCum = txtTenCumRap.Text;
            string DiaChi = txtDiaChi.Text;
            if (CumRapDAO.Instance.InsertCumRap(MaCum, TenCum, DiaChi))
            {
                MessageBox.Show("Thêm Cụm Rạp mới Thành công");
                GetAllCumRap();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra!!");
            }
        }

        private void btnSuaCumRap_Click(object sender, EventArgs e)
        {
            string MaCum = txtMaCumRap.Text;
            string TenCum = txtTenCumRap.Text;
            string DiaChi = txtDiaChi.Text;
            if (CumRapDAO.Instance.UpdateCumRap(MaCum, TenCum, DiaChi))
            {
                MessageBox.Show("Cập nhật Thông tin cụm rạp Thành công");
                GetAllCumRap();
            }
            else
            {
                MessageBox.Show("Cập nhật Thông tin Cụm rạp KHÔNG thành công!!");
            }
        }
        private void btnXemCumRap_Click(object sender, EventArgs e)
        {
            GetAllCumRap();
        }
        private void btnXoaCumRap_Click(object sender, EventArgs e)
        {
            string MaCum = txtMaCumRap.Text;
            if(MessageBox.Show("Xoá Cụm rạp?","Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                if (CumRapDAO.Instance.DeleteCumRap(MaCum))
                {
                    MessageBox.Show("Xoá Cụm rạp Thành công !!!!");
                    GetAllCumRap();
                }
                else
                {
                    MessageBox.Show("Xoá Cụm rạp KHÔNG thành công!!!!");
                }
            }
        }
        #endregion

        private void TabTheLoai_Click(object sender, EventArgs e)
        {

        }

        private void txtMaPhim_TextChanged(object sender, EventArgs e)
        {
            if(DataGridViewPhim.SelectedCells.Count > 0)
            {
                string MTLC = (string)DataGridViewPhim.SelectedCells[0].OwningRow.Cells["MaTheLoaiChinh"].Value;
                TheLoai TL = TheLoaiDAO.Instance.GetTheLoaiChinhofPhim(MTLC);
                ComboBoxMaTheLoaiChinh.SelectedItem = TL;
                int index = -1;
                int i = 0;
                foreach (TheLoai item in ComboBoxMaTheLoaiChinh.Items)
                {
                    if (item.Matheloai == TL.Matheloai)
                    {
                        index = i;
                        break;
                    }
                    i++;
                }
                ComboBoxMaTheLoaiChinh.SelectedIndex = index;

            }
        }

        private void txtmaRap_TextChanged(object sender, EventArgs e)
        {
            if(DataGridViewRap.SelectedCells.Count > 0)
            {
                string MCR = (string)DataGridViewRap.SelectedCells[0].OwningRow.Cells["MaCum"].Value;
                CumRap CR = CumRapDAO.Instance.GetCumRapofRap(MCR);
                ComboBoxMaCumRap.SelectedItem = CR;
                int index = -1;
                int i = 0;
                foreach(CumRap item in ComboBoxMaCumRap.Items)
                {
                    if(item.Macum == CR.Macum)
                    {
                        index = i;
                        break;
                    }
                    i++;
                }
                ComboBoxMaCumRap.SelectedIndex = index;
            }
        }

        
    }
}