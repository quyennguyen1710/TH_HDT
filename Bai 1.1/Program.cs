﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_1._1
{
    class Program
    {
        // Khai báo các hằng 
        const int Muc1 = 100, Muc2 = 150, Muc3 = 300;
        const int Gia1 = 2000, Gia2 = 2500, Gia3 = 3000;

        static void Main()
        {
            int sokWh = 0;
            double sotien = 0;

            // Input
            // Nhap so kWH tieu thu
            Console.Write("Nhap so kWh tieu thu: ");
            sokWh = int.Parse(Console.ReadLine());

            // Process
            // Tinh tien dien dua vao so kWh va bang gia
            if (sokWh <= 0) sotien = 0;
            else if (sokWh <= Muc1) sotien = sokWh * Gia1;
            else if (sokWh <= Muc2) sotien = Muc1 * Gia1 + (sokWh - Muc1) * Gia2;
            else if (sokWh <= Muc3) sotien = Muc1 * Gia1 + (Muc2 - Muc1) * Gia2 + (sokWh - Muc2) * Gia3;
            // Neu tieu thu qua 300 thi cong them 10% tong tien 
            else sotien = (Muc1 * Gia1 + (Muc2 - Muc1) * Gia2 + (sokWh - Muc2) * Gia3) * 1.1;
            // Output
            Console.WriteLine("So kWh tieu thu: {0}, so tien: {1:#.00} (vnd)",sokWh, sotien);
        }
    }
}
