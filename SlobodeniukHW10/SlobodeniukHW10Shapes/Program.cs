using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();

            shapes.Add(new Circle(2, nameof(Circle)));
            shapes.Add(new Circle(4, nameof(Circle)));
            shapes.Add(new Circle(1, nameof(Circle)));
            shapes.Add(new Square(2, nameof(Square)));
            shapes.Add(new Square(8, nameof(Square)));
            shapes.Add(new Square(1, nameof(Square)));
            
            

            foreach (Shape shape in shapes)
            {
                shape.GetArea();
                shape.GetPerimeter();

            }

            Console.WriteLine("Find and write into the file shapes with area from range [10,100]:");
            var areasRange = shapes.Where(n => n.Area > 10 && n.Area < 100);

            foreach (var area in areasRange)
            {
                Console.WriteLine("This area has been written to a new file: " + area.Area);
                using (StreamWriter sw = new StreamWriter(@"D:\NewListArea.txt", true, System.Text.Encoding.Default))
                {
                    sw.WriteLine(area.Area);
                }

            }

            Console.WriteLine();

            Console.WriteLine("Find and write into the file shapes which name contains letter 'a':");
            var shapeA = shapes.Where(n => n.Name.ToLower().Contains("a"));

            foreach (var a in shapeA)
            {
                Console.WriteLine("This name has been written to a new file: " + a.Name);
                using (StreamWriter sw = new StreamWriter(@"D:\ShapesWithA.txt", true, System.Text.Encoding.Default))
                {
                    sw.WriteLine(a.Name);
                }
            }

            Console.WriteLine();

            Console.WriteLine("Find and remove from the list all shapes with perimeter less then 5.");
            shapes.RemoveAll(n => n.Perimeter < 5);
            Console.WriteLine("New shape's list: ");

            foreach (var n in shapes)
            {
                Console.WriteLine("Name: {0} ; Perimeter: {1}", n.Name, n.Perimeter);
            }

            Console.ReadKey();

        }
    }
}