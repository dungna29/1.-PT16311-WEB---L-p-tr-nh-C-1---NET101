using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3._3_Contructor
{
    class SinhVien
    {
        //Phần 1: Liệt kê tất cả các thuộc tính phải có của đối tượng
        private string tenSv;
        private string maSv;
        private string school = "FPTPOLY";

        private double diemCsharp;
        //Phần 2: Tạo 2 Contructor
        public SinhVien()
        {
            
        }

        public SinhVien(string tenSv, string maSv)
        {
            this.tenSv = tenSv;
            this.maSv = maSv;
        }

        //Phần 3: Getter và Setter
        //Setter dùng để gán giá trị cho thuộc tính đối tượng
        public void setTenSv(string tenSv)
        {
            this.tenSv = tenSv;
        }
        //Getter dùng để lấy giá trị của thuộc tính đối tượng
        public String getTenSv()
        {
            return tenSv;
        }

        public void setMaSv(string maSv)
        {
            this.maSv = maSv;
        }
        public String getMaSv()
        {
            return maSv;
        }

        public void setDiem(double diemCsharp)
        {
            if (diemCsharp < 0)
            {
                Console.WriteLine("Điểm bị âm không tồn tại");
                return;
            }
            this.diemCsharp = diemCsharp;
        }
        public double getDiem()
        {
            return diemCsharp;
        }

        public String getSchool()
        {
            return school;
        }

        //Phần 4: Phương thức của đối tượng
        private void inRaManHinh()
        {

        }
    }
}
