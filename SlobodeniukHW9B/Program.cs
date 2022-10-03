using System;

namespace Slobodeniuk_HW9
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Read all lines of text from file into array of strings. Count and write the number of symbols in every line.");
            string[] fileContent = File.ReadAllLines(Path.Join(@"D:\Text.txt"), System.Text.Encoding.Default);

            for (int i = 0; i < fileContent.Length; i++)
            {
                Console.WriteLine($"Line {i}; chars:{fileContent[i].Length}");
            }

            Console.WriteLine("Find the longest and the shortest line. ");
            string longestLine = fileContent.OrderByDescending(n => n.Length).First();
            Console.WriteLine("Line '{0}' is a longest line.", longestLine);

            string shortestLine = fileContent.OrderByDescending(n => n.Length).Last();
            Console.WriteLine("Line '{0}' is a shortest line.", shortestLine);

            Console.WriteLine("Find and write only lines, which consist of word 'var'");
            foreach (string countVar in fileContent.ToList().FindAll(n => n.ToLower().Contains("var")))
            {
                Console.WriteLine("Line consist 'var': '{0}'", countVar);
            }

        }
    }
}