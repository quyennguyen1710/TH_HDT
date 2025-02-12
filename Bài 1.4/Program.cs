using System;
using System.Xml.Schema;

namespace ArrayFunctions
{
    class Program
    {
        // a. Nhap mot mang n so nguyen tu ban phim 
        public static void NhapMang(int[] mang,out int n)
        {
            Console.WriteLine("Nhap so phan tu cua mang: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("Phan tu thu {0}: ", i + 1);
                mang[i] = int.Parse(Console.ReadLine());
            }   
        }
        // b. In các phần tử của mảng lên màn hình.
        public static void InMang(int[] mang, int n)
        {           
            for(int i = 0; i < n; i++)
            {
                Console.Write("{0} ", mang[i]);
            }    
            Console.WriteLine();
        }
        // c. Trả về phần tử lớn nhất của mảng.
        public static int PhanTuLonNhat(int[] mang,int n)
        {
            int max = 0;
            for(int i = 0; i < n; i++)
            {
                if (mang[i] > max)
                    max = mang[i];
            }    
            return max;
        }
        // d. Trả về kiểu boolean kiểm tra mảng đã được sắp xếp tăng dần chưa.
        public static bool SXTD(int[] mang, int n)
        {
            if (n <= 1)
                return true;
            for(int i = 0; i < n; i++)
            {
                for(int j = i+1; j < n; j++)
                {
                    if (mang[j] < mang[i])
                        return false;
                }    
            }    
            return true;
        }
        // e. Sắp xếp mảng theo thứ tự tăng dần.
        public static void SX(int[] mang, int n)
        {
            int tam;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (mang[j] < mang[i])
                    {
                        tam = mang[i];
                        mang[i] = mang[j];
                        mang[j] = tam;
                    }    
                      
                }
            }
            InMang(mang, n);
        }
        // f. Tách mảng thành 2 mảng con: một mảng chứa các phần tử chẵn, mảng còn lại chứa các phần tử lẻ.
        public static void PTC(int[] mang, int n)
        {
            int[] mangchan = new int[100];
            int c = 0;
            int[] mangle = new int[100];
            int l = 0;
            for(int i = 0; i < n; i++)
            {
                if (mang[i]% 2 == 0)
                    mangchan[c++] = mang[i];
                else mangle[l++] = mang[i];
            }
            Console.WriteLine("Mang chan: ");
            InMang(mangchan, c);
            Console.WriteLine("Mang le: ");
            InMang(mangle, l);
        }

        static void Main(string[] args)
        {
            // Nhap mang tu ban phim 
            int[] mang = new int[100];
            int n;
            NhapMang(mang, out n);
            Console.WriteLine("Noi dung cua mang la: ");
            InMang(mang, n);
            Console.WriteLine("Phan tu lon nhat la {0} ", PhanTuLonNhat(mang, n));
            if (SXTD(mang, n))
                Console.WriteLine("Mang tang dan ");
            else
            {
                Console.WriteLine("Mang khong tang dan ");
                Console.WriteLine("Mang sau khi sap xep ");
                SX(mang, n);
            }
            PTC(mang, n);
        }
    }
    
}
   

