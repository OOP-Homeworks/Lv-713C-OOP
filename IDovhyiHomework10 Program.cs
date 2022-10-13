using System;
using System.Collections.Generic;

namespace IDovhyiHomework10
{
    public struct Point
    { 
        public double x, y;
        public override string ToString()

        {
            return $"({x},{y})";
        }
        public Point(double x, double y)
        { 
            this.x = x;
            this.y = y;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Triangle> triangles = new List<Triangle>()
            { 
            new Triangle(new Point(0,3), new Point(4,2), new Point(10,10)),
            new Triangle(new Point(0,2), new Point(5,2), new Point(11,11)),
            new Triangle(new Point(0,1), new Point(6,2), new Point(12,12))
            };
            foreach (Triangle triangle in triangles) triangle.Print();
            
            Console.WriteLine("Triangle with vertex which is the closest to origin (0,0):");
            Triangle triangleWithMinDistance = triangles[0];
            foreach (Triangle triangle in triangles)
                if (triangleWithMinDistance.minDistance() > triangle.minDistance()) triangleWithMinDistance = triangle;
            triangleWithMinDistance.Print();
        }
    }
}
