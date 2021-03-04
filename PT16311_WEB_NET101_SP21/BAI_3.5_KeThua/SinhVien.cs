using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_3._5_KeThua
{
    class SinhVien: Person
    {
        private string maSv;
        private double diemCsharp;

        public SinhVien()
        {
            
        }

        
        public SinhVien(string ho, string tendem, string ten, string maSv, double diemCsharp) : base(ho, tendem, ten)
        {
            this.maSv = maSv;
            this.diemCsharp = diemCsharp;
        }

        public string MaSv
        {
            get => maSv;
            set => maSv = value;
        }

        public double DiemCsharp
        {
            get => diemCsharp;
            set => diemCsharp = value;
        }

        void inRaManHinhSinhVien()
        {
            inRaManHinhPeron();//Vẫn có thể gọi phương thức lớp cha ra để sử dụng
            //Gọi các thuộc tính lớp  cha
            
        }

        public override void inRaManHinhPeron()
        {
            //base.inRaManHinhPeron();
            Console.WriteLine("Đây là phương thức của sinh viên");
        }

      
    }
}
