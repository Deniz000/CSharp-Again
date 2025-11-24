using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
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
        public FrmProduct()
        {
            _productService = new ProductManager(new EfProductDal());
            InitializeComponent();
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
        }
    }
}
