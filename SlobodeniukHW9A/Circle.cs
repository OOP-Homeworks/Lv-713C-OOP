using Slobodeniuk_HW9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Slobodeniuk_HW9
{
    public class Circle : Shape
    {

        private double radius;
        public override double Perimeter { get; set; }
        public override double Area { get; set; }

        public Circle(double radius, string name) : base(name)
        {
            this.radius = radius;
        }

        public override void GetPerimeter()
        {
            Perimeter = Math.Round((radius * 2 * Math.PI), 2);
        }

        public override void GetArea()
        {
            Area = Math.Round((Math.PI * Math.Pow(radius, 2)), 2);
        }

        public override void Print()
        {
            Console.WriteLine("Name is: " + Name + "; Area is: " + Area + "; Perimeter is: " + Perimeter);
        }

    }
}
