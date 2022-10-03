///////////// Task1

using System;

class Program
{
    static void Main(string[] args)
    {
        string input;
        int countA = 0;
        int countO = 0;
        int countI = 0;
        int countE = 0;
        Console.WriteLine("Enter your string");
        input = Console.ReadLine();
        for (int i = 0; i < input.Length; i++)
        {
            switch (input[i])
            {
                case 'a': countA++; break;
                case 'o': countO++; break;
                case 'i': countI++; break;
                case 'e': countE++; break;
            }

        }
            Console.WriteLine($"This string contains {countA} 'a', {countO} 'o', {countI} 'i' and {countE} 'e' symbols");
        Console.ReadKey();

    }
}

///////////Task2
using System;

class Program
{
    static void Main(string[] args)
    {
        int month;
        Console.WriteLine("Please enter the number of the month");
        month = Convert.ToInt32(Console.ReadLine());
        switch (month)
        {
            case (1):
            case (3):
            case (5):
            case (7):
            case (8):
            case (10):
            case (12):
                Console.WriteLine("This month has 31 day");
                break;
            case (4):
            case (6):
            case (9):
            case (11):
                Console.WriteLine("This month has 30 days");
                break;
            case (2):
                Console.WriteLine("Please enter the year");
                int year = Convert.ToInt32(Console.ReadLine());
                bool leap = false;
                if (year % 4 == 0)
                    leap = true;
                if ((year % 100 == 0) && (year % 400 != 0))
                    leap = false;
                if (leap)
                    Console.WriteLine("This month has 29 days");
                else
                    Console.WriteLine("This month has 28 days");
                break;
            default:
                Console.WriteLine("This value is not correct");
                break;
        }


        //        ////////////////Task 3
        using System;
class Program
    {
        static void Main(string[] args)
        {
            int k = 0;
            int sum = 0;
            int prod = 1;
            bool positive = true;
            int[] array = new int[10];
            Console.WriteLine("Enter 10 integer numbers");
            while (k < 10)
            {
                array[k] = Convert.ToInt32(Console.ReadLine());
                k++;
            }
            for (k = 0; k < 5; k++)
            {
                if (array[k] > 0)
                {
                    positive = true;
                }
                if (array[k] < 0)
                {
                    positive = false;
                    break;
                }
            }
            if (positive)
            {
                for (k = 0; k < 5; k++)
                { sum += array[k]; }
                Console.WriteLine($"The result of sum is {sum}");
            }
            if (positive == false)
            {
                for (k = 5; k < 10; k++)
                { prod *= array[k]; }
                Console.WriteLine($"The result of product is {prod}");
            }

        }
    }

