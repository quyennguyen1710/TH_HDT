using System;
using System.Collections.Generic;

namespace Bai3_1
{
    public class Xe
    {
        public string BienSo { get; set; }
        public int NamSX { get; set; }
        public double Gia { get; set; }
        public Xe(string bienso, int namsx, double gia)
        {
            // Phuong thức thiết lập có tham số
            BienSo = bienso;
            NamSX = namsx;
            Gia = gia;
        }
        // Hàm nhập thông tin xe
        public void Nhap()
        {
            Console.Write("Nhap bien so: ");
            BienSo = Console.ReadLine();
            Console.Write("Nhap nam san xuat: ");
            NamSX = int.Parse(Console.ReadLine());
            Console.Write("Nhap gia (trieu dong): ");
            Gia = double.Parse(Console.ReadLine());
        }

        // Hàm in thông tin xe 
        public void Xuat()
        {
            Console.WriteLine("Bien so: " + BienSo);
            Console.WriteLine("Nam san xuat: " + NamSX);
            Console.WriteLine("Gia (trieu dong): " + Gia);
        }

        // Cài đặt lớp xe con kế thừa lớp xe
        public class XeCon : Xe
        {
            public int SoChoNgoi { get; set; }
            public string Loaixe { get; set; }
            public XeCon(string bienso, int namsx, double gia, int soChoNgoi, string loaiXe)
                : base(bienso, namsx, gia)
            {
                // Phương thức thiết lập có tham số
                SoChoNgoi = soChoNgoi;
                Loaixe = loaiXe;
            }
            public void Nhap()
            {
                base.Nhap();
                Console.Write("Nhap so cho ngoi: ");
                SoChoNgoi = int.Parse(Console.ReadLine());
                Console.Write("Nhap loai xe(sedan/SUV/ban tai): ");
                Loaixe = Console.ReadLine();
            }

            public void Xuat()
            {
                base.Xuat();
                Console.WriteLine("So cho ngoi: " + SoChoNgoi);
                Console.WriteLine("Loai xe: " + Loaixe);
            }
        }

        class Program
        {
            static void Main()
            {
                Console.Write("Nhap so luong xe: ");
                int n = int.Parse(Console.ReadLine());

                List<Xe.XeCon> danhSachXe = new List<Xe.XeCon>();
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Nhap thong tin cho xe thu " + (i + 1) + ":");
                    Xe.XeCon xe = new Xe.XeCon("", 0, 0, 0, "");
                    xe.Nhap();
                    danhSachXe.Add(xe);
                }

                Console.WriteLine("\nDanh sách các xe:");
                foreach (var xe in danhSachXe)
                {
                    xe.Xuat();
                    Console.WriteLine();
                }

                Xe.XeCon xeGiaThapNhat = danhSachXe[0];
                Xe.XeCon xeGiaCaoNhat = danhSachXe[0];
                foreach (var xe in danhSachXe)
                {
                    if (xe.Gia < xeGiaThapNhat.Gia)
                    {
                        xeGiaThapNhat = xe;
                    }
                    if (xe.Gia > xeGiaCaoNhat.Gia)
                    {
                        xeGiaCaoNhat = xe;
                    }
                }

                Console.WriteLine("\nXe co gia thap nhat:");
                xeGiaThapNhat.Xuat();
                Console.WriteLine("\nXe co gia cao nhat:");
                xeGiaCaoNhat.Xuat();

                Console.Write("\nNhap 2 chu so dau bien so: ");
                string maTinh = Console.ReadLine();
                Console.WriteLine($"Xe thuoc tinh co ma so {maTinh}:");
                foreach (var xe in danhSachXe)
                {
                    if (xe.BienSo.StartsWith(maTinh))
                    {
                        xe.Xuat();
                        Console.WriteLine();
                    }
                }

                danhSachXe.Sort((x1, x2) => x1.NamSX.CompareTo(x2.NamSX));
                Console.WriteLine("\nDanh sach xe khi truc tiep theo nam san xuat:");
                foreach (var xe in danhSachXe)
                {
                    xe.Xuat();
                    Console.WriteLine();
                }
            }
        }
    }
}
    
