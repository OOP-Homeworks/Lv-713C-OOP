using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marysa2003_Homework4
{
    class Person
    {

        private string name;
        private DateTime birthYear;
        public int age;
        public string PersonName
        {
            get { return name; }
        }
        public DateTime PersonAge
        {
            get { return birthYear; }
        }

        public Person(string name, DateTime birthYear)
        {
            this.name = name;
            this.birthYear = birthYear;
        }
        public Person(){}
        public void Age()
        {
            age = DateTime.Now.Year - birthYear.Year;
           
            if (DateTime.Now.Month < birthYear.Month)
            {
                age -= 1;
            }
            
            Console.WriteLine($"{name} is {age}");
        }

        public void Input(int i)
        {
            Console.Write($"Enter {i + 1} person's name : ");
            name = Console.ReadLine();
            Console.Write($"Enter {i + 1} person's birthday in format dd/mm/yyyy : ");
            birthYear = Convert.ToDateTime(Console.ReadLine());
            while (birthYear.Year > DateTime.Now.Year)
            {
                Console.WriteLine("You Enter wrong date!");
                Console.Write($"Enter {i + 1} person`s birthday in format dd/mm/yyyy : ");
                birthYear = Convert.ToDateTime(Console.ReadLine());
            
            } 

        }
        public void ChangeName(Person[] person,int i)
        {
            Console.Write($"Change {person[i]} to ");
            name = "Very Young";
        }

        public override string ToString()
        {         
            return name;
        }
        public void Output()
        {
            name.ToString();
        }
        public static bool operator == ( Person first, Person second)
        {
            return (first.name == second.name);
        }

        public static bool operator != (Person first, Person second)
        {
            return !(first.name == second.name);
        }
    }
}
