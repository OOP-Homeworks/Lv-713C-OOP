using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASKS5
{
    internal class Builder : IDeveloper, IComparable<IDeveloper>
    {
        private string tool;
        public string Tool
        {
            get { return tool; }
            set { tool = value; }
        }

        public void Create()
        {
            Console.WriteLine($"{nameof(Builder)} creates something with {tool}");
        }

        public void Destroy()
        {
            Console.WriteLine($"{nameof(Builder)} destroy something with {tool}");
        }

        int IComparable<IDeveloper>.CompareTo(IDeveloper other)
        {
            return String.Compare(this.Tool, other.Tool);
        }

    }
}
