﻿using System;
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
    public partial class OrderDetailsForm : Form
    {
		//int billID;
        public OrderDetailsForm()
        {
            InitializeComponent();
			
        }
        public void LoadDetail(int billID)
        {
            try
            {
                SqlConnection conn = new SqlConnection(Form1.mainForm.connectionString);

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "EXECUTE BillDetail_GetById @id";

                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = billID;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                conn.Open();

                adapter.Fill(dt);
                dgvOrderDetail.DataSource = dt;
                dgvOrderDetail.Columns[0].ReadOnly = true;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SQL Error");
            }
        }

		private void OrderDetailsForm_Load(object sender, EventArgs e)
		{
			//LoadDetail(billID);
		}
	}
}
