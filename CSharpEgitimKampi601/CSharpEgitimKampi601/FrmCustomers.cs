using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi601
{
    public partial class FrmCustomers : Form
    {
        public FrmCustomers()
        {
            InitializeComponent();
        }

        string connectionString = "Server=localhost;port=5432;Database=CustomerDb;user ID=postgres;Password=12345";
        void GetAllCustomers()
        {
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();  
            string sql = "SELECT * FROM Customers";
            var command = new NpgsqlCommand(sql, connection);
            var adapter = new NpgsqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }
        private void btnListele_Click(object sender, EventArgs e)
        {
           
            GetAllCustomers();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var name = txtName.Text;
            var surname = txtSurName.Text;
            var city = txtCity.Text;
            var connection = new NpgsqlConnection(connectionString);
                        connection.Open();
            string sql = "INSERT INTO Customers (customername, customersurname, customercity) VALUES (@name, @surname, @city)";
            var command = new NpgsqlCommand(sql, connection);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@surname", surname);
            command.Parameters.AddWithValue("@city", city);
            command.ExecuteNonQuery();  
            connection.Close();
            MessageBox.Show("Müşteri Eklendi");
            GetAllCustomers();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string sql = "DELETE FROM Customers WHERE customerid = @id";
            var command = new NpgsqlCommand(sql, connection);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Müşteri Silindi");
            GetAllCustomers();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var name = txtName.Text;
            var surname = txtSurName.Text;
            var city = txtCity.Text;
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string sql = "UPDATE Customers SET customername = @name, customersurname = @surname, customercity = @city WHERE customerid = @id";
            var command = new NpgsqlCommand(sql, connection);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@surname", surname);
            command.Parameters.AddWithValue("@city", city);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Müşteri Güncellendi");
            GetAllCustomers();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtCity_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtSurName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
