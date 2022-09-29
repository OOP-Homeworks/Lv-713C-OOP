using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marichka2003_Homwork_8
{
    class Square : Shape
    {
        private double side;
        public string Side { get; set; }
        public Square(string name, double side) : base(name)
        {
            this.side = side;
        }

        override public void Print()
        {
            Console.WriteLine($"Shape: {Name}\t side: {side}\t area: {Math.Round(Area(),2)}\t perimeter: {Math.Round(Perimeter(),2)}");
        }

        public override double Area()
        {
            return side * side;
        }

        public override double Perimeter()
        {
            return 4*side;
        }
    }
}
