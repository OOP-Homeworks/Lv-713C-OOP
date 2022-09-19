using SlobodeniukHW5;


namespace SlobodeniukHW5
{
    internal class Builder : IDeveloper, IComparable<IDeveloper>
    {
        private string tool;

        public Builder(string tool)
        {
            this.tool = tool;
        }

        public string Tool
        {
            get { return tool; }
            set { tool = value; }

        }

        public void Create()
        {
            Console.WriteLine($"Builder tool '{Tool}' was created");
        }

        public void Destroy()
        {
            Console.WriteLine($"Builder tool '{Tool}' was destroyed");
        }

        int IComparable<IDeveloper>.CompareTo(IDeveloper other)
        {
            return String.Compare(this.Tool, other.Tool);
        }
    }
}