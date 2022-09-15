using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASKS4
{
    internal class Person
    {
        private string name;
        private int birthYear;


        public string Name 
        {
            get { return name; }
        }

        public int BirthYear { get; }

        public Person()
        {
            name = "John";
            birthYear = 1994;
        }

        public Person (string name, int birtYear)
        {
            this.name = name;
            this.birthYear = birtYear;
        }

        public int Age()
        {
            int age = DateTime.Now.Year - birthYear;
            
            return age;
        }

        public static Person Input()
        {
            Console.WriteLine("Enter a name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter a birth year");
            int birthYear = Convert.ToInt32(Console.ReadLine());

            Person person = new Person(name, birthYear);

            return person;
        }

        public void ChangeName (string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return $"Name: {name}\nBirth year: {birthYear}";
        }

        public void Output()
        {
            Console.WriteLine(ToString());
        }

        public static bool operator == (Person first , Person second)
        { 
            return first.name == second.name;
        }

        public static bool operator !=(Person first, Person second)
        {
            return !(first.name == second.name);
        }


    }
}
