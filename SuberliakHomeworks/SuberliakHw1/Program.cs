using System;


namespace SuberliakHw1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TASK1:calculate the area and perimeter of a square

            static void ShowErrorMessage()
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("You added wrong value,add only positive number and > 0");
            }

            Console.Write("Please add square side length: ");
            try
            {
                double a = Convert.ToDouble(Console.ReadLine());

                if (a > 0)
                {
                    double area = Math.Pow(a, 2);
                    double perimeter = 4 * a;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Square area is equal to {area};\nSquare perimeter is equal to {perimeter}.");
                }
                else
                {
                    ShowErrorMessage();
                }

            }
            catch (FormatException)
            {
                ShowErrorMessage();
            }

        }
    }
}