using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_8
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shape = new List<Shape>();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter type: Circle or Square!");
                string typeString = Console.ReadLine();
                if (typeString =="Circle")
                {
                    Console.WriteLine("Enter name of Circle: ");
                    string circleName = Console.ReadLine();
                    Console.WriteLine("Enter radius: ");
                    int circleRadius = Convert.ToInt32(Console.ReadLine());

                    shape.Add(new Circle(circleName, circleRadius));
                }
                else if (typeString == "Square")
                {
                    Console.WriteLine("Enter name: ");
                    string squareName = Console.ReadLine();
                    Console.WriteLine("Enter side of Squere: ");
                    int sideSquere = Convert.ToInt32(Console.ReadLine());

                    shape.Add(new Square(squareName, sideSquere));
                }
                else
                {
                    Console.WriteLine("Not found shape!");
                }

            }

            foreach (Shape c in shape)
            {
                c.Print();
            }

            var maxSelectedItem = shape.OrderByDescending(x => x.Perimetr()).First();

            Console.WriteLine($"\nMax value of Perimetr: {maxSelectedItem.name}: {maxSelectedItem.Perimetr()}");

            shape.Sort();

            Console.WriteLine("\n_____________Sorted_____________");
            foreach (Shape area in shape)
            {
                Console.WriteLine(area.Area());
            }
        }
    }
}
