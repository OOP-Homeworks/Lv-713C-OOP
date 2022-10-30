using System.Collections.Generic;
namespace HW8_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter shape: Circle or Square");
                string shapeName = Console.ReadLine();
                if (shapeName == "Circle")
                {
                    Console.Write("Enter data: ");
                    double circleData = Convert.ToDouble(Console.ReadLine());
                    shapes.Add(new Circle(shapeName, circleData));
                }
                else if (shapeName == "Square")
                {
                    Console.Write("Enter data: ");
                    double squareData = Convert.ToDouble(Console.ReadLine());
                    shapes.Add(new Square(shapeName, squareData));
                }
                else
                {
                    Console.Write("Error, try again! ");
                }
            }
            Console.WriteLine(" ");
            Console.WriteLine("***************");
            Console.WriteLine(" ");
            foreach (Shape shape in shapes)
            {
                if (shape.Name == "Square")
                {
                    Console.WriteLine($"Name shape: {shape.Name}");
                    Console.WriteLine($"Perimeter: {shape.Perimeter()}");
                    Console.WriteLine($"Area: {shape.Area()}");
                    Console.WriteLine("_______");
                }
                else
                {
                    Console.WriteLine($"Name shape: {shape.Name}");
                    Console.WriteLine($"Perimeter: {shape.Perimeter()}");
                    Console.WriteLine($"Area: {shape.Area()}");
                    Console.WriteLine("_______");
                }
            }
            Console.WriteLine(" ");
            Console.WriteLine("***************");
            Console.WriteLine(" ");
            Shape lagestPerimeter = shapes[0];
            foreach (Shape shape in shapes)
            {
                if (shape.Perimeter() > lagestPerimeter.Perimeter())
                {
                    lagestPerimeter = shape;
                }
            }
            Console.WriteLine($"Lagest perimeter: Shape: {lagestPerimeter.Name}, perimeter: {lagestPerimeter.Perimeter()}");
            Console.WriteLine(" ");
            Console.WriteLine("***************");
            Console.WriteLine(" ");
            Console.WriteLine("Sort for Area");
            shapes.Sort();
            foreach (Shape shape in shapes)
            {
                Console.WriteLine($"Shape: {shape.Name}, Area: {shape.Area()}");
            }
        }
    }
}