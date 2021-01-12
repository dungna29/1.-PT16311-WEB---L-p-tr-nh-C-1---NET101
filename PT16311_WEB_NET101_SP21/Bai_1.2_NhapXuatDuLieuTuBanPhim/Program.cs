using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Bai_1._2_NhapXuatDuLieuTuBanPhim
{
    class Program
    {
        /*
         * BÀI 1.2 Nhập xuất dữ liệu từ bàn phím
         *  1. Xuất dữ liệu ra màn hình
         *      + Phím tắt : cw + tab
         *      + Console.WriteLine(); Ghi xong thì xuống dòng
         *      + Console.Write(); Ghi xong thì không xuống dòng
         *  2. Nhập dữ liệu từ bàn phím:
         *      +Console.Read(); Đọc 1 ký tự từ bàn phím dưới dạng số nguyên
         *      +Console.ReadLine();  Đọc nhiều ký tự từ bàn phím
         */
        static void Main(string[] args)
        {
            //Giúp hiển thị tiếng việt trên console
            Console.OutputEncoding = Encoding.UTF8;
            /*
             * Ví dụ : Nhập tên và in ra màn hình
             */
            //Bước 1: Khai báo biến phụ thuộc bài toán
            string name;
            //Bước 2: Lấy giá trị từ bàn phí hoặc lấy dữ liệu....
            Console.WriteLine("Mời bạn nhập tên:  ");
            name = Console.ReadLine();//Gán giá trị do người dùng nhập vào từ bàn phím
            //Bước 3: Xử lý nghiệp vụ
            Console.WriteLine("Temn ban vua nhap vao la: " + name);
            Console.ReadKey();
        }
        
    }
}

