using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_MAU_BIEN_TOANTU_VONGLAP_DIEUKIEN_NHAPXUAT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            //Bài tập : Viết 1 chương trình cho phép người dùng đăng nhập vào được thông qua tài khoản và mật khẩu đúng. Tài khoản mật khẩu các bạn sẽ cho trước. Nếu đăng nhập thành công thì sẽ thực hiện cho phép người dùng nhập 1 số nằm trong 2 khoảng  từ 10 đến 20 hoặc 90 100. Nếu nhập đúng in ra thông báo nhập thành công và kết thúc chương trình. Nếu người dùng nhập không đúng trong 2 khoảng thì yêu cầu nhập lại.
            const string user = "dungna29", pass = "aaa";
            string inputUser, inputPass;
            bool result, resultInput;
            int inputNumber;
            Console.WriteLine("*********Login***********");
            do
            {
                Console.WriteLine("User: ");
                inputUser = Console.ReadLine();
                Console.WriteLine("Pass: ");
                inputPass = Console.ReadLine();
                result = (inputUser == user) && inputPass == pass ? true : false;
                if (!result)
                {
                    Console.WriteLine("Bạn đã nhập sai mật khẩu hoặc tài khoản vui lòng nhập lại");
                }
            } while (!result);
            if (result)
            {
                do
                {
                    Console.Write("Mời bạn nhập số trong khoảng 10-20 || 90 100: ");
                    inputNumber = int.Parse(Console.ReadLine());
                    resultInput = (inputNumber >= 10 && inputNumber <= 20) || (inputNumber >= 90 && inputNumber <= 100)
                        ? false
                        : true;

                } while (resultInput);
                Console.WriteLine("Bạn đã làm đúng");
            }

            Console.WriteLine("Kế Thúc Chương Trình");
            Console.ReadKey();

        }
    }
    }
}
