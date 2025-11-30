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
    public partial class FrmEmployee : Form
    {
        public FrmEmployee()
        {
            InitializeComponent();
        }


        private readonly string connectionString = "Server=localhost;port=5432;Database=CustomerDb;user ID=postgres;Password=12345";

        private NpgsqlConnection CreateConnection()
        {
            var connection =  new NpgsqlConnection(connectionString);
            connection.Open();
            return connection;

        }
        void EmployeeList()
        {
            var connection = CreateConnection();
            string sql = "SELECT * FROM Employees";
            var command = new NpgsqlCommand(sql, connection);
            var adapter = new NpgsqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }
        void DepartmentList()
        {
            var connection = CreateConnection();
            string sql = "SELECT * FROM Departments";
            var command = new NpgsqlCommand(sql, connection);
            var adapter = new NpgsqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cmbEmployeeDepartment.DisplayMember = "departmentname"; // kullanıcıya gözükecek alan
            cmbEmployeeDepartment.ValueMember = "departmentid"; // arka planda tutulacak alan
            cmbEmployeeDepartment.DataSource = dt;
            connection.Close();
        }
        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            EmployeeList();
            DepartmentList();
        }

        private void btnEmployeeListele_Click(object sender, EventArgs e)
        {
            EmployeeList();
        }

        private void btnEmployeeAdd_Click(object sender, EventArgs e)
        {
            EmployeeList();
            string name = txtEmployeeName.Text;
            string surname = txtEmployeeSurName.Text;
            int salary = int.Parse(txtEmployeeSalary.Text);
            int departmentId = (int)cmbEmployeeDepartment.SelectedValue;
            var connection = CreateConnection();
            string sql = "INSERT INTO Employees (employeename, employeesurname, employeesalary, departmentid) VALUES (@name, @surname, @salary, @departmentId)";
            var command = new NpgsqlCommand(sql, connection); // sql komutunu ve bağlantıyı belirttim
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@surname", surname);
            command.Parameters.AddWithValue("@salary", salary);
            command.Parameters.AddWithValue("@departmentId", departmentId);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Çalışan Eklendi");
            EmployeeList();
        }

        private void btnEmployeeDelete_Click(object sender, EventArgs e)
        {
            EmployeeList();
            int id = int.Parse(txtId.Text);
            var connection = CreateConnection();
            string sql = "DELETE FROM Employees WHERE employeeid = @id";
            var command = new NpgsqlCommand(sql, connection);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Çalışan Silindi");

        }

        private void btnEmployeeUpdate_Click(object sender, EventArgs e)
        {
            EmployeeList();
            int id = int.Parse(txtId.Text);
            string name = txtEmployeeName.Text;
            string surname = txtEmployeeSurName.Text;
            int salary = int.Parse(txtEmployeeSalary.Text);
            int departmentId = (int)cmbEmployeeDepartment.SelectedValue;
            var connection = CreateConnection();
            string sql = "UPDATE Employees SET employeename = @name, employeesurname = @surname, employeesalary = @salary, departmentid = @departmentId WHERE employeeid = @id";
            var command = new NpgsqlCommand(sql, connection);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@surname", surname);
            command.Parameters.AddWithValue("@salary", salary);
            command.Parameters.AddWithValue("@departmentId", departmentId);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Çalışan Güncellendi");
            EmployeeList();
        }
    }
}
