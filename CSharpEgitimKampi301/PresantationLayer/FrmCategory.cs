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
    public partial class FrmCategory : Form
    {
        private readonly ICategoryService _categoryService;

        public FrmCategory()
        {
            InitializeComponent();
            _categoryService =new CategoryManager(new EfCategoryDal());
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            var categoryValues = _categoryService.TGetAll();
            dataGridView1.DataSource = categoryValues;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.CategoryName = txtName.Text;
            category.CategoryStatus = true;
            _categoryService.TInsert(category);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            var category = _categoryService.TGetById(id);
            _categoryService.TDelete(category);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            var category = _categoryService.TGetById(id);
            category.CategoryName = txtName.Text;
            category.CategoryStatus = true;
            _categoryService.TUpdate(category);
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            var category = _categoryService.TGetById(id);
            dataGridView1.DataSource = new List<Category> { category }; // DataGridView tablo mantığıyla çalışır; bir satır da olsa liste olarak vermek gerekir.

        }
    }
}
