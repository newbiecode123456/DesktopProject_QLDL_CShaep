using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
        BindingSource BindingKeHoach = new BindingSource();
        BindingSource BindingLichChieu = new BindingSource();
        BindingSource BindingSuatChieu = new BindingSource();
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
            DataGridViewKeHoach.DataSource = BindingKeHoach;
            GetAllKeHoach();
            GetBindingKeHoach();
            DataGridViewLichChieu.DataSource = BindingLichChieu;
            GetAllLichChieu();
            GetBindingLichChieu();
            DataGridViewSuatChieu.DataSource = BindingSuatChieu;
            GetAllSuatChieu();
            GetBindingSuatChieu();
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

        private void btnThemPhimMoi_Click(object sender, EventArgs e)
        {
            if (btnThemPhim.Enabled)
            {
                btnThemPhimMoi.Text = "Thêm phim mới";
                btnThemPhim.Enabled = false;
            }
            else
            {
                btnThemPhim.Enabled = true;
                txtMaPhim.Text = "";
                txtTenPhim.Text = "";
                btnThemPhimMoi.Text = "Huỷ thêm phim mới";
            }
            
        }

        private void btnThemPhim_Click(object sender, EventArgs e)
        {
            string MaPhim = txtMaPhim.Text;
            string TenPhim = txtTenPhim.Text;
            string MaTheLoaiChinh = (ComboBoxMaTheLoaiChinh.SelectedItem as TheLoai).Matheloai;
            int ThoiLuong = Convert.ToInt32(txtThoiLuong.Text);
            if (MessageBox.Show("Thêm phim mới?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
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
        }

        private void btnSuaPhim_Click(object sender, EventArgs e)
        {
            string MaPhim = txtMaPhim.Text;
            string TenPhim = txtTenPhim.Text;
            string MaTheLoaiChinh = (ComboBoxMaTheLoaiChinh.SelectedItem as TheLoai).Matheloai;
            int ThoiLuong = Convert.ToInt32(txtThoiLuong.Text);
            if (MessageBox.Show("Cập nhật thông tin phim?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                if (PhimDAO.Instance.UpdatePhim(MaPhim, TenPhim, MaTheLoaiChinh, ThoiLuong))
                {
                    MessageBox.Show("Cập nhật Thông tin Phim Thành công!!");
                    GetAllPhim();
                }
                else
                {
                    MessageBox.Show("Cập nhật Thông tin Thất bại!!");
                }
            }
        }

        private void btnXoaPhim_Click(object sender, EventArgs e)
        {
            string MaPhim = txtMaPhim.Text;
            if (MessageBox.Show("Xoá phim này?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                if (PhimDAO.Instance.DeletePhim(MaPhim))
                {
                    MessageBox.Show("Đã xoá Phim!!");
                    GetAllPhim();
                }
                else
                {
                    MessageBox.Show("Xoá phim KHÔNG thành công!!!");
                }
            }
        }
        private void btnXemPhim_Click(object sender, EventArgs e)
        {
            GetAllPhim();
        }
        private void txtMaPhim_TextChanged(object sender, EventArgs e)
        {
            if (DataGridViewPhim.SelectedCells.Count > 0)
            {
                // xử lý Thể loại chính
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
                // xử lý Thể loại phụ
                FlowLayoutPanelTheLoaiPhu.Controls.Clear();
                ComboBoxMaTheLoaiChinh.SelectedIndex = index;
                string MP = (string)DataGridViewPhim.SelectedCells[0].OwningRow.Cells["MaPhim"].Value;
                List<TheLoai> theloaiphu = TheLoaiDAO.Instance.GetAllTheLoaiPhuofPhim(MP);
                List<TheLoai> alltheloai = TheLoaiDAO.Instance.GetAllTheLoai();
                foreach (TheLoai atl in alltheloai)
                {
                    if (atl.Matheloai != MTLC)
                    {
                        CheckBox chkbx = new CheckBox();
                        chkbx.Text = atl.Tentheloai;
                        //chkbx.Enabled = false;
                        PhimTheLoaiPhu tempPTLP = new PhimTheLoaiPhu(MP, atl.Matheloai);
                        chkbx.Tag = tempPTLP;
                        foreach (TheLoai tlp in theloaiphu)
                        {
                            if (tlp.Matheloai == atl.Matheloai)
                            {
                                chkbx.Checked = true;
                            }
                        }
                        chkbx.Click += chk_Click;
                        FlowLayoutPanelTheLoaiPhu.Controls.Add(chkbx);
                    }
                }
            }
        }
        private void chk_Click(object sender, EventArgs e)
        {
            string MaPhim = ((sender as CheckBox).Tag as PhimTheLoaiPhu).Maphim;
            string MaTheLoai = ((sender as CheckBox).Tag as PhimTheLoaiPhu).Matheloai;
            if (PhimTheLoaiPhuDAO.Instance.CheckorUncheckPhimTheLoaiPhu(MaPhim, MaTheLoai))
            {
                MessageBox.Show("Đã cập nhật thể loại phụ");
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra");
            }

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
            if (MessageBox.Show("Thêm thể loại phim mới?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
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
        }

        private void btnSuaTheLoai_Click(object sender, EventArgs e)
        {
            string MaTheLoai = txtMaTheLoai.Text;
            string TenTheLoai = txtTenTheLoai.Text;
            if (MessageBox.Show("Cập nhật thông tin thể loại phim?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                if (TheLoaiDAO.Instance.UpdateTheLoai(MaTheLoai, TenTheLoai))
                {
                    MessageBox.Show("Cập nhật Thể loại thành công!!!");
                    GetAllTheLoai();
                }
                else
                {
                    MessageBox.Show("Cập nhật thể loại KHÔNG thành công!!!");
                }
            }
        }

        private void btnXemTheLoai_Click(object sender, EventArgs e)
        {
            GetAllTheLoai();
        }
        private void btnXoaTheLoai_Click(object sender, EventArgs e)
        {
            string MaTheLoai = txtMaTheLoai.Text;
            if (MessageBox.Show("Xoá thể loại phim?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
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
            if (MessageBox.Show("Thêm rạp mới?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
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
        }

        private void btnSuaRap_Click(object sender, EventArgs e)
        {
            string MaRap = txtmaRap.Text;
            int TongGhe = Convert.ToInt32(txtTenRap.Text);
            string MaCum = (ComboBoxMaCumRap.SelectedItem as CumRap).Macum;
            if (MessageBox.Show("Cập nhật thông tin Rạp?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                if (RapDAO.Instance.UpdateRap(MaRap, TongGhe, MaCum))
                {
                    MessageBox.Show("Sửa Thông tin Rạp Thành công !!!!!");
                    GetAllRap();
                }
                else
                {
                    MessageBox.Show("Sửa Thông tin Rạp Thất bại!!!!");
                }
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
        private void txtmaRap_TextChanged(object sender, EventArgs e)
        {
            if (DataGridViewRap.SelectedCells.Count > 0)
            {
                string MCR = (string)DataGridViewRap.SelectedCells[0].OwningRow.Cells["MaCum"].Value;
                CumRap CR = CumRapDAO.Instance.GetCumRapofRap(MCR);
                ComboBoxMaCumRap.SelectedItem = CR;
                int index = -1;
                int i = 0;
                foreach (CumRap item in ComboBoxMaCumRap.Items)
                {
                    if (item.Macum == CR.Macum)
                    {
                        index = i;
                        break;
                    }
                    i++;
                }
                ComboBoxMaCumRap.SelectedIndex = index;
            }
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
            if (MessageBox.Show("Thêm cụm rạp mới?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
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
        }

        private void btnSuaCumRap_Click(object sender, EventArgs e)
        {
            string MaCum = txtMaCumRap.Text;
            string TenCum = txtTenCumRap.Text;
            string DiaChi = txtDiaChi.Text;
            if (MessageBox.Show("Cập nhật thông tin Cụm rạp?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
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

        #region KeHoach
        private void GetAllKeHoach()
        {
            BindingKeHoach.DataSource = KeHoachDAO.Instance.GetAllKeHoach();
            ComboBoxPhimofKeHoach.DataSource = PhimDAO.Instance.GetAllPhim();
            ComboBoxPhimofKeHoach.DisplayMember = "TenPhim";
            ComboBoxCumRapofKeHoach.DataSource = CumRapDAO.Instance.GetAllCumRap();
            ComboBoxCumRapofKeHoach.DisplayMember = "TenCum";
        }
        private void GetBindingKeHoach()
        {
            txtMaPhimofKeHoach.DataBindings.Add(new Binding("Text", DataGridViewKeHoach.DataSource, "MaPhim", true, DataSourceUpdateMode.Never));
            txtmaCumofKeHoach.DataBindings.Add(new Binding("Text", DataGridViewKeHoach.DataSource, "MaCum", true, DataSourceUpdateMode.Never));
            DateTimePickerNgayKhoiChieuofKeHoach.DataBindings.Add(new Binding("Value", DataGridViewKeHoach.DataSource, "NgayKhoiChieu", true, DataSourceUpdateMode.Never));
            DateTimePickerNgayKetThucofKeHoach.DataBindings.Add(new Binding("Value", DataGridViewKeHoach.DataSource, "NgayKetThuc", true, DataSourceUpdateMode.Never));
            txtGhiChuofKeHoach.DataBindings.Add(new Binding("Text", DataGridViewKeHoach.DataSource, "GhiChu", true, DataSourceUpdateMode.Never));
        }

        private int InsertSuatChieubyKeHoach(string MaPhim, string MaCum, DateTime NgayKhoiChieu, DateTime NgayKetThuc)
        {
            List<Rap> rapofcumrap = RapDAO.Instance.GetAllRapofCumRap(MaCum);
            int ktngay = 0;
            int sorapofcum = 0;
            TimeSpan songay = NgayKetThuc - NgayKhoiChieu;
            int TongSoNgay = songay.Days;

            foreach (Rap temprap in rapofcumrap)
            {
                // vòng lặp ngày
                for (int i = 0; i <= TongSoNgay; i++)
                {
                    if (CheckisExistLichChieu(temprap.Marap, NgayKhoiChieu.AddDays(i)) == 1)
                    {
                        ktngay++;
                    }
                }
            }
            if (ktngay > 0)
            {
                // đã tồn tại
                return 0;
            }
            else
            {
                //chưa tồn tại, tiến hành thêm
                foreach (Rap temprap in rapofcumrap)
                {
                    // vòng lặp ngày
                    for (int i = 0; i <= TongSoNgay; i++)
                    {
                        LichChieuDAO.Instance.InsertLichChieu(MaPhim, temprap.Marap, NgayKhoiChieu.AddDays(i), "");
                        ktngay++;
                    }
                }
                if (ktngay > 0)
                {
                    return 1;
                }
                else return 0; // đã thêm không thành công
            }
        }

        private void btnThemKeHoach_Click(object sender, EventArgs e)
        {
            //string MaPhim = txtMaPhimofKeHoach.Text;
            string MaPhim = (ComboBoxPhimofKeHoach.SelectedItem as Phim).Maphim;
            //string MaCum = txtmaCumofKeHoach.Text;
            string MaCum = (ComboBoxCumRapofKeHoach.SelectedItem as CumRap).Macum;
            DateTime NgayKhoiChieu = DateTimePickerNgayKhoiChieuofKeHoach.Value;
            DateTime NgayKetThuc = DateTimePickerNgayKetThucofKeHoach.Value;
            string GhiChu = txtGhiChuofKeHoach.Text;
            if (MessageBox.Show("Thêm Kế hoạch mới?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                if(InsertSuatChieubyKeHoach(MaPhim, MaCum, NgayKhoiChieu, NgayKetThuc) == 1)
                {
                    if (KeHoachDAO.Instance.InsertKeHoach(MaPhim, MaCum, NgayKhoiChieu, NgayKetThuc, GhiChu))
                    {
                        MessageBox.Show("Thêm Kế hoạch mới Thành công !!!!");
                        GetAllKeHoach();
                        GetAllLichChieu();
                    }
                    else
                    {
                        MessageBox.Show("Thêm kế hoạch KHÔNG thành công!!!!");
                    }
                } else MessageBox.Show("Thêm kế hoạch KHÔNG thành công!!!!");
            }
        }

        private void btnSuaKeHoach_Click(object sender, EventArgs e)
        {
            string MaPhim = txtMaPhimofKeHoach.Text;
            string MaCum = txtmaCumofKeHoach.Text;
            DateTime? NgayKhoiChieu = DateTimePickerNgayKhoiChieuofKeHoach.Value;
            DateTime? NgayKetThuc = DateTimePickerNgayKetThucofKeHoach.Value;
            string GhiChu = txtGhiChuofKeHoach.Text;
            if (MessageBox.Show("Sửa Ghi chú cho Kế hoạch ?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                if (KeHoachDAO.Instance.UpdateKeHoach(MaPhim, MaCum, NgayKhoiChieu, NgayKetThuc, GhiChu))
                {
                    MessageBox.Show("Sửa Ghi chú cho Kế hoạch Thành công !!!!");
                    GetAllKeHoach();
                }
                else
                {
                    MessageBox.Show("Sửa Ghi chú cho kế hoạch KHÔNG thành công!!!!");
                }
            }
        }

        private void btnXoaKeHoach_Click(object sender, EventArgs e)
        {
            string MaPhim = txtMaPhimofKeHoach.Text;
            string MaCum = txtmaCumofKeHoach.Text;
            DateTime? NgayKhoiChieu = DateTimePickerNgayKhoiChieuofKeHoach.Value;
            DateTime? NgayKetThuc = DateTimePickerNgayKetThucofKeHoach.Value;
            string GhiChu = txtGhiChuofKeHoach.Text;
            if (MessageBox.Show("Xoá Kế hoạch ?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                if (KeHoachDAO.Instance.DeleteKeHoach(MaPhim, MaCum, NgayKhoiChieu, NgayKetThuc))
                {
                    MessageBox.Show("Xoá Kế hoạch Thành công !!!!");
                    GetAllKeHoach();
                }
                else
                {
                    MessageBox.Show("Xoá kế hoạch KHÔNG thành công!!!!");
                }
            }
        }

        private void btnXemKeHoach_Click(object sender, EventArgs e)
        {
            GetAllKeHoach();
        }

        private void txtMaPhimofKeHoach_TextChanged(object sender, EventArgs e)
        {
            if (DataGridViewKeHoach.SelectedCells.Count > 0)
            {
                string MP = (string)DataGridViewKeHoach.SelectedCells[0].OwningRow.Cells["MaPhim"].Value;
                string MC = (string)DataGridViewKeHoach.SelectedCells[0].OwningRow.Cells["MaCum"].Value;
                
                int indexP = -1;
                int i = 0;
                foreach(Phim phim in ComboBoxPhimofKeHoach.Items)
                {
                    if (MP == phim.Maphim)
                    {
                        indexP = i;
                        break;
                    }
                    i++;
                }

                int indexCR = -1;
                int j = 0;
                foreach (CumRap cumr in ComboBoxCumRapofKeHoach.Items)
                {
                    if (MC == cumr.Macum)
                    {
                        indexCR = j;
                        break;
                    }
                    j++;
                }
                ComboBoxPhimofKeHoach.SelectedIndex = indexP;
                ComboBoxCumRapofKeHoach.SelectedIndex = indexCR;
            }
        }
        private void txtmaCumofKeHoach_TextChanged(object sender, EventArgs e)
        {
            if (DataGridViewKeHoach.SelectedCells.Count > 0)
            {
                string MP = (string)DataGridViewKeHoach.SelectedCells[0].OwningRow.Cells["MaPhim"].Value;
                string MC = (string)DataGridViewKeHoach.SelectedCells[0].OwningRow.Cells["MaCum"].Value;

                int indexP = -1;
                int i = 0;
                foreach (Phim phim in ComboBoxPhimofKeHoach.Items)
                {
                    if (MP == phim.Maphim)
                    {
                        indexP = i;
                        break;
                    }
                    i++;
                }

                int indexCR = -1;
                int j = 0;
                foreach (CumRap cumr in ComboBoxCumRapofKeHoach.Items)
                {
                    if (MC == cumr.Macum)
                    {
                        indexCR = j;
                        break;
                    }
                    j++;
                }
                ComboBoxPhimofKeHoach.SelectedIndex = indexP;
                ComboBoxCumRapofKeHoach.SelectedIndex = indexCR;
            }
        }
        #endregion

        #region LichChieu
        private void GetAllLichChieu()
        {
            ComboBoxPhimofLichChieu.DataSource = PhimDAO.Instance.GetAllPhim();
            ComboBoxPhimofLichChieu.DisplayMember = "TenPhim";
            BindingLichChieu.DataSource = LichChieuDAO.Instance.GetAllLichChieu();
        }
        private void GetBindingLichChieu()
        {
            txtMaPhimofLichChieu.DataBindings.Add(new Binding("Text", DataGridViewLichChieu.DataSource, "MaPhim", true, DataSourceUpdateMode.Never));
            txtMaRapofLichChieu.DataBindings.Add(new Binding("Text", DataGridViewLichChieu.DataSource, "MaRap", true, DataSourceUpdateMode.Never));
            DateTimePickerNgayChieuofLichChieu.DataBindings.Add(new Binding("Value", DataGridViewLichChieu.DataSource, "NgayChieu", true, DataSourceUpdateMode.Never));
            txtChuoiMaSuat.DataBindings.Add(new Binding("Text", DataGridViewLichChieu.DataSource, "ChuoiMaSuat", true, DataSourceUpdateMode.Never));
        }
        private int CheckisExistLichChieu(string MaRap, DateTime NgayKhoiChieu)
        {
            if (LichChieuDAO.Instance.CheckExistLichChieu(MaRap, NgayKhoiChieu))
            {
                return 1;
            }

            else
                return 0;
        }

        private void btnThemLichChieu_Click(object sender, EventArgs e)
        {
            //string MaPhim = txtMaPhimofLichChieu.Text;
            string MaPhim = (ComboBoxPhimofLichChieu.SelectedItem as Phim).Maphim;
            string MaRap = txtMaRapofLichChieu.Text;
            DateTime NgayChieu = DateTimePickerNgayChieuofLichChieu.Value;
            string ChuoiMaSuat = txtChuoiMaSuat.Text;
            if (MessageBox.Show("Thêm Lịch chiếu mới?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                if (CheckisExistLichChieu(MaRap,NgayChieu)==1)
                {
                    if(LichChieuDAO.Instance.InsertLichChieu(MaPhim, MaRap, NgayChieu, ChuoiMaSuat))
                    {
                        MessageBox.Show("Thêm Lịch chiếu mới Thành công !!!!");
                        GetAllLichChieu();
                    }
                }
                else
                {
                    MessageBox.Show("Thêm Lịch chiếu KHÔNG thành công!!!!");
                }
            }
        }



        private void btnSuaLichChieu_Click(object sender, EventArgs e)
        {
            string MaPhim = txtMaPhimofLichChieu.Text;
            string MaRap = txtMaRapofLichChieu.Text;
            DateTime? NgayChieu = DateTimePickerNgayChieuofLichChieu.Value;
            string ChuoiMaSuat = txtChuoiMaSuat.Text;
            if (MessageBox.Show("Đặt lại tất cả Suất chiếu của Lịch chiếu này?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                if (LichChieuDAO.Instance.UpdateLichChieu(MaPhim, MaRap, NgayChieu, ""))
                {
                    MessageBox.Show("Đặt lại tất cả Suất chiếu của Lịch chiếu Thành công !!!!");
                    GetAllLichChieu();
                }
                else
                {
                    MessageBox.Show("Đặt lại tất cả Suất chiếu của Lịch chiếu KHÔNG thành công!!!!");
                }
            }
        }

        private void btnXoaLichChieu_Click(object sender, EventArgs e)
        {
            string MaPhim = txtMaPhimofLichChieu.Text;
            string MaRap = txtMaRapofLichChieu.Text;
            DateTime? NgayChieu = DateTimePickerNgayChieuofLichChieu.Value;
            if (MessageBox.Show("Xoá Lịch chiếu?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                if (LichChieuDAO.Instance.DeleteLichChieu(MaPhim, MaRap, NgayChieu))
                {
                    MessageBox.Show("Xoá Lịch chiếu Thành công !!!!");
                    GetAllLichChieu();
                }
                else
                {
                    MessageBox.Show("Xoá Lịch chiếu KHÔNG thành công!!!!");
                }
            }
        }

        private void btnXemLichChieu_Click(object sender, EventArgs e)
        {
            GetAllLichChieu();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // xử lý Thể loại phụ
            
        }

        private int CheckifExistLichChieu(string MaRap, DateTime? NgayChieu, string ChuoiMaSuat)
        {
            if (LichChieuDAO.Instance.CheckIfExistLichChieu(MaRap, NgayChieu, ChuoiMaSuat))
            {
                return 1;
            }

            else
                return 0;
        }

        private void txtMaRapofLichChieu_TextChanged(object sender, EventArgs e)
        {
            

            FlowLayoutPanelChuoiMaSuat.Controls.Clear();
            List<SuatChieu> suatChieus = SuatChieuDAO.Instance.GetAllSuatChieu();
            string MaPhim = (string)DataGridViewLichChieu.SelectedCells[0].OwningRow.Cells["MaPhim"].Value;
            string MaRap = (string)DataGridViewLichChieu.SelectedCells[0].OwningRow.Cells["MaRap"].Value;
            DateTime? NgayChieu = (DateTime?)DataGridViewLichChieu.SelectedCells[0].OwningRow.Cells["NgayChieu"].Value;
            string ChuoiMaSuat = (string)DataGridViewLichChieu.SelectedCells[0].OwningRow.Cells["ChuoiMaSuat"].Value;
            LichChieu lc = new LichChieu(MaPhim, MaRap, NgayChieu, ChuoiMaSuat);
            foreach (SuatChieu sc in suatChieus)
            {
                CheckBox chkbox = new CheckBox();
                chkbox.Text = sc.Masuat + ":" + sc.Giobatdau + ":" + sc.Phutbatdau;
                if(CheckifExistLichChieu(MaRap, NgayChieu, sc.Masuat)==1){
                    chkbox.Enabled = false;
                }

                chkbox.Tag = lc;
                if (ChuoiMaSuat.Length >= 3)
                {
                    if (ChuoiMaSuat.Contains(sc.Masuat))
                    {
                        chkbox.Checked = true;
                    }
                }
                chkbox.Click += chkbox_Click;
                FlowLayoutPanelChuoiMaSuat.Controls.Add(chkbox);
            }
        }
        private void txtMaPhimofLichChieu_TextChanged(object sender, EventArgs e)
        {
            // xử lý Phim Combobox
            string MP = (string)DataGridViewLichChieu.SelectedCells[0].OwningRow.Cells["MaPhim"].Value;

            int indexP = -1;
            int i = 0;
            foreach (Phim phim in ComboBoxPhimofLichChieu.Items)
            {
                if (MP == phim.Maphim)
                {
                    indexP = i;
                    break;
                }
                i++;
            }
            ComboBoxPhimofLichChieu.SelectedIndex = indexP;

            FlowLayoutPanelChuoiMaSuat.Controls.Clear();
            List<SuatChieu> suatChieus = SuatChieuDAO.Instance.GetAllSuatChieu();
            string MaPhim = (string)DataGridViewLichChieu.SelectedCells[0].OwningRow.Cells["MaPhim"].Value;
            string MaRap = (string)DataGridViewLichChieu.SelectedCells[0].OwningRow.Cells["MaRap"].Value;
            DateTime? NgayChieu = (DateTime?)DataGridViewLichChieu.SelectedCells[0].OwningRow.Cells["NgayChieu"].Value;
            string ChuoiMaSuat = (string)DataGridViewLichChieu.SelectedCells[0].OwningRow.Cells["ChuoiMaSuat"].Value;
            LichChieu lc = new LichChieu(MaPhim,MaRap,NgayChieu,ChuoiMaSuat);
            foreach (SuatChieu sc in suatChieus)
            {
                CheckBox chkbox = new CheckBox();
                chkbox.Text = sc.Masuat + ":" + sc.Giobatdau + ":" + sc.Phutbatdau;
                chkbox.Tag = lc;
                if (CheckifExistLichChieu(MaRap, NgayChieu, sc.Masuat) == 1)
                {
                    chkbox.Enabled = false;
                }
                if (ChuoiMaSuat.Length >= 3)
                {
                    if (ChuoiMaSuat.Contains(sc.Masuat))
                    {
                        chkbox.Checked = true;
                    }
                }
                chkbox.Click += chkbox_Click;
                FlowLayoutPanelChuoiMaSuat.Controls.Add(chkbox);
            }
        }

        private void DateTimePickerNgayChieuofLichChieu_ValueChanged(object sender, EventArgs e)
        {

            FlowLayoutPanelChuoiMaSuat.Controls.Clear();
            List<SuatChieu> suatChieus = SuatChieuDAO.Instance.GetAllSuatChieu();
            string MaPhim = (string)DataGridViewLichChieu.SelectedCells[0].OwningRow.Cells["MaPhim"].Value;
            string MaRap = (string)DataGridViewLichChieu.SelectedCells[0].OwningRow.Cells["MaRap"].Value;
            DateTime? NgayChieu = (DateTime?)DataGridViewLichChieu.SelectedCells[0].OwningRow.Cells["NgayChieu"].Value;
            string ChuoiMaSuat = (string)DataGridViewLichChieu.SelectedCells[0].OwningRow.Cells["ChuoiMaSuat"].Value;
            LichChieu lc = new LichChieu(MaPhim, MaRap, NgayChieu, ChuoiMaSuat);
            foreach (SuatChieu sc in suatChieus)
            {
                CheckBox chkbox = new CheckBox();
                chkbox.Text = sc.Masuat + ":" + sc.Giobatdau + ":" + sc.Phutbatdau;
                if (CheckifExistLichChieu(MaRap, NgayChieu, sc.Masuat) == 1)
                {
                    chkbox.Enabled = false;
                }
                Console.WriteLine();
                chkbox.Tag = lc;
                if (ChuoiMaSuat.Length >= 3)
                {
                    if (ChuoiMaSuat.Contains(sc.Masuat))
                    {
                        chkbox.Checked = true;
                    }
                }
                chkbox.Click += chkbox_Click;
                FlowLayoutPanelChuoiMaSuat.Controls.Add(chkbox);
            }
        }

        private void chkbox_Click(object sender, EventArgs e)
        {
            string marap = ((sender as CheckBox).Tag as LichChieu).Marap;
            string maphim = ((sender as CheckBox).Tag as LichChieu).Maphim;
            DateTime? ngaychieu = ((sender as CheckBox).Tag as LichChieu).Ngaychieu;
            string chuoimasuat = ((sender as CheckBox).Tag as LichChieu).Chuoimasuat;
            string chuoi = (sender as CheckBox).Text;
            string machuoicat = chuoi.Substring(0, 3);
            
            if ((sender as CheckBox).Checked == false)
            {
                // BỎ TÍCH CHỌN
                // Chuỗi sau khi cắt Mã suất vd "S20"
                string chuoiupdate = chuoimasuat.Replace(machuoicat, "");
                LichChieuDAO.Instance.UpdateLichChieu(maphim, marap, ngaychieu, chuoiupdate);
                MessageBox.Show("Đã cập nhật");
                GetAllLichChieu();
            }
            else { 
                if((sender as CheckBox).Checked == true) {
                    // TÍCH CHỌN
                    string chuoiupdate = chuoimasuat + machuoicat;
                    LichChieuDAO.Instance.UpdateLichChieu(maphim, marap, ngaychieu, chuoiupdate);
                    MessageBox.Show("Đã cập nhật");
                    GetAllLichChieu();
                }
                else {
                    MessageBox.Show("Có lỗi xảy ra!!!!!");
                }
            }
        }
        #endregion

        #region SuatChieu
        private void GetAllSuatChieu()
        {
            BindingSuatChieu.DataSource = SuatChieuDAO.Instance.GetAllSuatChieu();
        }
        private void GetBindingSuatChieu()
        {
            txtMaSuatChieuofSuatChieu.DataBindings.Add(new Binding("Text", DataGridViewSuatChieu.DataSource, "MaSuat", true, DataSourceUpdateMode.Never));
            NumericUpDownGioBatDau.DataBindings.Add(new Binding("Text", DataGridViewSuatChieu.DataSource, "GioBatDau", true, DataSourceUpdateMode.Never));
            NumericUpDownPhutBatDau.DataBindings.Add(new Binding("Text", DataGridViewSuatChieu.DataSource, "PhutBatDau", true, DataSourceUpdateMode.Never));
        }
        private void btnThemSuatChieu_Click(object sender, EventArgs e)
        {
            int GioBatDau = Convert.ToInt32(NumericUpDownGioBatDau.Text);
            int PhutBatDau = Convert.ToInt32(NumericUpDownPhutBatDau.Text);
            string MaSuat = GioBatDau < 10?"S0"+GioBatDau.ToString() : "S"+GioBatDau.ToString();
            if (MessageBox.Show("Thêm Suất chiếu mới?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                if (SuatChieuDAO.Instance.InsertSuatChieu(MaSuat, GioBatDau,PhutBatDau))
                {
                    MessageBox.Show("Thêm Suất chiếu mới Thành công !!!!");
                    GetAllSuatChieu();
                }
                else
                {
                    MessageBox.Show("Thêm Suất chiếu KHÔNG thành công!!!!");
                }
            }
        }

        private void btnSuaSuatChieu_Click(object sender, EventArgs e)
        {
            string MaSuat = txtMaSuatChieuofSuatChieu.Text;
            int GioBatDau = Convert.ToInt32(NumericUpDownPhutBatDau.Text);
            int PhutBatDau = Convert.ToInt32(NumericUpDownPhutBatDau.Text);
            if (MessageBox.Show("Sửa thông tin Suất chiếu?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                if (SuatChieuDAO.Instance.UpdateSuatChieu(MaSuat, GioBatDau, PhutBatDau))
                {
                    MessageBox.Show("Sửa thông tin Suất chiếu Thành công !!!!");
                    GetAllSuatChieu();
                }
                else
                {
                    MessageBox.Show("Sửa thông tin Suất chiếu KHÔNG thành công!!!!");
                }
            }
        }

        private void btnXoaSuatChieu_Click(object sender, EventArgs e)
        {
            string MaSuat = txtMaSuatChieuofSuatChieu.Text;
            if (MessageBox.Show("Xoá Suất chiếu?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                if (SuatChieuDAO.Instance.DeleteSuatChieu(MaSuat))
                {
                    MessageBox.Show("Xoá Suất chiếu Thành công !!!!");
                    GetAllSuatChieu();
                }
                else
                {
                    MessageBox.Show("Xoá Suất chiếu KHÔNG thành công!!!!");
                }
            }
        }

        private void btnXemSuatChieu_Click(object sender, EventArgs e)
        {
            GetAllSuatChieu();
        }

        #endregion
        private void TabTheLoai_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

       
    }
}
