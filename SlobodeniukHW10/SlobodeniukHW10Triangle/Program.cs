using System;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

namespace SlobodeniukHW10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Triangle> triangles = new List<Triangle>();

            triangles.Add(new Triangle(new Point(1, 2), new Point(1, 10), new Point(3, 8)));
            triangles.Add(new Triangle(new Point(4, 2), new Point(4, 6), new Point(2, 3)));
            triangles.Add(new Triangle(new Point(3, 2), new Point(3, 6), new Point(2, 7)));

            foreach (Triangle eachtriangle in triangles)
            {
                eachtriangle.Print();
            }
            Console.ReadLine();

            // *Print the triangle with vertex which is the closest to origin (0,0)

            Point origin = new Point(0, 0);

            Dictionary<Triangle, double> dict = new Dictionary<Triangle, double>();

            foreach (Triangle closestTriangle in triangles)
                dict.Add(closestTriangle, closestTriangle.TriangleClosestOrigin().Min());

            var closestOrigin = dict.OrderBy(x => x.Value).First();

            Console.WriteLine("The triangle with vertex which is the closest to origin: {0}, {1}, {2}.",
                               closestOrigin.Key.Vertex1.ToString(), closestOrigin.Key.Vertex2.ToString(),
                               closestOrigin.Key.Vertex3.ToString());
        }
    }
}