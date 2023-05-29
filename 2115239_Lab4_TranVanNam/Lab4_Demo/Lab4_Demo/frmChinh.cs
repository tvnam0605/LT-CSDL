using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_Demo
{
    public partial class frmChinh : Form
    {
        QuanLySinhVien qlsv;

        public object sv { get; private set; }

        public frmChinh()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnChonHinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog browser = new OpenFileDialog();
            // kiểm tra điều kiện đọc file: filter
            browser.Filter = "Image file (*.bmp; *.jpg; *.png)|*.bmp; *.jpg; *.png| All file (*.*)|*.*; ";
            // đặt tiêu đề
            browser.Title = "Chọn hình";
            // kiểm tra người dùng chọn file hay chưa
            if (browser.ShowDialog() == DialogResult.OK)
            {
                pbHinh.Image = Image.FromFile(browser.FileName);
            }
            txtHinh.Text = browser.FileName;

        }

        private void btnMacDinh_Click(object sender, EventArgs e)
        {
           

        }
        private void XoaNoiDung(Control ctrl)
        {
           
        }
        // lấy thông tin từ controls thong tin sinh viên
        public SinhVien GetSinhVien()
        {
            SinhVien sv = new SinhVien();
            bool gt = true;
            sv.MaSo = this.mskMSSV.Text;
            sv.HoTen = this.txtHoTen.Text;
            if (rdNu.Checked)
                gt = false;
            sv.GioiTinh = gt;
            sv.NgaySinh = this.dtpNgaySinh.Value;
            sv.Lop = this.cbbLop.ValueMember;
            sv.SDT = this.mskSDT.Text;
            sv.Email = this.txtEmail.Text;
            sv.DiaChi = this.txtDiaChi.Text;
            sv.Hinh = this.txtHinh.Text;
            return sv;
        }
        // lấy thông tin sinh viên từ dòng item của listview
        private SinhVien GetSinhVienLV(ListViewItem lvitem)
        {
            SinhVien sv = new SinhVien();
            sv.MaSo = lvitem.SubItems[0].Text;
            sv.HoTen = lvitem.SubItems[1].Text;
            sv.GioiTinh = false;
            if (lvitem.SubItems[2].Text == "Nam")
                sv.GioiTinh = true;
            sv.NgaySinh = DateTime.Parse(lvitem.SubItems[3].Text);
            sv.Lop = lvitem.SubItems[4].Text;
            sv.SDT = lvitem.SubItems[5].Text;
            sv.Email = lvitem.SubItems[6].Text;
            sv.DiaChi = lvitem.SubItems[7].Text;
            sv.Hinh = lvitem.SubItems[8].Text;

            return sv;
        }
        // thiết lập các thông tin controls sinh viên
        private void ThietLapThongTin(SinhVien sv)
        {
            this.mskMSSV.Text = sv.MaSo;
            this.txtHoTen.Text = sv.HoTen;
            if (sv.GioiTinh)
                this.rdNam.Checked = true;
            else
                this.rdNu.Checked = true;
            this.dtpNgaySinh.Value = sv.NgaySinh;
            this.cbbLop.Text = sv.Lop;
            this.mskSDT.Text = sv.SDT;
            this.txtEmail.Text = sv.Email;
            this.txtDiaChi.Text = sv.DiaChi;
            this.txtHinh.Text = sv.Hinh;
            this.pbHinh.ImageLocation=sv.Hinh;
            
        }
        // thêm sinh viên vào list view
        private void ThemSV(SinhVien sv)
        {
            ListViewItem lvitem = new ListViewItem(sv.MaSo);
            lvitem.SubItems.Add(sv.HoTen);
            string gt = "Nữ";
            if (sv.GioiTinh)
                gt = "Nam";
            lvitem.SubItems.Add(gt);
            lvitem.SubItems.Add(sv.NgaySinh.ToShortDateString());
            lvitem.SubItems.Add(sv.Lop);
            lvitem.SubItems.Add(sv.SDT);
            lvitem.SubItems.Add(sv.Email);
            lvitem.SubItems.Add(sv.DiaChi);
            lvitem.SubItems.Add(sv.Hinh);
            this.lvDanhSach.Items.Add(lvitem);
        }
        //Hiển thị các sinh viên trong qlsv lên ListView
        private void LoadListView()
        {
            this.lvDanhSach.Items.Clear();
            foreach (SinhVien sv in qlsv.DanhSach)
            {
                ThemSV(sv);
            }
            toolStripStatusLabel1.Text = "Tổng số sinh viên là: " + lvDanhSach.Items.Count;
        }


        private void frmChinh_Load(object sender, EventArgs e)
        {
            qlsv = new QuanLySinhVien();
            qlsv.DocTuFile();
            LoadListView();
        }

        private void btnLuu_Click(object sender, EventArgs e)
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
           // this.LuuDuLieu();
        }

        private void lvDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = this.lvDanhSach.SelectedItems.Count;
            if (count > 0)
            {
                ListViewItem lvitem =
                this.lvDanhSach.SelectedItems[0];
                SinhVien sv = GetSinhVienLV(lvitem);
                ThietLapThongTin(sv);
            }
        }

        private void lvDanhSach_MouseUp(object sender, MouseEventArgs e)
        {
        }
        private int SoSanhTheoMa(object obj1, object obj2)
        {
            SinhVien sv = obj2 as SinhVien;
            return sv.MaSo.CompareTo(obj1);
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int count, i;
            ListViewItem lvitem;
            count = this.lvDanhSach.Items.Count - 1;
            for (i = count; i >= 0; i--)
            {
                lvitem = this.lvDanhSach.Items[i];
                if (lvitem.Checked)
                    qlsv.Xoa(lvitem.SubItems[0].Text, SoSanhTheoMa);
            }
            this.LoadListView();
            this.btnMacDinh.PerformClick();
        }

        private void tảiLạiDanhSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvDanhSach.Refresh();
            this.LoadListView();
        }

        private void frmChinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn thoát không?", "Quản lý sinh viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            //if (e.Cancel == true)
            //{
            //    SinhVien sv = GetSinhVien();
            //    SinhVien kq = qlsv.Tim(sv.MaSo,
            //    delegate (object obj1, object obj2)
            //    {
            //        return (obj2 as
            //     SinhVien).MaSo.CompareTo(obj1.ToString());
            //    });
            //    if (kq != null)
            //        MessageBox.Show("Mã sinh viên đã tồn tại!", "Lỗi thêm dữ liệu",
            //        MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    else
            //    {
            //        this.qlsv.Them(sv);
            //        this.LoadListView();
            //    }
            //}
            //else
            //    Application.Exit();
        }

        private void btnMacDinh_Click_1(object sender, EventArgs e)
        {
            this.mskMSSV.Text = "";
            this.txtHoTen.Text = "";
            this.dtpNgaySinh.Value = DateTime.Now;
            this.txtDiaChi.Text = "";
            this.cbbLop.Text = this.cbbLop.Items[0].ToString();
            this.txtHinh.Text = "";
            this.pbHinh.ImageLocation = "";
            this.txtEmail.Text = "";
            this.mskSDT.Text = "";
            this.rdNam.Checked = true;
        }
        //public void LuuDuLieu()
        //{
            
        //        StreamWriter writer = File.AppendText("DSNV.txt");//path là đường dẫn file text của bạn
        //        foreach (ListViewItem i in this.lvDanhSach.Items)
        //        {
        //            if (i.SubItems[2].Text == "Nam")


        //                writer.WriteLine('\n' + i.SubItems[0].Text + '\t' + i.SubItems[1].Text + '\t' + i.SubItems[2].Text + '\t' + i.SubItems[3].Text + '\t' + i.SubItems[4].Text + '\t' + i.SubItems[5].Text
        //                    + '\t' + i.SubItems[6].Text + '\t' + i.SubItems[7].Text + '\t' + i.SubItems[8].Text);

        //        }
        //        writer.Flush();
        //        writer.Close();
        //        writer.Dispose();
            
           
        //}
    }
}
