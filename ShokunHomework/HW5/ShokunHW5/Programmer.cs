using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShokunHW5
{
    internal class Programmer : IDeveloper, IComparable<IDeveloper>
    {
        string language;
        string name;

        public string Tool
        { 
            get { return language; }
            set { language = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Programmer(string name, string language)
        {
            this.name = name;
            this.language = language;
        }


        public void Create()
        {
            Console.WriteLine($"{name} codes in {language}");

        }

        public void Destroy()
        {
            Console.WriteLine($"{name} can destroy your business with {language}");
        }

        int IComparable<IDeveloper>.CompareTo(IDeveloper other)
        {
            return String.Compare(this.Tool, other.Tool);
        }

        public void Info()
        {
            Console.WriteLine($"Name {name}, programming language: {language}");
        }
    }
}
