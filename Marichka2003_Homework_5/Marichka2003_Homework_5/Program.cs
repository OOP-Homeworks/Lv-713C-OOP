using System;
using System.Collections.Generic;


namespace Marichka2003_Homework_5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IDeveloper> developers = new List<IDeveloper>();
           
            developers.Add(new Programmer("Maria", "C#"));
            developers.Add(new Programmer("Ann", "Java"));
            developers.Add(new Builder("Sasha", " roof"));
            developers.Add(new Builder("Alex", " ceiling"));

            Console.WriteLine("Programmers");
            foreach (IDeveloper i in developers)
            {
                if (i.GetType() == typeof(Programmer))
                {
                    i.Create();
                    
                }
               
            }
            Console.WriteLine();
            Console.WriteLine("Builders");
            foreach (IDeveloper i in developers)
            {
                if (i.GetType() == typeof(Builder))
                {
                    i.Create();
                    
                }

            }

            Console.WriteLine();

            Console.WriteLine("Sort by name :");
            developers.Sort();
            foreach (IDeveloper i in developers)
            {
                Console.WriteLine(i.Tool);
            }
            Console.WriteLine();

            Console.WriteLine("Your list are cleaned");
            foreach (IDeveloper i in developers)
            {
                i.Destroy();
            }
        }
    }
}
