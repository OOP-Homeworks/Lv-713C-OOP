using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShavronskyyHW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetSquare();
            GetCircle();
            GetPersonInfo();
        }

        public static void GetSquare()
        {
            Console.WriteLine("Enter length of the square");
            int squareSide = Convert.ToInt32(Console.ReadLine());
            int perimeter = 4 * squareSide;
            double area = Math.Pow(squareSide, 2);
            Console.WriteLine("Perimeter: {0}\nArea: {1}", perimeter, area);
        }
        public static void GetCircle()
        {
            const double PI = 3.14159;

            Console.WriteLine("Enter radius of circle");
            double circleRadius = Convert.ToDouble(Console.ReadLine());
            double length = 2 * PI * circleRadius;
            double area = PI * Math.Pow(circleRadius, 2);
            double volume = (4 / 3) * PI * Math.Pow(circleRadius, 3);
            Console.WriteLine("length is:{0}\narea is:{1}\nvolume is:{2}", length, area, volume);
        }
        public static void GetPersonInfo()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("How old are you, {0}?", name);
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}, you are {1} years old", name, age);

        }
    }
}
