using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8_9
{
    internal class Circle : Shape
    {
        private double radius;
        public Circle(string name, double radius) : base(name)
        {
            this.radius = radius;
        }
        public override double Area()
        {
            double circleArea = Math.PI * (radius * radius);
            return circleArea;
        }

        public override double Perimeter()
        {
            double circlePerimeter = 2 * (Math.PI * radius);
            return circlePerimeter;
        }
    }
}
