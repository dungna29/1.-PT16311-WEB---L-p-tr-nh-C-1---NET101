using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3._3_Contructor
{
    class Program
    {
        /*
         * Đặc tả truy xuất trong C# - Phạm vi truy cập - Access Modifier c#
         * 1. Public: Không giới hạn khi truy cập
         * 2. Private: Chỉ được phép truy cập ở bên trong của Class
         * 3. Protected: Chỉ có các class con mới có thể truy cập
         * 4. Internal: Chỉ được phép sử dụng bên trong project
         * 5. Protected internal: 
         */

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            //Phần 1: Cách gọi đối tượng ra để sử dụng cần phải biết tên đối tượng
            GiaoVien gv1 = new GiaoVien();//Tạo ra 1 đối tượng giáo viên
            //+ Gán giá trị cho thuộc tính đối tượng thì sử dụng biến đối tượng và chấm "."
            gv1.tenGv = "Dũng";//Gán đúng kiểu dữ liệu cho thuộc tính
            gv1.namsinh = 1989;

            //Phần 2: Contrcutor không tham số
            GiaoVien gv2 = new GiaoVien();
            //Trong trường hợp Class đối tượng chưa khởi tạo Contructor thì sẽ tự động ngầm định tạo ra 1 contructor không tham số
            //Gán giá trị cho Contructoi không tham số
            gv2.tenGv = "Minh";//Gán đúng kiểu dữ liệu cho thuộc tính
            gv2.namsinh = 1989;
            //In giá trị của đối tượng
            Console.WriteLine(gv2.tenGv + gv2.namsinh);

            //Phần 3: Contructor có tham số truyền vào
            //Khi sử dụng Contructor có tham số phải gán giá trị cho thuộc tính của đối tượng
            //Khi truyền tham số phải truyền đúng vị trí và đúng kiểu dữ liệu
            GiaoVien gv3 = new GiaoVien("Huy", "0123456", "Số 1 Tây hồ", "Lào Cai", 2000);
            Console.WriteLine(gv3.tenGv + gv3.sdt);

            //Phần 4: Khi các thuộc tính bị private vẫn có thể gán giá trị cho đối tượng nếu sử dụng Contructor có tham số
            SinhVien sv1 = new SinhVien();
            SinhVien sv2 = new SinhVien("Huy", "HuyPH");//Gán giá trị nhưng không lấy được giá trị của thuộc tính ra

            //Khi các thuộc tính bị priavate  muốn gán giá tị và lấy giá trị thuộc tính thì phải sử dụng phương thức Getter và Setter
            SinhVien sv3 = new SinhVien();
            sv3.setTenSv("Hiệp");//Set để gán giá trị cho thuộc tính
            sv3.setMaSv("PH00533");
            sv3.setDiem(-1);
            
            //Get dùng để lấy giá trị của thuộc tính đối tượng
            Console.WriteLine(sv3.getTenSv() +" " + sv3.getMaSv() + " " + sv3.getSchool());
            

            /*
             * Bài tập:
             * Viết 1 chương trình cho người dùng nhập vào 1 đối tượng Sinh Viên gồm các thuộc tính : Ten,Tuoi,Msv,Sdt sau đó in ra .
             * - Tạo 1 Class đối tượng hoàn chỉnh gồm 4 phần có private thuộc tính

             */

        }
    }
}
