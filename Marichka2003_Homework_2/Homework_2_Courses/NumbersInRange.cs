using System;

namespace Homework_2_Courses
{
    class NumbersInRange
    {
        public void RangeOfNumber()
        {
            Console.WriteLine("First task");
            Console.Write("Enter a: ");
            float a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter b: ");
            float b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter c: ");
            float c = Convert.ToInt32(Console.ReadLine());
            if (a > -5 && a < 5 && b > -5 && b < 5 && c > -5 && c < 5)
            {
                Console.WriteLine("They all in range [-5:5]");
            }
            else
            {
                Console.WriteLine("Some number isn't in the range [-5:5]");
            }
        }
    }
}
