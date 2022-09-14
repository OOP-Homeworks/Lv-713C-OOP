using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marysa2003_Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] person = new Person[6];
            for (int i = 0; i < person.Length; i++)
            {
                person[i] = new Person();
                person[i].Input(i);
            }
            for (int i = 0; i < person.Length; i++)
            {
                
                person[i].Age();
                person[i].Output();
                if (person[i].age < 16)
                {
                    person[i].ChangeName(person,i);
                    Console.WriteLine(person[i]);
                }
            }
            for (int i = 0; i < person.Length; i++)
            {
                person[i].Output();
            }


            for (int i = 0; i < person.Length; i++)
            {
                for (int j = i + 1; j < person.Length; j++)
                {
                    if (person[i] == person[j])
                    {
                        Console.WriteLine($"The same name is : {person[i]}");
                    }
                    else
                    { Console.WriteLine($"There aren't the same names"); }
                }
            }


        }
    }
}
