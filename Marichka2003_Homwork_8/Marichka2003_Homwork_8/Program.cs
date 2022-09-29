using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marichka2003_Homwork_8
{
    class Program
    {
        static void Main(string[] args)
        {
            const int quantityShapes = 10;
            List<Shape> shapes = new List<Shape>(quantityShapes);

            bool ifTrue = true;


            for (int i = 0; i < quantityShapes; i++)
            {
                start:
                Console.Write("Enter the name of shapes (circle or square): ");
                string nameOfShapes = Console.ReadLine();
                if (nameOfShapes == "circle")
                {
                startR:
                    try
                    {
                        Console.Write("Enter the radius: ");
                        double radiusCircle = Convert.ToDouble(Console.ReadLine());
                        if (radiusCircle <= 0)
                        {
                            goto startR;
                        }

                        shapes.Add(new Circle("circle", radiusCircle));
                        ifTrue = false;
                    }
                    catch
                    {
                        Console.WriteLine("Invalid number!");
                        goto startR;
                    }
                   
                }
                if (nameOfShapes == "square")
                {
                startS:
                    try
                    {
                        Console.Write("Enter the side: ");
                        double sideSquare = Convert.ToDouble(Console.ReadLine());
                        if (sideSquare <= 0)
                        {
                            goto startS;
                        }

                        shapes.Add(new Square("square", sideSquare));
                        ifTrue = false;
                    }
                    catch
                    {
                        Console.WriteLine("Invalid number!");
                        goto startS;
                    }
                   
                }
                if (ifTrue)
                {
                    Console.WriteLine("There isn't such shapes!");
                    goto start;
                }
            }
            
            Console.Clear();
            foreach (var i in shapes)
            {
                i.Print();
            }
            Console.WriteLine();

            Shape largestPerimeter = shapes[0];
            foreach (Shape shape in shapes)
            {
                if (shape.Perimeter() > largestPerimeter.Perimeter())
                { 
                    largestPerimeter = shape; 
                }
            }

            Console.WriteLine($"Finding shape with the largest perimeter: {largestPerimeter.Name} , his perimeter is: " +
                $"{Math.Round(largestPerimeter.Perimeter(),2)}");
            Console.WriteLine();

            Console.WriteLine("Sort shapes: ");
            shapes.Sort();
            foreach (Shape shape in shapes)
            {
                Console.WriteLine($"{shape.Name} with area {Math.Round(shape.Area()),2}");
            }
        }
    }
}
