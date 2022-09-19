using System;


namespace Marichka2003_Homework_5
{
    class Builder : IDeveloper, IComparable<IDeveloper>
    {
        private string name;
        private string tool;
        public Builder(string name, string tool)
        {
            this.name = name;
            this.tool = tool;
        }
        public string Tool
        {
            get { return name; }
            set { name = value; }
        }
        public void Create()
        {
            Console.WriteLine($"{name} master in construction {tool}");
        }
        public void Destroy()
        {
            name = "";
            tool = "";          
        }
        int IComparable<IDeveloper>.CompareTo(IDeveloper other)
        {
            return String.Compare(this.Tool, other.Tool);
        }

    }

}
