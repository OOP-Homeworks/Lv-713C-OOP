using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlobodeniukHW10
{
    public struct Point
    {
        public int x;

        public int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int X
        {
            set { x = value; }
            get { return x; }

        }

        public int Y
        {
            set { y = value; }
            get { return y; }
        }

        public string ToString() => ($"({x},{y})");
    }
}
