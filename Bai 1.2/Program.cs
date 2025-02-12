using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            char phepToan;

            // Input: Không thay đổi phần này
            Console.Write("Nhap a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhap b = ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Nhap phep toan (+,-,*,/): ");
            phepToan = char.Parse(Console.ReadLine());

            switch (phepToan)
            {
                case '+': Console.WriteLine("\n{0} + {1} = {2}", a, b, a + b); break;
                case '-': Console.WriteLine("\n{0} - {1} = {2}", a, b, a - b); break;
                case '*': Console.WriteLine("\n{0} * {1} = {2}", a, b, a * b); break;
                case '/':
                    if (b == 0)
                        Console.WriteLine("\nKhong chia duoc!");
                    else
                        Console.WriteLine("\n{0}/{1} = {2}", a, b, (double)a / b);
                    break;
                default: Console.WriteLine("\nKhong biet phep toan!"); break;
            }
        }
    }
}
