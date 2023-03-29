using Azure.Core.GeoJson;
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
    public partial class frmBrand : Form
    {
        public frmBrand()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void LoadData()
        {
           using(var context  = new DbPrn211ProjectContext())
            {
                List<Brand> listB = context.Brands.ToList();
                dataGridView1.Rows.Clear();
                foreach (Brand item in listB)
                {
                    dataGridView1.Rows.Add(item.Id,item.Name);
                }
            }
        }
        private void frmBrand_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string txt = txtSearch.Text;
            dataGridView1.Rows.Clear();
            using (var context = new DbPrn211ProjectContext())
            {
                List<Brand> listB = context.Brands.Where(x=>x.Name.Contains(txt)).ToList();
                foreach (Brand item in listB)
                {
                    dataGridView1.Rows.Add(item.Id, item.Name);
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
        //add
        private void button1_Click(object sender, EventArgs e)
        {
            Brand b = new Brand();
            b.Name = txtName.Text;
            using (var context = new DbPrn211ProjectContext())
            {
                context.Add(b);
                context.SaveChanges();
                MessageBox.Show("Thêm thành công 1 brand");
            }
            LoadData();
        }
        //update
        private void button2_Click(object sender, EventArgs e)
        {
            using (var context = new DbPrn211ProjectContext())
            {
                int id = int.Parse(txtID.Text);
                Brand b = context.Brands.FirstOrDefault(x => x.Id == id);
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
        //delete
        private void button3_Click(object sender, EventArgs e)
        {
            using (var context = new DbPrn211ProjectContext())
            {
                int id = int.Parse(txtID.Text);
                Brand b = context.Brands.FirstOrDefault(x => x.Id == id);
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
    }
}
