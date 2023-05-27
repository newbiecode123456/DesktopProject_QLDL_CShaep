using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DangNhap
    {
        public DangNhap(string userName,string displayName,int type,string password = null) {
            this.UserName = userName;
            this.DisplayName = displayName;
            this.Type = type;
            this.PassWord = password;
        }
        public DangNhap(DataRow row) {
            this.UserName = row["userName"].ToString();
            this.DisplayName = row["displayName"].ToString();
            this.Type = (int)row["Type"];
            this.PassWord = row["password"].ToString();
        }
        private int type;
        public int Type
        {
            get { return type; }
            set { type = value; }
        }
        private string passWord;
        public string PassWord
        {
            get { return passWord; }
            set { passWord = value; }
        }
        private string userName;
        public string UserName
        {
            get { return userName;  }
            set { userName = value; }
        }
        private string displayName;
        public string DisplayName
        {
            get { return displayName; }
            set { displayName = value; }
        }
    }
}
