
namespace HW4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] person = new Person[3];
            for (int i = 0; i < person.Length; i++)
            {
                person[i] = new Person();
                person[i].Input();
                person[i].Age();
            }
            for (int i = 0; i < person.Length; i++)
            {
                if (person[i].AgePerson < 16)
                {
                    person[i].ChangeName();
                }
                Console.WriteLine(person[i].Output());
            }
            Console.WriteLine("_______________");
            for (int i = 0; i < person.Length; i++)
            {
                for (int j = i; j < person.Length; j++)
                {
                    if (person[i].Name == person[j].Name)
                    {
                        Console.WriteLine("Person {0} and {1} is a Equals", person[i].Name, person[j].Name);
                    }
                    else
                    {
                        Console.WriteLine("Not equals");
                    }
                }
            }
            Console.WriteLine("_______________");
            for (int i = 0; i < person.Length; i++)
            {
                Console.WriteLine(person[i].Output());
            }
        }
    }
}