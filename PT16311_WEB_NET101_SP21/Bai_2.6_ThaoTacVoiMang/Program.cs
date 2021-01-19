using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2._6_ThaoTacVoiMang
{
    class Program
    {
        /*
         * Bài 2.6 Thao tác với mảng
         *  - 1. Phương thức của Array
         *      + SetValue(<giá trị>,<index>): Gán giá trị cho phần tử ở vị trí.
         *      + GetValue(index): lấy giá trị ở vị trí
         *      + IndexOf(<Array>,element): Tìm kiếm vị trí của phần tử
         *      + GetLeghth(): Trả ra số lượng phần tử trong mảng
         *      + Reverse(<mảng>): Đảo ngược mảng
         *      + Sort(Array): Sắp xếp mảng
         */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            string[] arrNames = { "B", "C", "A", "F", "E", "D" };
            int[] arrNumber = { 99, 55, 66, 77, 11, 33 };
            //In mảng:
            for (int i = 0; i < arrNames.Length; i++)
            {
                Console.Write(arrNames[i] + " ");
                //Console.WriteLine(arrNumber[i]);
            }
            Console.WriteLine("------------");
            //1. Reverse
            Array.Reverse(arrNames);//Đảo ngược mảng
            Console.WriteLine("Mảng đảo ngược: ");
            for (int i = 0; i < arrNames.Length; i++)
            {
                Console.Write(arrNames[i] + " ");
                //Console.WriteLine(arrNumber[i]);
            }

            //2. Sort
            Array.Sort(arrNames);//Đảo ngược mảng
            Console.WriteLine("Mảng được sắp xếp: ");
            for (int i = 0; i < arrNames.Length; i++)
            {
                Console.Write(arrNames[i] + " ");
                //Console.WriteLine(arrNumber[i]);
            }

            //3. Một vài phương thức khác
            arrNames.SetValue("Dung", 0);
            Console.WriteLine(arrNames.GetValue(0));
            Console.WriteLine("IndexOf: " + Array.IndexOf(arrNames, "B") + Array.IndexOf(arrNames, "B"));
            Console.WriteLine("GetLengh: " + arrNames.GetLength(0));

            Console.WriteLine("Giải thích thuật toán");
            //Thuật toán sắp xếp nổi bọt
            for (int i = 0; i < arrNumber.Length; i++)
            {
                Console.WriteLine("Tại thời điểm i = " + i);
                foreach (var x in arrNumber)
                {
                    Console.Write(x + " ");
                }
                for (int j = i + 1; j < arrNumber.Length; j++)
                {
                    Console.WriteLine("Tại thời điểm j = " + j);
                    Console.WriteLine("Điều kiện:  " + arrNumber[i]+ " > "+ arrNumber[j]);
                    if (arrNumber[i] > arrNumber[j])
                    {
                        int temp = arrNumber[i];
                        arrNumber[i] = arrNumber[j];
                        arrNumber[j] = temp;
                        Console.WriteLine("Sau khi đổi chỗ: ");
                        foreach (var x in arrNumber)
                        {
                            Console.Write(x + " ");
                        }

                        Console.WriteLine();
                    }
                }
            }
            //In mảng:
            for (int i = 0; i < arrNames.Length; i++)
            {
                Console.WriteLine(arrNumber[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
