using System;
using static HW_2.Enum;
using static HW_2.Struct;

namespace HW_2
{
    public class Program
    {      
        static void Main(string[] args)
        {
            //1

            Console.WriteLine("Write three numbers in the range from -5 to 5:");

            float firstNumber = float.Parse(Console.ReadLine());
            float secondNumber = float.Parse(Console.ReadLine());
            float thirdNumber = float.Parse(Console.ReadLine());

            Console.WriteLine(((firstNumber >= -5 && firstNumber <= 5) &&
                               (secondNumber >= -5 && secondNumber <= 5) &&
                               (thirdNumber >= -5 && thirdNumber <= 5)) ? "Numbers are all in the range" : "Not all numbers are in range!");
            //2

            Console.WriteLine("Write three integer numbers:");

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            int max = Math.Max(Math.Max(a, b), c);
            int min = Math.Min(Math.Min(a, b), c);

            Console.WriteLine($"Max value: {max}\nMin value: {min}");
            //3

            Console.Write("Write Status Code: ");

            HTTPError error = (HTTPError)Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("This Status Code mean: " + error);
            //4

            Dog myDog;
            myDog.name = "Jessy";
            myDog.mark = "Spitz";
            myDog.age = 1;

            myDog.Info();
        }
    }
}
