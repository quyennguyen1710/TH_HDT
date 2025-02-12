using System;

namespace Bai2_2
{
    public class PhanSo
    {
        private int _tuSo;
        private int _mauSo;

        // Hàm khởi tạo phân số
        public PhanSo(int ts, int ms)
        {
            _tuSo = ts;
            _mauSo = ms;
        }

        // Hàm thiết lập sao chép
        public PhanSo(PhanSo p)
        {
            _tuSo = p._tuSo;
            _mauSo = p._mauSo;
        }

        // Nhập phân số từ bàn phím
        public void Nhap()
        {
            Console.Write("Nhap tu so: ");
            _tuSo = int.Parse(Console.ReadLine());
            Console.Write("Nhap mau so: ");
            _mauSo = int.Parse(Console.ReadLine());
        }

        // In phân số lên màn hình
        public void Xuat()
        {
            Console.WriteLine($"{_tuSo}/{_mauSo}");
        }
        public override string ToString()
        {
            return $"{_tuSo}/{_mauSo}";
        }

        // Trả về giá trị của phân số dưới dạng float
        public float GiaTri()
        {
            return (float)_tuSo / _mauSo;
        }
    }

    public class DSPhanSo
    {
        private List<PhanSo> _dsPS;
        private int _size;

        public DSPhanSo()
        {
            _dsPS = new List<PhanSo>();
            _size = 0;
        }

        // Nhập danh sách phân số
        public void Nhap()
        {
            Console.Write("Nhap so luong phan so: ");
            string sizeInput = Console.ReadLine();
            _size = int.TryParse(sizeInput, out int size) ? size : 0;

            for (int i = 0; i < _size; i++)
            {
                Console.WriteLine($"Nhap phan so thu {i + 1}:");
                PhanSo phanSo = new PhanSo(0, 1);
                phanSo.Nhap();
                _dsPS.Add(phanSo);
            }
        }

        // In danh sách phân số
        public void Xuat()
        {
            Console.WriteLine("Danh sach phan so:");
            foreach (var ps in _dsPS)
            {
                ps.Xuat();
            }
        }

        // Tìm phân số lớn nhất
        public PhanSo TimMax()
        {
            if (_dsPS.Count == 0)
                return null;

            PhanSo max = _dsPS[0];
            foreach (var ps in _dsPS)
            {
                if (ps.GiaTri() > max.GiaTri())
                    max = ps;
            }
            return max;
        }

        // Sắp xếp danh sách phân số theo thứ tự tăng dần của giá trị phân số
        public void SapXepTangDan()
        {
            _dsPS.Sort((ps1, ps2) => ps1.GiaTri().CompareTo(ps2.GiaTri()));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DSPhanSo ds = new DSPhanSo();
            ds.Nhap();
            Console.WriteLine("Danh sach phan so ban vua nhap:");
            ds.Xuat();

            PhanSo max = ds.TimMax();
            Console.WriteLine($"Phan so lon nhat trong danh sach: {max}");

            ds.SapXepTangDan();
            Console.WriteLine("Danh sach phan so theo thu tu tang dan cua gia tri:");
            ds.Xuat();
        }
    }
}