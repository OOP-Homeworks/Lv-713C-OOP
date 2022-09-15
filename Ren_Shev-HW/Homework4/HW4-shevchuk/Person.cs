using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HW4_shevchuk
{
    internal class Person
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
            this.name = "John";
            this.birthYear = DateTime.Now.Year;
        }
        public Person(string name, int year)
        {
            this.name = name;
            this.birthYear = year;
        }

        public static bool operator ==(Person first, Person second)
        {
            return first.name == second.name;
        }
        public static bool operator !=(Person first, Person second)
        {
            return !(first == second);
        }
        public static Person Input(int i)
        {
            Console.WriteLine($"Enter person {i + 1} name: ");
            string name = Console.ReadLine();

            Console.WriteLine($"Enter person {i + 1} year of birthday: ");
            int birthYear = Convert.ToInt16(Console.ReadLine());

            Person person = new Person(name, birthYear); 
            return person;
        }
        public int Age(int year)
        {
            var today = DateTime.Today;

            var age = today.Year - year;
            return age;
        }
        public void ChangeName(string newName)
        {
            this.name = newName;
        }
        public void Output()
        {
            Console.WriteLine(ToString());
        }
        public override string ToString()
        {
            return $"Person name: {name} \nperson age: {Age(birthYear)}\n";
        }
    }
}
