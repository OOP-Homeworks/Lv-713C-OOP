using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isTrue = true;
            do
            {
                Console.WriteLine("1 - Counting the letters in line, 2 - find the number of days in a month," +
                " 3 - operation with number, 4 - exit");

                Console.Write("Your choice : ");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                Counting action = new Counting();
                Month day = new Month();
                OperationWithNumbers operation = new OperationWithNumbers();
                switch (number)
                {
                    case 1:

                        action.CountingLetters();
                        Console.WriteLine();
                        break;

                    case 2:
                        Console.Clear();
                        day.MonthAndTheirDays();
                        Console.WriteLine();
                        break;

                    case 3:
                        Console.Clear();
                        operation.Operation();
                        Console.WriteLine();
                        break;

                    case 4:
                        isTrue = false;
                        break;

                    default:
                        break;
                }
            } while (isTrue);


        }
    }
}
