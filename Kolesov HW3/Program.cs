using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASKS3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //task 1

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = 0;

            for (; a < b; a++)
            {
                if (a % 3 == 0)
                {
                    c++;
                }
            }
            Console.WriteLine(c);

            //task 2

            string str = Console.ReadLine();

            for (int i = 1; i < str.Length; i += 2)
            {
                Console.WriteLine(str[i]);
            }

            //task 3

            Console.Write("Enter the name of the drink: ");
            string drink = Console.ReadLine();

            switch (drink.ToLower())
            {

                case "coffee":
                    Console.WriteLine($"Drink = {drink} Price = 2$");
                    break;
                case "jea":
                    Console.WriteLine($"Drink = {drink} Price = 1.5$");
                    break;
                case "juice":
                    Console.WriteLine($"Drink = {drink} Price = 1$");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;

            }

            //task 4

            int sum = 0;
            int i = 0;

            int a = Convert.ToInt32(Console.ReadLine());

            while (a > 0)
            {

                i++;
                sum += a;
                a = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(sum / i);

            //task 5 

            int year = Convert.ToInt32(Console.ReadLine());

            if (year % 4 == 0 || (year % 100 == 0 && year % 400 == 0))
            {
                Console.WriteLine("The year is not a leap year");

            }
            else
            {
                Console.WriteLine("The year is a leap year");
            }

            //task 6

            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            while (num != 0)
            {
                sum = sum + num % 10;
                num = num / 10;
            }

            Console.WriteLine(sum);

            //task 7

            int num = Convert.ToInt32(Console.ReadLine());
            bool test;

            while (num != 0)
            {
                int x = num % 10;
                num = num / 10;

                if (x % 2 != 0)
                {
                    test = true;
                }
                else
                {
                    test = false;
                }
                Console.WriteLine($"Is the number {x} odd? {test}");
            }

            //HW1


            string str = Console.ReadLine();
            int a = 0, o = 0, i = 0, e = 0;

            foreach (char symbol in str)
            {
                if (symbol == 'a')
                {
                    a++;
                }
                else if (symbol == 'o')
                {
                    o++;
                }
                else if (symbol == 'i')
                {
                    i++;
                }
                else if (symbol == 'e')
                {
                    e++;
                }

            }
            Console.WriteLine($"a = {a} o = {o} i = {i} e = {e}");
            Console.ReadKey();

            //HW2

            int numOfMonth = Convert.ToInt32(Console.ReadLine());

            try
            {
                int daysInMonth = System.DateTime.DaysInMonth(2022, numOfMonth);
                Console.WriteLine(daysInMonth);
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error");
            }

            Console.ReadKey();

            //HW3

            int[] arr = new int[10];
            bool check = true;
            int x = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());

                if(arr[i] <= 0)
                {
                    check = false;
                }
            }
            
            if(check == true)
            {
                for(int i = 0; i < arr.Length-5; i++)
                {
                    x = x + arr[i];
                }
                
            }
            else
            {
                x = arr[5];
                for(int i = 6; i < arr.Length; i++)
                {
                    x = x * arr[i];
                }
                
            }


            Console.WriteLine(x);




        }
    }
}
