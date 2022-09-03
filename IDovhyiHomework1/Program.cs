using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace IDovhyiHomework1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1
            // Define integer variable a(side of the square). ​
            // Read value from the console and calculate the area and perimeter of a square with length a.
            // Output results on the console.​

            Console.WriteLine("Task 1");
            Console.Write("Pleace, enter a (integer variable, side of the square): ");
            int a = Convert.ToInt32(Console.ReadLine());
            int AreaSquare = a * a;
            int NumerSideSqure = 4;
            int Perimeter = NumerSideSqure * a;
            Console.WriteLine("The area of a square with length {0} = {1}", a, AreaSquare);
            Console.WriteLine("The perimeter of a square with length {0} = {1}", a, Perimeter);
            Console.ReadKey();
            Console.WriteLine();


            // Task 2
            // Define string name and integer age. ​
            // Output question "What is your name?"; ​
            // Read value name and output next question: "How old are you, (name)?". ​
            // Read value age and output whole information​

            Console.WriteLine("Task 2");
            Console.Write("What is your name? ");
            string Name = Console.ReadLine();
            Console.Write("How old are you, " + Name + " ? ");
            int Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Name: {0}, Age: {1}", Name, Age);
            Console.ReadKey();
            Console.WriteLine();

            // Read double number r(radius of a circle).​
            // Calculate the length(l = 2 * pi * r), area(S = pi * r * r), and volume(4 / 3 * pi * r * r * r) of a circle.​

            Console.WriteLine("Task 3");
            Console.Write("Pleace, enter r (double variable, radius of a circle): ");
            double r = Convert.ToDouble(Console.ReadLine());
            double Length = 2 * Math.PI * r;
            double AreaCircle = Math.PI * r * r;
            double Volume = 4 / 3 * Math.PI * r * r * r;
            Console.WriteLine("The length(l = 2 * pi * r) =     " + Math.Round(Length, 3) +",");
            Console.WriteLine("Area(S = pi * r * r) =           " + Math.Round(AreaCircle, 3) + ",");
            Console.WriteLine("Volume(4 / 3 * pi * r * r * r) = " + Math.Round(Volume, 3) + ".");
            Console.ReadKey();
        }
    }
}
