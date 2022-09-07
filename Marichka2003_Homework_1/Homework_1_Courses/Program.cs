using System;


namespace Homework_1_Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isTrue = true;

            do
            {
                Console.WriteLine("1 - search for area and perimeter, 2 - display data about you," +
                " 3 - calculate for a circle, 4 - exit");

                Console.Write("Your choice : ");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                
                Addition generalObject = new Addition();

                switch (number)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("Enter the value of a(side of the square): ");
                        int a = Convert.ToInt32(Console.ReadLine());
                        generalObject.AreaOfSquare(a);
                        generalObject.PerimetrOfSquare(a);
                        Console.WriteLine();
                        break;

                    case 2:
                        Console.Clear();
                        generalObject.Age();
                        Console.WriteLine();
                        break;

                    case 3:
                        Console.Clear();
                        Console.Write("Enter the value of radius: ");
                        double r = Convert.ToDouble(Console.ReadLine());
                        generalObject.AreaOfCircle(r);
                        generalObject.LengthOfCircle(r);
                        generalObject.VolumeOfCircle(r);
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
