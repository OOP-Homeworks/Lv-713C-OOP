using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    internal class Person
    {
        private string name;
        private DateTime birthYear;
        private int agePerson;
        public string Name
        {
            get { return name; }
        }
        public DateTime BirthYear
        {
            get { return birthYear; }
        }
        public int AgePerson
        {
            get { return agePerson; }
        }
        public Person(){}
        public Person(string name, DateTime birthYear, int agePerson)
        {
            this.name = name;
            this.birthYear = birthYear;
            this.agePerson = agePerson;
        }
        public void Input()
        {
            Console.Write("enter you name: ");
            name = Console.ReadLine();
            Console.Write("enter you year of born: ");
            int year = Convert.ToInt32(Console.ReadLine());
            birthYear = new DateTime(year, 1, 1);
        }
        public void Age()
        {
            agePerson = DateTime.Now.Year - birthYear.Year;
        }
        public void ChangeName()
        {
            if (agePerson < 16)
            {
                name = "Very Young";
            }
        }
        public override string ToString()
        {
            return $"You name: {name}, your age: {agePerson} years";
        }
        public string Output()
        {
            return ToString();
        }

        public static bool operator ==(Person first, Person second)
        {
            return (first.name == second.name);
        }

        public static bool operator !=(Person first, Person second)
        {
            return !(first.name == second.name);
        }
    }
}
