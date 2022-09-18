using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4
{
    public class Person
    {
        private string name { get; set; }
        private int birthYear { get; set; }

        public Person()
        {
            name = "Mark";
            birthYear = 1995;
        }

        public Person(string name, int birthYear)
        {
            this.name = name;
            this.birthYear = birthYear;
        }

        public int Age()
        {
            int age = DateTime.Now.Year - birthYear;
            return age;
        }

        public static Person Input()
        {
            Console.Write("Please, enter name: ");
            string name = Console.ReadLine();
            Console.Write("Please, enter year of birth: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Person person = new Person(name, age);
            return person;
        }

        public void ChangeName()
        {
            if (Age() < 16)
            {
                name = "Very Young";
            }          
        }

        public void Output()
        {
            Console.WriteLine($"Person's name: {name}, Person's age: {Age()}");
        }

        public static bool operator == (Person first, Person second)
        {
            return (first.name == second.name);
        }

        public static bool operator != (Person first, Person second)
        {
            return !(first == second);
        }

        public override string ToString()
        {
            return "\nPerson's name: " + name + " " + "Person's age: " + Age();
        }
    }
}
