using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_Demo
{
    public partial class frmTuyChon : Form
    {
        QuanLySinhVien quanLy;
        public List<SinhVien> DanhSach;

        public frmTuyChon()
        {
            InitializeComponent();
        }
        public enum TuyChon
        {
            MaSV,
            HoTen,
            NgaySinh
        }
        private int SoSanhTheoMa(object obj1, object obj2)
        {
            SinhVien sv = obj2 as SinhVien;
            return sv.MaSo.CompareTo(obj1);
        }
        int DieuKienSapXep(SinhVien a, SinhVien b, TuyChon k)
        {
            //if(k==TuyChon.)
            return 0;
        }
        void SapXep(TuyChon k)
        {
            
            
           
        }

        private void frmTuyChon_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSapXep_Click(object sender, EventArgs e)
        {
            if(rdHoTen.Checked)
            {

            }    
        }


        private void btnMaSV_CheckedChanged(object sender, EventArgs e)
        {
            if(rdHoTen.Checked)
            {

            }
        }

       

        private void btnTim_Click(object sender, EventArgs e)
        {
             ListViewItem lvitem= new ListViewItem();
            SinhVien sv = new SinhVien();

            if (txtNhapTT.Text=="")
            {
                MessageBox.Show("Hãy nhập thông tin tìm!", "Lỗi nhập thông tin",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(rdHoTen.Checked==true)
            {
                for (int i = 0; i < lvitem.IndentCount; i++)
                    lvitem.SubItems[i].BackColor = Color.White;
      
                string TenTim;
                bool TimThay = false;
                TenTim = txtNhapTT.Text;
                for (int i = 0; i < lvitem.IndentCount; i++)
                {
                    if (lvitem.SubItems[1].Text == TenTim)
                    {
                        TimThay = true;
                        MessageBox.Show("Tìm  thấy Tên: " + TenTim.ToString(), "Thông báo");

                    }    
                }
                if (TimThay == false)
                    MessageBox.Show("Không tìm thấy Tên: " + TenTim.ToString(), "Thông báo");

            }    
            else if(rdMaSV.Checked==true)
            {
                sv.MaSo = lvitem.SubItems[0].Text;
            }
            else
            {
                sv.NgaySinh = DateTime.Parse(lvitem.SubItems[2].Text);

            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnDieuKien_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void groupBoxTim_Enter(object sender, EventArgs e)
        {
            
        }

       
    }
}
