using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ShokunHW3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1

            {
                Console.WriteLine("Enter some text");
                string text = Console.ReadLine();
                int count = 0;
                for (int i = 0; i < text.Length; i++)
                {
                    switch (text[i].ToString())
                    {
                        case "a":
                        case "o":
                        case "i":
                        case "e":
                            count++;
                            break;
                    }
                }
                Console.WriteLine($"Characters ‘a’, ’o’, ’i’, ’e’  in this text: { count}");
            }

            //Task 2 

            {
                Console.WriteLine("Enter number of the month");
                int month = Convert.ToInt32(Console.ReadLine());
                switch (month)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        Console.WriteLine("In the month 31 days");
                        break;
                    case 2:
                        Console.WriteLine("Enter the year");
                        int year = Convert.ToInt32(Console.ReadLine());
                        if (DateTime.IsLeapYear(year))
                        {
                            Console.WriteLine("In the month 29 days");
                        }
                        else
                        {
                            Console.WriteLine("In the month 28 days");
                        }
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        Console.WriteLine("In the month 30 days");
                        break;
                }
            }

            //Task 3

            {
                Console.WriteLine("enter 10 integer numbers");
                int[] nums = new int[10];
                int sum = 0;
                int prod = 1;
                bool positive = true;
                for (int i = 0; i < nums.Length; i++)
                {
                    nums[i] = Convert.ToInt32(Console.ReadLine());
                }
                for (int i = 0; i < 5; i++)
                {
                    if (nums[i] > 0)
                    {
                        positive = true;
                    }
                    else
                    {
                        positive = false;
                        break;
                    }
                }
                if (positive == true)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        sum += nums[i];
                    }
                    Console.WriteLine($"Sum of firs 5 elements: {sum}");
                }
                else
                {
                    for (int i = 5; i < nums.Length; i++)
                    {
                        prod *= nums[i];
                    }
                    Console.WriteLine($"Product of last 5 elements: {prod}");
                }
            }
            Console.ReadKey();
        }
    }
}
