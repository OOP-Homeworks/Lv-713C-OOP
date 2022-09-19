using System;
namespace learnqw
{
    public class EmptyClass
    {
        public EmptyClass()
        {
            class Person
        {
            private string name;
            public string Name
            {
                set { name = value; }
                get { return name; }
            }
            private int birthYear;
            public int PersonAge
            {
                set { birthYear = value; }
                get { return birthYear; }
            }

            public int Person_Age;

            public Person() { }
            public Person(string n, int b) { name = n; b = birthYear; }

            public void Person_age()
            {
                Person_Age = 2022 - birthYear;
                Console.WriteLine($"Person_age :   Name is {name} && age {Person_Age}");

            }

            public void Input(int i)
            {
                Console.WriteLine("Enter the name ");
                name = Console.ReadLine();
                Console.WriteLine("Enter the birhyear ");
                birthYear = int.Parse(Console.ReadLine());
            }
            public void ChangeName(Person[] person, int i)
            {
                Console.WriteLine($"Change {person[i]} to ");
                name = "Very Young";
            }
            public override string ToString()
            {
                return "Name is :" + name + "  BirhYear is :" + birthYear;
            }
            public void Output()
            {

                Console.WriteLine($"Person name " + name + "Birth Year " + birthYear);
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
}

