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
    public partial class AccountForrm : Form
    {
        public AccountForrm()
        {
            InitializeComponent();
        }

        private void AccountForrm_Load(object sender, EventArgs e)
        {
            LoadAccount();
        }
        private void LoadAccount()
        {
            SqlConnection conn = new SqlConnection(Form1.mainForm.connectionString);

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Account";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            conn.Open();

            adapter.Fill(dt);
            dgvAccount.DataSource = dt;
            dgvAccount.Columns[0].ReadOnly = true;

            conn.Close();
        }
        private void dgvAccount_Click(object sender, EventArgs e)
        {
            int index = dgvAccount.CurrentRow.Index;
            if (index != null)
            {
                txtAccountName.Text = dgvAccount.Rows[index].Cells["AccountName"].Value.ToString();
                txtPass.Text = dgvAccount.Rows[index].Cells["Password"].Value.ToString();
                txtFullName.Text = dgvAccount.Rows[index].Cells["FullName"].Value.ToString();
                txtEmail.Text = dgvAccount.Rows[index].Cells["Email"].Value.ToString();
                mtbSDT.Text = dgvAccount.Rows[index].Cells["Tell"].Value.ToString();

                btnUpdate.Enabled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(Form1.mainForm.connectionString);

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "EXECUTE USP_ThemKhachTaiKhoan @account,@pass,@fullname,@email,@tell,@date";

                cmd.Parameters.Add("@account", SqlDbType.NVarChar, 100);
                cmd.Parameters.Add("@pass", SqlDbType.NVarChar, 200);
                cmd.Parameters.Add("@fullname", SqlDbType.NVarChar, 1000);
                cmd.Parameters.Add("@email", SqlDbType.NVarChar, 1000);
                cmd.Parameters.Add("@tell", SqlDbType.NVarChar, 200);
                cmd.Parameters.Add("@date", SqlDbType.SmallDateTime);

                cmd.Parameters["@account"].Value = txtAccountName.Text;
                cmd.Parameters["@pass"].Value = txtPass.Text;
                cmd.Parameters["@fullname"].Value = txtFullName.Text;
                cmd.Parameters["@email"].Value = txtEmail.Text;
                cmd.Parameters["@tell"].Value = mtbSDT.Text;
                cmd.Parameters["@date"].Value = DateTime.Now.ToShortDateString();

                conn.Open();

                int numOfRows = cmd.ExecuteNonQuery();

                if (numOfRows == 1)
                {
                    LoadAccount();
                    ResetForm();
                    MessageBox.Show("Thêm thành công");
                }
                else
                {
                    MessageBox.Show("Lỗi", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SQL Error");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(Form1.mainForm.connectionString);

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "EXEC USP_UpdateAccount @account,@pass,@fullname,@email,@tell,@date";

                cmd.Parameters.Add("@account", SqlDbType.NVarChar, 100);
                cmd.Parameters.Add("@pass", SqlDbType.NVarChar, 200);
                cmd.Parameters.Add("@fullname", SqlDbType.NVarChar, 1000);
                cmd.Parameters.Add("@email", SqlDbType.NVarChar, 1000);
                cmd.Parameters.Add("@tell", SqlDbType.NVarChar, 200);
                cmd.Parameters.Add("@date", SqlDbType.SmallDateTime);

                cmd.Parameters["@account"].Value = txtAccountName.Text;
                cmd.Parameters["@pass"].Value = txtPass.Text;
                cmd.Parameters["@fullname"].Value = txtFullName.Text;
                cmd.Parameters["@email"].Value = txtEmail.Text;
                cmd.Parameters["@tell"].Value = mtbSDT.Text;
                cmd.Parameters["@date"].Value = DateTime.Now.ToShortDateString();

                conn.Open();

                int numOfRows = cmd.ExecuteNonQuery();

                if (numOfRows == 1)
                {
                    LoadAccount();
                    ResetForm();
                    MessageBox.Show("Cập nhật thành công");
                }
                else
                {
                    MessageBox.Show("lỗi", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SQL Error");
            }
        }
        private void ResetForm()
        {
            txtAccountName.Text = "";
            txtPass.Text = "";
            txtFullName.Text = "";
            txtEmail.Text = "";
            mtbSDT.Text = "";
            btnUpdate.Enabled = false;
        }

        private void tsmRole_Click(object sender, EventArgs e)
        {
            var name = dgvAccount.SelectedRows[0].Cells[0].Value.ToString();
            RoleForm frm = new RoleForm();
            frm.LoadRole(name);
            frm.ShowDialog(this);
        }
    }
}
