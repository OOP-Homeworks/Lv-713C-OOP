using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Homework1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //task 1
            Console.WriteLine( "Enter the side of the square: " );
            int a = Convert.ToInt32( Console.ReadLine() );
            int perimeter = 4 * a;
            int areaOfSquare = a * a;
            Console.WriteLine($"Side of the square: {a}");
            Console.WriteLine($"Perimeter of Square: {perimeter}");
            Console.WriteLine($"Area of Square: {areaOfSquare}");

            //task2
            const string NAME_QUESTION = "Enter your name?: ";
            const string AGE_QUESTION = "How old are you, {0}?: ";
            const string ABOUT_USER = "Your name: {0}, your age: {1}";

            Console.WriteLine(NAME_QUESTION);
            string name = Console.ReadLine();
            Console.WriteLine( AGE_QUESTION, name );
            int? age = Convert.ToInt32( Console.ReadLine() );
            Console.WriteLine( ABOUT_USER, name, age );

            //task3
            const double PI = 3.14159;
            const double FOUR_THIRD_OF_CIRCLE = 4.0 / 3.0;
            const string RADIUS_QUESTION = "Enter radius of circle: ";
            const string LENGHT_CIRCLE = "Lenght of the square: {0}";
            const string AREA_CIRCLE = "Area of square: {0}";
            const string VOLUME_CIRCLE = "Volume of square: {0}";

            Console.WriteLine(RADIUS_QUESTION);
            double r = Convert.ToDouble(Console.ReadLine());
            double length = 2 * PI * r;
            Console.WriteLine(LENGHT_CIRCLE, length);
            double areaOfCircle = PI * r * r;
            Console.WriteLine(AREA_CIRCLE, areaOfCircle);        
            double volume = FOUR_THIRD_OF_CIRCLE * PI * r * r * r;
            Console.WriteLine(VOLUME_CIRCLE, volume);

            Console.ReadKey();

        }
    }
}
