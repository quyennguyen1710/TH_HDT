using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3_2
{
    public class NhanVien
    {
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public double Luong { get; set; }
        public NhanVien(string hoten, DateTime ngaysinh, double luong)
        {
            HoTen = hoten;
            NgaySinh = ngaysinh;
            Luong = luong;
        }
        public NhanVien()
        {
            HoTen = " ";
            NgaySinh = DateTime.MinValue;
            Luong = 0;
        }
        public virtual void Nhap()
        {
            Console.Write("Nhap ho ten: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhap ngay sinh(yyyy/mm/dd): ");
            NgaySinh = DateTime.Parse(Console.ReadLine());
        }
        public virtual void Xuat()
        {
            Console.Write("Ho ten: {0}\n", HoTen);
            Console.Write("Ngay sinh: {0}\n", NgaySinh);
        }
        public virtual double TienLuong()
        {
            return 0;
        }
    }
    //Nhan vien van phong
    public class NVVP : NhanVien
    {
        public int SoNgayLam { get; set; }
        public NVVP(int sonlv, string hoten, DateTime ngaysinh, double luong) : base(hoten, ngaysinh, luong)
        {
            SoNgayLam = sonlv;
        }
        public NVVP() : base() 
        {
            SoNgayLam = 0;
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap so ngay lam viec: ");
            SoNgayLam = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.Write("So ngay lam viec: {0}\n", SoNgayLam);
        }
        public override double TienLuong()
        {
            return SoNgayLam * 100000;
        }
    }
    //Nhan vien san xuat
    public class NVSX : NhanVien
    {
        public double LuongCB { get; set; }
        public int SoSP { get; set; }
        public NVSX(double luongcb, int sosp, string hoten, DateTime ngaysinh, double luong) : base(hoten, ngaysinh, luong)
        {
            LuongCB = luongcb;
            SoSP = sosp;
        }
        public NVSX() : base()
        {
            LuongCB = 0;
            SoSP = 0;
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap luong co ban: ");
            LuongCB = double.Parse(Console.ReadLine());
            Console.Write("Nhap so san pham: ");
            SoSP = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.Write("Luong con ban: {0}\n", LuongCB);
            Console.Write("So san pham: {0}\n", SoSP);
        }
        public override double TienLuong()
        {
            return LuongCB + SoSP * 5000;
        }
    }
    class Program
    {
        static void Main()
        {
            int check; //chon nvvp hoac nvsx
            int n;
            Console.Write("Nhap so nhan vien: ");
            n = int.Parse(Console.ReadLine());
            NhanVien[] NV = new NhanVien[n];
            //nhap thong tin
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhan vien thu {0}\n", i + 1);
                Console.Write("Chon loai nhan vien(1.Van phong, 2.San Xuat): ");
                check = int.Parse(Console.ReadLine());
                Console.WriteLine();
                if (check == 1)
                {
                    NV[i] = new NVVP();

                }
                else if (check == 2)
                {
                    NV[i] = new NVSX();
                }
                else
                {
                    Console.Write("Loai nhan vien khong hop le");
                    i--;
                }
                NV[i].Nhap();
                NV[i].Xuat();
                Console.Write("Luong: {0}\n", NV[i].TienLuong());
                Console.WriteLine();
            }
            //sap xep
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (NV[i].TienLuong() < NV[j].TienLuong())
                    {
                        NhanVien temp = NV[i];
                        NV[i] = NV[j];
                        NV[j] = temp;
                    }
                }
            }
            Console.WriteLine("Sap xep danh sach nhan vien theo thu tu giam dan cua luong: ");
            foreach (var nv in NV)
            {
                nv.Xuat();
                Console.Write("Luong: {0}\n", nv.TienLuong());
                Console.WriteLine();
            }
        }
    }
}