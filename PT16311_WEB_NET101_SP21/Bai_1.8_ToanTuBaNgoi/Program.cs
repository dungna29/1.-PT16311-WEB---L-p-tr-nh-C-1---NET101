using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Bai_1._8_ToanTuBaNgoi
{
    class Program
    {
        /*
         * TOÁN TỬ 3 NGÔI
         * <Điều kiện> ? <Kết quả nếu điều kiện đúng> : <Kết quả nếu điều kiện sai>;
         */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            // Toán tử 3 ngôi
            string kq = (5 > 6) || (3 > 2) ? "Đúng" : "Sai";
            Console.WriteLine(kq);
            //Viết kiểu if else
            if (5 > 6)
            {
                Console.WriteLine("Đúng");
            }
            else
            {
                Console.WriteLine("Sai");
            }
            Console.ReadKey();
        }
    }
}
