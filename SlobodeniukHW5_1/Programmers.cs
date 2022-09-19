using System;


namespace SlobodeniukHW5
{
    internal class Programmer : IDeveloper, IComparable<IDeveloper>
    {
        private string language;
        public string Tool
        {
            get { return language; }
            set { language = value; }
        }

        public Programmer(string language)
        {
            this.language = language;
        }



        public void Create()
        {
            Console.WriteLine($"Create Programmer with programming language: '{Tool}'");
        }

        public void Destroy()
        {
            Console.WriteLine($"Destroy Programmer with programming language: '{Tool}'");
        }

        int IComparable<IDeveloper>.CompareTo(IDeveloper other)
        {
            return String.Compare(this.Tool, other.Tool);
        }
    }
}