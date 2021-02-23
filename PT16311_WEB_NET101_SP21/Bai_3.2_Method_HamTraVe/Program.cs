using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3._2_Method_HamTraVe
{
    class Program
    {
        /*
         * Hàm không trả về công thức và định nghĩa ở bên Project 3.1
         *
         * Định nghĩa: Hàm trả về bắt buộc phải trả về 1 giá trị hoặc 1 tập giá trị, đối tượng.... tương ứng với kiểu dữ liệu của hàm.
         */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            //1. Sử dụng hàm trả 
            // Coi hàm trả về là 1 giá trị hoặc 1 tập giá trị hoặc 1 đối tượng....
            int year = 2021;
            //getYear() = giá trị là 2021 là kiểu số nguyên
            Console.WriteLine(getYear() + 1);

            //Sử dụng hàm trả về 1 tập giá trị
            foreach (var x in getListYear())
            {
                Console.Write(x + " ");
            }

            for (int i = 0; i < getListYear().Length; i++)
            {
                Console.Write(getListYear()[i] + " ");
            }

            //Sử dụng hàm trả về 1 đối tượng
            Console.WriteLine("Hàm trả về là đối tượng");
            getSinhVien().getSinhVien();
            Console.WriteLine(getSinhVien().tenSV);

            Console.WriteLine("Hàm không trả về");
            Console.ReadKey();
        }



        //Phần 1: Hàm trả về không tham số
        //Ví dụ hàm trả về kiểu giá trị đơn: int,string,double.....
        static int getYear()
        {
            //Hàm bắt buộc phải trả về đúng kiểu dữ liệu của hàm
            //return <giá trị đúng kiểu dữ liệu của hàm>;

            //Thực hiện dòng lệnh để xử lý công việc nhưng kết quả cuối cùng phải trả về 1 giá trị.
            int a = 2021;
            return a;
        }

        //Ví dụ hàm trả về là tập giá trị: Array,List...
        static int[] getListYear()
        {
            //int[] arrYears = {1980,1981,1982};
            int[] arrYears = new int[41];
            int a = 0;
            for (int i = 1980; i < 2021; i++)
            {
                arrYears[a] = i;
                a++;
            }
            return arrYears;
        }

        //Hàm trả về 1 đối tượng class
        static SinhVien getSinhVien()
        {
            SinhVien sv1 = new SinhVien();
            sv1.tenSV = "Name String";
            return sv1;
        }

        //int year = tham số có kiểu dữ liệu và đặt tên tham số
        static int inRaManHinhCoThamSo(int year, string name)
        {
            //Coi tham số như là biến có thể thao tác được với nó
            return 0;
        }
        static List<string> inRaManHinhCoThamSo(int[] year, string[] name, List<string> lstname, SinhVien sinhvien)
        {
            //Coi tham số như là biến có thể thao tác được với nó
            return null;

        } 
    }
}
