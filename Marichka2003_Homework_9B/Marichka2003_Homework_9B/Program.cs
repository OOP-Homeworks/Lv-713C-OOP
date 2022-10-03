using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marichka2003_Homework_9B
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrString = File.ReadAllLines("Shapes.txt", Encoding.Default);
            bool ifTrue = true;
            int j = 0;
            Console.WriteLine("Counting the number of symbols in every line: ");
            for (; j < arrString.Length; j++)
            {
                Console.WriteLine($" In Line {j + 1} we have {arrString[j].Length} chars");
            }
            Console.WriteLine("\n");

            Console.WriteLine("Longest and the shortest line: ");
            string longest = arrString.OrderByDescending(n => n.Length).First();
            Console.WriteLine($"Line {longest} is a longest line.");
            string shortest = arrString.OrderByDescending(n => n.Length).Last();
            Console.WriteLine($"Line {shortest} is a shortest line.");

            Console.WriteLine("\n");

            Console.WriteLine("Lines which consist of word 'var': ");

            foreach (string searchVar in arrString.ToList().FindAll(n => n.ToLower().Contains("var")))
            {
                ifTrue = false;

                Console.WriteLine($"Line contains word 'var' is {searchVar}");

            }
            if (ifTrue)
            {
                Console.WriteLine("There isn't word 'var' ");
            }
        }

        
    }
}
