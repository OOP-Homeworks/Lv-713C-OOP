using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1._2
{
    internal class Program
    {
        private static string shapesTxt = @"C:\Users\38096\Desktop\c#\c#SoftServe\hw9\hw9\shapes.txt";
        static void Main(string[] args)
        {
            string[] textFromFile = new string[12];
            using (StreamReader sr = new StreamReader(shapesTxt))
            {
                for(int i = 0; i < textFromFile.Length; i++)
                textFromFile[i] = (sr.ReadLine());
            }

            SymbolsCount(textFromFile);
            LongestNshortestLine(textFromFile);
            ContainsCheck(textFromFile);
        }

        static int[] SymbolsCount(string[] words)
        {
            int[] symbolsCount = new int[words.Length];
            for (int i = 0; i < words.Length; i++)
            {
                symbolsCount[i] = words[i].Length;
                Console.WriteLine("number of symbols on line {0}: {1}", i, words[i].Length);
            }
            return symbolsCount;
        }
        
        static void LongestNshortestLine(string[] words)
        {
            int maxValueIndex = Array.IndexOf(SymbolsCount(words), SymbolsCount(words).Max());
            int minValueIndex = Array.IndexOf((words), SymbolsCount(words).Min());

            Console.WriteLine("Longest line is: {0}, Shortest line is: {1}", maxValueIndex, minValueIndex);
        }

        static void ContainsCheck(string[] words)
        {
            Console.WriteLine("Enter the word you want to find");
            try
            {
                string word = Console.ReadLine();
                var search = from s in words
                             where s.Contains(word)
                             select s;
                foreach (string s in search)
                {
                    Console.WriteLine(s);
                }
            } catch(Exception ex)
            {
                Console.WriteLine(ex.Message); ;
            }
        }
    }
}
