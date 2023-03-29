using Project_WinForm_PRN211.Models;

namespace Project_WinForm_PRN211
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text;
            if (user == "")
            {
                MessageBox.Show("Tên đăng nhập không được trống");
            }
            string pass = txtPass.Text;
            if (pass==null ||pass == "")
            {
                MessageBox.Show("Chưa nhập mật khẩu");
            }
            using (var context = new DbPrn211ProjectContext())
            {
                Account a = context.Accounts.FirstOrDefault(x => x.Username.Equals(user) && x.Pasword.Equals(pass));
                if (a == null)
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng");
                }
                else
                {
                   if(a.RoleId == 1 || a.RoleId==2)
                    {
                        Const.AccountRole =int.Parse(a.RoleId.ToString());
                        MessageBox.Show("Đăng nhập thành công");
                        frmMain fMain = new frmMain();
                        fMain.Show();
                        this.Hide();
                        fMain.Logout += FMain_Logout;
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản không được phép truy cập");
                    }
                }
            }
        }

        private void FMain_Logout(object? sender, EventArgs e)
        {
            (sender as frmMain).isExit = false;
            (sender as frmMain).Close();
            this.Show();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPass.Text = "";
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                txtPass.UseSystemPasswordChar = true;
            }
            if (!checkBox1.Checked)
            {
                txtPass.UseSystemPasswordChar = false;
            }
        }
    }
}