using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public abstract class Xe
    {
        private string BienSo;
        private int NamSX;

        public string bienso
        {
            get { return BienSo; }
            set { if (value.Length > 0) bienso = value; }
        }
        public int namsx
        {
            get { return NamSX; }
            set { if (value > 0) NamSX = value; }
        }
        public Xe(string bs = " ", int nsx = 0)
        {
            BienSo = bs;
            NamSX = nsx;
        }
        public virtual void Nhap()
        {
            Console.Write("Bien so: ");
            do
            {
                bienso = Console.ReadLine();
            }
            while (!(bienso.Length > 0));
            Console.Write("Nam san xuat: ");
            do
            {
                int n = int.Parse(Console.ReadLine());
            }
            while (!(NamSX > 0));
        }
        public virtual void Xuat()
        {
            Console.WriteLine("Bien so: {0} Nam san xuat {1}", BienSo, NamSX);
        }
        public abstract int HetHan();
    }
    public class XeCon:Xe
    {
        private int scn;
        public int Socn
        {
            get { return Socn; }
            set { if (value > 0) Socn = value; }
        }
        public XeCon(string bs = " ", int nsx = 0, int scn = 0) : base(bs, nsx)
        {
            Socn = scn;
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("So cho ngoi: ");
            do
            {
                scn = int.Parse(Console.ReadLine());
            }
            while (!(scn > 0));
        }
        public override void Xuat()
        {
            Console.Write("XeCon ");
            base.Xuat();
            Console.WriteLine("So cho ngoi: {0}", scn);
        }
        public override int HetHan()
        {
            return namsx + 30;
        }
    }
    public class XeTai : Xe
    {
        private double TaiTrong;
        public double tt
        {
            get { return tt; }
            set { if (value > 0) tt = value; }
        }
        public XeTai(string bs = " ", int nsx = 0, int tt = 0) : base(bs, nsx)
        {
            TaiTrong = tt;
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Tai trong: ");
            do
            {
                tt = double.Parse(Console.ReadLine());
            }
            while (!(tt > 0));
        }
        public override void Xuat()
        {
            Console.Write("XeTai ");
            base.Xuat();
            Console.WriteLine("Tai trong: {0}", tt);
        }
        public override int HetHan()
        {
            return namsx + 20;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Nhap thong tin n xe vao mot danh sach
            Console.Write("So luong xe: ");
            int n = int.Parse(Console.ReadLine());
            Xe[] ds = new Xe[n];
            Console.WriteLine("1-Xe con\n 2-Xe tai");
            int c;
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("\nChon xe: {0}", i + 1);
                do
                {
                    c = int.Parse(Console.ReadLine());
                }
                while (!(c == 1 || c == 2));
                if(c == 1)
                {
                    ds[i] = new XeCon();
                    ds[i].Xuat();
                }
                else if (c == 2)
                {
                    ds[i] = new XeTai();
                    ds[i].Xuat();
                }
            }
            // In danh sach xe vua nhap va thong tin chi tiet
            Console.WriteLine("\nDanh sach cac loai xe: ");
            for(int i = 0; i < n; i++)
            {
                ds[i].Xuat();
            }
            //Liet ke cac xe het thoi han bao hanh
            Console.WriteLine("\nDanh sach cac xe het thoi han bao hanh: ");
            for(int i = 0; i < n; i++)
            {
                if (ds[i].HetHan() < DateTime.Now.Year)
                {
                    ds[i].Xuat();
                    Console.WriteLine("Het han: {0}", ds[i].HetHan());
                }
            }
            //Sap xep ds xe theo tung loai, trong moi loai co nam san xuat tang dan
            List<XeCon> dsxc = new List<XeCon>();
            List<XeTai> dsxt = new List<XeTai>();
            for(int i =0; i < n; i++)
            {
                if (ds[i].GetType().ToString()=="XeCon.XeTai")
                {
                    dsxc.Add((XeCon)ds[i]);
                }
                else
                {
                    dsxt.Add((XeTai)ds[i]);
                }
            }
            Console.WriteLine("\nDanh sach xe con tang dan theo nam san xuat: ");
            for(int i = 0; i < dsxc.Count -1; i++)
            {
                for(int j = i + 1; j < dsxt.Count; j++)
                {
                    if (dsxc[i].namsx > dsxc[j].namsx)
                    {
                        var temp = dsxc[i];
                        dsxc[i] = dsxc[j];
                        dsxc[j] = temp;
                    }
                }
            }
            for(int i = 0; i < dsxc.Count; i++)
            {
                dsxc[i].Xuat();
            }
            Console.WriteLine("\nDanh sach xe tai tang dan theo nam san xuat: ");
            for(int i = 0; i < dsxt.Count + 1; i++)
            {
                for(int j = i + 1; j < dsxt.Count; j++)
                {
                    if (dsxt[i].namsx > dsxt[j].namsx) 
                    {
                        var temp = dsxt[i];
                        dsxt[i] = dsxt[j];
                        dsxt[j] = temp;
                    }
                }
            }
            for(int i = 0; i <dsxt.Count; i++)
            {
                dsxt[i].Xuat();
            }
            //Liet ke cac xe thuoc tinh khanh hoa
            Console.WriteLine("\n Danh sach xe cua Khanh Hoa: ");
            for(int i  = 0; i < n; i++)
            {
                if (ds[i].bienso.Substring(0, 2) == "79")
                {
                    ds[i].Xuat();
                }
            }
        }
    }
}
