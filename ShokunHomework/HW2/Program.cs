using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShokunHW2
{
    internal class Program
    {

        enum HTTPError
        {
            BadRequest = 400,
            Unauthorized,
            PaymentRequired,
            Forbidden,
            NotFound,
            MethodNotAllowed,
            NotAcceptable,
            ProxyAuthenticationRequired,
            RequestTimeout,
            Conflict,
            Gone
        }

        struct Dog
        {
            public string name;
            public string mark;
            public int age;
            public override string ToString()
            {
                return string.Format($"Dog's name: {name}, mark: {mark}, age: {age}.");
            }
        }

        static void Main(string[] args)
        {

            //Task 1

            Console.WriteLine("Enter three numbers");
            float firstNum = (float) Convert.ToDouble(Console.ReadLine());
            float secondNum = (float) Convert.ToDouble(Console.ReadLine());
            float thirdNum = (float) Convert.ToDouble(Console.ReadLine());

            if (firstNum >= -5 && firstNum <= 5)
            {
                Console.WriteLine($"{firstNum} is in the range [-5.5]");
            }
            else
            {
                Console.WriteLine($"{firstNum} out of the range [-5.5]");
            }

            if (secondNum >= -5 && secondNum <= 5)
            {
                Console.WriteLine($"{secondNum} is in the range [-5.5]");
            }
            else
            {
                Console.WriteLine($"{secondNum} out of the range [-5.5]");
            }

            if (thirdNum >= -5 && thirdNum <= 5)
            {
                Console.WriteLine($"{thirdNum} is in the range [-5.5]");
            }
            else
            {
                Console.WriteLine($"{thirdNum} out of the range [-5.5]");
            }

            //Task 2

            Console.WriteLine("Enter three numbers");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());
            

            if (num1 < num2 && num1 < num3)
            {
                Console.WriteLine($"Min = {num1}");
            }
            else if (num2 < num1 && num2 < num3)
            {
                Console.WriteLine($"Min = {num2}");
            }
            else
            {
                Console.WriteLine($"Min = {num3}");
            }

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine($"Max = {num1}");
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine($"Max = {num2}");
            }
            else
            {
                Console.WriteLine($"Max = {num3}");
            }

            //Task 3

            Console.WriteLine("Enter error code");
            int numOfError = Convert.ToInt32(Console.ReadLine());
            HTTPError error = (HTTPError)numOfError;
            Console.WriteLine($"{numOfError} - {error}");

            //Task 4

            Dog myDog;
            Console.WriteLine("Please enter the Dog's name");
            myDog.name = Console.ReadLine();
            Console.WriteLine("Enter the Dog's mark");
            myDog.mark = Console.ReadLine();
            Console.WriteLine("How old is the dog?");
            myDog.age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(myDog);


            Console.ReadKey();
        }
    }
}
