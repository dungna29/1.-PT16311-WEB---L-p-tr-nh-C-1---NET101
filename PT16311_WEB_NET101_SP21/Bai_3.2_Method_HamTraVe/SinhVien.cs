using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3._2_Method_HamTraVe
{
    /*
     * Tạo ra 1 đối tượng Sinh Viên
     *
     * Tên Class bắt buộc phải viết hoa chữ cái đầu của từ lên
     */
    class SinhVien
    {
        //Phần 1: Liệt kê tất cả các thuộc tính mà đối tượng phải có
        public string tenSV;
        public string queQuanSv;
        public string diachi;
        public int namsinh;
        public int sdt;

        //Phần 2: Contructor


        //Phần 3: Phương thức - method
        public void getSinhVien()
        {
            Console.WriteLine("Chào mừng {0} {1}", tenSV, queQuanSv);
        }
    }
}
