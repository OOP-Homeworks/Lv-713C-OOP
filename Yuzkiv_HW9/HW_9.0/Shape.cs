using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_9
{
    public abstract class Shape : IComparable<Shape>
    {
        public string name;

        public string Name
        {
            get { return name; }
        }

        public Shape(string name)
        {
            this.name = name;
        }

        public virtual double Area()
        {
            return Area();
        }

        public virtual double Perimetr()
        {
            return Perimetr();
        }

        public abstract void Print();

        public int CompareTo(Shape other)
        {
            if (this.Area() < other.Area()) return 1;
            else if (this.Area() > other.Area()) return -1;
            else return 0;
        }
    }
}
