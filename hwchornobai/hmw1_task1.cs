using System;

namespace hmw1_tasks1
{
    class Program
    {
        static void Main(string[] args)
        {
            // task 1


            Console.WriteLine("Ведіть число а");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Ведіть число b");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("A+B");
            Console.WriteLine($" A+B =  {a}+{b}={a + b}");
            Console.WriteLine($" A-B =  {a}-{b}={a - b}");
            Console.WriteLine($" A*B =  {a}*{b}={a * b}");
            Console.WriteLine($" A/B =  {a}/{b}={a / b}");
            Console.ReadLine();




            // task 2
            Console.WriteLine("How are you?");
            string answer = Console.ReadLine();
            Console.WriteLine($"You are {answer}");
            Console.ReadLine();


            //Task 3
            Console.WriteLine("Ведіть символ 1 ");
            char symbol1 = char.Parse(Console.ReadLine());
            Console.WriteLine("Ведіть символ 2 ");
            char symbol2 = char.Parse(Console.ReadLine());
            Console.WriteLine("Ведіть символ 3 ");
            char symbol3 = char.Parse(Console.ReadLine());
            Console.WriteLine($"You enter" + "   first char == " + symbol1 + "   second char == " + symbol2 + " 3 char ==" + symbol3);

            Console.ReadKey();

            //Task 4
            Console.WriteLine("Enter integer number =  ");
            double integernum1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter integer number =  ");
            double integernum2 = double.Parse(Console.ReadLine());
            if ((integernum1 > 0) && (integernum2 > 0))
            {
                Console.WriteLine("THIS INTEGER IS TRUE");
            }
            else
            {
                Console.WriteLine("THIS INTEGER ISN'T TRUE");
            }
            Console.ReadLine();

            //Homework 1
            Console.WriteLine("Enter length a = ");
            double a = double.Parse(Console.ReadLine());
            double area = a * a;
            double perimeter = 4 * a;
            Console.WriteLine($"Area is = " + area);
            Console.WriteLine($"Perimeter is = " + perimeter);
            Console.ReadLine();

            //Homework 2
            Console.WriteLine("Hello, what is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("How old are you, " + name);
            string age = Console.ReadLine();
            Console.WriteLine("Name is = " + name + "     Age is =      " + age);
            Console.ReadKey();


            //Homework 3
            Console.WriteLine("Enter radius of a circle ");
            double radius = double.Parse(Console.ReadLine());
            double pi = 3.14;
            double length = (2 * pi * radius);
            double area = (pi * radius * radius);
            double volume = (4 / 3 * pi * radius * radius * radius);
            Console.WriteLine("Length is = " + length);
            Console.WriteLine("Area is = " + area);
            Console.WriteLine("Volume is = " + volume);
            Console.ReadLine();
        }
    }
}

