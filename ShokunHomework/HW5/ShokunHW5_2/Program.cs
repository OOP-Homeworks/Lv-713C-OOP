using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShokunHW5_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<int, string> users = new Dictionary<int, string>();

            int key = 0;
            string value = "";

            for(int i = 0; i < 7; i++)
            {
                Console.WriteLine($"Enter {i + 1} ID namber of user");
                key = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Enter {i + 1} user name");
                value = Console.ReadLine();
                users.Add(key, value);
            }

            Console.WriteLine("Please, enter user ID number");
            key = Convert.ToInt32(Console.ReadLine());
            if(users.TryGetValue(key, out string value1) == true)
            {
                Console.WriteLine($"User name: {users[key]}");
            }
            else
            {
                Console.WriteLine("There is no user with this ID in the list");
            }
            
        }
    }
}
