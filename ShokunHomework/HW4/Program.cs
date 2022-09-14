using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShokunHW4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[6];
            for(int i = 0; i < persons.Length; i++)
            {
                persons[i] = Person.Input(i);
            }

            int ageOfPerson;
            for(int i = 0; i < persons.Length; i++)
            {
                ageOfPerson = Person.Age(persons[i]);
                Console.WriteLine($"{persons[i].Name} is {ageOfPerson} years old");
            }

            for (int i = 0; i < persons.Length; i++)
            {
                if(persons[i].BirthYear > 2007)
                {
                    persons[i].ChangeName("Very young");
                }
            }

            for (int i = 0; i < persons.Length; i++)
            {
                persons[i].Output(persons[i]);
            }

            for (int i = 0; i < persons.Length; i++)
            {
                for ( int k = i+1; k < persons.Length; k++)
                {
                    if (persons[i] == persons[k])
                    {
                        Console.WriteLine($"Person {persons[i].Name} and person {persons[k].Name} have the same names");
                    }
                    else
                    {
                        Console.WriteLine($"The persons have different names");
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
