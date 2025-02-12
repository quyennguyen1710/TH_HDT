using System;

namespace Bai2_1
{
    // Khai báo lớp phân số 
    public class PhanSo
    {
        // Khai báo các trường (fields)
        private int _tuSo;
        private int _mauSo;

        // Phương thức thiết lập 
        public PhanSo(int ts, int ms)
        {
            _tuSo = ts;
            _mauSo = ms;
        }

        public PhanSo(PhanSo p)
        {
            _tuSo = p._tuSo;
            _mauSo = p._mauSo;
        }

        public void Nhap()
        {
            Console.Write("Nhap tu so: ");
            _tuSo = int.Parse(Console.ReadLine());
            Console.Write("Nhap mau so: ");
            _mauSo = int.Parse(Console.ReadLine());
        }

        public void Xuat()
        {
            Console.WriteLine("Phan so: " + _tuSo + "/" + _mauSo);
        }

        private int UCLN(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public void ToiGian()
        {
            int ucln = UCLN(_tuSo, _mauSo);
            _tuSo /= ucln;
            _mauSo /= ucln;
        }

        public PhanSo Cong(PhanSo ps)
        {
            int ts = _tuSo * ps._mauSo + ps._tuSo * _mauSo;
            int ms = _mauSo * ps._mauSo;
            PhanSo tong = new PhanSo(ts, ms);
            tong.ToiGian();
            return tong;
        }

        public PhanSo Tru(PhanSo ps)
        {
            int ts = _tuSo * ps._mauSo - ps._tuSo * _mauSo;
            int ms = _mauSo * ps._mauSo;
            PhanSo hieu = new PhanSo(ts, ms);
            hieu.ToiGian();
            return hieu;
        }
    }  // End of class PhanSo

    // Main program
    class Program
    {
        static void Main()
        {
            // Khai báo và khởi tạo 2 đối tượng PhanSo
            PhanSo ps1 = new PhanSo(1, 2);
            PhanSo ps2 = new PhanSo(3, 4);

            // Nhập và xuất các phân số
            Console.WriteLine("Nhap phan so thu nhat:");
            ps1.Nhap();
            Console.WriteLine("Nhap phan so thu hai:");
            ps2.Nhap();
            Console.WriteLine("Phan so thu nhat:");
            ps1.Xuat();
            Console.WriteLine("Phan so thu hai:");
            ps2.Xuat();

            // Tối giản các phân số
            ps1.ToiGian();
            ps2.ToiGian();
            Console.WriteLine("Phan so sau khi toi gian:");
            ps1.Xuat();
            ps2.Xuat();

            // Tính tổng và hiệu các phân số
            PhanSo tong = ps1.Cong(ps2);
            PhanSo hieu = ps1.Tru(ps2);
            Console.WriteLine("Tong hai phan so:");
            tong.Xuat();
            Console.WriteLine("Hieu hai phan so:");
            hieu.Xuat();
        }
    } // End of class Program
}


