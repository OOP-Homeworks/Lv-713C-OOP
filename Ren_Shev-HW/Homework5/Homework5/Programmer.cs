using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    internal class Programmer: IDeveloper, IComparable<IDeveloper>
    {
        private string name;
        private string language;

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
            this.language = language;
            this.name = name;

        }
        public void Create()
        {
            Console.WriteLine($"The programmer {name} has excellent knowledge of {language}");
        }
        public void Destroy()
        {
            Console.WriteLine($"The programmer {name} has been removed from our database");
            language = "";
            name = "";
        }
        public IDeveloper Print(int i)
        {
            Console.WriteLine($"Enter developer {i} name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Enter a programming language that {name} knows : ");
            string language = Console.ReadLine();

            IDeveloper dev = new Programmer(name, language);
            return dev;
        }
        int IComparable<IDeveloper>.CompareTo(IDeveloper other)
        {
            return String.Compare(this.Tool, other.Tool);
        }
    }
}
