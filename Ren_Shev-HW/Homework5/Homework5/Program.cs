using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // hw5 part 1
            List<IDeveloper> listOfDevelopers = new List<IDeveloper>();

            for (int i = 1; i < 5; i++)
            {
                
                if (i % 2 == 0)
                {
                    listOfDevelopers.Add(Programmer.Print(i));
                }
                else
                {
                    listOfDevelopers.Add(Builder.Print(i));
                }

            }

            Console.WriteLine("Sort by tools");

            listOfDevelopers.Sort();

            foreach (var developer in listOfDevelopers)
            {
                developer.Create();
            }

            Console.WriteLine("Destroy users");

            foreach (var developer in listOfDevelopers)
            {
                developer.Destroy();
            }

            listOfDevelopers.Clear();


            // hw 5 part 2
            Dictionary<uint, string> developers = new Dictionary<uint, string>();

            int index = 1;

            while (index <= 7)
            {
                Console.WriteLine($"Enter name of person number {index}: ");
                string name = Console.ReadLine();
                Console.WriteLine($"Enter ID for user {name}: ");
                uint ID = Convert.ToUInt16(Console.ReadLine());

                try
                {
                    developers.Add(ID, name);
                    index++;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Try again!");
                    continue;

                }
            }
        
            Console.WriteLine("Check user by ID.");
            Console.WriteLine("Enter ID number: ");
            uint userID = Convert.ToUInt16(Console.ReadLine());

            string username;

            if(developers.TryGetValue(userID, out username))
            {
                Console.WriteLine($"Name user: {username}");
            }
            else
            {
                Console.WriteLine($"We cant find this ID: {userID}");
            }
            
            
            Console.ReadKey();
        }
    }
}
