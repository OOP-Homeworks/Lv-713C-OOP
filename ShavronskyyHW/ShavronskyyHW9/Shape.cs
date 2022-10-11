using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShavronskyyHW9
{
    abstract class Shape : IComparable<Shape>
    {
        private string name;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public Shape(string name)
        {
            this.name = name;
        }
        public abstract double Area();

        public abstract double Perimeter();

        public int CompareTo(Shape other)
        {
            if (this.Area() < other.Area()) return 1;
            else if (this.Area() > other.Area()) return -1;
            else return 0;
        }
    }
    class Circle : Shape
    {
        private double radius;
        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }
        public Circle(double radius, string name) : base(name)
        {
            this.radius = radius;
        }
        public override double Area()
        {
            return Math.PI * Math.Pow(this.radius, 2);
        }

        public override double Perimeter()
        {
            return (2 * Math.PI) * this.radius;
        }
    }
    class Square : Shape
    {
        private double side;
        public double Side
        {
            get { return side; }
            set { side = value; }
        }
        public Square(double side, string name) : base(name)
        {
            this.side = side;
        }
        public override double Area()
        {
            return Math.Pow(this.side, 2);
        }

        public override double Perimeter()
        {
            return 4 * this.side; //4 - side
        }
    }
}
