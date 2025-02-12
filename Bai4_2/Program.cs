using System;   
using System.Globalization;

namespace Bai4_2
{
    // Tạo lớp hình vẽ tổng quát (Shape)
    public class Shape
    {
        public virtual double GetArea()
        {
            return 0;
        }
    } // Kết thúc lớp Shape
    
    // Tạo lớp hình tròn (Circle) kế thừa lớp hình vẽ
    public class Circle : Shape
    {
        public double Radius; //Thuộc tính lưu độ dài bán kính

        // Contructor
        public Circle (double r=0)
        {
            Radius = r;
        }
        // Phương thức ghi dè (override) tính diện tích hình tròn
        public override double GetArea()
        {
            return Math.Round(Math.PI * Radius * Radius, 2);
        }
    } //Kết thúc lớp Circle 

    // Lớp hình chữ nhật (Rectangle) kế thừa lớp hình vẽ
    public class Rectangle : Shape
    {
        public double width; //Các thuộc tính lưu kích thước hình chữ nhật
        public double height;

        // Contructor
        public Rectangle (double w=0, double h=0)
        {
            width = w;
            height = h;
        }
        // Phương thức ghi dè tính diện tích hình chữ nhật 
        public override double GetArea()
        {
            return Math.Round(width * height, 2);
        }
    } //Kết thúc lớp Rectangle 

    //Lớp hình tam giác (Triangle) kế thừa lớp hình vẽ
    public class Triangle : Shape
    {
        public double a;
        public double b;
        public double c;

        // Contructor
        public Triangle (double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        // Phương thức ghi dè tính diện tích hình tam giác
        public override double GetArea()
        {
            double s = (a + b + c) / 2;
            return Math.Round(Math.Sqrt(s * (s - a) * (s - b) * (s - c)), 2);
        }
    } //Kết thúc lớp Triangle
    internal class Program
    {
        public static void Main()
        {
            Console.Write("Nhap so luong hinh ve: ");
            int n = int.Parse(Console.ReadLine());

            List<Shape> shapes = new List<Shape>();

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap loai hinh cho hinh {i + 1} (1.circle/2.rectangle/3.triangle): ");
                string shapeType = Console.ReadLine();

                switch (shapeType.ToLower())
                {
                    case "circle":
                        Console.Write("Nhap ban kinh cua hinh tron: ");
                        double radius = double.Parse(Console.ReadLine());
                        shapes.Add(new Circle(radius));
                        break;
                    case "rectangle":
                        Console.Write("Nhap chieu rong cua hinh chu nhat: ");
                        double width = double.Parse(Console.ReadLine());
                        Console.Write("Nhap chieu dai cua hinh chu nhat: ");
                        double height = double.Parse(Console.ReadLine());
                        shapes.Add(new Rectangle(width, height));
                        break;
                    case "triangle":
                        Console.Write("Nhap canh a cua tam giac: ");
                        double a = double.Parse(Console.ReadLine());
                        Console.Write("Nhap canh b cua tam giac: ");
                        double b = double.Parse(Console.ReadLine());
                        Console.Write("Nhap canh c cua tam giac: ");
                        double c = double.Parse(Console.ReadLine());
                        shapes.Add(new Triangle(a, b, c));
                        break;
                    default:
                        Console.WriteLine("Loai hinh khong hop le.");
                        break;
                }
            }

            // Tính diện tích và tìm diện tích lớn nhất
            double maxArea = -1;
            Shape maxShape = null;

            foreach (var shape in shapes)
            {
                double area = shape.GetArea(); // Lấy diện tích từ phương thức GetArea()
                if (area > maxArea)
                {
                    maxArea = area;
                    maxShape = shape;
                }
            }

            Console.WriteLine($"Hinh voi dien tich lon nhat la {maxShape.GetType().Name} voi dien tich {maxArea}");

            // Sắp xếp danh sách theo thứ tự giảm dần của diện tích
            shapes.Sort((x, y) => y.GetArea().CompareTo(x.GetArea()));

            Console.WriteLine("Danh sach hinh sau khi sap xep:");
            foreach (var shape in shapes)
            {
                Console.WriteLine($"{shape.GetType().Name}: {shape.GetArea()}");
            }
        }
    }
}