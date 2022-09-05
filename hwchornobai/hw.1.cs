using System;
using Internal;

namespace hw.task
{
    class Program
    {
        static void Main(string[] args)
        {
            //Homework 1
            Console.WriteLine("Enter length a = ");
            double a = double.Parse(Console.ReadLine());
            double area = a * a;
            double perimeter = 4 * a;
            Console.WriteLine($"Area is = " + area);
            Console.WriteLine($"Perimeter is = " + perimeter);
            Console.ReadLine();

            //Homework 2
            Console.WriteLine("Hello, what is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("How old are you, " + name);
            string age = Console.ReadLine();
            Console.WriteLine("Name is = " + name + "     Age is =      " + age);
            Console.ReadKey();


            //Homework 3
            Console.WriteLine("Enter radius of a circle ");
            double radius = double.Parse(Console.ReadLine());
            double pi = 3.14;
            double length = (2 * pi * radius);
            double area = (pi * radius * radius);
            double volume = (4 / 3 * pi * radius * radius * radius);
            Console.WriteLine("Length is = " + length);
            Console.WriteLine("Area is = " + area);
            Console.WriteLine("Volume is = " + volume);
            Console.ReadLine();

        }
    }
}

