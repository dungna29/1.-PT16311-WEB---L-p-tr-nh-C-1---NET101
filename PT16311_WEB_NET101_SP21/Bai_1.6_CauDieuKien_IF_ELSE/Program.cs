using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_1._6_CauDieuKien_IF_ELSE
{
    class Program
    {
        /*
         * Bài 1.6 Cầu điều kiện IF...ELSE (Nếu Thì)
         * Dùng để thực hiện 1 hành động nếu IF(TRUE) và ngược lại sẽ vào Else.
         * Cấu trúc: 
         * if (true)
            {
                Nếu mà If true thì sẽ thực hiện 1 hành động nào đó
            }
            else
            {
                Nếu không thỏa mãn IF thì mặc định là vào ELSE
            }
         */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            //Ví dụ: Viết 1 chương trình nhập số buổi nghỉ và điểm thi với điều kiện như sau. Nếu số buổi nghỉ <=4 thì mới yêu cầu người dùng nhập điểm thi còn ngược lại thì in ra thông báo bạn không đủ điều kiện nhập điểm thi.

            //Bước 1: Xác định biến cần sử dụng
            int nghi;
            double diemCSharp;
            //Bước 2: Gán giá trị cho biến
            Console.WriteLine("Mời bạn nhập số buổi nghỉ: ");
            nghi = Convert.ToInt32(Console.ReadLine());
            //Bước 3: Xử lý nghiệp vụ
            if (nghi <= 4 && nghi >= 0)
            {
                Console.WriteLine("Mời bạn nhập điểm vào: ");
                diemCSharp = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Buổi nghỉ {0} | Điểm của bạn: {1}", nghi, diemCSharp);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Bạn nghỉ {0} vì vậy không thể nhập điểm thi", nghi);
                Console.ReadKey();
            }
        }
    }

}
