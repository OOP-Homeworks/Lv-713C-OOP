using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_8
{
    public class Square : Shape
    {
        public int side;

        public Square(string name, int side) : base(name)
        {
            this.side = side;
        }

        public override double Area()
        {
            double area = Math.Pow(side, 2);
            return area;
        }

        public override double Perimetr()
        {
            int perimetr = 4 * side;
            return perimetr;
        }

        public override void Print()
        {
            Console.WriteLine($"Name: {name}, Area: {Area()}, Perimetr: {Perimetr()}");
        }
    }
}
