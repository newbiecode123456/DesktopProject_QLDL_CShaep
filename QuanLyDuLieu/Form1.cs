using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using DAO;
namespace QuanLyDuLieu
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Thoát Chương trình?","Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        bool Login(string userName,string passWord)
        {
            return DangNhapDAO.Instance.Login(userName, passWord);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string passWord = txtPassWord.Text;
            if (Login(userName, passWord))
            {
                FormAdmin formAdmin = new FormAdmin();
                this.Hide();
                formAdmin.ShowDialog();
                this.Show();
            } else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!!");
            }
        }
    }
}
