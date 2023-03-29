using Project_WinForm_PRN211.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_WinForm_PRN211
{
    public partial class frmChangePass : Form
    {
        public frmChangePass()
        {
            InitializeComponent();
        }

        private void frmChangePass_Load(object sender, EventArgs e)
        {

        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;
            string newpass = txtNewPass.Text;
            string confirm = txtConfirmNewPass.Text;
            if (user == "")
            {
                MessageBox.Show("Tên đăng nhập trống !!!!");
            }
            else if (pass == "")
            {
                MessageBox.Show("Mật khẩu trống !!!!");
            }
            else if (newpass == "")
            {
                MessageBox.Show("Mật khẩu mới trống !!!!");
            }
            else if (confirm == "")
            {
                MessageBox.Show("Nhập lại mật khẩu trống !!!!");
            }
            else
            using (var context = new DbPrn211ProjectContext())
            {
                Account a = context.Accounts.FirstOrDefault(x => x.Username.Equals(user) && x.Pasword.Equals(pass));
                if (a == null)
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng !!!!");
                }
                else
                {
                    if (newpass.Equals(confirm))
                    {
                        a.Username= user;
                        a.Pasword = newpass;
                        context.SaveChanges();
                        MessageBox.Show("Đổi mật khẩu thành công !!!!");
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu mới không khớp !!!!");
                    }
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
