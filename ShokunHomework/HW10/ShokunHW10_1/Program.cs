using System;
using System.Collections.Generic;

namespace ShokunHW10_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1, p2, p3, p4, p5, p6, p7, p8, p9;
            p1 = new Point(10, 20);
            p2 = new Point(-2, 53);
            p3 = new Point(3, 4);
            p4 = new Point(4, 5);
            p5 = new Point(5, 6);
            p6 = new Point(6, 7);
            p7 = new Point(1, 5);
            p8 = new Point(2, 7);
            p9 = new Point(3, 1);

            List<Triangle> triangles = new List<Triangle>();

            triangles.Add(new Triangle(p1, p2, p3));
            triangles.Add(new Triangle(p4, p5, p6));
            triangles.Add(new Triangle(p7, p8, p9));

            foreach(Triangle triangle in triangles)
            {
                triangle.Print();
            }

            Console.ReadKey();
        }
    }
}
