using System;
using System.Threading.Tasks;

namespace SuberliakHw2._1
{
    internal class Program
    {
        //Task:1 Read 3 float numbers and check if they are all in the range[-5.5].
        static void Main(string[] args)
        {
            float minRage = -5;
            float maxRage = 5;

            try
            {

                Console.WriteLine("add first float number");
                float number1 = (float)Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("add 2nd float number");
                float number2 = (float)Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("add 3rd float number");
                float number3 = (float)Convert.ToDecimal(Console.ReadLine());

                if (number1 > minRage && number1 < maxRage && number2 > minRage && number2 < maxRage && number3 > minRage && number3 < maxRage)
                {
                    Console.WriteLine("values are in range");
                }

                else
                {
                    Console.WriteLine("values are not in range");
                }

            }

            catch (FormatException)
            {
                Console.WriteLine("ERROR!: only float values can be added!");
            }

        }
    }
}
