using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2._3_VongLap_Foreach
{
    class Program
    {
        /*
         * Vòng lặp foreach
         * Cách gõ: fore + tab
         *
         * Công thức:
         *  foreach (var VARIABLE in COLLECTION)
            {
                
            }
            var: Kiểu dữ liệu đã học ở bài khai báo biến
            VARIABLE: tên biến có thể đặt tùy ý và nó đại diện cho kiểu dữ liệu.
            COLLECTION//Array: Phải là 1 tập hợp nhiều giá trị.
         */
        static void Main(string[] args)
        {
            String[] arrName = {"JAVA", "C#", "C++"};
            foreach (var x in arrName)
            {
                Console.Write(x + " ");
            }

            //Tương tự như cách dùng for
            for (int i = 0; i < arrName.Length; i++)
            {
                Console.Write(arrName[i] + " ");
            }

            Console.ReadKey();

            //Viết 1 chương trình cho phép nhập vào bảng cửu chương sử dụng cả 3 vòng lặp được để làm.
        }
    }
}
