using System;

namespace Bai3_3
{
    // Lớp cơ sở HinhVe
    public abstract class HinhVe
    {
        public abstract double DienTich();
    }

    // Lớp hình chữ nhật kế thừa từ HinhVe
    public class HinhChuNhat : HinhVe
    {
        public double ChieuDai { get; set; }
        public double ChieuRong { get; set; }

        public override double DienTich()
        {
            return ChieuDai * ChieuRong;
        }
    }

    // Lớp hình tròn kế thừa từ HinhVe
    public class HinhTron : HinhVe
    {
        public double BanKinh { get; set; }

        public override double DienTich()
        {
            return Math.PI * BanKinh * BanKinh;
        }
    }

    // Lớp hình vuông kế thừa từ HinhChuNhat
    public class HinhVuong : HinhChuNhat
    {
        public double Canh { get; set; }

        // Khi tính diện tích hình vuông, cả hai cạnh sẽ bằng nhau
        public override double DienTich()
        {
            return Canh * Canh;
        }
    }

    class Program
    {
        static void Main(string[] args)  
        {
            Console.WriteLine("Chon hinh can tinh dien tich:");
            Console.WriteLine("1. Hinh chu nhat");
            Console.WriteLine("2. Hinh tron");
            Console.WriteLine("3. Hinh vuong");
            Console.Write("Nhap lua chon cua ban: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Nhap chieu dai: ");
                    double dai = double.Parse(Console.ReadLine());
                    Console.Write("Nhap chieu rong: ");
                    double rong = double.Parse(Console.ReadLine());
                    HinhChuNhat hcn = new HinhChuNhat { ChieuDai = dai, ChieuRong = rong };
                    Console.WriteLine("Dien tich cua hinh chu nhat la: " + hcn.DienTich());
                    break;
                case 2:
                    Console.Write("Nhap ban kinh: ");
                    double banKinh = double.Parse(Console.ReadLine());
                    HinhTron ht = new HinhTron { BanKinh = banKinh };
                    Console.WriteLine("Dien tich cua hinh tron la: " + ht.DienTich());
                    break;
                case 3:
                    Console.Write("Nhap do dai canh hinh vuong: ");
                    double canh = double.Parse(Console.ReadLine());
                    HinhVuong hv = new HinhVuong { Canh = canh };
                    Console.WriteLine("Dien tich cua hinh vuong la: " + hv.DienTich());
                    break;
                default:
                    Console.WriteLine("Lua chon khong hop le.");
                    break;
            }
        }
    }

}



