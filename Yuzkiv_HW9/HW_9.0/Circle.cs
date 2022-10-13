using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_9
{
    public class Circle : Shape
    {
        private int radius;

        public Circle(string name, int radius) : base(name)
        {
            this.radius = radius;
        }

        public override double Area()
        {
            double area = Math.PI * Math.Pow(radius, 2);
            return area;
        }

        public override double Perimetr()
        {
            double perimetr = 2 * Math.PI * radius;
            return perimetr;
        }

        public override void Print()
        {
            Console.WriteLine($"Name: {name}, Area: {Area()}, Perimetr: {Perimetr()}");
        }
    }
}
