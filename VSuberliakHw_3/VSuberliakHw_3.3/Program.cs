using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace VSuberliakHw_3._3
{
    internal class Program

        //Enter 10 integer numbers.
        //Calculate the sum of first 5 elements if they are positive or product of last 5 element in the other case.
    {
        static void Main(string[] args)
        {
            
            int[] numbers = new int[10];
            bool calcCase = true;
            int elementsCount = 0;
            int elementsCount2 = 1;

            Console.WriteLine("Enter 10 integer numbers");

            try
            {

                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = Convert.ToInt32(Console.ReadLine());
                }

                for (int i = 0; i < 5; i++)
                {
                    if (numbers[i] >= 0)
                    {
                        elementsCount = elementsCount + numbers[i];
                    }
                    else
                    {
                        for (int a = 5; a < 10; a++)
                        {
                            elementsCount2 = elementsCount2 * numbers[a];
                        }
                        calcCase = false;
                        Console.WriteLine($"Case 2: product of last 5 element is " + elementsCount2);
                    }
                };

                if (calcCase)
                {
                    Console.WriteLine($"Case 1: sum of first positive digits " + elementsCount);
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("Please add only digits");
            }
        }
    }
}
