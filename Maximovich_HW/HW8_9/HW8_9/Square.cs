using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8_9
{
    internal class Square : Shape
    {
        private double side;
        public Square(string name, double side) : base(name)
        {
            this.side = side;
        }

        public override double Area()
        {
            double squareArea = Math.Pow(side, 2);
            return squareArea;
        }

        public override double Perimeter()
        {
            double squarePerimetr = 4 * side;
            return squarePerimetr;
        }
    }
}
