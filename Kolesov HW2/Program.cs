using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASKS2
{
    internal class Program
    {
        enum TestCaseStatus
        {
            Pass,
            Fail,
            Blocked,
            WP,
            Unexecuted
        }

        struct Rgb
        {
            public byte r;
            public byte g;
            public byte b;

            public Rgb (byte r, byte g, byte b)
            {
                this.r = r; 
                this.g = g;
                this.b = b;

            }

            public override string ToString()
            {
                return String.Format($"{r} {g} {b}"); 
            }

        }

        enum HTTPError
        {
           Bad_Request = 400,
           Unauthorized,
           Payment_Required,
           Forbidden,
           Not_Found,
           Method_Not_Allowed,
           Not_Acceptable,
           Proxy_Authentication_Required,
        }

        struct Dog
        {
            public string name;
            public string mark;
            public int age;


            public void InfoInput()
            {
                Console.WriteLine("What is your dog's name?");
                name = Console.ReadLine();
                Console.WriteLine("What is your dog's mark?");
                mark = Console.ReadLine();
                Console.WriteLine("What is your dog's age?");
                age = Convert.ToInt32(Console.ReadLine());
            }

            public override string ToString()
            {
                return String.Format($"{name} {mark} {age}");
            }
        }

        static void Main(string[] args)
        {

            //TASKS
            //task 1

            uint day = Convert.ToUInt32(Console.ReadLine());
            uint mounth = Convert.ToUInt32(Console.ReadLine());


            Console.WriteLine($"Day = {(day < 31 && day > 0 ? day : 0)} Mounth = {(mounth < 12 && mounth > 0 ? mounth : 0)}");
            Console.ReadKey();



            //task 2

            double num = Convert.ToDouble(Console.ReadLine());
            int digit = (int)num;
            int digit2 = (int)(num * 10);

            double num1 = num * 10 % (digit * 10);
            double num2 = num * 100 % (digit2);

            Console.WriteLine($"{(int)num1} + {(int)num2} = {(int)num1 + (int)num2}");
            Console.ReadKey();


            //task 3

            int h = Convert.ToInt32(Console.ReadLine());
            string timeOfDay = (h > 6 && h < 12) ? "Good morning" : (h > 12 && h < 18) ? "Good afternoon" : (h > 18 && h < 24) ? "Good evening" : (h > 0 && h < 6) ? "Good night" : "Error";
            Console.WriteLine(timeOfDay);
            Console.ReadKey();


            //task 4

            TestCaseStatus test1Status = TestCaseStatus.Pass;
            Console.WriteLine(test1Status);
            Console.ReadKey();

            //task 5

            Rgb white = new Rgb(255, 255, 255);
            Console.WriteLine($"White = {white}");
            Rgb black = new Rgb(255, 255, 255);
            Console.WriteLine($"Black = {black}");
            Console.ReadKey();

            //HW task 1


            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());

            string result = (a >= -5 && a <= 5 && b >= -5 && b <= 5 && c >= -5 && c <= 5) ? "True " : "False";
            Console.WriteLine(result);
            Console.ReadKey();

            //HW task 2

            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int z = Convert.ToInt32(Console.ReadLine());

            int max = Math.Max(x, Math.Max(y, z));
            int min = Math.Min(x, Math.Min(y, z));

            Console.WriteLine($"Max = {max} Min = {min}");
            Console.ReadKey();

            //HW task 3

            int numError = Convert.ToInt32(Console.ReadLine());         
            var textError = (HTTPError)numError;
            Console.WriteLine(textError);
            Console.ReadKey();

            //HW task 4

            Dog myDog;
            myDog = new Dog();
            myDog.InfoInput();
            Console.WriteLine(myDog);
            Console.ReadKey();


        }
    }
}
