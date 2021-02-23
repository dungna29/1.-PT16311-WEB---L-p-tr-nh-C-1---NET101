using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3._3_Contructor
{
    class GiaoVien
    {
        //Phần 1: Liệt kê tất cả các thuộc tính phải có của đối tượng
        public string tenGv;
        public string sdt;
        public string diachi;
        public string quequan;
        public int namsinh;

        //Phần 2: Contructor - Hàm Tạo
        // Contructor phải giống với tên Class
        // Contructor được chạy đầu tiên khi new Class

        //1. Contructor không tham số truyền vào - Gõ nhanh bằng cách gõ: ctor + tab
        public GiaoVien()
        {
            //Console.WriteLine("Đây là text được in ra từ Contructor không tham số");
        }

        //2. Contructor có tham số truyền vào - Gõ nhanh bằng cách gõ: ctorf + tab
        public GiaoVien(string tenGv1, string sdt, string diachi, string quequan, int namsinh)
        {
            tenGv = tenGv1;//Có thể xóa được this nhưng phải đối tên tham số truyền vào
            this.sdt = sdt;
            this.diachi = diachi;
            this.quequan = quequan;
            this.namsinh = namsinh;
        }
        //Từ khóa this dùng để tham chiếu đến thuộc tính hoặc phương thức của lớp hiện tại

        //Phần 3 Getter và Setter


        //Phần 4 Các phương thức của đối tượng



    }
}
