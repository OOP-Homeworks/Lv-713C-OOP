using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace IDovhyiHomework10
{
    public class Triangle
    {
        Point vertex1, vertex2, vertex3;
        public Triangle(Point vertex1, Point vertex2, Point vertex3)
        {
            this.vertex1 = vertex1;
            this.vertex2 = vertex2;
            this.vertex3 = vertex3;
        }
        public double Distance(Point point1, Point point2)
        { 
            return Math.Sqrt(Math.Pow(point1.x-point2.x,2)+ Math.Pow(point1.y-point2.y,2));
        }
        public double Perimeter()
        { 
            double a = Distance(this.vertex1, this.vertex2);
            double b = Distance(this.vertex2, this.vertex3);
            double c = Distance(this.vertex1, this.vertex3);
        return a+b+c;
        }

        public double Square()
        {
            double a = Distance(this.vertex1, this.vertex2);
            double b = Distance(this.vertex2, this.vertex3);
            double c = Distance(this.vertex1, this.vertex3);
            double p = (a + b + c) / 2;
            return Math.Sqrt( p * (p - a) * (p - b) * (p - c));
        }
        public void Print()
        {
            Console.WriteLine($"Triangle with vertices ({vertex1.x},{vertex1.y}) ({vertex2.x},{vertex2.y}) ({vertex3.x},{vertex3.y})");
        }

        public double minDistance()
        {
            double dist1 = Distance(this.vertex1, new Point(0, 0));
            double dist2 = Distance(this.vertex2, new Point(0, 0));
            double dist3 = Distance(this.vertex3, new Point(0, 0));
            if (dist1 < dist2)
                if (dist1 < dist3) return dist1;
                else return dist3;
            else 
                if (dist2 < dist3) return dist2;
                else return dist3;
        }
    }
}
