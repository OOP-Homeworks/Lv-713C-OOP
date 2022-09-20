using System;

namespace Marichka2003_Task_6
{

    class Program
    {
        public static void Div(int firstNumber, int secondNumber)
        {
            again:
            try
            {
                Console.Write($"Dividing : { firstNumber / secondNumber} ");
            }
            catch (DivideByZeroException)
            {
                Console.Write("Divide by 0\nEnter second number : ");
                secondNumber = Convert.ToInt32(Console.ReadLine());
                goto again;
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
        start:

            int firstNumber;
            int secondNumber;
            try
            {
                Console.Write("Enter the first number : ");
                firstNumber = Convert.ToInt32(Console.ReadLine());
            }

            catch (FormatException exception)
            {
                Console.WriteLine(exception.Message);
                goto start;
            }
        start2:

            try
            {
                Console.Write("Enter the second number : ");
                secondNumber = Convert.ToInt32(Console.ReadLine());
            }

            catch (FormatException exception)
            {
                Console.WriteLine(exception.Message);
                goto start2;
            }

            Div(firstNumber, secondNumber);
        }
    }      
}
