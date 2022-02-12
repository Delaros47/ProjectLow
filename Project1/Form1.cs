using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListProducts();
            ListCategories();
        }

        private void ListProducts()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                gvProducts.DataSource = context.Products.ToList();
            }
        }

        private void ListCategories()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                cbxCategories.DataSource = context.Categories.ToList();
                cbxCategories.ValueMember = "CategoryId";
                cbxCategories.DisplayMember = "CategoryName";
            }
        }

        private void ListProductsByCategoryId(int categoryId)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                gvProducts.DataSource = context.Products.Where(p => p.CategoryId == categoryId).ToList();
            }
        }

        private void ListProductsByProductName(string key)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                gvProducts.DataSource = context.Products.Where(p=>p.ProductName.Contains(key)).ToList();
            }
        }

        private void cbxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxCategories.SelectedIndex > 0)
            {
                int categoryId = Convert.ToInt32(cbxCategories.SelectedValue.ToString());
                ListProductsByCategoryId(categoryId);
            }

        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            ListProductsByProductName(tbxSearch.Text);
        }
    }
}
