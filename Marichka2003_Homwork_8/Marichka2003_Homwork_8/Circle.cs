using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marichka2003_Homwork_8
{
    class Circle : Shape
    {
        private double radius;
        public string Radius { get; set; }
        public Circle(string name, double radius) : base(name)
        {
            this.radius = radius;
        }
        public override double Area()
        {
            return Math.PI * radius * radius;
        }
        public override double Perimeter()
        {
            return 2 * Math.PI * radius;
        }
        override public void Print()
        {
            Console.WriteLine($"Shape: {Name}\t radius: {radius}\t area: {Math.Round(Area(), 2)}\t perimeter: {Math.Round(Perimeter(), 2)}");
        }
    }
}
