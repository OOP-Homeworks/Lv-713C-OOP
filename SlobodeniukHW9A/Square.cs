using Slobodeniuk_HW9;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Slobodeniuk_HW9
{
    public class Square : Shape
    {
        private double side;

        public override double Perimeter { get; set; }
        public override double Area { get; set; }

        public Square(double side, string name) : base(name)
        {
            this.side = side;
        }

        public override void GetPerimeter()
        {
            Perimeter = side * 4;
        }

        public override void GetArea()
        {
            Area = Math.Pow(side, 2);
        }

        public override void Print()
        {
            Console.WriteLine("Name is: " + Name + "; Area is: " + Area + "; Perimeter is: " + Perimeter);
        }



    }
}
