namespace QuanLyDuLieu
{
    partial class FormAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlAdmin = new System.Windows.Forms.TabControl();
            this.TabPhim = new System.Windows.Forms.TabPage();
            this.ComboBoxMaTheLoaiChinh = new System.Windows.Forms.ComboBox();
            this.btnXemPhim = new System.Windows.Forms.Button();
            this.btnXoaPhim = new System.Windows.Forms.Button();
            this.btnSuaPhim = new System.Windows.Forms.Button();
            this.btnThemPhim = new System.Windows.Forms.Button();
            this.txtThoiLuong = new System.Windows.Forms.TextBox();
            this.txtTenPhim = new System.Windows.Forms.TextBox();
            this.txtMaPhim = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DataGridViewPhim = new System.Windows.Forms.DataGridView();
            this.TabTheLoai = new System.Windows.Forms.TabPage();
            this.btnXemTheLoai = new System.Windows.Forms.Button();
            this.btnXoaTheLoai = new System.Windows.Forms.Button();
            this.btnSuaTheLoai = new System.Windows.Forms.Button();
            this.btnThemTheLoai = new System.Windows.Forms.Button();
            this.txtTenTheLoai = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaTheLoai = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DataGridViewTheLoai = new System.Windows.Forms.DataGridView();
            this.TabRap = new System.Windows.Forms.TabPage();
            this.ComboBoxMaCumRap = new System.Windows.Forms.ComboBox();
            this.btnXemRap = new System.Windows.Forms.Button();
            this.btnXoaRap = new System.Windows.Forms.Button();
            this.btnSuaRap = new System.Windows.Forms.Button();
            this.btnThemRap = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTenRap = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtmaRap = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DataGridViewRap = new System.Windows.Forms.DataGridView();
            this.TabCumRap = new System.Windows.Forms.TabPage();
            this.DataGridViewCumRap = new System.Windows.Forms.DataGridView();
            this.btnXemCumRap = new System.Windows.Forms.Button();
            this.btnXoaCumRap = new System.Windows.Forms.Button();
            this.btnSuaCumRap = new System.Windows.Forms.Button();
            this.btnThemCumRap = new System.Windows.Forms.Button();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTenCumRap = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMaCumRap = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControlAdmin.SuspendLayout();
            this.TabPhim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPhim)).BeginInit();
            this.TabTheLoai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTheLoai)).BeginInit();
            this.TabRap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewRap)).BeginInit();
            this.TabCumRap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCumRap)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlAdmin
            // 
            this.tabControlAdmin.Controls.Add(this.TabPhim);
            this.tabControlAdmin.Controls.Add(this.TabTheLoai);
            this.tabControlAdmin.Controls.Add(this.TabRap);
            this.tabControlAdmin.Controls.Add(this.TabCumRap);
            this.tabControlAdmin.Location = new System.Drawing.Point(16, 15);
            this.tabControlAdmin.Name = "tabControlAdmin";
            this.tabControlAdmin.SelectedIndex = 0;
            this.tabControlAdmin.Size = new System.Drawing.Size(786, 423);
            this.tabControlAdmin.TabIndex = 0;
            // 
            // TabPhim
            // 
            this.TabPhim.Controls.Add(this.ComboBoxMaTheLoaiChinh);
            this.TabPhim.Controls.Add(this.btnXemPhim);
            this.TabPhim.Controls.Add(this.btnXoaPhim);
            this.TabPhim.Controls.Add(this.btnSuaPhim);
            this.TabPhim.Controls.Add(this.btnThemPhim);
            this.TabPhim.Controls.Add(this.txtThoiLuong);
            this.TabPhim.Controls.Add(this.txtTenPhim);
            this.TabPhim.Controls.Add(this.txtMaPhim);
            this.TabPhim.Controls.Add(this.label4);
            this.TabPhim.Controls.Add(this.label3);
            this.TabPhim.Controls.Add(this.label2);
            this.TabPhim.Controls.Add(this.label1);
            this.TabPhim.Controls.Add(this.DataGridViewPhim);
            this.TabPhim.Location = new System.Drawing.Point(4, 25);
            this.TabPhim.Name = "TabPhim";
            this.TabPhim.Padding = new System.Windows.Forms.Padding(3);
            this.TabPhim.Size = new System.Drawing.Size(778, 394);
            this.TabPhim.TabIndex = 0;
            this.TabPhim.Text = "Phim";
            this.TabPhim.UseVisualStyleBackColor = true;
            // 
            // ComboBoxMaTheLoaiChinh
            // 
            this.ComboBoxMaTheLoaiChinh.FormattingEnabled = true;
            this.ComboBoxMaTheLoaiChinh.Location = new System.Drawing.Point(540, 96);
            this.ComboBoxMaTheLoaiChinh.Name = "ComboBoxMaTheLoaiChinh";
            this.ComboBoxMaTheLoaiChinh.Size = new System.Drawing.Size(214, 24);
            this.ComboBoxMaTheLoaiChinh.TabIndex = 13;
            // 
            // btnXemPhim
            // 
            this.btnXemPhim.Location = new System.Drawing.Point(655, 279);
            this.btnXemPhim.Name = "btnXemPhim";
            this.btnXemPhim.Size = new System.Drawing.Size(99, 39);
            this.btnXemPhim.TabIndex = 12;
            this.btnXemPhim.Text = "Xem";
            this.btnXemPhim.UseVisualStyleBackColor = true;
            this.btnXemPhim.Click += new System.EventHandler(this.btnXemPhim_Click);
            // 
            // btnXoaPhim
            // 
            this.btnXoaPhim.Location = new System.Drawing.Point(540, 279);
            this.btnXoaPhim.Name = "btnXoaPhim";
            this.btnXoaPhim.Size = new System.Drawing.Size(99, 39);
            this.btnXoaPhim.TabIndex = 11;
            this.btnXoaPhim.Text = "Xoá";
            this.btnXoaPhim.UseVisualStyleBackColor = true;
            this.btnXoaPhim.Click += new System.EventHandler(this.btnXoaPhim_Click);
            // 
            // btnSuaPhim
            // 
            this.btnSuaPhim.Location = new System.Drawing.Point(655, 234);
            this.btnSuaPhim.Name = "btnSuaPhim";
            this.btnSuaPhim.Size = new System.Drawing.Size(99, 39);
            this.btnSuaPhim.TabIndex = 10;
            this.btnSuaPhim.Text = "Sửa";
            this.btnSuaPhim.UseVisualStyleBackColor = true;
            this.btnSuaPhim.Click += new System.EventHandler(this.btnSuaPhim_Click);
            // 
            // btnThemPhim
            // 
            this.btnThemPhim.Location = new System.Drawing.Point(540, 234);
            this.btnThemPhim.Name = "btnThemPhim";
            this.btnThemPhim.Size = new System.Drawing.Size(99, 39);
            this.btnThemPhim.TabIndex = 9;
            this.btnThemPhim.Text = "Thêm";
            this.btnThemPhim.UseVisualStyleBackColor = true;
            this.btnThemPhim.Click += new System.EventHandler(this.btnThemPhim_Click);
            // 
            // txtThoiLuong
            // 
            this.txtThoiLuong.Location = new System.Drawing.Point(540, 206);
            this.txtThoiLuong.Name = "txtThoiLuong";
            this.txtThoiLuong.Size = new System.Drawing.Size(214, 22);
            this.txtThoiLuong.TabIndex = 7;
            // 
            // txtTenPhim
            // 
            this.txtTenPhim.Location = new System.Drawing.Point(540, 51);
            this.txtTenPhim.Name = "txtTenPhim";
            this.txtTenPhim.Size = new System.Drawing.Size(214, 22);
            this.txtTenPhim.TabIndex = 6;
            // 
            // txtMaPhim
            // 
            this.txtMaPhim.Location = new System.Drawing.Point(622, 4);
            this.txtMaPhim.Name = "txtMaPhim";
            this.txtMaPhim.Size = new System.Drawing.Size(132, 22);
            this.txtMaPhim.TabIndex = 5;
            this.txtMaPhim.TextChanged += new System.EventHandler(this.txtMaPhim_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(537, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Thời lượng phim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(537, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Thể loại Chính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(537, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên phim";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(537, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Phim";
            // 
            // DataGridViewPhim
            // 
            this.DataGridViewPhim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewPhim.Location = new System.Drawing.Point(6, 6);
            this.DataGridViewPhim.Name = "DataGridViewPhim";
            this.DataGridViewPhim.RowHeadersWidth = 51;
            this.DataGridViewPhim.RowTemplate.Height = 24;
            this.DataGridViewPhim.Size = new System.Drawing.Size(504, 381);
            this.DataGridViewPhim.TabIndex = 0;
            // 
            // TabTheLoai
            // 
            this.TabTheLoai.Controls.Add(this.btnXemTheLoai);
            this.TabTheLoai.Controls.Add(this.btnXoaTheLoai);
            this.TabTheLoai.Controls.Add(this.btnSuaTheLoai);
            this.TabTheLoai.Controls.Add(this.btnThemTheLoai);
            this.TabTheLoai.Controls.Add(this.txtTenTheLoai);
            this.TabTheLoai.Controls.Add(this.label6);
            this.TabTheLoai.Controls.Add(this.txtMaTheLoai);
            this.TabTheLoai.Controls.Add(this.label5);
            this.TabTheLoai.Controls.Add(this.DataGridViewTheLoai);
            this.TabTheLoai.Location = new System.Drawing.Point(4, 25);
            this.TabTheLoai.Name = "TabTheLoai";
            this.TabTheLoai.Padding = new System.Windows.Forms.Padding(3);
            this.TabTheLoai.Size = new System.Drawing.Size(778, 394);
            this.TabTheLoai.TabIndex = 1;
            this.TabTheLoai.Text = "Thể loại";
            this.TabTheLoai.UseVisualStyleBackColor = true;
            this.TabTheLoai.Click += new System.EventHandler(this.TabTheLoai_Click);
            // 
            // btnXemTheLoai
            // 
            this.btnXemTheLoai.Location = new System.Drawing.Point(642, 135);
            this.btnXemTheLoai.Name = "btnXemTheLoai";
            this.btnXemTheLoai.Size = new System.Drawing.Size(99, 39);
            this.btnXemTheLoai.TabIndex = 16;
            this.btnXemTheLoai.Text = "Xem";
            this.btnXemTheLoai.UseVisualStyleBackColor = true;
            this.btnXemTheLoai.Click += new System.EventHandler(this.btnXemTheLoai_Click);
            // 
            // btnXoaTheLoai
            // 
            this.btnXoaTheLoai.Location = new System.Drawing.Point(527, 135);
            this.btnXoaTheLoai.Name = "btnXoaTheLoai";
            this.btnXoaTheLoai.Size = new System.Drawing.Size(99, 39);
            this.btnXoaTheLoai.TabIndex = 15;
            this.btnXoaTheLoai.Text = "Xoá";
            this.btnXoaTheLoai.UseVisualStyleBackColor = true;
            this.btnXoaTheLoai.Click += new System.EventHandler(this.btnXoaTheLoai_Click);
            // 
            // btnSuaTheLoai
            // 
            this.btnSuaTheLoai.Location = new System.Drawing.Point(642, 90);
            this.btnSuaTheLoai.Name = "btnSuaTheLoai";
            this.btnSuaTheLoai.Size = new System.Drawing.Size(99, 39);
            this.btnSuaTheLoai.TabIndex = 14;
            this.btnSuaTheLoai.Text = "Sửa";
            this.btnSuaTheLoai.UseVisualStyleBackColor = true;
            this.btnSuaTheLoai.Click += new System.EventHandler(this.btnSuaTheLoai_Click);
            // 
            // btnThemTheLoai
            // 
            this.btnThemTheLoai.Location = new System.Drawing.Point(527, 90);
            this.btnThemTheLoai.Name = "btnThemTheLoai";
            this.btnThemTheLoai.Size = new System.Drawing.Size(99, 39);
            this.btnThemTheLoai.TabIndex = 13;
            this.btnThemTheLoai.Text = "Thêm";
            this.btnThemTheLoai.UseVisualStyleBackColor = true;
            this.btnThemTheLoai.Click += new System.EventHandler(this.btnThemTheLoai_Click);
            // 
            // txtTenTheLoai
            // 
            this.txtTenTheLoai.Location = new System.Drawing.Point(523, 62);
            this.txtTenTheLoai.Name = "txtTenTheLoai";
            this.txtTenTheLoai.Size = new System.Drawing.Size(245, 22);
            this.txtTenTheLoai.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(520, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tên thể loại";
            // 
            // txtMaTheLoai
            // 
            this.txtMaTheLoai.Location = new System.Drawing.Point(622, 7);
            this.txtMaTheLoai.Name = "txtMaTheLoai";
            this.txtMaTheLoai.Size = new System.Drawing.Size(146, 22);
            this.txtMaTheLoai.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(517, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Mã thể loại";
            // 
            // DataGridViewTheLoai
            // 
            this.DataGridViewTheLoai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewTheLoai.Location = new System.Drawing.Point(6, 6);
            this.DataGridViewTheLoai.Name = "DataGridViewTheLoai";
            this.DataGridViewTheLoai.RowHeadersWidth = 51;
            this.DataGridViewTheLoai.RowTemplate.Height = 24;
            this.DataGridViewTheLoai.Size = new System.Drawing.Size(504, 381);
            this.DataGridViewTheLoai.TabIndex = 1;
            // 
            // TabRap
            // 
            this.TabRap.Controls.Add(this.ComboBoxMaCumRap);
            this.TabRap.Controls.Add(this.btnXemRap);
            this.TabRap.Controls.Add(this.btnXoaRap);
            this.TabRap.Controls.Add(this.btnSuaRap);
            this.TabRap.Controls.Add(this.btnThemRap);
            this.TabRap.Controls.Add(this.label9);
            this.TabRap.Controls.Add(this.txtTenRap);
            this.TabRap.Controls.Add(this.label8);
            this.TabRap.Controls.Add(this.txtmaRap);
            this.TabRap.Controls.Add(this.label7);
            this.TabRap.Controls.Add(this.DataGridViewRap);
            this.TabRap.Location = new System.Drawing.Point(4, 25);
            this.TabRap.Name = "TabRap";
            this.TabRap.Padding = new System.Windows.Forms.Padding(3);
            this.TabRap.Size = new System.Drawing.Size(778, 394);
            this.TabRap.TabIndex = 2;
            this.TabRap.Text = "Rạp";
            this.TabRap.UseVisualStyleBackColor = true;
            // 
            // ComboBoxMaCumRap
            // 
            this.ComboBoxMaCumRap.FormattingEnabled = true;
            this.ComboBoxMaCumRap.Location = new System.Drawing.Point(520, 116);
            this.ComboBoxMaCumRap.Name = "ComboBoxMaCumRap";
            this.ComboBoxMaCumRap.Size = new System.Drawing.Size(248, 24);
            this.ComboBoxMaCumRap.TabIndex = 17;
            // 
            // btnXemRap
            // 
            this.btnXemRap.Location = new System.Drawing.Point(651, 191);
            this.btnXemRap.Name = "btnXemRap";
            this.btnXemRap.Size = new System.Drawing.Size(99, 39);
            this.btnXemRap.TabIndex = 16;
            this.btnXemRap.Text = "Xem";
            this.btnXemRap.UseVisualStyleBackColor = true;
            this.btnXemRap.Click += new System.EventHandler(this.btnXemRap_Click);
            // 
            // btnXoaRap
            // 
            this.btnXoaRap.Location = new System.Drawing.Point(536, 191);
            this.btnXoaRap.Name = "btnXoaRap";
            this.btnXoaRap.Size = new System.Drawing.Size(99, 39);
            this.btnXoaRap.TabIndex = 15;
            this.btnXoaRap.Text = "Xoá";
            this.btnXoaRap.UseVisualStyleBackColor = true;
            this.btnXoaRap.Click += new System.EventHandler(this.btnXoaRap_Click);
            // 
            // btnSuaRap
            // 
            this.btnSuaRap.Location = new System.Drawing.Point(651, 146);
            this.btnSuaRap.Name = "btnSuaRap";
            this.btnSuaRap.Size = new System.Drawing.Size(99, 39);
            this.btnSuaRap.TabIndex = 14;
            this.btnSuaRap.Text = "Sửa";
            this.btnSuaRap.UseVisualStyleBackColor = true;
            this.btnSuaRap.Click += new System.EventHandler(this.btnSuaRap_Click);
            // 
            // btnThemRap
            // 
            this.btnThemRap.Location = new System.Drawing.Point(536, 146);
            this.btnThemRap.Name = "btnThemRap";
            this.btnThemRap.Size = new System.Drawing.Size(99, 39);
            this.btnThemRap.TabIndex = 13;
            this.btnThemRap.Text = "Thêm";
            this.btnThemRap.UseVisualStyleBackColor = true;
            this.btnThemRap.Click += new System.EventHandler(this.btnThemRap_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(517, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "Mã Cụm rạp";
            // 
            // txtTenRap
            // 
            this.txtTenRap.Location = new System.Drawing.Point(520, 60);
            this.txtTenRap.Name = "txtTenRap";
            this.txtTenRap.Size = new System.Drawing.Size(248, 22);
            this.txtTenRap.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(517, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "Tên rạp";
            // 
            // txtmaRap
            // 
            this.txtmaRap.Location = new System.Drawing.Point(613, 7);
            this.txtmaRap.Name = "txtmaRap";
            this.txtmaRap.Size = new System.Drawing.Size(155, 22);
            this.txtmaRap.TabIndex = 4;
            this.txtmaRap.TextChanged += new System.EventHandler(this.txtmaRap_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(517, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Mã rạp";
            // 
            // DataGridViewRap
            // 
            this.DataGridViewRap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewRap.Location = new System.Drawing.Point(6, 6);
            this.DataGridViewRap.Name = "DataGridViewRap";
            this.DataGridViewRap.RowHeadersWidth = 51;
            this.DataGridViewRap.RowTemplate.Height = 24;
            this.DataGridViewRap.Size = new System.Drawing.Size(504, 381);
            this.DataGridViewRap.TabIndex = 2;
            // 
            // TabCumRap
            // 
            this.TabCumRap.Controls.Add(this.DataGridViewCumRap);
            this.TabCumRap.Controls.Add(this.btnXemCumRap);
            this.TabCumRap.Controls.Add(this.btnXoaCumRap);
            this.TabCumRap.Controls.Add(this.btnSuaCumRap);
            this.TabCumRap.Controls.Add(this.btnThemCumRap);
            this.TabCumRap.Controls.Add(this.txtDiaChi);
            this.TabCumRap.Controls.Add(this.label12);
            this.TabCumRap.Controls.Add(this.txtTenCumRap);
            this.TabCumRap.Controls.Add(this.label11);
            this.TabCumRap.Controls.Add(this.txtMaCumRap);
            this.TabCumRap.Controls.Add(this.label10);
            this.TabCumRap.Location = new System.Drawing.Point(4, 25);
            this.TabCumRap.Name = "TabCumRap";
            this.TabCumRap.Padding = new System.Windows.Forms.Padding(3);
            this.TabCumRap.Size = new System.Drawing.Size(778, 394);
            this.TabCumRap.TabIndex = 3;
            this.TabCumRap.Text = "Cụm rạp";
            this.TabCumRap.UseVisualStyleBackColor = true;
            // 
            // DataGridViewCumRap
            // 
            this.DataGridViewCumRap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewCumRap.Location = new System.Drawing.Point(6, 7);
            this.DataGridViewCumRap.Name = "DataGridViewCumRap";
            this.DataGridViewCumRap.RowHeadersWidth = 51;
            this.DataGridViewCumRap.RowTemplate.Height = 24;
            this.DataGridViewCumRap.Size = new System.Drawing.Size(503, 381);
            this.DataGridViewCumRap.TabIndex = 17;
            // 
            // btnXemCumRap
            // 
            this.btnXemCumRap.Location = new System.Drawing.Point(643, 200);
            this.btnXemCumRap.Name = "btnXemCumRap";
            this.btnXemCumRap.Size = new System.Drawing.Size(99, 39);
            this.btnXemCumRap.TabIndex = 16;
            this.btnXemCumRap.Text = "Xem";
            this.btnXemCumRap.UseVisualStyleBackColor = true;
            this.btnXemCumRap.Click += new System.EventHandler(this.btnXemCumRap_Click);
            // 
            // btnXoaCumRap
            // 
            this.btnXoaCumRap.Location = new System.Drawing.Point(528, 200);
            this.btnXoaCumRap.Name = "btnXoaCumRap";
            this.btnXoaCumRap.Size = new System.Drawing.Size(99, 39);
            this.btnXoaCumRap.TabIndex = 15;
            this.btnXoaCumRap.Text = "Xoá";
            this.btnXoaCumRap.UseVisualStyleBackColor = true;
            this.btnXoaCumRap.Click += new System.EventHandler(this.btnXoaCumRap_Click);
            // 
            // btnSuaCumRap
            // 
            this.btnSuaCumRap.Location = new System.Drawing.Point(643, 155);
            this.btnSuaCumRap.Name = "btnSuaCumRap";
            this.btnSuaCumRap.Size = new System.Drawing.Size(99, 39);
            this.btnSuaCumRap.TabIndex = 14;
            this.btnSuaCumRap.Text = "Sửa";
            this.btnSuaCumRap.UseVisualStyleBackColor = true;
            this.btnSuaCumRap.Click += new System.EventHandler(this.btnSuaCumRap_Click);
            // 
            // btnThemCumRap
            // 
            this.btnThemCumRap.Location = new System.Drawing.Point(528, 155);
            this.btnThemCumRap.Name = "btnThemCumRap";
            this.btnThemCumRap.Size = new System.Drawing.Size(99, 39);
            this.btnThemCumRap.TabIndex = 13;
            this.btnThemCumRap.Text = "Thêm";
            this.btnThemCumRap.UseVisualStyleBackColor = true;
            this.btnThemCumRap.Click += new System.EventHandler(this.btnThemCumRap_Click);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(523, 127);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(231, 22);
            this.txtDiaChi.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(520, 108);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 16);
            this.label12.TabIndex = 7;
            this.label12.Text = "Địa chỉ";
            // 
            // txtTenCumRap
            // 
            this.txtTenCumRap.Location = new System.Drawing.Point(523, 73);
            this.txtTenCumRap.Name = "txtTenCumRap";
            this.txtTenCumRap.Size = new System.Drawing.Size(231, 22);
            this.txtTenCumRap.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(520, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 16);
            this.label11.TabIndex = 5;
            this.label11.Text = "Tên Cụm rạp";
            // 
            // txtMaCumRap
            // 
            this.txtMaCumRap.Location = new System.Drawing.Point(606, 10);
            this.txtMaCumRap.Name = "txtMaCumRap";
            this.txtMaCumRap.Size = new System.Drawing.Size(148, 22);
            this.txtMaCumRap.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(517, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 16);
            this.label10.TabIndex = 3;
            this.label10.Text = "Mã Cụm rạp";
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlAdmin);
            this.Name = "FormAdmin";
            this.Text = "Admin";
            this.tabControlAdmin.ResumeLayout(false);
            this.TabPhim.ResumeLayout(false);
            this.TabPhim.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPhim)).EndInit();
            this.TabTheLoai.ResumeLayout(false);
            this.TabTheLoai.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTheLoai)).EndInit();
            this.TabRap.ResumeLayout(false);
            this.TabRap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewRap)).EndInit();
            this.TabCumRap.ResumeLayout(false);
            this.TabCumRap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCumRap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlAdmin;
        private System.Windows.Forms.TabPage TabPhim;
        private System.Windows.Forms.Button btnXemPhim;
        private System.Windows.Forms.Button btnXoaPhim;
        private System.Windows.Forms.Button btnSuaPhim;
        private System.Windows.Forms.Button btnThemPhim;
        private System.Windows.Forms.TextBox txtThoiLuong;
        private System.Windows.Forms.TextBox txtTenPhim;
        private System.Windows.Forms.TextBox txtMaPhim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DataGridViewPhim;
        private System.Windows.Forms.TabPage TabTheLoai;
        private System.Windows.Forms.TabPage TabRap;
        private System.Windows.Forms.TabPage TabCumRap;
        private System.Windows.Forms.DataGridView DataGridViewTheLoai;
        private System.Windows.Forms.DataGridView DataGridViewRap;
        private System.Windows.Forms.TextBox txtTenTheLoai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaTheLoai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTenRap;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtmaRap;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnXemTheLoai;
        private System.Windows.Forms.Button btnXoaTheLoai;
        private System.Windows.Forms.Button btnSuaTheLoai;
        private System.Windows.Forms.Button btnThemTheLoai;
        private System.Windows.Forms.Button btnXemRap;
        private System.Windows.Forms.Button btnXoaRap;
        private System.Windows.Forms.Button btnSuaRap;
        private System.Windows.Forms.Button btnThemRap;
        private System.Windows.Forms.Button btnXemCumRap;
        private System.Windows.Forms.Button btnXoaCumRap;
        private System.Windows.Forms.Button btnSuaCumRap;
        private System.Windows.Forms.Button btnThemCumRap;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTenCumRap;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMaCumRap;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView DataGridViewCumRap;
        private System.Windows.Forms.ComboBox ComboBoxMaTheLoaiChinh;
        private System.Windows.Forms.ComboBox ComboBoxMaCumRap;
    }
}