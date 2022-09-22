using System;
using System.Collections.Generic;

namespace Marichka2003_Homework_6
{
    class Program
    {
        public static void Output(List<int> numbers)
        {
            foreach (var item in numbers)
            {
                Console.Write($"{item} ");
            }
        }
        static void Main(string[] args)
        {
        start:
            try {
                bool isTrue = true;
                Console.Write("Enter the start number : ");
                int startNumber = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the end number : ");
                int endNumber = Convert.ToInt32(Console.ReadLine());
                do
                {
                    if (endNumber < startNumber || endNumber < startNumber + 10)
                    {
                        Console.Write("Enter the end number : ");
                        endNumber = Convert.ToInt32(Console.ReadLine());
                    }
                    else
                    {
                        isTrue = false;
                    }
                } while (isTrue);

                List<int> numbers = new List<int>();
                int number;
                bool ifTrue = true;
                int i = 0;
                numbers.Add(startNumber);


                while (ifTrue)
                {
                    try
                    {
                        for (; i < 10; i++)
                        {
                            Console.Write("Enter the 10 number more then previous: ");
                            number = Convert.ToInt32(Console.ReadLine());
                            if (number > startNumber && number < endNumber)
                            {
                                startNumber = number;
                            }
                            else
                            {
                                Console.WriteLine("Enter the number more then startNumber : ");
                                Output(numbers);


                                Console.Write("\nEnter the number more then last in this list : ");
                                number = Convert.ToInt32(Console.ReadLine());
                            }
                            if (i == 9)
                            {
                                ifTrue = false;
                            }
                            numbers.Add(number);
                        }
                        numbers.Add(endNumber);
                    }

                    catch
                    {
                        Console.WriteLine("No int number");
                    }

                    Output(numbers);
                    Console.WriteLine();
                }
            }
            catch (FormatException exception)
            {
                Console.WriteLine(exception.Message);
                goto start;
            }
        }
    }
}
