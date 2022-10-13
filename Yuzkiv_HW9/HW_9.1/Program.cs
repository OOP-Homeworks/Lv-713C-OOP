using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_9._1
{
    public class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Learn .Net\SoftServeHomeTasks\HW_9.1\iii.txt";

            List<string> readedLines = new List<string>();

            using (StreamReader sr = new StreamReader(path, Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    readedLines.Add(line);          
                }              
            }

            foreach (string item in readedLines)
            {
                Console.WriteLine(item.Length);
            }

            var sortedParts = readedLines.OrderBy(x => x.Length).ToList();

            var minElement = sortedParts.Min();
            var maxElement = sortedParts.Max();

            Console.WriteLine($"Minimal line: {minElement}");
            Console.WriteLine($"Maximal line: {maxElement}");

            var sortedWithWord = readedLines.Where(x => x.Contains("var")).ToList();

            foreach (string item in sortedWithWord)
            {
                Console.WriteLine($"Lines with word 'var' {item}");
            }
        }
    }
}
