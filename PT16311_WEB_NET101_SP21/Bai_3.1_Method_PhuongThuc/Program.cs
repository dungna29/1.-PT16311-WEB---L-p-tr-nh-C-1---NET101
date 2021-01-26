using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3._1_Method_PhuongThuc
{
    class Program
    {
        /*
         *  Bài 3.1 Hàm -Phương thức - Method
         *  Định nghĩa: 1 tập các câu lệnh cùng nhau thực hiện 1 tác vụ nào đó.
         *  LỢI ÍCH: - Giúp quản lý code tốt hơn
         *           - Tái sử dụng
         *
         *  Công thức chung:
         *  <Phạm vi truy cập> <Kiểu trả về> <Tên phương thức> (<Danh sách tham số>)
         *  {
         *          Body code
         *  }
         * <Phạm vi truy cập> - Access Specifier:Public,Private,Protected, Default
         *
         * <Kiểu trả về> : có 2 kiểu trả về và không trả về
         *          - Kiểu không trả về: void
         *          - Kiểu trả về: là giá trị(int,string,double....) hoặc tập giá trị(Array,List.....) hoặc đối tượng(class) và còn nhiều kiểu khác.
         *
         * <Tên phương thức>: Tên động từ viết thường + tên.
         * <Danh sách tham số>: Phương thức có thể có tham hoặc không tham số và lưu ý khi sử dụng tham số thì khi gọi phương thức thì phải truyền đúng vị trí của tham số.
         */

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            //Gợi ý: - Tái sử dụng khi gặp các đoạn code bị lặp để xử lý 1 công việc thì nên đưa ra ngoài để tiết kiệm line code
            
            //1. Gọi hàm không tham số: Cần phải biết tên hàm, phạm vi truy cập của hàm không bị private khi gọi từ Class khác sang.
            inRaManHinh();//Cuối của hàm luôn là ()

            //2. Gọi hàm có tham số: bắt buộc phải truyền đủ tham số theo thứ tự và phải đúng kiểu dữ liệu.
            inRaManHinhCoThamSo(2021,"Hiếu");
            string[] arrName = {"Tùng", "Long", "Toàn"};
            foreach (var x in arrName)
            {
                inRaManHinhCoThamSo(2021, x);
            }
            Console.ReadKey();
        }

        //Phần 1: Phương không trả về không tham số
        static void inRaManHinh()//() mở ngoặc không có tham số bên trong
        {
            //Body code thực hiện 1 nhiệm vụ nào đó ví dụ: Phương thức nhập giá trị từ bàn phí, tạo menu, các chức năng.......
            Console.WriteLine("Chúc mừng năm mới 2021");
        }

        //Phần 2: Phương không trả về có tham số - Số lượng tham số phụ thuộc vào bài toán cần phải giải. - Tham ố truyền vào là các kiểu dữ liệu khác nhau không nhất thiết phải giống nhau như: có thể kiểu dữ liệu, mảng, đối tượng, danh sách.

        //int year = tham số có kiểu dữ liệu và đặt tên tham số
        static void inRaManHinhCoThamSo(int year, string name)
        {
            //Coi tham số như là biến có thể thao tác được với nó
            Console.WriteLine("Chúc mừng năm mới " + year + " bạn : " + name);
        }
        static void inRaManHinhCoThamSo(int[] year, string[] name, List<string> lstname, SinhVien sinhvien)
        {
            //Coi tham số như là biến có thể thao tác được với nó
            
        }
    }
}
