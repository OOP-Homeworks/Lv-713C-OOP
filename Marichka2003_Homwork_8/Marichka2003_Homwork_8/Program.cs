using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marichka2003_Homwork_8
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter w = new StreamWriter("Shapes.txt"))
            {

            }
            
            const int quantityShapes = 6;
            List<Shape> shapes = new List<Shape>(quantityShapes);

            List<Shape> NewShape = new List<Shape>();
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

            var areaOfShapes = from shape in shapes
                                     where (shape.Area() >= 10) && (shape.Area() <= 100)
                                     select shape;
            using (StreamWriter w = new StreamWriter("Shapes.txt", true))
            {
                w.WriteLine($"Area in range [10:100] :");
                foreach (Shape shape in areaOfShapes)
                {
                    w.WriteLine($"{shape.Name} with area {Math.Round(shape.Area(), 2)} and perimeter {Math.Round(shape.Perimeter(),2)}");
                }
                
            }
            Console.Clear();

            var nameWithA = from shape in shapes
                               where (shape.Name.ToLower().Contains('a'))
                               select shape;
            using (StreamWriter w = new StreamWriter("Shapes.txt", true))
            {
                w.WriteLine("Shapes which name contains letter 'a':");
                foreach (Shape shape in nameWithA)
                {
                    w.WriteLine($"{shape.Name}, with area {Math.Round(shape.Area()),2} and perimeter {Math.Round(shape.Perimeter()),2}");                   
                }
            }

            foreach (var i in shapes)
            {
                i.Print();
            }
            Console.WriteLine();

            var perimeterOfShape = from shape in shapes
                                   where shape.Perimeter() < 5
                                   select shape;
            
            Console.WriteLine("Removed : ");
            foreach (Shape shape in perimeterOfShape)
            {
                NewShape.Add(shape);
            }
            
            foreach (Shape shape in NewShape)
            {
                Console.WriteLine($"{shape.Name} with perimeter {Math.Round(shape.Perimeter()),2}\n");
            }
            Console.WriteLine("List without removed element: ");

            foreach (var shape in NewShape)
            {
                shapes.Remove(shape);
            }

            foreach (Shape shape in shapes)
            {
                Console.WriteLine($"{shape.Name} with perimeter {Math.Round(shape.Perimeter()),2}");
            }
        }
        
    }
}
