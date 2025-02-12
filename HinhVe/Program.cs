using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;

namespace HinhVe
{
    public abstract class Shape
    {
        public string Name { get; set; }
        public abstract double Area();
    }
    public class Rectangle : Shape
    {
        public double width { get; set; }
        public double height { get; set; }

        public Rectangle(double cd, double cr)
        {
            width = cd;
            height = cr;
        }
        public override double Area()
        {
            return width * height;
        }
        public class Circle : Shape
        {
            public double radius { get; set; }
            public Circle(double R)
            {
                radius = R;
            }
            public override double Area()
            {
                return Math.PI * Math.Pow(radius, 2);
            }
            public class Triangle : Shape
            {
                public double _a { get; set; }
                public double _b { get; set; }
                public double _c { get; set; }

                public Triangle(double a, double b, double c)
                {
                    _a = a;
                    _b = b;
                    _c = c;
                }
                public override double Area()
                {
                    double s = 0;
                    double p = 0;
                    if (!(_a + _b > _c || _c + _b > _a || _a + _c > _b))
                    {
                        return -1;
                    }
                    else
                    {
                        p = (_a + _b + _c) / 2;
                        s = Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
                    }
                    return s;
                }
            }
            public class Square : Rectangle
            {
                public double Canh { get; set; }
                public Square(double canh) : base(canh, canh)
                {
                    Canh = canh;
                }
                public override double Area()
                {
                    return base.Area();
                }
            }
        }
    }
                internal class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<Shape>
            {
                new Rectangle (9,6),
                new Circle (1),
                new Circle (2.5),
                new Rectangle (6,9),
                new Circle (2,3),
                new Triangle(4,2,5),
                new Square (4),
                new Square (2),
                new Triangle (2,5,9),
            };
            double MaxArea = 0;
            for (int i = 0; i < shapes.Count; i++)
            {
                if (shapes[i].Area() > 0) Console.WriteLine("Hinh so {0} la {1} co dien tich bang {2:0.00}", i + 1, shapes[i].GetType(), shapes[i].Area());
                if (shapes[i].Area() > MaxArea = shapes[i].Area());

            }
            Console.WriteLine();

            Console.WriteLine("Hinh co dien tich lon nhat: ");
            for (int i = 0; i < shapes.Count; i++)
            {
                if (shapes[i].Area() == MaxArea)
                    Console.WriteLine("Hinh so {0} la {1} co dien tich bang {2:0.00}", i + 1, shapes[i].GetType(), shapes[i].Area());
                {
                    for(int i = 0; i < shapes.Count;i++) 
                    {
                        for(int j = i + 1; j < shapes.Count;j++)
                        {
                            if (shapes[j].Area() > shapes[i].Area())
                            {
                                var tam = shapes[j];
                                shapes[j] = shapes[i];
                                shapes[i] = tam;
                            }
                        }
                    }
                    Console.WriteLine();

                    Console.WriteLine("Danh sach giam dan theo dien tich: ");
                    for(int i = 0; i < shapes.Count;i++)
                    {
                        if (shapes[i].Area() > 0) Console.WriteLine("Hinh so {0} la {1} co dien tich bang {2:0.00}", i + 1, shapes[i].GetType(), shapes[i].Area());
                    }
                }
            }
        }
    }
}
