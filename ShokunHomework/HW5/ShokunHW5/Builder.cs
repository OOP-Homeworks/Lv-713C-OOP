using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShokunHW5
{
    internal class Builder : IDeveloper, IComparable<IDeveloper>
    {
        string tool;
        string name;

        public string Tool
        {
            get { return tool; }
            set { tool = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Builder(string name, string tool)
        {
            this.name = name;
            this.tool = tool;
        }

        public void Create()
        {
            Console.WriteLine($"{name} working with {tool}");
        }

        public void Destroy()
        {
            Console.WriteLine($"{name} can destroy the toilet with {tool}");
        }

        int IComparable<IDeveloper>.CompareTo(IDeveloper other)
        {
            return String.Compare(this.Tool, other.Tool);
        }

        public void Info()
        {
            Console.WriteLine($"Name {name}, builder's tool: {tool}");
        }
    }
}
