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
    public partial class frmCustomerAccount : Form
    {
        public frmCustomerAccount()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            using (var context = new DbPrn211ProjectContext())
            {
                List<Account> listA = context.Accounts.Where(x => x.RoleId == 3).ToList();
                dataGridView1.Rows.Clear();
                foreach (Account item in listA)
                {
                    Role role = context.Roles.FirstOrDefault(x => x.Id == item.RoleId);
                    string rolename = role == null ? "" : role.Name;
                    string dob;
                    if(item.Dob == null)
                    {
                        dob = "";
                    }
                    else
                    {
                        dob = item.Dob?.ToString("dd/MM/yyyy");
                    }
                    dataGridView1.Rows.Add(item.Id, item.Username, item.Pasword, item.Phone, item.Email,dob, rolename);
                }
                //đổ dữ liệu vào combobox role
                List<Role> roles = context.Roles.ToList();
                cboRole.DisplayMember = "Name";
                cboRole.ValueMember = "Id";
                cboRole.DataSource = roles;
            }
        }
        private void frmCustomerAccount_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtID.Text = dataGridView1.Rows[e.RowIndex].Cells["Column1"].Value.ToString();
                txtName.Text = dataGridView1.Rows[e.RowIndex].Cells["Column2"].Value.ToString();
                txtPass.Text = dataGridView1.Rows[e.RowIndex].Cells["Column3"].Value.ToString();
                txtPhone.Text = dataGridView1.Rows[e.RowIndex].Cells["Column4"].Value.ToString();
                txtEmail.Text = dataGridView1.Rows[e.RowIndex].Cells["Column5"].Value.ToString();
                string strDate = dataGridView1.Rows[e.RowIndex].Cells["Column6"].Value.ToString();
                string[] dateString = strDate.Split('/');
                DateTime enter_date = Convert.ToDateTime(dateString[1] + "/" + dateString[0] + "/" + dateString[2]);
                dtpDOB.Value = enter_date;
                cboRole.SelectedIndex = cboRole.FindStringExact(dataGridView1.Rows[e.RowIndex].Cells["Column7"].Value.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string txt = textBox1.Text;
            dataGridView1.Rows.Clear();
            using (var context = new DbPrn211ProjectContext())
            {
                List<Account> listB = context.Accounts.Where(x => x.Username.Contains(txt)).ToList();
                foreach (Account item in listB)
                {
                    Role role = context.Roles.FirstOrDefault(x => x.Id == item.RoleId);
                    string rolename = role == null ? "" : role.Name;
                    string dob;
                    if (item.Dob == null)
                    {
                        dob = "";
                    }
                    else
                    {
                        dob = item.Dob?.ToString("dd/MM/yyyy");
                    }
                    dataGridView1.Rows.Add(item.Id, item.Username, item.Pasword, item.Phone, item.Email, dob, rolename);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Account c = new Account();
            c.Username = txtName.Text;
            c.Pasword = txtPass.Text;
            c.Phone = txtPhone.Text;
            c.Email = txtEmail.Text;
            c.Dob = dtpDOB.Value;
            c.RoleId = 3;
            using (var context = new DbPrn211ProjectContext())
            {
                context.Add(c);
                context.SaveChanges();
                MessageBox.Show("Thêm thành công 1 tài khoản khách hàng");
            }
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (var context = new DbPrn211ProjectContext())
            {
                int id = int.Parse(txtID.Text);
                Account b = context.Accounts.FirstOrDefault(x => x.Id == id);
                if (b != null)
                {
                    context.Remove(b);
                    context.SaveChanges();
                    MessageBox.Show("Xóa thành công tài khoản khách hàng có id= " + id);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy đối tượng cần xóa");
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            using (var context = new DbPrn211ProjectContext())
            {
                int id = int.Parse(txtID.Text);
                Account e1 = (Account)context.Accounts.FirstOrDefault(x => x.Id == id);
                if (e1 != null)
                {
                    e1.Username = txtName.Text;
                    e1.Pasword = txtPass.Text;
                    e1.Phone = txtPhone.Text;
                    e1.Email = txtEmail.Text;
                    e1.Dob = dtpDOB.Value;
                    e1.RoleId = int.Parse(cboRole.SelectedValue.ToString());
                    context.SaveChanges();
                    MessageBox.Show("Cập nhật thành công tài khoản có id = " + id);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy");
                }
            }
        }
    }
}
