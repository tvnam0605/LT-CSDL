using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab7
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(Form1.mainForm.connectionString);

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "EXECUTE Bills_GetByDate @StartDay , @EndDay";

                cmd.Parameters.Add("@StartDay", SqlDbType.SmallDateTime);
                cmd.Parameters["@StartDay"].Value = dpkTuNgay.Value.ToShortDateString();
				cmd.Parameters["@EndDay"].Value = dpkDenNgay.Value.ToShortDateString();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                conn.Open();

                adapter.Fill(dt);
                cmd.CommandText = "Select SUM(Amount) from Bills where CheckoutDate = @date";

                var doanhThu = cmd.ExecuteScalar();
                lbDoanhThu.Text = doanhThu.ToString();

                conn.Close();

                dgvHoaDon.DataSource = dt;
                dgvHoaDon.Columns[0].ReadOnly = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SQL Error");
            }
        }

        private void dgvHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvHoaDon_DoubleClick(object sender, EventArgs e)
        {
			if (dgvHoaDon.SelectedRows.Count > 0)
			{
				if (!dgvHoaDon.SelectedRows[0].Cells[0].IsInEditMode)
				{
					string billID = dgvHoaDon.SelectedRows[0].Cells[0].Value.ToString();
					if (int.TryParse(billID, out int parsedBillID))
					{
						OrderDetailsForm billDetails = new OrderDetailsForm();
						billDetails.LoadDetail(parsedBillID);
						billDetails.Show();
					}
					else
					{
						MessageBox.Show("Vui lòng chọn một hóa đơn để xem chi tiết.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
				else
				{
					MessageBox.Show("Vui lòng chọn một hóa đơn để xem chi tiết.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			else
			{
				MessageBox.Show("Vui lòng chọn một hóa đơn để xem chi tiết.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}


		}

		private void lbDoanhThu_Click(object sender, EventArgs e)
        {

        }

		private void OrderForm_Load(object sender, EventArgs e)
		{
			string connString = @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=RestaurantManagement;Integrated Security=True";
			SqlConnection conn = new SqlConnection(connString);
			SqlCommand cmd = conn.CreateCommand();
			cmd.CommandText = "SELECT  * from Bills";
			
			SqlDataAdapter adapter = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();

			conn.Open();

			adapter.Fill(dt);
			conn.Close();
			conn.Dispose();
			dgvHoaDon.DataSource = dt;
			TinhTongTienHang();

			//cbbCategory.DataSource = dt;
			//cbbCategory.DisplayMember = "Name";
			//cbbCategory.ValueMember = "ID";
		}
		public void TinhTongTienHang()
		{
			decimal totalAmount = 0;
			foreach (DataGridViewRow row in dgvHoaDon.Rows)
			{
				if (row.Cells["Amount"].Value != null && row.Cells["Amount"].Value != DBNull.Value)
				{
					decimal rowAmount = Convert.ToDecimal(row.Cells["Amount"].Value);
					totalAmount += rowAmount;
				}
			}
			
			lbDoanhThu.Text = totalAmount.ToString();
		}
	}
}
