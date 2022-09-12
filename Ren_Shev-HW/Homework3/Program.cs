using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // hw 1
            Console.WriteLine("Enter some string: ");
            string words = Console.ReadLine().ToLower();
            CountVowelsLetter(words);

            // hw 2
            Console.WriteLine("Enter the months of numbers: ");
            int monthOfNumbers = Convert.ToInt32(Console.ReadLine());

            int currentYear = DateTime.Now.Year;
            int daysOfMonth = DateTime.DaysInMonth(currentYear, monthOfNumbers);

            Console.WriteLine("{0} number of month contains {1} day", monthOfNumbers, daysOfMonth);

            // hw 3
            const int maxLength = 10;
            const int halfLength = (maxLength / 2);

            int[] numbers = CreateNewArray(maxLength);

            DisplaySumPositiveNumbers(numbers, halfLength);

            Console.ReadKey();
        }

       static void CountVowelsLetter(string message)
        {
 
            int countA = 0;
            int countO = 0;
            int countE = 0;
            int countI = 0;

            foreach (char letter in message)
            {
                switch(letter)
                {
                    case 'a': countA++; break;
                    case 'e': countE++; break;
                    case 'o': countO++; break;
                    case 'i': countI++; break;      
                }
                
            }
         Console.WriteLine("String {0} contains 'e' {1}, 'o' {2}, 'i' {3}, 'a' {4} ", message, countE, countO, countI, countA); 

        }

        static void DisplaySumPositiveNumbers(int[] numbers, int maxIndex)
        {   int sum = 0;

            for (int i = 0; i < maxIndex; i++)
            {
                if (numbers[i] < 0)
                {
                    sum = 0;
                    DisplaySumMultiplyNumbers(numbers, maxIndex);
                    break;
                }

                    sum += numbers[i];
            }

           if  (sum > 0) Console.WriteLine("Sum of the first 5 elements is {0}", sum);

        }
        static void DisplaySumMultiplyNumbers(int[] numbers, int startIndex)
        {
            int sum = 1;

            for (int i = startIndex; i < numbers.Length; i++)
            {
                sum *= numbers[i];
            }
            Console.WriteLine("Sum of the last 5 elements is {0}", sum);
        }
        static int[] CreateNewArray(int length)
        {
            const string MESSAGE = "Enter {0} integer number";

            int sum = 1;

            int[] numbers = new int[length];

            do
            {
                Console.WriteLine(MESSAGE, sum);
                int number = Convert.ToInt32(Console.ReadLine());
                numbers[sum - 1] = number;
                sum++;
            }
            while (sum <= 10);

            return numbers;
        }
    }
}
