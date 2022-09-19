using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Homework5
{
    internal class Builder: IDeveloper, IComparable<IDeveloper>
    {
        private string tool;
        private string name;

        public string Tool { 
            get { return tool; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Builder(string name, string tool)
        {
            this.tool = tool;
            this.name = name;

        }
        public void Create()
        {
            Console.WriteLine($"The builder {name} uses a {tool} for his work");
        }
        public void Destroy()
        {
            Console.WriteLine($"The builder {name} has been removed from our database");
            tool = "";
            name = "";
        }
        public IDeveloper Print(int i)
        {
            Console.WriteLine($"Enter developer {i} name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Enter the tool that {name} uses : ");
            string tool = Console.ReadLine();

            IDeveloper dev = new Builder(name, tool);
            return dev;
        }
        int IComparable<IDeveloper>.CompareTo(IDeveloper other)
        {
            return String.Compare(this.Tool, other.Tool);
        }
    }
}
