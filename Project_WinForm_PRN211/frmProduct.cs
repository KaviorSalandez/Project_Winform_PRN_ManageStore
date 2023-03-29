using Azure.Core.GeoJson;
using Project_WinForm_PRN211.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project_WinForm_PRN211
{
    public partial class frmProduct : Form
    {
        public frmProduct()
        {
            InitializeComponent();
        }

       
        public void LoadData()
        {
            using (var context = new DbPrn211ProjectContext())
            {
                List<Product> listP = context.Products.ToList();
                dataGridView1.Rows.Clear();
                foreach (Product item in listP)
                {
                    //cách 1 lấy brand name
                    //Department d = context.Departments.FirstOrDefault(x => x.Id == item.Department);//lấy kq đầu tiên nếu ko có kết quả trả về null
                    //cách 2 lấy qua department Navigator trong Employee
                    //item.DepartmentNavigation = context.Departments.FirstOrDefault(x => x.Id == item.Department);
                    // cách 1 lấy brand name
                    Brand brand = context.Brands.FirstOrDefault(x => x.Id == item.Bid);
                    Category cate = context.Categories.FirstOrDefault(y => y.Id == item.Cid);
                    string brandname= brand == null? "":brand.Name;
                    string catename= cate== null?"":cate.Name;
                   
                    Boolean check;
                    if (item.Stock > 0)
                    {
                        check = true;
                    }
                    else
                    {
                        check = false;
                    }
                    dataGridView1.Rows.Add(item.Id, item.Name, item.Price, item.Descrip, brandname, catename, item.Stock, check);
                    
                    
                }

                //đổ dữ liệu vào combobox Brand
                List<Brand> listB1 = context.Brands.ToList();
                cboBrand.DisplayMember = "Name";
                cboBrand.ValueMember = "Id";
                cboBrand.DataSource = listB1;
                //đổ dữ liệu vào combobox Brand để search
                List<Brand> listB2 = context.Brands.ToList();
                Brand br = new Brand();
                br.Id = 0;
                br.Name = "Select All";
                listB2.Insert(0, br);
                cboBrandSearch.DisplayMember = "Name";
                cboBrandSearch.ValueMember = "Id";
                cboBrandSearch.DataSource = listB2;
               

                //đổ dữ liệu vào combobox Category
                List<Category> listC1 = context.Categories.ToList();
                cboCate.DisplayMember = "Name";
                cboCate.ValueMember = "Id";
                cboCate.DataSource = listC1;
                //đổ dữ liệu vào combobox Category để search
                List<Category> listC2 = context.Categories.ToList();
                Category c=new Category();
                c.Id = 0;
                c.Name = "Select All";
                listC2.Insert(0, c);
                cboCategorySearch.DisplayMember = "Name";
                cboCategorySearch.ValueMember = "Id";
                cboCategorySearch.DataSource = listC2;
            }
        }
        private void frmProduct_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtID.Text = dataGridView1.Rows[e.RowIndex].Cells["Column1"].Value.ToString();
                txtName.Text = dataGridView1.Rows[e.RowIndex].Cells["Column2"].Value.ToString();
                numericUpDownPrice.Text = dataGridView1.Rows[e.RowIndex].Cells["Column3"].Value.ToString();
                txtDescrip.Text = dataGridView1.Rows[e.RowIndex].Cells["Column4"].Value.ToString();
                cboBrand.SelectedIndex = cboBrand.FindStringExact(dataGridView1.Rows[e.RowIndex].Cells["Column5"].Value.ToString());
                cboCate.SelectedIndex = cboCate.FindStringExact(dataGridView1.Rows[e.RowIndex].Cells["Column6"].Value.ToString());
                numericUpDownStock.Text = dataGridView1.Rows[e.RowIndex].Cells["Column7"].Value.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product e1 = new Product();
            e1.Name = txtName.Text;
            e1.Price = int.Parse(numericUpDownPrice.Text);
            e1.Descrip = txtDescrip.Text;
            e1.Bid = int.Parse(cboBrand.SelectedValue.ToString());
            e1.Cid = int.Parse(cboCate.SelectedValue.ToString());
            e1.Stock = int.Parse(numericUpDownStock.Text);
            using (var context = new DbPrn211ProjectContext())
            {
                context.Add(e1);
                context.SaveChanges();
                MessageBox.Show("Add thành công sản phẩm");
            }
            LoadData();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtName.Text = "";
            numericUpDownPrice.Text = "0";
            txtDescrip.Text = "";
            cboBrand.SelectedIndex = 0;
            cboCate.SelectedIndex = 0;
            numericUpDownStock.Text = "0";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (var context = new DbPrn211ProjectContext())
            {
                int id = int.Parse(txtID.Text);
                Product e1 = (Product)context.Products.FirstOrDefault(x => x.Id == id);
                if (e1 != null)
                {
                    e1.Name = txtName.Text;
                    e1.Price = int.Parse(numericUpDownPrice.Text);
                    e1.Descrip = txtDescrip.Text;
                    e1.Bid = int.Parse(cboBrand.SelectedValue.ToString());
                    e1.Cid = int.Parse(cboCate.SelectedValue.ToString());
                    e1.Stock = int.Parse(numericUpDownStock.Text);
                    context.SaveChanges();
                    MessageBox.Show("Cập nhật thành công sản phẩm có id = " + id);
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
                Product p1 = context.Products.FirstOrDefault(x => x.Id == id);
                if (p1 != null)
                {
                    context.Remove(p1);
                    context.SaveChanges();
                    MessageBox.Show("Xóa thành công sản phẩm có id = "+id);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy đối tượng cần xóa");
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string txt = txtSearch.Text;
            int bid = int.Parse(cboBrandSearch.SelectedValue.ToString());
            int cid= int.Parse(cboCategorySearch.SelectedValue.ToString());
            dataGridView1.Rows.Clear();
            using (var context = new DbPrn211ProjectContext())
            {
                List<Product> list = context.Products.ToList();
                //search theo name
                if (txt != "")
                {
                    list = list.Where(x => x.Name.ToLower().Contains(txt.ToLower())).ToList();
                }
                //search theo brand
                if (bid != 0)
                {
                    list = list.Where(x => x.Bid == bid).ToList();
                }
                //search theo category
                if (cid != 0)
                {
                    list = list.Where(x => x.Cid == cid).ToList();
                }
                foreach (Product item in list)
                {
                    Brand brand = context.Brands.FirstOrDefault(x => x.Id == item.Bid);
                    Category cate = context.Categories.FirstOrDefault(y => y.Id == item.Cid);
                    string brandname = brand == null ? "" : brand.Name;
                    string catename = cate == null ? "" : cate.Name;
                    Boolean check;
                    if (item.Stock > 0)
                    {
                        check = true;
                    }
                    else
                    {
                        check = false;
                    }
                    dataGridView1.Rows.Add(item.Id, item.Name, item.Price, item.Descrip, brandname, catename, item.Stock, check);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            cboBrandSearch.SelectedIndex = 0;
            cboCategorySearch.SelectedIndex = 0;
            LoadData();
        }
    }
}
