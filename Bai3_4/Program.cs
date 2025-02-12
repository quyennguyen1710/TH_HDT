using System;
using System.Collections.Generic;
using System.Linq;

namespace Bai3_4
{
    // Lớp máy in cơ bản
    public class Printer
    {
        public string NhaSanXuat { get; set; }
        public double GiaBan { get; set; }

        // Phương thức khởi tạo
        public Printer(string nhaSanXuat, double giaBan)
        {
            NhaSanXuat = nhaSanXuat;
            GiaBan = giaBan;
        }

        // Phương thức nhập thông tin máy in
        public virtual void Nhap()
        {
            Console.Write("Nhap nha san xuat: ");
            NhaSanXuat = Console.ReadLine();
            Console.Write("Nhap gia ban: ");
            GiaBan = double.Parse(Console.ReadLine());
        }

        // Phương thức xuất thông tin máy in
        public virtual void Xuat()
        {
            Console.WriteLine($"Nha san xuat: {NhaSanXuat}, Gia ban: {GiaBan}");
        }
    }

    // Lớp máy in laser kế thừa từ Printer
    class LaserPrinter : Printer
    {
        public string DoPhanGiai { get; set; }

        // Phương thức khởi tạo
        public LaserPrinter(string nhaSanXuat, double giaBan, string doPhanGiai) : base(nhaSanXuat, giaBan)
        {
            DoPhanGiai = doPhanGiai;
        }

        // Phương thức nhập thông tin máy in laser
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap do phan giai (vd: 1200x1200): ");
            DoPhanGiai = Console.ReadLine();
        }

        // Phương thức xuất thông tin máy in laser
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Do phan giai: {DoPhanGiai}");
        }
    }

    class Program
    {
        static void Main()
        {
            Console.Write("Nhap so luong may in laser: ");
            int n = int.Parse(Console.ReadLine());

            List<LaserPrinter> danhSachMayIn = new List<LaserPrinter>();

            // Nhập thông tin cho từng máy in laser
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhap thong tin cho may in laser thu {i + 1}:");
                LaserPrinter mayIn = new LaserPrinter("", 0, "");
                mayIn.Nhap();
                danhSachMayIn.Add(mayIn);
            }

            // In ra danh sách và thông số kèm theo
            Console.WriteLine("\nDanh sach may in laser:");
            foreach (var mayIn in danhSachMayIn)
            {
                mayIn.Xuat();
            }

            // Tìm máy in có giá thấp nhất và cao nhất
            LaserPrinter mayInGiaThapNhat = danhSachMayIn.OrderBy(mayIn => mayIn.GiaBan).First();
            LaserPrinter mayInGiaCaoNhat = danhSachMayIn.OrderByDescending(mayIn => mayIn.GiaBan).First();

            Console.WriteLine($"\nMay in co gia thap nhat:");
            mayInGiaThapNhat.Xuat();
            Console.WriteLine($"\nMay in co gia cao nhat:");
            mayInGiaCaoNhat.Xuat();

            // Lọc danh sách máy in theo tên hãng sản xuất
            Console.Write("\nNhap ten nha san xuat can loc: ");
            string tenNhaSanXuat = Console.ReadLine();
            var danhSachLoc = danhSachMayIn.Where(mayIn => mayIn.NhaSanXuat.ToLower() == tenNhaSanXuat.ToLower()).ToList();

            Console.WriteLine($"\nDanh sach may in laser cua nha san xuat {tenNhaSanXuat}:");
            foreach (var mayIn in danhSachLoc)
            {
                mayIn.Xuat();
            }

            // Sắp xếp danh sách theo thứ tự tăng dần của giá bán và in ra danh sách sau sắp xếp
            Console.WriteLine("\nDanh sach may in laser sau sap xep:");
            var danhSachSapXep = danhSachMayIn.OrderBy(mayIn => mayIn.GiaBan).ToList();
            foreach (var mayIn in danhSachSapXep)
            {
                mayIn.Xuat();
            }
        }
    }

}




