using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2._1_DO_WHILE
{
    class Program
    {
        /*
         * Bài 2.1 Vòng lặp do..While khác với vòng lặp while đó là sẽ thực hiện hành động 1 lần kể cả khi while(False). Điều kiện kiện để chạy vòng lặp vẫn là While(true)
         *
         * Cách gõ: do + tab
         *
         * Công thức:
         *  do
            {
                //Thực hiện ít nhất 1 lần nếu While False             
            } while (false);
         */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            do
            {
                Console.WriteLine("While đang false");
                //Thực hiện 1 lần nếu While False
            } while (false);

            //Ví dụ: Nhập vào những số từ 50 đến 100 nếu trong khoảng thì ngắt vòng lặp.
            int input = 0;
            do
            {
                Console.Write("Mời bạn nhập các số trong khoảng 50 đến 100: ");
                input = int.Parse(Console.ReadLine());
            } while (!(input >=50 && input <=100));

            Console.WriteLine(" Chúc mừng bạn nhập đúng ");
            Console.ReadKey();
        }
    }
}
