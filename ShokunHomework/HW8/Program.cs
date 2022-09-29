using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShokunHW8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Shape> shapes = new List<Shape>();
            Console.WriteLine("Enter data of 10 different shapes");
            int typeOfShape = 0;
            for (int i = 0; i < 10; i++)
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
                if(typeOfShape == 0)
                {
                    Console.WriteLine($"Enter radius of the {name}");
                    double radius = double.Parse(Console.ReadLine());
                    shapes.Add(new Circle(name, radius));
                }
            }
            
            foreach (Shape shape in shapes)
            {
                Console.WriteLine($"The name of shape is {shape.Name}\nArea: {Math.Round(shape.Area(), 1)}\nPerimeter: {Math.Round(shape.Perimeter(), 1)}\n");
            }

            string nameOfShapeWithLargestPerimeter = "";
            double largestPerimeter = 0;
            for(int i = 0; i < shapes.Count; i++)
            {
                if (shapes[i].Perimeter() > largestPerimeter)
                {
                    largestPerimeter = shapes[i].Perimeter();
                    nameOfShapeWithLargestPerimeter = shapes[i].Name;
                }
            }

            Console.WriteLine($"Name of shape with the largest perimeter is {nameOfShapeWithLargestPerimeter}");

            shapes.Sort();
            Console.WriteLine("Shapes sort by Area");
            foreach(Shape shape in shapes)
            {
                Console.WriteLine($"The shape {shape.Name}, area: {Math.Round(shape.Area(), 1)}");
            }

            Console.ReadKey();

        }
    }
}
