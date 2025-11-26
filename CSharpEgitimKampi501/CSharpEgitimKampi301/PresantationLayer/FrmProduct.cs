using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresantationLayer
{
    public partial class FrmProduct : Form
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        public FrmProduct()
        {
            _productService = new ProductManager(new EfProductDal());
            _categoryService = new CategoryManager(new EfCategoryDal());
            InitializeComponent();
        }
        private void FrmProduct_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void LoadCategories()
        {
            var categories = _categoryService.TGetAll();
            cmbProductCategory.DisplayMember = "CategoryName";
            cmbProductCategory.ValueMember = "CategoryId";
            cmbProductCategory.DataSource = categories;
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _productService.TGetAll();
        }

        private void btnlistele2_Click(object sender, EventArgs e)
        {
            var values = _productService.GetProductsWithCategory();
            dataGridView1.DataSource = values;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtProductId.Text);
            var product = _productService.TGetById(id);
            _productService.TDelete(product);
            MessageBox.Show("Product Deleted Dude!");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.ProductName = txtProductName.Text;
            product.ProductStock = Convert.ToInt32(txtProductStock.Text);
            product.ProductPrice = Convert.ToDecimal(txtProductPrice.Text);
            product.ProductDescription = txtProductDescription.Text;
            product.CategoryId = Convert.ToInt32(cmbProductCategory.SelectedValue);
            _productService.TInsert(product);
            MessageBox.Show("Product Added Dude!");

        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtProductId.Text);
            var product = _productService.TGetById(id);
            dataGridView1.DataSource = new List<Product> { product};
            ;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtProductId.Text);
            var product = _productService.TGetById(id);
            product.ProductName = !string.IsNullOrEmpty(txtProductName.Text) ? txtProductName.Text : product.ProductName;
            product.ProductStock = !string.IsNullOrEmpty(txtProductStock.Text) ? Convert.ToInt32(txtProductStock.Text) : product.ProductStock;
            product.ProductPrice = !string.IsNullOrEmpty(txtProductPrice.Text) ? Convert.ToDecimal(txtProductPrice.Text) : product.ProductPrice;
            product.ProductDescription = !string.IsNullOrEmpty(txtProductDescription.Text) ? txtProductDescription.Text : product.ProductDescription;
            product.CategoryId = cmbProductCategory.SelectedValue != null ? Convert.ToInt32(cmbProductCategory.SelectedValue) : product.CategoryId;
            _productService.TUpdate(product);
            MessageBox.Show("Product Updated Dude!");
        }
    }
}
