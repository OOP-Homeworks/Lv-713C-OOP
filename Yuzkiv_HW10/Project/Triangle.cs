using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_10
{
    public class Triangle
    {
        public Point Vertex1, Vertex2, Vertex3;
        public double Side1, Side2, Side3;

        public Triangle(Point a, Point b, Point c)
        {
            Vertex1 = a;
            Vertex2 = b;
            Vertex3 = c;
        }

        public Triangle()
        {
        }

        public double Distance(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(b.X - a.X, 2) +
                   Math.Pow(b.Y - a.Y, 2) * 1.0);
        }

        public double Perimetr()
        {
            return Side1 + Side2 + Side3;
        }

        public double Squere()
        {
            double semiperimeter = (Side1 + Side2 + Side3) / 2;
            double area = Math.Sqrt(semiperimeter * (semiperimeter - Side1) * (semiperimeter - Side2) * (semiperimeter - Side3));
            return area;
        }

        public void Print()
        {
            Console.WriteLine($"Perimetr: {Perimetr()}, Squere: {Squere()}");
        }
    }
}
