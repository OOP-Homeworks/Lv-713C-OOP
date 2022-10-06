using System;
using System.Collections.Generic;

namespace Marichka2003_Homework_10
{
    public class Person
    {
        private string name;
        private DateTime birthYear;
        public int age;

        public Person() { }

        public Person(string name)
        {
            this.name = name;
        }
        public struct People
        {
            public string name;
            public override string ToString()
            {
                return $"({name})";
            }
            public People(string name)
            {
                this.name = name;
            }
        }
     
        public int Age(DateTime birthYear)
        {
            age = DateTime.Now.Year - birthYear.Year;

            if (DateTime.Now.Month < birthYear.Month)
            {
                age -= 1;
            }
            return age;
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
        public string ChangeName(int age)
        {          
            if (age < 18)
            {
                return "Very Young";
            }
            else
            {
                return "Adult";
            }
        }

        public override string ToString()
        {
            return name;
        }
        public string Output()
        {
            return name.ToString();
        }

        public override bool Equals(object obj)
        {
            return obj is Person person &&
                   name == person.name &&
                   birthYear == person.birthYear &&
                   age == person.age;
        }

        public override int GetHashCode()
        {
            int hashCode = -1346232979;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(name);
            hashCode = hashCode * -1521134295 + birthYear.GetHashCode();
            hashCode = hashCode * -1521134295 + age.GetHashCode();
            return hashCode;
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
    class Program
    {
        static void Main(string[] args)
        {
                       
        }    
    }
}
