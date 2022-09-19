using SlobodeniukHW5_2;
using System;

namespace SlobodeniukHW5_2
{
    internal class Programm
    {
        static void Main(string[] args)
        {
            var persons = new Persons[7];

            for (int i = 0; i < persons.Length; i++)
            {
                persons[i] = Persons.Input(i);
            }


            Dictionary<uint, string> combinations = new Dictionary<uint, string>();
            combinations.Add(persons[0].Id, persons[0].Name);
            combinations.Add(persons[1].Id, persons[1].Name);
            combinations.Add(persons[2].Id, persons[2].Name);
            combinations.Add(persons[3].Id, persons[3].Name);
            combinations.Add(persons[4].Id, persons[4].Name);
            combinations.Add(persons[5].Id, persons[5].Name);
            combinations.Add(persons[6].Id, persons[6].Name);

            Console.WriteLine("Enter the ID: ");
            uint id = Convert.ToUInt32(Console.ReadLine());

            foreach (KeyValuePair<uint, string> pair in combinations)
            {
                if (id == pair.Key)
                {
                    Console.WriteLine("Name of user: " + pair.Value);
                }
                else
                {
                    Console.WriteLine("ID doesn't match");
                }
            }

        }
    }
}