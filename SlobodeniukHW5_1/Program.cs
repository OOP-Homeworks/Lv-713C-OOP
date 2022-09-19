using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlobodeniukHW5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IDeveloper> developers = new List<IDeveloper>();
            developers.Add(new Programmer("Java"));
            developers.Add(new Programmer("C++"));
            developers.Add(new Programmer("C#"));
            developers.Add(new Programmer("Python"));
            developers.Add(new Builder("Visual Stuio"));
            developers.Add(new Builder("PyCharm"));
            developers.Add(new Builder("Eclipse"));

            foreach (IDeveloper develop in developers)
            {
                develop.Create();
                develop.Destroy();
            }


            developers.Sort();
            foreach (IDeveloper develop in developers)
            {
                develop.Create();
                develop.Destroy();
            }

        }
    }
}