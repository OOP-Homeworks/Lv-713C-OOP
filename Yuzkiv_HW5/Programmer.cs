using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_5
{
    public class Programmer : IDeveloper, IComparable<IDeveloper>
    {
        public string language;

        public Programmer(string language)
        {
            this.language = language;
        }

        public string Tool
        {
            get { return language; }
            set { }
        }

        public void Create()
        {
            Console.WriteLine($"Programmer: {Tool} was created");
        }

        public void Destroy()
        {
            Console.WriteLine($"Programmer: {Tool} was destroyed");
        }

        int IComparable<IDeveloper>.CompareTo(IDeveloper other)
        {
            if (this.Tool.Length > other.Tool.Length)
            {
                return 1;
            }
            else if (this.Tool.Length < other.Tool.Length)
            {
                return -1;
            }              
            if (this.Tool.Length == other.Tool.Length)
            {
                return 0;
            }                

            return 0;
        }
    }
}
