using System;


namespace Marichka2003_Homework_5
{
    class Programmer : IDeveloper, IComparable<IDeveloper>
    {
        private string name;
        private string language;
        public Programmer(string name, string language)
        {
            this.name = name;
            this.language = language;
        }

        public string Tool
        {
            get { return name; }
            set { name = value; }
        }

        public void Create()
        {
            Console.WriteLine($"{name} master in programming language {language}");
        }
        public void Destroy()
        {            
            name = "";
            language = "";
        }
        int IComparable<IDeveloper>.CompareTo(IDeveloper other)
        {
            return String.Compare(this.Tool, other.Tool);
        }

    }
}
