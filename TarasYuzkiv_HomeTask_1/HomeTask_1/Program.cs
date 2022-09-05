using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1

            Console.Write("Enter the side value a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a <= 0)
            {
                Console.WriteLine("Value must be only positive!");
            }
            else
            {
                int areaSquare = a * a;
                int perimetrSquare = (a + a) * 2;

                Console.WriteLine("Area of Square = " + areaSquare + "\n" + "Perimetr of Square = " + perimetrSquare);
            }

            //Task 2

            Console.WriteLine("What is your name? ");
            string name = Console.ReadLine();
            Console.WriteLine($"How old are you, {name}?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Name: " + name + "\n" + "Age: " + age);

            //Task 3

            Console.Write("Enter the radius of a circle: ");
            double r = Convert.ToDouble(Console.ReadLine());

            double l = 2 * Math.PI * r;
            double s = Math.PI * r * r;
            double volume = 4f/3f * Math.PI * r * r * r;

            Console.WriteLine($"Lenght = " + Math.Round(l, 3) + "\n" 
                                + "Area = " + Math.Round(s, 3) + "\n" 
                                + "Volume = " + Math.Round(volume, 3));
        }
    }
}
