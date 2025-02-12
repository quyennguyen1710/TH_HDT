using System;

namespace Bai2_5
{
    // Khai báo lớp stack 
    public class Stack
    {
        private static readonly int Max = 1000;
        private int _top;
        private int[] _stack = new int[Max];

        public Stack()
        {
            _top = -1;
        }

        public void Push(int data)
        {
            if (_top >= Max - 1)
                Console.WriteLine("Ngan xep day! Khong chua them duoc!");
            else
            {
                _top++;
                _stack[_top] = data;
            }
        }

        public int Pop()
        {
            if (_top >= 0)
            {
                int data = _stack[_top];
                _top--;
                return data;
            }
            else
                return -1;
        }

        public void Print()
        {
            if (_top < 0)
                Console.WriteLine("Ngan xep rong!");
            else
                for (int i = _top; i > 0; i--)
                    Console.Write("{0}*", _stack[i]);
            Console.Write("{0}", _stack[0]);
        }

        public void PrintBin()
        {
            for (int i = _top; i >= 0; i--)
                Console.Write(_stack[i]);
        }

        public void PrintHex()
        {
            string csHex = "0123456789ABCDEF";
            for (int i = _top; i >= 0; i--)
                Console.Write(csHex[_stack[i]]);
        }
    } // ENd of class stack

    // Main program 
    class Program
    {
        static void Main()
        {
            int n, n0;

            Stack stack1 = new Stack();

            Console.Write("Nhap so tu nhien n: ");
            n = int.Parse(Console.ReadLine());
            n0 = n;
            for (int i = 2; i <= n; i++)
            {
                while (n % i == 0)
                {
                    stack1.Push(i);
                    n /= i;
                }
            }

            Console.WriteLine("So {0} phan tich ra thua so nguyen to:", n0);
            stack1.Print();

            n = n0;
            Stack stack2 = new Stack();

            while (n > 0)
            {
                int soDu = n % 16;
                stack2.Push(soDu);
                n = n / 16;
            }

            Console.WriteLine("\nSo {0} doi sang he 16 la:", n0);
            stack2.PrintHex();

            n = n0;
            Stack stack3 = new Stack();
            while (n > 0)
            {
                int bin = n % 2;
                stack3.Push(bin);
                n = n / 2;
            }
            Console.WriteLine("\nSo {0} doi sang he 2 la: ", n0);
            stack3.PrintBin();
        }
    } // End of class program
}
