using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    internal interface IDeveloper : IComparable<IDeveloper>
    {
        public string Tool { get; }
        public string Name { get; }
        public void Create()
        {
            //
        }
        public void Destroy()
        {
            //
        }
    }
}
