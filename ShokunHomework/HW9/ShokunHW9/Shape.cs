using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShokunHW9
{
    public abstract class Shape : IComparable<Shape>
    {
        private string name;

        public Shape(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public abstract double Area();

        public abstract double Perimeter();

        public int CompareTo(Shape s)
        {
            Shape circle = s as Shape;
            Shape square = s as Shape;

            if (circle != null) return this.Area().CompareTo(circle.Area());
            else if (square != null) return this.Area().CompareTo(square.Area());
            else throw new Exception("Not a shape");
        }

    }
}
