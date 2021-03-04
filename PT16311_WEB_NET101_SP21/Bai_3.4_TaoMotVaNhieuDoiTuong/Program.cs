using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3._4_TaoMotVaNhieuDoiTuong
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            Program p = new Program();
            //p.tao2DoiTuongContructor();
            //p.tao1Doituong();
            //p.taoMangDoiTuong();
            p.taoListDoiTuong();

        }
        //1. Sử dụng contructor để tạo đối tượng
        void tao2DoiTuongContructor()
        {
            //Contructor không tham số
            GiaoVien gv1 = new GiaoVien();
            gv1.Ten = "Dũng";
            gv1.MaGv = "DungNA";
            gv1.NamSinh = 2000;
            gv1 = new GiaoVien();//Khởi tạo lại đối tượng sẽ không có giá trị của thuộc tính
            gv1.inRaManHinh();

            //Contructor có tham số
            GiaoVien gv2 = new GiaoVien("Minh", "MinhDQ", 2022, "Số 1 trịnh văn bô");
            gv2.inRaManHinh();

        }

        //2. Tạo 1 đối tượng do người dùng nhập vào
        void tao1Doituong()
        {
            GiaoVien gv1 = new GiaoVien();
            Console.WriteLine("Mời bạn nhập tên: ");
            gv1.Ten = Console.ReadLine();
            Console.WriteLine("Mời bạn nhập mã: ");
            gv1.MaGv = Console.ReadLine();
            Console.WriteLine("Mời bạn nhập năm sinh: ");
            gv1.NamSinh = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mời bạn nhập địa chỉ: ");
            gv1.DiaChi = Console.ReadLine();

            Console.WriteLine("Đối tượng bạn vừa nhập vào là: ");
            gv1.inRaManHinh();
        }

        //3. Tạo 1 mảng đối tượng
        void taoMangDoiTuong()
        {
            //Bước 1: Khai báo
            //Công thức khai báo mảng: <Kiểu dữ liệu>[] tên mảng;
            GiaoVien[] arrGiaoViens;
            int size;

            //Bước 2: Triển khai
            Console.WriteLine("Bạn muốn thêm bao nhiêu GV: ");
            size = Convert.ToInt32(Console.ReadLine());
            arrGiaoViens = new GiaoVien[size];//Khởi tạo mảng có thích thước do người dùng nhập vào
            for (int i = 0; i < size; i++)
            {
                arrGiaoViens[i] = new GiaoVien();//Khởi tạo đối tượng tại vị trí thứ i
                Console.WriteLine("Mời bạn nhập tên: ");
                arrGiaoViens[i].Ten = Console.ReadLine();
                Console.WriteLine("Mời bạn nhập mã: ");
                arrGiaoViens[i].MaGv = Console.ReadLine();
                Console.WriteLine("Mời bạn nhập năm sinh: ");
                arrGiaoViens[i].NamSinh = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Mời bạn nhập địa chỉ: ");
                arrGiaoViens[i].DiaChi = Console.ReadLine();
            }

            //Bước 3: Xuất ds
            foreach (var x in arrGiaoViens)
            {
                x.inRaManHinh();
            }
        }

        //4. Tạo List Đối tượng
        void taoListDoiTuong()
        {
            List<GiaoVien> lstGiaoVien = new List<GiaoVien>();
            GiaoVien gv1;
            int size;

            Console.WriteLine("Bạn muốn thêm bao nhiêu GV: ");
            size = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < lstGiaoVien.Count; i++)
            {
                gv1 = new GiaoVien();
                Console.WriteLine("Mời bạn nhập tên: ");
                gv1.Ten = Console.ReadLine();
                Console.WriteLine("Mời bạn nhập mã: ");
                gv1.MaGv = Console.ReadLine();
                Console.WriteLine("Mời bạn nhập năm sinh: ");
                gv1.NamSinh = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Mời bạn nhập địa chỉ: ");
                gv1.DiaChi = Console.ReadLine();
                lstGiaoVien.Add(gv1);//Gán đối tượng vào List sau mỗi lần chạy
            }

            foreach (var x in lstGiaoVien)
            {
                x.inRaManHinh();
            }
        }
    }
}
