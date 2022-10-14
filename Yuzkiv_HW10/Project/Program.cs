using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_10
{
    public class Program
    {
        static void Main(string[] args)
        {
            Point p1, p2, p3, p4, p5, p6, p7, p8, p9;
            p1 = new Point(1, 5);
            p2 = new Point(4, 1);
            p3 = new Point(1, 1);

            p4 = new Point(1, 4);
            p5 = new Point(4, 2);
            p6 = new Point(1, 1);

            p7 = new Point(1, 6);
            p8 = new Point(4, 3);
            p9 = new Point(1, 0);

            List<Triangle> triangle = new List<Triangle>();
      
            triangle.Add(new Triangle(p1, p2, p3));
            triangle.Add(new Triangle(p4, p5, p6));
            triangle.Add(new Triangle(p7, p8, p9));

            foreach (Triangle item in triangle)
            {
                item.Side1 = item.Distance(item.Vertex1, item.Vertex2);
                item.Side2 = item.Distance(item.Vertex2, item.Vertex3);
                item.Side3 = item.Distance(item.Vertex3, item.Vertex1);
                item.Print();
            }
        }
    }
}
