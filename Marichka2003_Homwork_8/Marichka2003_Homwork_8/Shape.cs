using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marichka2003_Homwork_8
{
    public abstract class Shape : IComparable<Shape>
    {
        private string name;
        public string Name { get { return name; } set { name = value; } }

        protected Shape(string name)
        {
            this.name = name;
        }

        public virtual void Print()
        {
            Console.WriteLine($"This is shape: {name}");
        }
        public abstract double Area();

        public abstract double Perimeter();

        public int CompareTo(Shape shape)
        {
            if (this.Area() - shape.Area() < 0)
            {
                return -1;
            }
            if (this.Area() - shape.Area() > 0)
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
