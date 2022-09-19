using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASKS5
{
    internal class Plane : IFlyable
    {
        private string mark;
        private int hightFly;

        public Plane(string mark, int hightFly)
        {
            this.mark = mark;
            this.hightFly = hightFly;
        }
        public void Fly()
        {
            Console.WriteLine($"Mark {mark} hight fly {hightFly}");
        }

    }
}
