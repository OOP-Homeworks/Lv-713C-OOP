using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ShavronskyyHW9;

namespace ShavronskyyHW9
{
    internal class Program
    {
        private static string shapesTxt = @"C:\Users\38096\Desktop\c#\c#SoftServe\hw9\hw9\shapes.txt";
        public static string ShapesTxt { get { return shapesTxt; } }
        public static List<Shape> shapes = new List<Shape>();
        static void Main(string[] args)
        {
            //create Shapes
            Random rnd = new Random();
            for (int i = 0; i < 6; i++)
            {
                shapes.Add(new Square(rnd.Next(1, 6), $"Square number {i}"));
                shapes.Add(new Circle(rnd.Next(1, 4), $"Circle number {i}"));
            }
            // Adding all names to one list
            var names = ContainsLetter(shapes);
            var otherNames = FindShapesAreaRange(shapes);
            foreach (string shape in otherNames)
            {
                names.Add(shape);
            }

            RemoveItemsFromList();
            WriteTextIntoFile(names);
        }

        public static List<string> FindShapesAreaRange(List<Shape> shapes)
        {
            List<string> result = new List<string>();
            var items = from shape in shapes
                        where shape.Area() < 100 && shape.Area() > 10
                        select shape.Name;
            return items.ToList();
        }
        public static List<string> ContainsLetter(List<Shape> shapes)
        {
            Regex containsA = new Regex(@"a");
            List<string> names = new List<string>();
            foreach(Shape shape in shapes)
            {
                if(containsA.IsMatch(shape.Name))
                    names.Add(shape.Name);
            }
            return names;
        }
        public static void RemoveItemsFromList()
        {
            shapes.RemoveAll(i => i.Perimeter() < 5);
            Console.WriteLine("Removed {0} items\nShape's in list:", 12 - shapes.Count);
            foreach (Shape shape in shapes)
            {
                Console.WriteLine("\n{0}\n{1}\n{2}\n##############", shape.Name, shape.Perimeter(), shape.Area());
            }
        }
        public static void WriteTextIntoFile(List<string> names)
        {
            using (StreamWriter sw = new StreamWriter(ShapesTxt))
            {
                foreach (var name in names)
                {
                    sw.WriteLine(name);
                }
            }
        }
    }
}
