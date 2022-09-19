using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShokunHW5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<IDeveloper> developers = new List<IDeveloper>();

            developers.Add(new Programmer("Ivan", "C#"));
            developers.Add(new Programmer("Bob", "Java"));
            developers.Add(new Builder("Nick", "Axe"));
            developers.Add(new Builder("John", "hammer"));
            Console.WriteLine("We add some Programmers and Builders to list");
            for(int i = 0; i < developers.Count; i++)
            {
                developers[i].Info();
            }

            Console.WriteLine("Method 'Create'");
            foreach(IDeveloper developer in developers)
            {
                developer.Create();
            }

            Console.WriteLine("Method 'Destroy'");
            foreach(IDeveloper developer in developers)
            {
                developer.Destroy();
            }

            developers.Sort();
            foreach(IDeveloper developer in developers)
            {
                developer.Info();
            }
        }
    }
}
