using System;
using System.Linq;

namespace SuberliakHw2._2
{
    internal class Program
    {
        //TASK2: Read 3 integer numbers and output max and min of them.
        static void Main(string[] args)
        {
            int[] numberArray = new int[3];

            try 
            
            {
                for (int i = 0; i < numberArray.Length; i++)

                {
                    Console.Write("Please add your int number: ");
                    numberArray[i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine($"\nmax int number is {numberArray.Max()} and min int number is {numberArray.Min()}");
            }

            catch (FormatException)
            {
                Console.WriteLine("\nPlease add correct number!");
            }          

        }
    }
}
