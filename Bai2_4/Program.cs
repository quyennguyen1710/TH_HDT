using System;

namespace Bai2_4
{
    // Khai báo lớp Point
    public class Point
    {
        // Thuộc tính
        private double _x;
        private double _y;

        // Hàm thiết lập khởi tạo
        public Point(double x, double y)
        {
            _x = x;
            _y = y;
        }

        // Phương thức di chuyển điểm
        public void Move(double dx, double dy)
        {
            _x += dx;
            _y += dy;
        }

        // Phương thức in tọa độ của điểm
        public void PrintCoordinates()
        {
            Console.WriteLine($"({_x}, {_y})");
        }
    } 
    // Khai báo lớp Circle 
    public class Circle
    {

        private double _r;
        private Point _c;
        public Circle(double r, Point c)
        {
            _r = r;
            _c = c;
        }
        public double Area()
        {
            return Math.PI * _r * _r;
        }
        public void Move(double dx, double dy)
        {
            _c.Move(dx, dy);
        }
    } // End of Circle class
    
    // Main program
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Nhap toa do cua tam hinh tron:");
            Console.Write("Nhap x: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Nhap y: ");
            double y = double.Parse(Console.ReadLine());
            Console.Write("Nhap ban kinh cua hinh tron: ");
            double radius = double.Parse(Console.ReadLine());
            Point center = new Point(x, y);
            Circle circle = new Circle(radius, center);
            Console.WriteLine($"Dien tich hinh tron: {circle.Area()}");
            circle.Move(2, 3);
            Console.WriteLine("Toa do tam hinh tron sau khi di chuyen:");
            center.PrintCoordinates();
        }
    } // End of class Program 
}