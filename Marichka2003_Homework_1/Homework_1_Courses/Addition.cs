using System;


namespace Homework_1_Courses
{
    class Addition
    {
        public string name;

        public void AreaOfSquare(int a)
        {
            Console.WriteLine($"Area of a square : {a*a}");
        }
        public void PerimetrOfSquare(int a)
        {
            Console.WriteLine($"Area of a perimeter : {4 * a}");
        }
        
        public void Name()
        {
            Console.WriteLine("What is your name?");
            Console.Write("My name is : ");
            name = Console.ReadLine();
            Console.Clear();     
        }
        public void Age()
        {
            Name();
            Console.Write($"How old are you, {name} : ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Name: {name}, age: {age}");
        }

        public void LengthOfCircle(double r)
        {
            Console.WriteLine($"Our length is: {2 * Math.PI * r}");
        }
        public void AreaOfCircle(double r)
        {
            Console.WriteLine($"Our area is: {Math.PI * r * r}");
        }
        public void VolumeOfCircle(double r)
        {
            Console.WriteLine($"Our volume is: {4 / 3 * Math.PI * r * r * r}");
        }
    }
}
