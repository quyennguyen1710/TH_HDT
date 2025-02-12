using System;

namespace Bai2_3
{
    // Khai báo lớp Point 
    public class Point
    {
        // Khai báo thuộc tính (X, Y) là tọa độ điểm trong mặt phẳng
        public double X { get; set; }
        public double Y { get; set; }

        // Hàm thiết lập
        public Point(double x = 0, double y = 0)
        {
            X = x;
            Y = y;
        }

        // dx, dy là độ dịch chuyển theo chiều ngang và dọc
        public void Move(double dx = 0, double dy = 0)
        {
            X += dx;
            Y += dy;
        }

        public double khoangcach_goc()
        {
            return Math.Sqrt(X * X + Y * Y);
        }

        public double khoangcachtoidiem(Point other)
        {
            double dx = X - other.X;
            double dy = Y - other.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }

        public void toadohienthi()
        {
            Console.WriteLine($"({X}, {Y})");
        }
    } // End of Point 

    // Main program
    class Program
    {
        static void Main()
        {
            Point[] points = new Point[4];

            // Thêm các điểm vào danh sách
            points[0] = new Point(1, 2);
            points[1] = new Point(-3, 4);
            points[2] = new Point(5, -6);
            points[3] = new Point(-7, -8);

            // In ra tọa độ của các điểm
            Console.WriteLine("Toa do cac diem:");
            foreach (Point point in points)
            {
                point.toadohienthi();
            }
            Console.WriteLine();

            // Tìm điểm cách xa gốc tọa độ nhất
            Point farthestPoint = null;
            double maxDistance = 0;

            foreach (Point point in points)
            {
                double distance = point.khoangcach_goc();
                if (distance > maxDistance)
                {
                    maxDistance = distance;
                    farthestPoint = point;
                }
            }

            Console.WriteLine("Diem cach xa goc toa do nhat:");
            farthestPoint.toadohienthi();
            Console.WriteLine();

            // Tìm cặp điểm gần nhau nhất
            Point closestPoint1 = null;
            Point closestPoint2 = null;
            double minDistance = double.MaxValue;

            for (int i = 0; i < points.Length - 1; i++)
            {
                for (int j = i + 1; j < points.Length; j++)
                {
                    double distance = points[i].khoangcachtoidiem(points[j]);
                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        closestPoint1 = points[i];
                        closestPoint2 = points[j];
                    }
                }
            }

            Console.WriteLine("Cap diem gan nhau nhat:");
            closestPoint1.toadohienthi();
            closestPoint2.toadohienthi();
            Console.ReadLine();
        }
    } // End of class Program
}
