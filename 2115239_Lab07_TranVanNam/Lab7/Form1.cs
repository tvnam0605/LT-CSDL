using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Lab7
{
    public partial class Form1 : Form
    {
        public string connectionString = @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=RestaurantManagement;Integrated Security=True";
        public static Form1 mainForm = new Form1();

        private DataTable foodTable;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.LoadCategory();
        }

        private void LoadCategory()
        {
            string connString = @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=RestaurantManagement;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT ID, Name FROM Category";

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            conn.Open();

            adapter.Fill(dt);
            conn.Close();
            conn.Dispose();

            cbbCategory.DataSource = dt;
            cbbCategory.DisplayMember = "Name";
            cbbCategory.ValueMember = "ID";
        }

        private void cbbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbCategory.SelectedIndex == -1) return;
            string connString = @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=RestaurantManagement;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Food Where FoodCategoryID = @categoryId";

            cmd.Parameters.Add("@categoryId", SqlDbType.Int);
            if (cbbCategory.SelectedValue is DataRowView)
            {
                DataRowView rowView = cbbCategory.SelectedValue as DataRowView;
                cmd.Parameters["@categoryId"].Value = rowView["ID"];
            }
            else
            {
                cmd.Parameters["@categoryId"].Value = cbbCategory.SelectedValue;
            }

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            foodTable = new DataTable();

            conn.Open();

            adapter.Fill(foodTable);

            conn.Close();
            conn.Dispose();

            dgvFoodList.DataSource = foodTable;

            dgvFoodList.Columns[0].ReadOnly = true;

            lblCatName.Text = cbbCategory.Text;
            lblQuantity.Text = foodTable.Rows.Count.ToString();
        }

        private void tsmCalculateQuantity_Click(object sender, EventArgs e)
        {
            string connString = @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=RestaurantManagement;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT @numSaleFood = sum(Quantity) FROM BillDetails WHERE FoodID = @foodId";

            if (dgvFoodList.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvFoodList.SelectedRows[0];
                DataRowView rowView = selectedRow.DataBoundItem as DataRowView;

                cmd.Parameters.Add("@foodId", SqlDbType.Int);
                cmd.Parameters["@foodId"].Value = rowView["ID"];

                cmd.Parameters.Add("@numSaleFood", SqlDbType.Int);
                cmd.Parameters["@numSaleFood"].Direction = ParameterDirection.Output;

                conn.Open();

                cmd.ExecuteNonQuery();

                var result = cmd.Parameters["@numSaleFood"].Value.ToString();
                MessageBox.Show("Tổng số lượng món " + rowView["Name"] + " đã bán là: " + result + " " + rowView["Unit"]);

                conn.Close();

            }
            cmd.Dispose();
            conn.Dispose();
        }

        private void tsmAddFood_Click(object sender, EventArgs e)
        {
            FoodInfoForrm frmFood = new FoodInfoForrm();
            frmFood.loadAdd();
            frmFood.FormClosed += new FormClosedEventHandler(frmFood_FormClosed);
            frmFood.Show(this);
        }
        private void frmFood_FormClosed(object sender, FormClosedEventArgs e)
        {
            int index = cbbCategory.SelectedIndex;
            cbbCategory.SelectedIndex = -1;
            cbbCategory.SelectedIndex = index;
        }

        private void tsmUpdateFood_Click(object sender, EventArgs e)
        {
            if (dgvFoodList.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvFoodList.SelectedRows[0];
                var rowView = selectedRow.DataBoundItem as DataRowView;
                FoodInfoForrm frmFood = new FoodInfoForrm();
                frmFood.loadUpdate();
                frmFood.FormClosed += new FormClosedEventHandler(frmFood_FormClosed);
                frmFood.Show(this);
                frmFood.DisplayFoodInfo(rowView);
            }
        }

        private void txtSearchByName_TextChanged(object sender, EventArgs e)
        {
            if (foodTable == null) return;

            string filterExpression = "Name like '%" + txtSearchByName.Text + "%'";
            string sortExpression = "Price DESC";
            DataViewRowState dataViewRowState = DataViewRowState.OriginalRows;

            DataView foodView = new DataView(foodTable, filterExpression, sortExpression, dataViewRowState);

            dgvFoodList.DataSource = foodView;
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            AccountForrm frm = new AccountForrm();
            frm.ShowDialog(this);
        }

        private void bntBills_Click(object sender, EventArgs e)
        {
            OrderForm frm = new OrderForm();
            frm.ShowDialog(this);
        }
    }
}
