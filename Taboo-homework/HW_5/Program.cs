using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//public class Program
//{
//    public static void Main()
//    {
//        List<IDeveloper> developers = new List<IDeveloper>();
//        developers.Add(new Programmer("HTML"));
//        developers.Add(new Programmer("C++"));
//        developers.Add(new Programmer("C#"));
//        developers.Add(new Programmer("Python"));
//        developers.Add(new Builder("Visual Stuio Code"));
//        developers.Add(new Builder("SQL"));
//        developers.Add(new Builder("Java Script"));

//        foreach (IDeveloper dev in developers)
//        {
//            dev.Create();
//            dev.Destroy();
//        }

//        developers.Sort();
//    }
//    internal class Builder : IDeveloper
//    {
//        private string _tool;
//        public string Tool
//        {
//            get { return _tool; }
//            set { _tool = value; }
//        }
//        public Builder(string tool)
//        {
//            _tool = tool;
//        }
//        public void Create()
//        {
//            Console.WriteLine($"Builder : {Tool} was created");
//        }
//        public void Destroy()
//        {
//            Console.WriteLine($"Builder : {Tool} was destroyed");
//        }
//        int IComparable<IDeveloper>.CompareTo(IDeveloper other)
//        {
//            return string.Compare(this.Tool, other.Tool);
//        }
//    }
//    public interface IDeveloper : IComparable<IDeveloper>
//    {
//        string Tool { get; }
//        void Create();
//        void Destroy();
//    }
//    class Programmer : IDeveloper
//    {
//        private string _language;
//        public string Tool
//        {
//            get { return _language; }
//            set { _language = value; }
//        }
//        public Programmer(string language)
//        {
//            this._language = language;
//        }
//        public void Create()
//        {
//            Console.WriteLine($"Programmer:{Tool} was created");
//        }
//        public void Destroy()
//        {
//            Console.WriteLine($"Programmer:{Tool} was destroyed");
//        }
//        int IComparable<IDeveloper>.CompareTo(IDeveloper other)
//        {
//            return String.Compare(this.Tool, other.Tool);
//        }

//    }
//}

/////////////////////////////////////
public class Program
{
    static void Main(string[] args)
    {
        Dictionary<uint, string> persons = new Dictionary<uint, string>();

        for (int i = 0; i < 7; i++)
        {
            Console.Write("Enter id: ");
            uint id = Convert.ToUInt32(Console.ReadLine());
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            persons.Add(id, name);
        }
        Console.WriteLine();
        Console.WriteLine("Find user by id: ");
        uint findID = uint.Parse(Console.ReadLine());
        if (persons.Keys.Contains(findID))
        {
            Console.WriteLine(persons[findID]);
        }
        else
        {
            Console.WriteLine("This id is not value!");
        }
    }
}


