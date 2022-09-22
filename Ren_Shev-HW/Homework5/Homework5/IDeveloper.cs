using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    internal interface IDeveloper: IComparable<IDeveloper>
    {
        string Tool{ get; }
        void Create();
        void Destroy();
        IDeveloper Print(int i);
    }
}
