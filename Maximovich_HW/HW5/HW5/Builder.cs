using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    internal class Builder : IDeveloper, IComparable<IDeveloper>
    {
        private string name;
        private string tool;
        public string Name
        {
            get { return name; }
        }
        public string Tool
        {
            get { return tool; }
        }
        public Builder(string name, string tool)
        {
            this.name = name;
            this.tool = tool;
        }
        public void Create()
        {
            Console.WriteLine($"{name} is a Builder");
        }
        public void Destroy()
        {
            Console.WriteLine($"{tool} help a destroying");
        }
        public override string ToString()
        {
            return $"{name} {tool}";
        }

        int IComparable<IDeveloper>.CompareTo(IDeveloper? other)
        {
            return String.Compare(Name, other.Name);
        }
    }
}
