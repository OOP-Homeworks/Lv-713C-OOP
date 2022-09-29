using System;

namespace SuberliakHw1_3
{
    internal class Program
    {

        //TASK3: Calculate circle Length,Area and Volume
        public const double PI = Math.PI;
        static void ShowErrorMessage()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("You added wrong value,add only positive number and > 0");
        }
        static void Main(string[] args)
        {
            try
            {
                double circleRadius = Convert.ToDouble(Console.ReadLine());
                if (circleRadius >= 0)
                {
                    double circleLength = 2 * PI * circleRadius;
                    double circleArea = PI * Math.Pow(circleRadius, 2);
                    double circleVolume = (4 / 3) * PI * Math.Pow(circleRadius, 3);
                    Console.WriteLine($"Circle Length = {circleLength}\nCircle Area = {circleArea}\nCircle Volume = {circleVolume}");
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