using System;
using System.Collections.Generic;
using System.Text;

namespace ShokunHW10_1
{
    public struct Point
    {
        public int X, Y;

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }

    public class Triangle
    {

        public Point vertex1, vertex2, vertex3;

        public Triangle(Point vertex1, Point vertex2, Point vertex3)
        {
            this.vertex1 = vertex1;
            this.vertex2 = vertex2;
            this.vertex3 = vertex3;
        }

        public double Distance(Point p1, Point p2)
        {
            return Math.Round(Math.Sqrt(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2)), 2);
        }

        public double Perimeter()
        {
            return Math.Round(Distance(vertex1, vertex2) + Distance(vertex2, vertex3) + Distance(vertex1, vertex3), 2);
        }

        public double Square()
        {
            double ab = Distance(vertex1, vertex2);
            double bc = Distance(vertex2, vertex3);
            double ac = Distance(vertex1, vertex3);
            double p = Perimeter() / 2;
            return Math.Round(Math.Sqrt(p * (p - ab) * (p - bc) * (p - ac)), 2);
        }

        public void Print()
        {
            Console.WriteLine($"\nVertex1: {vertex1.ToString()}\nVetrex2: {vertex2.ToString()}\nVertex3: {vertex3.ToString()}\nPerimeter: {Perimeter()}\nSquare: {Square()}");
        }
    }
}
