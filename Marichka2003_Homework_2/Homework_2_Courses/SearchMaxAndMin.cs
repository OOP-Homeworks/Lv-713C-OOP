using System;
using System.Collections.Generic;

namespace Homework_2_Courses
{
    class SearchMaxAndMin
    {
        
        public void MaxAndMin()
        {
            Console.WriteLine("Second task");
            Console.Write("Enter first number: ");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int second = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter third number: ");
            int third = Convert.ToInt32(Console.ReadLine());

            List<int> numbers = new List<int>();
            numbers.Add(first);
            numbers.Add(second);
            numbers.Add(third);

            int min = numbers[0];
            int max = numbers[0];
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            Console.WriteLine($"Min number is {min}");
            Console.WriteLine($"Max number is {max}");
        }
    }
}
