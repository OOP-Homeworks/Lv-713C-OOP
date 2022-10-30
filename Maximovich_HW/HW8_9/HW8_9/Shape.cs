using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8_9
{
    public abstract class Shape : IComparable<Shape>
    {
        private string name;
        public string Name { get { return name; } }
        public Shape(string name)
        {
            this.name = name;
        }
        public abstract double Area();
        public abstract double Perimeter();

        int IComparable<Shape>.CompareTo(Shape? other)
        {
            if(Area() < other.Area())
            {
                return -1;
            }
            else if (Area() > other.Area())
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
