using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShokunHomework1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1

            Console.Write("Please write side length of a square: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("To calculate the area of a square, press 1");
            Console.WriteLine("To calculate the perimeter of a square, press 2");
            int pick = Convert.ToInt32(Console.ReadLine());
            if (pick == 1)
            {
                Console.WriteLine($"Area of a squre equals: {a * a}.");
            } 
            else if (pick == 2)
            {
                Console.WriteLine($"Perimeter of a square equals: {4 * a}.");
            } 
            else
            {
                Console.WriteLine($"Area of a squre equals: {a * a}.\nPerimeter of a square equals: {4 * a}.");
            }

            //Task 2

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"How old are you, {name}?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Hello {name}, your age is {age}.");

            //Task 3


            Console.Write("Please, write radius of a circle ");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("To calculate the length - press 1, area - press 2 and volume - press 3");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine($"The length of the circle equals: {2 * Math.PI * r}");
                    break;
                case 2:
                    Console.WriteLine($"The area of the circle equals: {Math.PI * r * r}");
                    break;
                case 3:
                    Console.WriteLine($"The volume of the circle equals: {4 / 3 * Math.PI * r * r * r}");
                    break;
                default:
                    Console.WriteLine($"The length of the circle equals: {2 * Math.PI * r}\nThe area of the circle equals: {Math.PI * r * r}\nThe volume of the circle equals: {4 / 3 * Math.PI * r * r * r}");
                    break;
            }

        }
    }
}
