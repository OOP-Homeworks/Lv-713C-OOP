using System;

namespace SlobodeniukY_HW1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1

            int a;
            Console.WriteLine("Please enter side of square: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Side of square is {0}. Area is {1}. Perimeter is {2}.", a, Math.Pow(a, 2), a*4);
            Console.ResetColor();
            Console.Write("Press any key to close... ");
            Console.ReadKey();

            // Task 2

            string name;
            int age;
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("How old are you, {0}?", name);
            age = Convert.ToInt32(Console.ReadLine());
                if (age < 18)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You are too young for register :(");
                Console.ResetColor();
            }
                else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Successful registration!");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Your name is {0}, you are {1}.", name, age);
                Console.ResetColor();
            }
            Console.Write("Press any key to close... ");
            Console.ReadKey();

            // Task 3

            double r;
            double length;
            double area;
            double volume;
            Console.WriteLine("Please, enter radius of a circule: ");
            r = Convert.ToDouble(Console.ReadLine());
            length = 2 * Math.PI * r;
            area = Math.PI * r * r;
            volume = 4.0 / 3 * Math.PI * r * r * r;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Length of a circule is {0:F2}, area is {1:F2}, volume is {2:F2}.", length, area, volume);
            Console.ResetColor();
            Console.Write("Press any key to close... ");
            Console.ReadKey();
        }
    }
}