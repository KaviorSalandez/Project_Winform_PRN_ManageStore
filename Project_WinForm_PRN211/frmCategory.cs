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
    public partial class frmCategory : Form
    {
        public frmCategory()
        {
            InitializeComponent();
        }

       

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string txt = txtSearch.Text;
            dataGridView1.Rows.Clear();
            using (var context = new DbPrn211ProjectContext())
            {
                List<Category> listB = context.Categories.Where(x => x.Name.Contains(txt)).ToList();
                foreach (Category item in listB)
                {
                    dataGridView1.Rows.Add(item.Id, item.Name);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Category c = new Category();
            c.Name = txtName.Text;
            using (var context = new DbPrn211ProjectContext())
            {
                context.Add(c);
                context.SaveChanges();
                MessageBox.Show("Thêm thành công 1 category");
            }
            LoadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (var context = new DbPrn211ProjectContext())
            {
                int id = int.Parse(txtID.Text);
                Category b = context.Categories.FirstOrDefault(x => x.Id == id);
                if (b != null)
                {
                    b.Name = txtName.Text;
                    context.SaveChanges();
                    MessageBox.Show("Cập nhật thành công");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (var context = new DbPrn211ProjectContext())
            {
                int id = int.Parse(txtID.Text);
                Category b = context.Categories.FirstOrDefault(x => x.Id == id);
                if (b != null)
                {
                    context.Remove(b);
                    context.SaveChanges();
                    MessageBox.Show("Xóa thành công");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy đối tượng cần xóa");
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtID.Text = dataGridView1.Rows[e.RowIndex].Cells["Column1"].Value.ToString();
                txtName.Text = dataGridView1.Rows[e.RowIndex].Cells["Column2"].Value.ToString();
            }
        }

        private void frmCategory_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            using (var context = new DbPrn211ProjectContext())
            {
                List<Category> listB = context.Categories.ToList();
                dataGridView1.Rows.Clear();
                foreach (Category item in listB)
                {
                    dataGridView1.Rows.Add(item.Id, item.Name);
                }
            }
        }
    }
}
