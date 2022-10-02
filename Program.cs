using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlobodeniukHW8
{
    internal class Program
    {
        private static void InputShapes(List<Shape> shape)
        {
            int count = 10;
            int id;
            double lenth;
            for (int i = 0; i < count; i++)
            {
                a1:
                try
                {
                    Console.WriteLine("Enret shape: '1' for circule or '2' for square");
                    id = Convert.ToInt32(Console.ReadLine());

                    switch (id)
                    {
                         case 1:
                            {
                                Console.WriteLine("Enter the radius of the circle: ");
                                lenth = Convert.ToInt32(Console.ReadLine());
                                shape.Add(new Circle(lenth, nameof(Circle)));
                                break;
                            }

                         case 2:
                            {
                                Console.WriteLine("Enter the side of the square: ");
                                lenth = Convert.ToInt32(Console.ReadLine());
                                shape.Add(new Square(lenth, nameof(Square)));
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("You need to choose some shape!");
                                goto a1;
                            }
                    }
                 
                }
                catch (FormatException)
                {
                    Console.WriteLine("Wrong format");
                    goto a1;
                }
            }
        }

        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            InputShapes(shapes);

            foreach (var shape in shapes)
            {
                shape.GetArea();
                shape.GetPerimeter();
                shape.Print();

             
            }

            double max = 0;
            string name = String.Empty;

            foreach (var shape in shapes)
            {
                if (shape.Perimeter > max)
                {
                    max = shape.Perimeter;
                    name = shape.Name;
                }
            }
            Console.WriteLine("************************************");
            Console.WriteLine("Name is: {0} with max perimetr: {1}", name, max);


            Console.WriteLine("************************************");
            Console.WriteLine("Sort shapes");
            shapes.Sort();

            foreach (var shape in shapes)
            {
                shape.Print();
            }

        }
    }
}