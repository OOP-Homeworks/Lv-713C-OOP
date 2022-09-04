using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task 1

            const int SIDES = 4;
            Console.Write("Enter the length of the side of the square: ");
            int s = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The area = {s * s}, perimeter = {s * SIDES}\n\n\n");
            Console.ReadKey();


            //task 2

            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            Console.Write($"How old are you {name}? ");
            string age = Console.ReadLine();
            try
            { 
                int a = Convert.ToInt32(age);
                Console.WriteLine($"Your name is {name}, age {a}\n\n\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error");
            }
        
            
            Console.ReadKey();

            //task 3

            const double PI = 3.14;
            
            Console.Write("Enter the radius of the circle: ");
            string radius = Console.ReadLine();
            
            try
            {
               double r = Convert.ToDouble(radius);
               Console.WriteLine($"lenght of the circle = {2 * PI * r}\narea of the circle = {PI * r * r} \n" +
                $"volume of the circle = {4 / 3 * PI * r * r * r}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error");
            }
           
            Console.ReadKey();

        }
    }
}
