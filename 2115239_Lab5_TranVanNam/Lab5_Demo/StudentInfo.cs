using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace Lab5_Demo
{
    public class StudentInfo
    {
        // Các thuộc tính
        public string MSSV { get; set; }
        public string Hoten { get; set; }
        public int Tuoi { get; set; }
        public double Diem { get; set; }
        public bool TonGiao { get; set; }
        // Phương thức tạo lập
        public StudentInfo(string mssv, string hoten, int tuoi, double diem,
       bool tongiao)
        {
            this.MSSV = mssv;
            this.Hoten = hoten;
            this.Tuoi = tuoi;
            this.Diem = diem;
            this.TonGiao = tongiao;
        }
        private List<StudentInfo> LoadJSON (string Path)
        {
            //Khai báo danh sách lưu trữ
            List<StudentInfo> List = new List<StudentInfo>();
            // đối tượng đọc tập tin
            StreamReader r = new StreamReader(Path);
            string json = r.ReadToEnd(); // đọc hết
            // chuyển về thành mảng đối các tượng.
            var array = (JObject)JsonConvert.DeserializeObject(json);
            // lấy đối tượng sinhvien
            var students = array["sinhvien"].Children();
            foreach (var item in students)

            {
                // lấy cacsthanh phần
                string mssv = item["MSSV"].Value<string>();
                string hoten = item["hoten"].Value<string>();
                int tuoi = item["tuoi"].Value<int>();
                double diem = item["diem"].Value<double>();
                bool tongiao = item["tongiao"].Value<bool>();
                // chuyển vào đối tượng StufentInfo
                StudentInfo info = new StudentInfo(mssv, hoten, tuoi, diem, tongiao);
                List.Add(info); // thêm vào danh sách
            }
            return List;
        }
    }
}
