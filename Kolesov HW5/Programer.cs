using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASKS5
{
    internal class Programer : IDeveloper, IComparable<IDeveloper>
    {
        private string language;
        public string Tool
        {
            get { return language; }
            set { language = value; }
        }

        public void Create()
        {
            Console.WriteLine($"{nameof(Programer)} creates something with {language}");
        }

        public void Destroy()
        {
            Console.WriteLine($"{nameof(Programer)} destroy something with {language}");
        }

        int IComparable<IDeveloper>.CompareTo(IDeveloper other)
        {
            return String.Compare(this.Tool, other.Tool);
        }

    }
}
