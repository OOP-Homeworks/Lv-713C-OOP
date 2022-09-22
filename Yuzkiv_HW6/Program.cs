using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6
{
    public class Program
    {
        static int ReadNumber(int start, int end)
        {
            int number;
            try
            {
                number = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {

                throw new ArgumentException("Is not a valid integer.");
            }

            if (number <= start)
            {
                throw new ArgumentOutOfRangeException($"Input must be greater than {start}.");
            }

            if (number >= end)
            {
                throw new ArgumentOutOfRangeException($"Input must be less than {end}.");
            }

            return number;
        }

        static void Main(string[] args)
        {
            int start = 1, end = 100;
            int inputNumber = 0;

            Console.WriteLine("Enter 10 numbers: \n");

            try
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.Write("Enter number [{0}] in range ({1}; {2}): ", i + 1, start, end);
                    int result = ReadNumber(start, end);
                    if(result > inputNumber)
                    {
                        inputNumber = result;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException($"Input must be greater than {result}.");
                    }       
                }
            } 
            catch (Exception e)
            {
                Console.Error.WriteLine("\n-> {0} -> {1}\n", e.GetType(), e.Message);
                Console.ReadLine();
            }
        }
    }
}
