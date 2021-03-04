using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3._6_LINQ
{
    class Program
    {
        private static List<SinhVien> _lstSinhViens = new List<SinhVien>();
        private static string _input;
        private static SinhVien _sinhVien;
        static void Main(string[] args)
        {
            them5SV();
            timKiemSV();
        }
        static void them5SV()
        {

            SinhVien sv1 = new SinhVien("Nguyễn", "Anh", "Dũng", "PH00532", 1999, 5, "Nam", "HN");
            SinhVien sv2 = new SinhVien("Hoàng", "Anh", "Tùng", "PH00533", 1999, 5, "Nam", "HN");
            SinhVien sv3 = new SinhVien("Đinh", "Anh", "Hoàng", "PH00534", 1999, 5, "Nam", "HN");
            SinhVien sv4 = new SinhVien("Nguyễn", "Quốc", "Long", "PH00535", 1999, 5, "Nam", "HN");
            SinhVien sv5 = new SinhVien();
            sv5.Ho = "Đặng";
            sv5.TenDem = "Quang";
            sv5.Ten = "Minh";
            sv5.MaSv = "Ph000555";
            sv5.NamSinh = 1998;
            sv5.DiemCsharp = 8;
            sv5.GioiTinh = "Nam";
            sv5.QueQuan = "ĐÀ NẴNG";
            _lstSinhViens.Add(sv1);
            _lstSinhViens.Add(sv2);
            _lstSinhViens.Add(sv3);
            _lstSinhViens.Add(sv4);
            _lstSinhViens.Add(sv5);
        }

        static void timKiemSV()
        {
            Console.WriteLine("Mời bạn nhập mã Sinh Viên muốn tìm: ");
            _input = Console.ReadLine();
            // for (int i = 0; i < _lstSinhViens.Count; i++)
            // {
            //     if (_input == _lstSinhViens[i].MaSv)
            //     {
            //         Console.WriteLine("ĐÃ TÌM THẤY SINH VIÊN: ");
            //         _lstSinhViens[i].inRaManHinh();
            //     }
            // }

            //Sử dụng LINQ để tìm kiếm
            _lstSinhViens.Where(c=>c.MaSv == _input).FirstOrDefault().inRaManHinh();

            //Sử dụng LINQ để sắp xếp
            foreach (var x in _lstSinhViens.OrderBy(c=>c.Ten))
            {
                x.inRaManHinh();
            }

            //Sắp xếp ngược 
            foreach (var x in _lstSinhViens.OrderByDescending(c => c.Ten))
            {
                x.inRaManHinh();
            }

            //Sử dụng sắp xếp theo phương thức của LIST
            
        }
    }
}
