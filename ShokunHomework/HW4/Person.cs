using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShokunHW4
{
    class Person
    {

        private string name;
        private int birthYear;

        public string Name 
        { 
            get { return name; } 
        }

        public int BirthYear 
        { 
            get { return birthYear; } 
        }

        public Person()
        {

        }

        public Person(string name, int birthYear)
        {
            this.name = name;
            this.birthYear = birthYear;
        }

        public static Person Input(int i)
        {
            Console.Write($"Enter {i+1} name ");
            string name = Console.ReadLine();
            Console.Write($"Enter {i+1} birthday year ");
            int birthYear = Convert.ToInt32(Console.ReadLine());
            Person person = new Person(name, birthYear);
            return person;
        }

        public static int Age(Person person)
        {
            int age = 2022 - person.BirthYear;
            return age;
        }

        public void ChangeName(string newName)
        {
            name = newName;
        }

        public override string ToString()
        {
            return "Name of person " + name + " , with birthday year " + birthYear;
        }

        public void Output(Person person)
        {
            Console.WriteLine(person.ToString());
        }

        public static bool operator ==(Person first, Person second)
        {
            return (first.name == second.name);
        }
        public static bool operator !=(Person first, Person second)
        {
            return !(first == second);
        }

    }
}
