using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2._8_MangHaiChieu
{
    class Program
    {
        /*
         * MẢNG 2 CHIỀU - MẢNG ĐA CHIỀU (TỰ TÌM HIỂU)
         * Mảng 2 chiều cần quan tâm đến cột và dòng
         *
         * Công thức: <kiểu dữ liệu>[,] = new <Kiểu dữ liệu>[row,column]
         *  row: Số lượng hàng kiểu số nguyên
         *  column: Số lượng cột kiểu số nguyên
         */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            //1. Khai báo 
            int[,] arrNumber = new int[2,3];//Khởi tạo 1 mảng 2 chiều 2 hàng và 3 cột
            //2. Gán giá trị cho mảng 2 chiều
            //Khai báo dòng 0 đủ 3 cột
            arrNumber[0,0] = 5;
            arrNumber[0,1] = 8;
            arrNumber[0,2] = 9;

            //Khai báo dòng số 1 chỉ 1 cột
            arrNumber[1,0] = 9;

            //3 Lấy giá trị mảng 2 chiều
            Console.WriteLine(arrNumber[0, 1]);//kq = 8

            //VÍ dụ mẫu: Viết 1 chương trình cho phép khởi tạo 2 chiều
            int row, col;
            int[,] arrNumber1;
            Console.WriteLine("Chương trình tạo mảng 2 chiều");
            Console.Write("Mời bạn nhập số lượng Row: ");
            row = int.Parse(Console.ReadLine());
            Console.Write("Mời bạn nhập số lượng Col: ");
            col = int.Parse(Console.ReadLine());
            //Khởi tạo mảng 2 chiều
            arrNumber1 = new int[row, col];

            //Nhập dữ liệu vào mảng 2 chiều
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.WriteLine("Giá trị tại row: {0} - col: {1}",i,j);
                    arrNumber1[i, j] = int.Parse(Console.ReadLine());
                }
            }

            //Xuất ra màn hình
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.WriteLine("Giá trị tại row: {0} - col: {1} = {2}",i,j, arrNumber1[i, j]);
                }
            }
            Console.ReadKey();
        }
    }
}
