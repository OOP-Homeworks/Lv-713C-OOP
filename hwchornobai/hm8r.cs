using System;
using System.Collections;
using System.Collections.Generic;

namespace hm8
{
    class Program
    {
        static void Main(string[] args)
        {
           
            List<Shape> shapes = new List<Shape>();
            int counter = 1;
            string name_shape;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Number of shape = ***** {counter++} *****") ;
                name_shape = Console.ReadLine();
                Console.Write("Enter the radius !  ");
                double radius = double.Parse(Console.ReadLine());
                shapes.Add(new Circle($"{name_shape}", "name_shape", radius)) ;
                Console.Write("Enter the square ! ");
                double side = double.Parse(Console.ReadLine());
                shapes.Add(new Square($"{ name_shape }", "name_shape", side));
            }


            Shape maxPer = shapes[0];
            foreach (Shape shape in shapes)
            {
                if (shape.Perimeter() > maxPer.Perimeter())
                {
                    maxPer = shape;
                }
            }
            Console.WriteLine($" Max perimeter is :   {maxPer.Perimeter():0.00}");

            Console.WriteLine("***** Sorting *****");
            shapes.Sort();
            foreach (Shape shape in shapes)
                Console.WriteLine($" Sort area :  {shape.Area()}");


            Console.ReadLine();




        }
    }
}

