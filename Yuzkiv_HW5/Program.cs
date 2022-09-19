using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_5
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<IDeveloper> developerList = new List<IDeveloper>();
            developerList.Add(new Programmer("JavaScript"));
            developerList.Add(new Programmer("C#"));
            developerList.Add(new Programmer("Java"));
            developerList.Add(new Programmer("Pyton"));
            developerList.Add(new Builder("Jenkins"));
            developerList.Add(new Builder("TeamCity"));


            for (int i = 0; i < developerList.Count; i++)
            {
                developerList[i].Create();
                developerList[i].Destroy();
            }

            Console.WriteLine("\n _________________SORTED_________________________ \n");

            developerList.Sort((i1, i2) => i1.CompareTo(i2));
            for (int i = 0; i < developerList.Count; i++)
            {
                developerList[i].Create();
                developerList[i].Destroy();
            }

            Console.ReadKey();




            Dictionary<int, string> persons = new Dictionary<int, string>();
            Console.WriteLine("Enter of number inputs: ");
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Enter id: ");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter name: ");
                string name = Console.ReadLine();
                persons.Add(id, name);   
            }

            Console.WriteLine("Enter id: ");
            int findID = int.Parse(Console.ReadLine());
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
}
