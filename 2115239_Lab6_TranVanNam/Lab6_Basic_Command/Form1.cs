using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Lab6_Basic_Command
{
    public partial class Form1 : Form
    {
        //SqlConnection connection;
        //SqlCommand command;
        //string str = @"Data Source=MAYTINH-D3SVJBQ\SQLEXPRESS;Initial Catalog=RestaurantManagement;Integrated Security=True";
        //SqlDataAdapter adapter = new SqlDataAdapter();
        //DataTable table = new DataTable();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            // tạo chuỗi kết nối tới cơ sở dữ liệu RestaurantManagement
            string connectionString = @"Data Source=MAYTINH-D3SVJBQ\SQLEXPRESS;Initial Catalog=RestaurantManagement;Integrated Security=True";

            // tạo đối tượng kết nối
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            // tạo đối tượng thực thi lệnh
            SqlCommand sqlCommand = sqlConnection.CreateCommand();

            // thiết lập lệnh truy vấn cho đối tượng conmand
            string query = "SELECT ID, Name, Type From Category";
            sqlCommand.CommandText = query;

            // mở kết nói tới cơ sở dữ liệu
            sqlConnection.Open();

            // thực thi lệnh bằng phương thức ExcuteReader
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            // gọi hàm hiện thị dữ liệu lên màn hình
            this.DisplayCategory(sqlDataReader);

            // đóng kết nói
            sqlConnection.Close();
            //SqlDataAdapter adapter = new SqlDataAdapter();
            //command = connection.CreateCommand();
            //command.CommandText = "SELECT ID, Name, Type From Category";
            //adapter.SelectCommand = command;
            //table.Clear();
            //adapter.Fill(table);
            //this.DisplayCategory(SqlDataReader);
             
        }
        private void DisplayCategory(SqlDataReader reader)
        {
            // xóa tất cả các dòng hiện tại
            lvCategory.Items.Clear();

            // đọc một dòng dữ liệu
            while (reader.Read())
            {
                // tạo một dòng mới trong ListView
                ListViewItem item = new ListViewItem(reader["ID"].ToString());

                // thêm dòng mới vào ListView

                lvCategory.Items.Add(item);

                // bổ sungg các thông tin khác cho ListViewItem
                item.SubItems.Add(reader["Name"].ToString());
                item.SubItems.Add(reader["Type"].ToString());
            }    
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            // tạo chuỗi kết nối tới cơ sở dữ liệu RestaurantManagement
            //  string connectionString = @"Data Source=MAYTINH-D3SVJBQ\SQLEXPRESS;Initial Catalog=RestaurantManagement;Integrated Security=True";

            //  // tạo đối tượng kết nối
            //  SqlConnection sqlConnection = new SqlConnection(connectionString);

            //  // tạo đối tượng thực thi lệnh
            //  SqlCommand sqlCommand = sqlConnection.CreateCommand();

            //  // thiết lập lệnh truy vấn cho đối tượng conmand
            ////  sqlCommand.CommandText = "Insert into Category(Name, [Type]" + "Values (N'" + txtName.Text + "', " +txtType + ")";
            //  //sqlCommand.CommandText = "Insert into Category '" + txtID.Text + "', N'" + txtName.Text + "', '" + txtType.Text + "'";
            ////  sqlCommand.CommandText = $"INSERT INTO Category(Name, [Type]) VALUES (N'{txtName.Text}', {int.Parse(txtType.Text)})";
            //  sqlCommand.CommandText = $"INSERT INTO Category(Name, [Type]) VALUES (N'{txtName.Text}', {int.Parse(txtType.Text)})";
            //  // mở kết nói tới cơ sở dữ liệu
            //  sqlConnection.Open();

            //  // thực thi lệnh bằng phương thức ExcuteReader
            //  int numOfRowsEffected = sqlCommand.ExecuteNonQuery();



            //  // đóng kết nói
            //  sqlConnection.Close();
            //  if (numOfRowsEffected == 1)
            //  {
            //      MessageBox.Show("Thêm món ăn thành công");

            //      // tải lại dữ liệu

            //      btnLoad.PerformClick();

            //      // xóa các ô nhập
            //      txtName.Text = "";
            //      txtType.Text = "";
            //  }
            //  else
            //  {
            //      MessageBox.Show("Đã có lỗi xảy ra, vui lòng thử lại");
            //  }
            //  //if (numOfRowsEffected != 1)
            //  //{
            //  //    MessageBox.Show("Có lỗi xảy ra.");
            //  //    return;
            //  //}
            string connectionString = @"Data Source=MAYTINH-D3SVJBQ\SQLEXPRESS;Initial Catalog=RestaurantManagement;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = connection.CreateCommand();
           command.CommandText = $"INSERT INTO Category(Name, [Type]) VALUES (N'{txtName.Text}', {int.Parse(txtType.Text)})";
            //command.CommandText = "INSERT INTO Catrgory(Name, [Type])" + "VALUES (N' " + txtName.Text + " ', " + txtType.Text + ")";

            connection.Open();

            int numOfRowsEffected = command.ExecuteNonQuery();

            connection.Close();

            if (numOfRowsEffected != 1)
            {
                MessageBox.Show("Có lỗi xảy ra.");
                return;
            }

            btnLoad.PerformClick();

            txtName.Text = "";
            txtType.Text = "";
        }

        

        private void lvCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void lvCategory_Click(object sender, EventArgs e)
        {
            ListViewItem item = lvCategory.SelectedItems[0];

            txtID.Text = item.SubItems[0].Text;
            txtName.Text = item.SubItems[1].Text;
            txtType.Text = item.SubItems[2].Text == "0" ? "Thức uống" : "Đồ ăn";

            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=MAYTINH-D3SVJBQ\SQLEXPRESS;Initial Catalog=RestaurantManagement;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = connection.CreateCommand();

            string name = txtName.Text;
            string type = txtType.Text == "Thức uống" ? "0" : "1";
            string id = txtID.Text;

            command.CommandText = $"UPDATE Category SET Name = N'{name}', [Type] = {type} WHERE ID = {id}";

            connection.Open();

            int numOfRowsEffected = command.ExecuteNonQuery();

            if (numOfRowsEffected != 1)
            {
                MessageBox.Show("Có lỗi xảy ra");
                return;
            }
            else
            {


                ListViewItem item = lvCategory.SelectedItems[0];
                item.SubItems[1].Text = name;
                item.SubItems[2].Text = type;

                txtID.Text = "";
                txtName.Text = "";
                txtType.Text = "";

                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                MessageBox.Show("Cập nhật món ăn thành công!");
            }
            connection.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=MAYTINH-D3SVJBQ\SQLEXPRESS;Initial Catalog=RestaurantManagement;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = connection.CreateCommand();

            command.CommandText = $"DELETE FROM Category WHERE ID = {txtID.Text}";

            connection.Open();

            int numOfRowsEffected = command.ExecuteNonQuery();

            if (numOfRowsEffected != 1)
            {
                MessageBox.Show("Có lỗi xảy ra.");
                return;
            }
            else
            {

           
            lvCategory.Items.Remove(lvCategory.SelectedItems[0]);

            txtID.Text = "";
            txtName.Text = "";
            txtType.Text = "";

            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
                MessageBox.Show("Xóa món ăn thành công!");
            }
            connection.Close();
        }

        private void tsmDelete_Click(object sender, EventArgs e)
        {
            if (lvCategory.SelectedItems.Count > 0)
                btnDelete.PerformClick();
        }

        private void tsmViewFood_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                frmFood frmFood = new frmFood();
                frmFood.Show(this);
                frmFood.LoadFood(Convert.ToInt32(txtID.Text));
            }
        }
    }
}
