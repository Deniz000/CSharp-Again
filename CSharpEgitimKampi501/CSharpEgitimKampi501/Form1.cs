using System.Data;
using Microsoft.Data.SqlClient;
using Dapper;
using CSharpEgitimKampi501.Dtos;

namespace CSharpEgitimKampi501
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=localhost;" +
            "Initial Catalog=EgitimKampi501Db;" +
            "Integrated Security=True;" +
            "Persist Security Info=False;" +
            "Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=True;Application Name=\"SQL Server Management Studio\";Command Timeout=0");

        private async void btnList_Click(object sender, EventArgs e)
        {
            string query = "select * from TblProduct";
            var values = await connection.QueryAsync<ResultProductDto>(query); // query'den gelen sorgu ile resultproductdto'yu eþleþtiriyoruz - mappleme iþlemi db-tablolarým
            dataGridView1.DataSource = values;
        }

        private async void btnAdd_ClickAsync(object sender, EventArgs e)
        {
            string query = "insert into TblProduct (ProductName,ProductStock,ProductPrice,ProductCategory) " +
                "values (@productName,@productStock,@productPrice,@productCategory)";
            var parameters = new DynamicParameters();
            parameters.Add("@productName", txtName.Text);
            parameters.Add("@productStock", txtStock.Text);
            parameters.Add("@productPrice", Convert.ToDecimal(txtPrice.Text));
            parameters.Add("@productCategory", txtCategory.Text);
            await connection.ExecuteAsync(query, parameters); //sorguyu, parametreleri ile birlikte çalýþtýrýr
            MessageBox.Show("Ürün Eklendi");

        }

        private async void btnDelete_ClickAsync(object sender, EventArgs e)
        {
            string query = "delete from TblProduct where ProductID=@productId";
            var parameters = new DynamicParameters();
            parameters.Add("@productId", Convert.ToInt32(txtid.Text));
            await connection.ExecuteAsync(query, parameters);
            MessageBox.Show("Ürün Silindi");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = "update TblProduct set ProductName=@productName, ProductStock=@productStock, " +
                "ProductPrice=@productPrice, ProductCategory=@productCategory where ProductID=@productId";
            var parameters = new DynamicParameters();
            parameters.Add("@productId", Convert.ToInt32(txtid.Text));
            parameters.Add("@productName", txtName.Text);
            parameters.Add("@productStock", txtStock.Text);
            parameters.Add("@productPrice", Convert.ToDecimal(txtPrice.Text));
            parameters.Add("@productCategory", txtCategory.Text);
            connection.Execute(query, parameters);
            MessageBox.Show("Ürün Güncellendi");
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            string query = "select Count(*) from TblProduct";
            var productTotalCount = await connection.QueryFirstOrDefaultAsync<int>(query); // query'den gelen sorgu ile resultproductdto'yu eþleþtiriyoruz - mappleme iþlemi db-tablolarým
            lblTotalProductCount.Text = productTotalCount.ToString();

            string query2 = "Select ProductName From TblProduct Where ProductPrice=(Select Max(ProductPrice) From TblProduct)";
            var maxPriceProductName = await connection.QueryFirstOrDefaultAsync<string>(query2);
            lblMaxPriceProductName.Text = maxPriceProductName.ToString();

            string query3 = "select count(distinct(ProductCategory)) from TblProduct";
            var totalCategoryCount = await connection.QueryFirstOrDefaultAsync<int>(query3);
            lblDistinctCategoryCount.Text = totalCategoryCount.ToString();
        }
    }
}
