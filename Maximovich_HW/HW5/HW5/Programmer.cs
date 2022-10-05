using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    internal class Programmer : IDeveloper, IComparable<IDeveloper>
    {
        private string name;
        private string language;

        public string Name 
        { 
            get { return name; } 
        }
        public string Language 
        { 
            get { return language; } 
        }

        public Programmer(string name, string language)
        {
            this.name = name;
            this.language = language;
        }

        public string Tool 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }

        public void Create()
        {
            Console.WriteLine($"Programmer {name} is a codding for {language}");
        }
        public void Destroy()
        {
            Console.WriteLine("Programmer don't destroy - hi's creator!");
        }
        public override string ToString()
        {
            return $"{name} {language}";
        }

        int IComparable<IDeveloper>.CompareTo(IDeveloper? other)
        {
            return String.Compare(Name, other.Name);
        }
    }
}
