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
    public partial class frmMain : Form
    {
        public bool isExit = true;//mặc định là tắt hoàn toàn chương trình
        public event EventHandler Logout;
        public frmMain()
        {
            InitializeComponent();
        }

        //Hàm phân quyền
        public void PhanQuyen()
        {
            if (Const.AccountRole == 2)
            {
               employeeAccountToolStripMenuItem.Enabled = false;     
            }
        }

        private void brandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBrand fb = new frmBrand();
            fb.ShowDialog();
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategory fc = new frmCategory();
            fc.ShowDialog();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduct fb = new frmProduct();
            fb.ShowDialog();
        }

       

        private void changePassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePass f = new frmChangePass();
            f.ShowDialog();
        }

       

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isExit)
            {
                Application.Exit();
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isExit)
            {
                if (MessageBox.Show("Bạn có muốn thoát chương trình không ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                e.Cancel = true;
            }
               
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            PhanQuyen();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Logout(this, new EventArgs());
        }

        private void employeeAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmployeeAccount fm = new frmEmployeeAccount();
            fm.ShowDialog();
        }

        private void customerAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomerAccount fa = new frmCustomerAccount();
            fa.ShowDialog();
        }
    }
}
