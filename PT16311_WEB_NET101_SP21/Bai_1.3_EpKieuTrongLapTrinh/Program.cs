using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_1._3_EpKieuTrongLapTrinh
{
    class Program
    {
        /*
         * P1: Ép kiểu từ kiểu dữ liệu số - Không đổ kiểu dữ liệu lớn về bé mà chỉ bé lên lớn ví dụ int lớn hơn byte hoặc long nhất trong số nguyên. Ngoài ra các bạn có thể tham khảo lại trong bảng kích thước kiểu dữ liệu.
         *
         * Công thức ép kiểu tường minh:
         *        (<kiểu dữ liệu>) <biến cần ép kiểu>;
         * P2: Ép kiểu từ string về số
         *  + Phương thức Parse()
         *  + Lớp Convert()
         */      
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //P1: Ép kiểu từ kiểu dữ liệu số
            // Ví dụ 1:
            byte a = 1;
            int b = 2;
            b = a;

            //ví dụ 2:
            double diem1 = 5.6;
            long temp;
            temp = (long) diem1;
            Console.WriteLine("Sau khi ép kiểu từ double về long: " + temp);
            //P2: Ép kiểu từ string về số
            // Ví dụ: Parse
            string tempSo = "8";
            int intParse = int.Parse(tempSo);
            double doubleParse = double.Parse("8.9");
            bool boolParse = bool.Parse("true");

            // Ví dụ: Lớp Convert
            string tempSo1 = "8";
            int intConvert = Convert.ToInt32(tempSo1);
            double doubleConvert = Convert.ToDouble("8.6");
            bool boolConvert = Convert.ToBoolean("false");
            Console.ReadKey();
        }
    }
}
