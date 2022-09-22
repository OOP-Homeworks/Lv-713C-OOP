using System;
using System.Collections.Generic;

namespace hw5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> idperson = new Dictionary<string, string>();
            // idperson["doc"] = "winword.exe";

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter please Key ");
                string person_key = Console.ReadLine();

                Console.WriteLine("Enter please Name ");
                string person_name = Console.ReadLine();
                idperson[person_key] = person_name;

            }
            Console.WriteLine("Enter id person please !");


            string value = "";
            string findkey = Console.ReadLine();
            if (idperson.TryGetValue("3", out value))
            {
                Console.WriteLine($"For key = {findkey}, value = {value}.", value);
            }
            else
            {
                Console.WriteLine($"Key = {findkey} is not found.");
            }


            Console.WriteLine("Info all person:");
            foreach (KeyValuePair<string, string> kvp in idperson)
            {
                    Console.WriteLine("Key = {0}, Value = {1}",
                        kvp.Key, kvp.Value);
            }





                Console.ReadLine();



            
        }
    }
}