using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShokunHW9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Shape> shapes = new List<Shape>();
            Console.WriteLine("Enter data of 6 different shapes");
            int typeOfShape = 0;
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Enter 1 if your shape is a square or 0 if a circle");
                typeOfShape = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter name of your shape");
                string name = Console.ReadLine();
                if (typeOfShape == 1)
                {
                    Console.WriteLine($"Enter side of the {name}");
                    double side = double.Parse(Console.ReadLine());
                    shapes.Add(new Square(name, side));
                }
                if (typeOfShape == 0)
                {
                    Console.WriteLine($"Enter radius of the {name}");
                    double radius = double.Parse(Console.ReadLine());
                    shapes.Add(new Circle(name, radius));
                }
            }

            IEnumerable<Shape> shapesWithArea10To100 = shapes.Where(shape => shape.Area() >= 10 || shape.Area() <= 100);
            
            using (StreamWriter sw = new StreamWriter(@"D:\AreaFrom10To100.txt", false, System.Text.Encoding.Default))
            {
                foreach(Shape shape in shapesWithArea10To100)
                {
                    sw.WriteLine($"Shape {shape.Name} with area {Math.Round(shape.Area(), 1)}");
                }
            }

            IEnumerable<Shape> shapesWithA = shapes.Where(shape => shape.Name.ToLower().Contains("a"));

            using (StreamWriter sw = new StreamWriter(@"D:\shapesWhithA.txt", false, System.Text.Encoding.Default))
            {
                foreach(Shape shape in shapesWithA)
                {
                    sw.WriteLine($"Shape {shape.Name} contains letter 'a'.");
                }
            }

            IEnumerable<Shape> shapesPerimeter = shapes.Where(shape => shape.Perimeter() >= 5);

            foreach(Shape shape in shapesPerimeter)
            {
                Console.WriteLine($"Shape {shape.Name} with perimeter: {Math.Round(shape.Perimeter())}");
            }


                 
            Console.ReadKey();

        }
    }
}
