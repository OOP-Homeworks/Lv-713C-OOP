using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class Shape : IComparable<Shape>
    {
        private string name;
        public string Name { get { return name; } set { name = value; } }


        public abstract double Area { get; set; }
        public abstract double Perimeter { get; set; }

        public Shape(string name)
        {
            this.name = name;
        }

        public abstract void GetArea();
        public abstract void GetPerimeter();
        public abstract void Print();


        public int CompareTo(Shape sh)
        {
            Shape cr = sh as Circle;
            Shape sq = sh as Square;
            if (cr != null)
            {
                return Area.CompareTo(cr.Area);
            }
            if (sq != null)
            {
                return Area.CompareTo(sq.Area);
            }
            else
            {
                throw new Exception("Unable to compare");
            }

        }

    }
}
