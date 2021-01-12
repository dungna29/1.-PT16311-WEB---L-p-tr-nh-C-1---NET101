using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_1._5_CauDieuKien_IF
{
    class Program
    {
        /*
         * Bài 1.5 Câu điều kiện rẽ nhánh IF
         * ĐƯợc sử dụng để lập điều kiện và sẽ thực thi 1 hành động nào đó nếu thỏa mãn điều kiện.
         *
         * Công thức IF: if + tab         *   
         *   if (<Điều kiện>)
            {
                If phải luôn đúng
                Một hành động được thi khi thỏa mãn điều kiện
            }
         */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            /*
             * Viết 1 chương trình cho phép nhập điểm môn C# sau đó in điểm đó ra màn hình và thông báo qua môn nếu điểm lớn hơn hoặc bằng 5.
             */
            double diemCharp;
            Console.WriteLine("Mời bạn nhập điểm thi C# vào: ");
            diemCharp = double.Parse(Console.ReadLine());//Lấy điểm và ép kiểu về sô thực double
            if (diemCharp >= 5)
            {
                Console.WriteLine("Chúc mừng bạn không mất 700k");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Chúc mừng bạn đã mất 700k");
            Console.ReadKey();
        }
    }
}
