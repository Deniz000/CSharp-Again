using CSharpEgitimKampi601.Entities;
using CSharpEgitimKampi601.Services;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        CustomerOperations operations = new CustomerOperations();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var customer = new Customer()
            {
                CustomerFirstName = txtName.Text,
                CustomerLastName = txtSurName.Text,
                CustomerCity = txtCity.Text,
                CustomerBalance = Convert.ToDecimal(txtBalance.Text),
                CustomerShoppingCount = Convert.ToInt32(txtCountOfShopping.Text),
            };
                operations.AddCustomer(customer);
                MessageBox.Show("Customer added successfully!");

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            List<Customer> customers = operations.GetAllCustomers();
            dataGridView1.DataSource = customers;   

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            operations.DeleteCustomer(id);
            MessageBox.Show("Customer deleted successfully!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            var updatedCustomer = new Customer()
            {
                CustomerId = txtId.Text,
                CustomerFirstName = txtName.Text,
                CustomerLastName = txtSurName.Text,
                CustomerCity = txtCity.Text,
                CustomerBalance = Convert.ToDecimal(txtBalance.Text),
                CustomerShoppingCount = Convert.ToInt32(txtCountOfShopping.Text),
            };
            operations.UpdateCustomer(id, updatedCustomer); 
            MessageBox.Show("Customer updated successfully!");
        }
    }
}
