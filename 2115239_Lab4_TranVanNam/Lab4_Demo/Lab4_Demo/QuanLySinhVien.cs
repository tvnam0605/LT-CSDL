using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;

namespace Lab4_Demo
{
    public delegate int SoSanh(object sv1, object sv2);
    public class QuanLySinhVien
    {
        public List<SinhVien> DanhSach;

        public QuanLySinhVien()
        {
            DanhSach = new List<SinhVien>();
        }
        public void Them(SinhVien sv)
        {
            this.DanhSach.Add(sv);
        }
        public SinhVien this[int index]
        {
            get { return DanhSach[index]; }
            set { DanhSach[index] = value; }
        }
        // xóa các obj trong danh sách nếu thỏa điều kiện so sánh
        public void Xoa(object obj, SoSanh ss)
        {
            int i = DanhSach.Count - 1;
            for (; i >= 0; i--)
                if (ss(obj, this[i]) == 0)
                    this.DanhSach.RemoveAt(i);
        }
        // tìm sv thỏa đk
        public SinhVien Tim(object obj, SoSanh ss)
        {
            SinhVien svkq = null;
            foreach (SinhVien sv in DanhSach)
                if(ss(obj, sv)==0)
                {
                    svkq = sv;
                    break;
                }
            return svkq;
        }
        //Tìm một sinh viên trong danh sách thỏa điều kiện so sánh, gán lại thông tin cho sinh viên này thành svsua
        public bool Sua(SinhVien svsua, object obj, SoSanh ss)
        {
            int i, count;
            bool kq = false;
            count = this.DanhSach.Count - 1;
            for (i=0; i < count; i++)
                if(ss(obj, this[i])==0)
                {
                    this[i] = svsua;
                    kq = true;
                    break;
                }
            return kq;
            
        }
        // hàm đọc từ file
        public void DocTuFile()
        {
            string filename = "DSNV.txt", t;
            string[] s;
            SinhVien sv;
            StreamReader sr = new StreamReader(
                new FileStream(filename, FileMode.Open));
            while ((t = sr.ReadLine())!= null)
            {
                s = t.Split('\t');
                sv = new SinhVien();
                sv.MaSo = s[0];
                sv.HoTen = s[1];
                //sv.GioiTinh =false;
                sv.GioiTinh = false;
                if (s[2] == "1")
                    sv.GioiTinh = true;
                sv.NgaySinh = DateTime.ParseExact(s[3] ,"MM/dd/yyyy", CultureInfo.InvariantCulture);
                sv.Lop = s[4];
                sv.SDT = s[5];
                sv.Email = s[6];
                sv.DiaChi = s[7];
                sv.Hinh = s[8];
                this.Them(sv);

            }    
        }
       

    }
}
