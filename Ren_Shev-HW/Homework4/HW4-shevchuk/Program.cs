using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HW4_shevchuk
{
    internal class Program
    {
        static void Main(string[] args)
        {
       
           Person tom = new Person();
           
            Person[] persons = new Person[6];
            persons[0] = tom;

            for(int i = 1; i < persons.Length; i++)
            {
                persons[i] = Person.Input(i);
            }

            Console.WriteLine("Info about all users: ");

            for (int i = 0; i < persons.Length; i++)
            {
                persons[i].Output();
            }

            Console.WriteLine("We change names all users who younger then 16. \nInfo about all users is updated: ");
            for (int i = 0; i < persons.Length; i++)
            {
                int yearOfBirth = persons[i].BirthYear;
                int currentAge = persons[i].Age(yearOfBirth);

                if(currentAge < 16)
                {
                    persons[i].ChangeName("Very Young");
                }
                persons[i].Output();
            }

            Console.WriteLine("List of persons with the same names: ");

            for (int i = 0; i < persons.Length; i++)
            {
                Console.WriteLine("Info about person");
                persons[i].Output();

                for (int j = (i + 1); j < persons.Length; j++)
                {

                    if (persons[i].Name == persons[j].Name)
                    {
                        Console.WriteLine("The person has the same name with {0}", persons[j].Name);
                        persons[j].Output();

                    }
                }
              
            }
            Console.ReadKey();
        }
    }
}
