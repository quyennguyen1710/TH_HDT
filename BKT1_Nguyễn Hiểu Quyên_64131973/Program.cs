using System;

namespace Bai_KT_1
{
    //Tạo lớp nhân viên
    public class NhanVien
    {
        //Khai báo các trường dữ liệu riêng (fields)
        private string maNV;
        private string hoTen;
        private double hsLuong;
        private static double LuongCB = 1500000; //Mức lương cơ bản
        private static int SoNV = 0; //Mức lương nhân viên được tạo

        //Khai báo các thuộc tính (properties) 
        public string MaNV
        {
            get { return maNV; }
            set
            {
                if (value.Length > 0) maNV = value;
            }
        }
        public string HoTen
        {
            get { return hoTen; }
            set
            {
                if (value.Length > 0) hoTen = value;
            }
        }
        public double HSLuong
        {
            get { return hsLuong; }
            set
            {
                if (value >= 2 && value <= 6) hsLuong = value;
                else throw new ArgumentOutOfRangeException("HSLuong ");
            }
        }
        //Hàm thiết lập
        public NhanVien(string ms = "", string ht = "", double hsl = 0)
        {
            maNV = ms;
            hoTen = ht;
            hsLuong = hsl;
            SoNV++;
        }
        //Hàm nhập thông tin nhân viên
        public void Nhap()
        {
            Console.Write("Ma nhan vien: ");
            string st;
            do
            {
                st = Console.ReadLine();
            } while (st.Length <= 0);
            maNV = st;

            Console.WriteLine("Ho va ten nhan vien: ");
            do
            {
                st = Console.ReadLine();
            } while (st.Length <= 0);
            hoTen = st;

            Console.Write("He so luong: ");
            bool isValidNumber = false;
            double hsl;
            do
            {
                isValidNumber = double.TryParse(Console.ReadLine(), out hsl);
            } while (!isValidNumber);
            hsLuong = hsl;
        }
        //Hàm in thông tin 1 nhân viên
        public void Xuat()
        {
            Console.WriteLine(String.Format("{0,-10}", maNV) + String.Format("{0,-30}", hoTen) + String.Format("{0:#.00}", hsLuong));
        }
        //Hàm tính lương 1 nhân viên
        public double TinhLuong()
        {
            return hsLuong * LuongCB;
        }
    } //End of class NhanVien
    internal class Program
    {
        static void Main(string[] args)
        {
            const int Max = 100;
            //Nhập số lượng nhân viên
            int soNV;
            bool isValidNumber = false;
            do
            {
                Console.Write("Nhap so nhan vien: ");
                isValidNumber = int.TryParse(Console.ReadLine(), out soNV);
            } while (!isValidNumber || soNV <= 0 || soNV > Max);
            //Khai báo danh sách tĩnh đối tượng nhân viên
            NhanVien[] nvList = new NhanVien[soNV];
            //Nhập thông tin cho từng nhân viên
            for (int i = 0; i < soNV; i++)
            {
                Console.WriteLine("Nhap thong tin nhan vien thu {0}: ", i + 1);
                nvList[i] = new NhanVien();
                nvList[i].Nhap();
            }
            //In danh sách nhân viên
            Console.WriteLine("Danh sach nhan vien: ");
            foreach (var nv in nvList) nv.Xuat();
            //Tìm hệ số lương cao nhất
            double maxHSL = nvList[0].HSLuong;
            for (int i = 1; i <soNV; i++)
                if (maxHSL < nvList[i].HSLuong) maxHSL = nvList[i].HSLuong;
            //In ra các nhân viên có hệ số lương cao nhất
            Console.WriteLine("Danh sach nhan vien co he so luong cao nhat ({0}): ", maxHSL);
            foreach (var nv in nvList)
                if (nv.HSLuong == maxHSL) nv.Xuat();

            //Sắp xếp danh sách giảm dần theo tiền lương
            for (int i = 0; i < soNV; i++)
                for (int j = 0; j < soNV; j++)
                    if (nvList[i].TinhLuong() < nvList[j].TinhLuong())
                    {
                        NhanVien tmp = nvList[i];
                        nvList[i] = nvList[j];
                        nvList[j] = tmp;
                    }
            // In ra danh sách đã sắp xếp
            Console.WriteLine("Danh sach nhan vien giam dan theo luong ");
            foreach (var nv in nvList) nv.Xuat();
        }
    }
}
