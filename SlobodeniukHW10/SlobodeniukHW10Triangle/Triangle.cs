using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlobodeniukHW10
{
    public class Triangle
    {
        private Point vertex1, vertex2, vertex3;

        public Point Vertex1 { get { return vertex1; } set { vertex1 = value; } }
        public Point Vertex2 { get { return vertex2; } set { vertex2 = value; } }
        public Point Vertex3 { get { return vertex3; } set { vertex3 = value; } }

        public Triangle(Point vertex1, Point vertex2, Point vertex3)
        {
            this.vertex1 = vertex1;
            this.vertex2 = vertex2;
            this.vertex3 = vertex3;
        }

        public double Distance(Point start, Point newpoint)
        {
            double xx = start.x - newpoint.x;
            double yy = start.y - newpoint.y;
            
            return Math.Sqrt(Math.Pow(xx, 2) + Math.Pow(yy, 2));
        }

        public bool TriangleExist()
        {
            bool result = true;

            result &= (Distance(vertex1, vertex2) + Distance(vertex2, vertex3)) > Distance(vertex1, vertex3);
            result &= (Distance(vertex2, vertex3) + Distance(vertex3, vertex1)) > Distance(vertex1, vertex2);
            result &= (Distance(vertex3, vertex1) + Distance(vertex1, vertex2)) > Distance(vertex2, vertex3);
            return result;
        }
        public double Perimeter()
        {
            return Math.Round(Distance(vertex1, vertex3) + Distance(vertex2, vertex3) + Distance(vertex3, vertex2));
        }

        public double Square()
        {
         
            double semiPerimeterTriangle = Perimeter() / 2;

            return Math.Round(Math.Sqrt(semiPerimeterTriangle * (semiPerimeterTriangle - Distance(vertex1, vertex3) * 
                                        (semiPerimeterTriangle - Distance(vertex2, vertex3) * 
                                        (semiPerimeterTriangle - Distance(vertex3, vertex2))))));
        }

        public void Print()
        {
            Console.WriteLine($"Vertex 1: {vertex1.ToString()}, vertex 2: {vertex2.ToString()}, " +
                    $"vertex 3: {vertex3.ToString()}, perimeter {Perimeter()}, square {Square()}");
        }

        // *Print the triangle with vertex which is the closest to origin (0,0)
        public List<double> TriangleClosestOrigin()
        {
            List<double> dist = new List<double>();
            dist.Add(this.Distance(this.Vertex1, new Point(0, 0)));
            dist.Add(this.Distance(this.Vertex2, new Point(0, 0)));
            dist.Add(this.Distance(this.Vertex3, new Point(0, 0)));
            return dist;
        }
    }
}
