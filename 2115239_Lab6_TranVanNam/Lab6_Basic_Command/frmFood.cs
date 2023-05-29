using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6_Basic_Command
{
    public partial class frmFood : Form

    {
        int categoryID;
        public frmFood()
        {
            InitializeComponent();
        }
        public void LoadFood(int categoryID)
        {
            //// tạo đối tượng kết nối
            //string connectionString = @"Data Source=MAYTINH-D3SVJBQ\SQLEXPRESS;Initial Catalog=RestaurantManagement;Integrated Security=True";
            //SqlConnection sqlConnection = new SqlConnection(connectionString);

            //// tạo đối tượng thực thi lệnh
            //SqlCommand sqlCommand = sqlConnection.CreateCommand();

            //// thiết lập lệnh truy vấn cho đối tượng Command

            //sqlCommand.CommandText = "Select Name From Category where ID = " + categoryID;

            //// mở kết nối tới Cơ sở dư liệu
            //sqlConnection.Open();

            //// gán tên nhóm sản phẩm cho têu đề
            //string catName = sqlCommand.ExecuteScalar().ToString();
            //this.Text = "Danh sách các món ăn thuộc nhóm: " + catName;

            //sqlCommand.CommandText = "SELECT ID, Name, Unit,FoodCategoryID, Price, Notes FROM Food WHERE FoodCategoryID = " + categoryID;

            //// tạo đối tương dataAapter

            //SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);

            //// tạo datatable để chứa dữ liệu
            //DataTable dataTable = new DataTable("Food");
            //dataAdapter.Fill(dataTable);

            //// hiện thị danh sách các món ăn lên FORM

            //dgvFood.DataSource = dataTable;

            //// đóng kết nối và giải phóng bộ nhớ
            //sqlConnection.Close();
            //sqlConnection.Dispose();
            //dataAdapter.Dispose();
            this.categoryID = categoryID;
            string connectionString = @"Data Source=MAYTINH-D3SVJBQ\SQLEXPRESS;Initial Catalog=RestaurantManagement;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = connection.CreateCommand();

            command.CommandText = "SELECT Name FROM Category WHERE ID = " + categoryID;

            connection.Open();

            string categoryName = command.ExecuteScalar().ToString();
            this.Text = "Danh sách các món ăn thuộc nhóm: " + categoryName;

            command.CommandText = "SELECT ID, Name, Unit, Price, Notes FROM Food WHERE FoodCategoryID = " + categoryID;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable("Food");
            adapter.Fill(table);

            dgvFood.DataSource = table;

            // Prevent user to edit ID
            dgvFood.Columns[0].ReadOnly = true;

            connection.Close();
            connection.Dispose();
            adapter.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //// tạo đối tượng kết nối
            //string connectionString = @"Data Source=MAYTINH-D3SVJBQ\SQLEXPRESS;Initial Catalog=RestaurantManagement;Integrated Security=True";
            //SqlConnection sqlConnection = new SqlConnection(connectionString);

            //// tạo đối tượng thực thi lệnh
            //SqlCommand sqlCommand = sqlConnection.CreateCommand();


            //// mở kết nối tới Cơ sở dư liệu
            //sqlConnection.Open();

            //// thiết lập lệnh truy vấn cho đối tượng Command

            //sqlCommand.CommandText = "DELETE FROM Food WHERE FoodCategoryID = " + categoryID;
            //sqlCommand.ExecuteNonQuery();
            //for(int i=0; i<dgvFood.Rows.Count-1; i++)
            //{
            //    string query = string.Format("" +
            //        "INSERT INTO Food(Name, Unit, FoodCategoryID, Price, Notes)" + " " +
            //        "VALUES (N'{0}', N'{1}', {2}, {3}, N'{4}')",
            //        dgvFood.Rows[i].Cells["Name"].Value,
            //        dgvFood.Rows[i].Cells["Unit"].Value,
            //        categoryID,
            //        dgvFood.Rows[i].Cells["Price"].Value,
            //        dgvFood.Rows[i].Cells["Notes"].Value).ToString();
            //    sqlCommand.CommandText = query;
            //    sqlCommand.ExecuteNonQuery();
            //}
            //sqlConnection.Close();
            string connectionString = @"Data Source=MAYTINH-D3SVJBQ\SQLEXPRESS;Initial Catalog=RestaurantManagement;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = connection.CreateCommand();

            connection.Open();

            command.CommandText = "DELETE FROM Food WHERE FoodCategoryID = " + categoryID;
            command.ExecuteNonQuery();

            for (int i = 0; i < dgvFood.Rows.Count - 1; i++)
            {
                string query = string.Format("" +
                    "INSERT INTO Food(Name, Unit, FoodCategoryID, Price, Notes)" + " " +
                    "VALUES (N'{0}', N'{1}', {2}, {3}, N'{4}')",
                    dgvFood.Rows[i].Cells["Name"].Value,
                    dgvFood.Rows[i].Cells["Unit"].Value,
                   // dgvFood.Rows[i].Cells["FoodCategory"]
                    categoryID,
                    dgvFood.Rows[i].Cells["Price"].Value,
                    dgvFood.Rows[i].Cells["Notes"].Value).ToString();
                command.CommandText = query;
                command.ExecuteNonQuery();
            }

            connection.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvFood.SelectedRows.Count == 0) return;

            var selectedRow = dgvFood.SelectedRows[0];

            string foodID = selectedRow.Cells[0].Value.ToString();

            string connectionString = "server=.; database = RestaunrantManagement; Integrated Security = true; ";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = connection.CreateCommand();

            string query = "DELETE FROM Food WHERE ID = " + foodID;
            command.CommandText = query;

            connection.Open();

            int numOfRowsEffected = command.ExecuteNonQuery();

            if (numOfRowsEffected != 1)
            {
                MessageBox.Show("Có lỗi xảy ra.");
                return;
            }

            dgvFood.Rows.Remove(selectedRow);

            connection.Close();
        }
    }
}
