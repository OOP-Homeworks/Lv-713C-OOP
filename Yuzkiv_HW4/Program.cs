using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Output();

            Person person1 = new Person("John", 2000);
            person1.Output();

            var persons = new Person[6];
            persons[0] = person;
            persons[1] = person1;

            for (int i = 2; i < persons.Length; i++)
            {
                persons[i] = Person.Input();
            }

            for (int i = 0; i < persons.Length; i++)
            {
                persons[i].Output();
                persons[i].ChangeName();
            }

            for (int i = 0; i < persons.Length; i++)
            {
                Console.WriteLine(persons[i].ToString());
            }

            for (int i = 0; i < persons.Length; i++)
            {
                for (int j = i + 1; j < persons.Length; j++)
                {
                    if (persons[i] == persons[j])
                    {
                        Console.WriteLine($"{persons[i]} and {persons[j]} are same names");
                    }
                    else
                    {
                        Console.WriteLine($"{persons[i]} and {persons[j]} aren't same names");
                    }
                }
            }
        }
    }
}
