using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2._0_VongLap_While
{
    class Program
    {
        /*
         * Bài 2.0 Vòng lặp:
         *
         * Định nghĩa chung cho tất cả vòng lặp:
         * Vòng lặp cho phép lặp lại một hoặc nhiều câu lệnh cho đến khi thỏa mãn điều kiện được chỉ định định.
         *
         * Các loại vòng lặp: while, do..while, for, foreach
         *
         * Từ khóa sử dụng trong vòng lặp:
         *
         * break - ngắt vòng lặp
         * continue: Sẽ bỏ qua các đoạn code phía sau nó và nó quay trở lại lần lặp tiếp theo.
         *
         * Vòng lặp while: Chỉ chạy khi điều kiện luôn đúng và nếu điều kiện luôn đúng ko điểm dừng thì được gọi là vòng lặp vô hạn.
         * + Cách dùng: wh + tab
         *
         * + Công thức:
         *  while (true)
            {
                //Thực thi 1 câu lệnh hoặc nhiều câu lệnh
            }
         */

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            //Ví dụ 1: Sử dụng cờ để ngắt vòng lặp
            int flag = 0;
            while (flag == 10)
            {
                Console.WriteLine("Đây là vòng lặp vô hạn" + flag);
                flag++;//Tăng giá trị của của cờ lên để đến 1 thời điểm sẽ thỏa mãn ngắt vòng lặp.
            }


            //Ví dụ 2: Sử dụng break để ngắt vòng lặp
            int flag2 = 0;
            while (true)
            {
                //Trong 1 vài bài toán có thể điều kiện sẽ được ngắt bằng câu lệnh break thông qua câu điều kiện IF.
                if (flag2 == 10)
                {
                    break;
                }
                Console.WriteLine("Đây là vòng lặp vô hạn" + flag);
                flag2++;
            }


            Console.ReadKey();
        }
    }
}
