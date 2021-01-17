using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2._5_Array
{
    class Program
    {
        /*
         * Phần 1: Mảng 1 chiều
         *
         *  1. Định nghĩa: Mảng dùng để lưu trữ nhiều phần tử có cùng kiểu dữ liệu (Biến dùng để lưu trữ 1 giá trị có cùng kiểu dữ liệu).
         *          - Để truy xuất (để lấy giá trị) các phần tử thì cần phải biết chỉ số(index). Index là số nguyên và bắt đầu từ 0 1 2 3....
         *
         *  2. Khai báo 1 mảng trong Csharp:
         *          - Cách 1:
         *              <Kiểu dữ liệu>[] arr<Tên Mảng>;
         *              arr<Tên Mảng> = new <Kiểu dữ liệu>[length];//Khởi tạo mảng có kích thước.
         *          - Cách 2: 
         *              <Kiểu dữ liệu>[] arr<Tên Mảng> = new <Kiểu dữ liệu>[length];
         *
         *          - Cách 3:
         *     <Kiểu dữ liệu>[] arr<Tên Mảng> = new <Kiểu dữ liệu>[] {value1,value2..,valuen};//Khởi tạo mảng kiểu tường minh.
         *
         *     <Kiểu dữ liệu>[] arr<Tên Mảng> = new [] {value1,value2..,valuen};//Khởi tạo kiểu ngầm đinhj
         *
         *  3. Truy xuất các phần tử trong mảng
         *      - Gán giá trị cho mảng:
         *           <tên mảng>[index] = Giá trị cần gán.
         *   
         *     - Lấy giá trị trong mảng:
         *          <tên mảng>[index] = Giá trị của mảng tại vị trí.
         *      Lưu ý: Để lấy nhiều giá trị trong mảng xuất ra cần sử dụng vòng lòng.
         *
         *  4. Kích thước hoặc độ dài của mảng sử dụng thuộc tính length.
         *      <tên mảng>.length = kích thước mảng có kiểu số nguyên
         */

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            //1. Khai báo mảng
            int[] arrNumber;
            arrNumber = new int[5];

            int[] arrNumber2 = new int[5];

            string[] arrMonHoc = new[] {"C#1", "C#2", "C#3"};//Khởi tạo kiểu ngầm định
            string[] arrMonHoc1 = new string[] {"C#1", "C#2", "C#3"};//Khởi tạo tường minh
            
            var arrDiem = new[] { 8.6,8.9,8.5 }; //double[]
            var arrDiem1 = new double[] { 8.6,8.9,8.5 }; //double[]

            //2. Gán giá trị cho mảng
            arrNumber[0] = 5;//Gán giá trị cho mảng ở vị trí số 0
            arrNumber[1] = 9;//Gán giá trị cho mảng ở vị trí số 1
            arrNumber[0] = 10;//Ghi đè giá trị vào vị trí số 0

            //3. Xuất 1 giá trị
            Console.WriteLine(arrNumber[0]);

            //4. Xuất tập giá trị ra màn hình
            //Sử dụng for:
            for (int i = 0; i < arrNumber.Length; i++)
            {
                Console.WriteLine(arrNumber[i]);
            }

            Console.ReadKey();

        }
    }
}
