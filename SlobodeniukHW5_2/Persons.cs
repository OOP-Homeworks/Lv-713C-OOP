using System;

namespace SlobodeniukHW5_2
{
    internal class Persons
    {
        private string name;
        private uint id;

        public Persons(string name, uint id)
        {
            this.name = name;
            this.id = id;
        }

        public static Persons Input(int i)
        {
            Console.WriteLine($"Enter {i + 1} name of person: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Enter {i + 1} ID of person: ");
            uint id = Convert.ToUInt32(Console.ReadLine());
            Persons persons = new Persons(name, id);
            return persons;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public uint Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}