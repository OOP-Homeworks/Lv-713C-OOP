using System;

namespace learnqw
{
    }
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
                person[i].Person_age();
                person[i].Output();
                if (person[i].Person_Age < 16)
                {
                    person[i].ChangeName(person, i);
                    Console.WriteLine($"Change name {person[i]}");
                }
            }
            for (int i = 0; i < person.Length; i++)
            {
                person[i].Output();
            }
            for (int i = 0; i < person.Length; i++)
            {
                for (int q = i + 1; q < person.Length; q++)
                {
                    if (person[i] == person[q])
                    {
                        Console.WriteLine($"Same name is :  {person[i]}");
                    }
                    else
                    { Console.WriteLine($"There aren't same name!"); }
                }
            }
            Console.ReadLine();
        }
    }
}

