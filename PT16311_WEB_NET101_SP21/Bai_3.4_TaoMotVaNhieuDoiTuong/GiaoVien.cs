using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3._4_TaoMotVaNhieuDoiTuong
{
    class GiaoVien
    {
        private string ten;
        private string maGv;
        private int namSinh;
        private string diaChi;

        //ctor
        public GiaoVien()
        {
            
        }
        //ALT + ENTER
        public GiaoVien(string ten, string maGv, int namSinh, string diaChi)
        {
            this.ten = ten;
            this.maGv = maGv;
            this.namSinh = namSinh;
            this.diaChi = diaChi;
        }

        public string Ten
        {
            get => ten;
            set => ten = value;
        }

        public string MaGv
        {
            get => maGv;
            set => maGv = value;
        }

        public int NamSinh
        {
            get => namSinh;
            set => namSinh = value;
        }

        public string DiaChi
        {
            get => diaChi;
            set
            {
                if (value == null)
                {
                    value = "N/A";
                    
                }
                diaChi = value;
            } 
        }

       public void inRaManHinh()
        {
            Console.WriteLine("Tên: {0} Mã: {1} Tuổi: {2} Địa Chỉ: {3}",ten,maGv,2021 - namSinh,diaChi);
        }
    }
}
