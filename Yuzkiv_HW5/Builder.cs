using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_5
{
    public class Builder : IDeveloper, IComparable<IDeveloper>
    {
        public string Tool { get; set; }

        public Builder(string tool)
        {
            Tool = tool;
        }

        public void Create()
        {
            Console.WriteLine($"Builder: {Tool} was created");
        }

        public void Destroy()
        {
            Console.WriteLine($"Builder: {Tool} was destroyed");
        }

        int IComparable<IDeveloper>.CompareTo(IDeveloper other)
        {
            if (this.Tool.Length > other.Tool.Length)
            {
                return 1;
            }             
            else if (this.Tool.Length < other.Tool.Length)
            {
                return -1;
            }              
            if (this.Tool.Length == other.Tool.Length)
            {
                return 0;
            }
               
            return 0;
        }
    }
}
