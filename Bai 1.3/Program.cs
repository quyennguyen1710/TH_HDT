using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vt, gio;
            Console.Write("So vi trung ban dau = ");
            vt = int.Parse(Console.ReadLine());
            Console.Write("So gio = ");
            gio = int.Parse(Console.ReadLine());

            if ((vt < 0) || (gio < 0))
                Console.WriteLine("Error");
            else
            {
                long s = vt * (long)Math.Pow(2, gio);
                Console.WriteLine("Tong so vi trung sau {0} gio = {1}", gio, s);
            }
        }
    }
}
