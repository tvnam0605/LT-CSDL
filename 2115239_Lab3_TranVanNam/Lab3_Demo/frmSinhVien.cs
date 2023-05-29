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
    public partial class frmSinhVien : Form
    {
        QuanLySinhVien qlsv;

        public object sv { get; private set; }

        public frmSinhVien()
        {
            InitializeComponent();
        }
        #region Method
        //Lấy thông tin từ controls thông tin SV
        public SinhVien GetSinhVien()
        {
            SinhVien sv = new SinhVien();
            bool gt = true;
            List<string> cn = new List<string>();
            sv.MaSo = this.mtxtMaSo.Text;
            sv.HoTen = this.txtHoTen.Text;
            sv.NgaySinh = this.dtpNgaySinh.Value;
            sv.DiaChi = this.txtDiaChi.Text;
            sv.Lop = this.cboLop.Text;
            sv.Hinh = this.txtHinh.Text;
            if (rdNu.Checked)
                gt = false;
            sv.GioiTinh = gt;
            for (int i = 0; i < this.clbChuyenNganh.Items.Count; i++)
                if (clbChuyenNganh.GetItemChecked(i))
                    cn.Add(clbChuyenNganh.Items[i].ToString());
            sv.ChuyenNganh = cn;
            return sv;
        }
        //Lấy thông tin sinh viên từ dòng item của ListView
        private SinhVien GetSinhVienLV(ListViewItem lvitem)
        {
            SinhVien sv = new SinhVien();
            sv.MaSo = lvitem.SubItems[0].Text;
            sv.HoTen = lvitem.SubItems[1].Text;
            sv.NgaySinh = DateTime.Parse(lvitem.SubItems[2].Text);
            sv.DiaChi = lvitem.SubItems[3].Text;
            sv.Lop = lvitem.SubItems[4].Text;
            sv.GioiTinh = false;
            if (lvitem.SubItems[5].Text == "Nam")
                sv.GioiTinh = true;
            List<string> cn = new List<string>();
            string[] s = lvitem.SubItems[6].Text.Split(',');
            foreach (string t in s)
                cn.Add(t);
            sv.ChuyenNganh = cn;
            sv.Hinh = lvitem.SubItems[7].Text;
            return sv;
        }
        //Thiết lập các thông tin lên controls sinh viên
        private void ThietLapThongTin(SinhVien sv)
        {
            this.mtxtMaSo.Text = sv.MaSo;
            this.txtHoTen.Text = sv.HoTen;
            this.dtpNgaySinh.Value = sv.NgaySinh;
            this.txtDiaChi.Text = sv.DiaChi;
            this.cboLop.Text = sv.Lop;
            this.txtHinh.Text = sv.Hinh;
            this.pbHinh.ImageLocation = sv.Hinh;
            if (sv.GioiTinh)
                this.rdNam.Checked = true;
            else
                this.rdNu.Checked = true;
            for (int i = 0; i < this.clbChuyenNganh.Items.Count; i++)
                this.clbChuyenNganh.SetItemChecked(i, false);
            foreach (string s in sv.ChuyenNganh)
            {
                for (int i = 0; i < this.clbChuyenNganh.Items.Count;
                i++)
                    if
                    (s.CompareTo(this.clbChuyenNganh.Items[i]) == 0)
                        this.clbChuyenNganh.SetItemChecked(i,
                        true);
            }
        }
        //Thêm sinh viên vào ListView
        private void ThemSV(SinhVien sv)
        {
            ListViewItem lvitem = new ListViewItem(sv.MaSo);
            lvitem.SubItems.Add(sv.HoTen);
            lvitem.SubItems.Add(sv.NgaySinh.ToShortDateString());
            lvitem.SubItems.Add(sv.DiaChi);
            lvitem.SubItems.Add(sv.Lop);
            string gt = "Nữ";
            if (sv.GioiTinh)
                gt = "Nam";
            lvitem.SubItems.Add(gt);
            string cn = "";
            foreach (string s in sv.ChuyenNganh)
                cn += s + ",";
            cn = cn.Substring(0, cn.Length - 1);
            lvitem.SubItems.Add(cn);
            lvitem.SubItems.Add(sv.Hinh);
            this.lvSinhVien.Items.Add(lvitem);
        }
        //Hiển thị các sinh viên trong qlsv lên ListView
        private void LoadListView()
        {
            this.lvSinhVien.Items.Clear();
            foreach (SinhVien sv in qlsv.DanhSach)
            {
                ThemSV(sv);
            }
            toolStripStatusLabel1.Text = "Tổng số sinh viên là: " + lvSinhVien.Items.Count;
        }


        #endregion

        #region Events
        //sự kiện Load form
        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            qlsv = new QuanLySinhVien();
            qlsv.DocTuFile();
            LoadListView();
            
        }
       


       

        private void lvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = this.lvSinhVien.SelectedItems.Count;
            if (count > 0)
            {
                ListViewItem lvitem =
                this.lvSinhVien.SelectedItems[0];
                SinhVien sv = GetSinhVienLV(lvitem);
                ThietLapThongTin(sv);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SinhVien sv = GetSinhVien();
            SinhVien kq = qlsv.Tim(sv.MaSo,
            delegate (object obj1, object obj2)
            {
                return (obj2 as
    SinhVien).MaSo.CompareTo(obj1.ToString());
            });
            if (kq != null)
                MessageBox.Show("Mã sinh viên đã tồn tại!", "Lỗi thêm dữ liệu",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                this.qlsv.Them(sv);
                this.LoadListView();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int count, i;
            ListViewItem lvitem;
            count = this.lvSinhVien.Items.Count - 1;
            for (i = count; i >= 0; i--)
            {
                lvitem = this.lvSinhVien.Items[i];
                if (lvitem.Checked)
                    qlsv.Xoa(lvitem.SubItems[0].Text, SoSanhTheoMa);
            }
            this.LoadListView();
            this.btnMacDinh.PerformClick();

        }

        private void btnMacDinh_Click(object sender, EventArgs e)
        {
            this.mtxtMaSo.Text = "";
            this.txtHoTen.Text = "";
            this.dtpNgaySinh.Value = DateTime.Now;
            this.txtDiaChi.Text = "";
            this.cboLop.Text = this.cboLop.Items[0].ToString();
            this.txtHinh.Text = "";
            this.pbHinh.ImageLocation = "";
            this.rdNam.Checked = true;
            for (int i = 0; i < this.clbChuyenNganh.Items.Count - 1;
            i++)
                this.clbChuyenNganh.SetItemChecked(i, false);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SinhVien sv = GetSinhVien();
            bool kqsua;
            kqsua = qlsv.Sua(sv, sv.MaSo, SoSanhTheoMa);
            if (kqsua)
            {
                this.LoadListView();
            }
        }
        private int SoSanhTheoMa(object obj1, object obj2)
        {
            SinhVien sv = obj2 as SinhVien;
            return sv.MaSo.CompareTo(obj1);
        }
        #endregion

        public void DemSV()
        {
            //lvSinhVien.Columns.Count(qlsv);
            
        }
        private void btnBrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog browser = new OpenFileDialog();
            //check ddiefu kiện đọc file
            browser.Filter = "image File (*.bmp; *.jpg; *.png)|*.bmp; *.jpg; *.png |All file (*.*)|*.*";
            //Set tiêu đề
            browser.Title = "Open File Image";
            //kiểm tra xem người dùng đã chọn file hay chưa
            if(browser.ShowDialog()==DialogResult.OK)
            {
                //MessageBox.Show(browser.SafeFileName);
                MessageBox.Show("Đã nhập thành công ảnh!", "Thông báo",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                pbHinh.Image = Image.FromFile(browser.FileName);
            }    
        }

        
        private void tsmThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsmOpenImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog browser = new OpenFileDialog();
            //check ddiefu kiện đọc file
            browser.Filter = "image File (*.bmp; *.jpg; *.png)|*.bmp; *.jpg; *.png |All file (*.*)|*.*";
            //Set tiêu đề
            browser.Title = "Open File Image";
            //kiểm tra xem người dùng đã chọn file hay chưa
            if (browser.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(browser.SafeFileName);
                pbHinh.Image = Image.FromFile(browser.FileName);
            }
        }

        private void tsmSapXep_Click(object sender, EventArgs e)
        {
            frmTuyChon frm = new frmTuyChon();
            frm.groupBoxTim.Enabled = false;
            frm.txtNhapTT.Enabled = false;
            frm.btnTim.Enabled = false;
            frm.ShowDialog();

        }

        private void tsmThem_Click(object sender, EventArgs e)
        {
            SinhVien sv = GetSinhVien();
            SinhVien kq = qlsv.Tim(sv.MaSo,
            delegate (object obj1, object obj2)
            {
                return (obj2 as
    SinhVien).MaSo.CompareTo(obj1.ToString());
            });
            if (kq != null)
                MessageBox.Show("Mã sinh viên đã tồn tại!", "Lỗi thêm dữ liệu",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                this.qlsv.Them(sv);
                this.LoadListView();
            }
        }

       

        private void tsmXoa_Click(object sender, EventArgs e)
        {
            int count, i;
            ListViewItem lvitem;
            count = this.lvSinhVien.Items.Count - 1;
            for (i = count; i >= 0; i--)
            {
                lvitem = this.lvSinhVien.Items[i];
                if (lvitem.Checked)
                    qlsv.Xoa(lvitem.SubItems[0].Text, SoSanhTheoMa);
            }
            this.LoadListView();
            this.btnMacDinh.PerformClick();

        }

        private void tsmSua_Click(object sender, EventArgs e)
        {
            SinhVien sv = GetSinhVien();
            bool kqsua;
            kqsua = qlsv.Sua(sv, sv.MaSo, SoSanhTheoMa);
            if (kqsua)
            {
                this.LoadListView();
            }
        }

        private void tsmTimKiem_Click(object sender, EventArgs e)
        {
            frmTuyChon frm = new frmTuyChon();
            frm.btnSapXep.Enabled = false;
            frm.ShowDialog();

        }

        private void tsmColorText_Click(object sender, EventArgs e)
        {
            
            
            
        }

        private void tsmXanh_Click(object sender, EventArgs e)
        {
            this.lvSinhVien.ForeColor = Color.Green;

        }

        private void tsmDo_Click(object sender, EventArgs e)
        {
            this.lvSinhVien.ForeColor = Color.Red;
        }

        private void tsmTim_Click(object sender, EventArgs e)
        {
            this.lvSinhVien.ForeColor = Color.Purple;
        }

        private void mặcĐịnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.lvSinhVien.ForeColor = Color.Black;
            

        }

        private void tsmFont_Click(object sender, EventArgs e)
        {
           
        }

        private void tsmBold_Click(object sender, EventArgs e)
        {
            
            
            lvSinhVien.Text = "Font Bold at 24";
            lvSinhVien.Font = new Font("Monotype Corsiva", 8);
        }

        private void tsmNghieng_Click(object sender, EventArgs e)
        {
            lvSinhVien.Font = new Font("Mistral", 8);

        }

        private void tsmGachChan_Click(object sender, EventArgs e)
        {
            lvSinhVien.Font = new Font("Ravie", 8);
        }

        private void tsmFMacDinh_Click(object sender, EventArgs e)
        {
            lvSinhVien.Font = new Font("Microsoft Sans Serif", 8);

        }
    }
}



            
        