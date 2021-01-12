using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_1._1_KhaiBaoBien
{
    class Program
    {

        /*
         * Bài 1.1 Khai báo biến
         * Định nghĩa biến: Dùng để lưu trữ giá trị hoặc 1 tập giá trị và biến
         * được khở tạo trong bộ nhớ ảo khi chương trình khởi chạy.
         *
         * Công thức: <Kiểu dữ liệu> <Tên Biến> = <Giá trị>;
         * 1. <Kiểu dữ liệu>
         *  + Số nguyên:sbyte, byte, long, int
         *  + Sô thực: float, double, decimal
         *  + Chuỗi hoặc ký tự: string, char
         *  + Logic: bool
         *  + var: nó có thể đại diện là tất cả các kiểu dữ liệu.
         * 2. <Tên Biến>
         *  + Quy tắc:
         *      - Tên biến phải có nghĩa
         *      - Có phân biệt chữ hoa chữ thường
         *      - Không bắt đầu bởi số, không dùng từ khóa
         *      - Cố gắng làm quen đặt tên biến với Tiếng Anh
         *  + Khai báo tên biến với 2 từ trở lên:
         *      - Cách 1: normal = firstname
         *      - Cách 2: CamelCase = FirstName, firstName
         *      - Cách 3: Under_Score = first_name, first_Name
         *  + Biến cục bộ: là biến được khai báo bên trong 1 hàm.
         *  + Biến toàn cục: là biến được khai báo bên ngoài hàm.
         *      - Khi khai báo biến toàn cục sử dụng dấu gạch dưới _ trước tên biến.
         *      - int _year = 1989;
         * 3.<Giá trị>
         *  + Khi khai báo biến có thể khởi tạo giá trị hoặc không khởi tạo giá trị.
         *  + Giá trị phải đúng các quy tắc với kiểu dữ liệu
         *
         */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            int a;//Khởi tạo 1 biến có tên là a có kiểu dữ liệu là số nguyên và không khởi tạo giá trị ban đầu.
            string name = "FPT POLYTECHNIC";//Khởi tạo 1 biến có tên name và có kiểu dữ liệu là chuỗi và có khởi tạo giá trị ban đầu.

            var school = "ĐH FPT";
            var year = 2021;
            Console.WriteLine(year);
            Console.ReadKey();
           
        }
    }
}
