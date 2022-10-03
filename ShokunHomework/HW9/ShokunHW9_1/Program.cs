using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShokunHW9_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> textFromFile = new List<string>();

            using (StreamReader sr = new StreamReader(@"D:\SomeText.txt", System.Text.Encoding.Default))
            {
                string line;
                while((line = sr.ReadLine()) != null)
                {
                    textFromFile.Add(line);
                }
            }

            using (StreamWriter sw = new StreamWriter(@"D:\NumbersOfSymbols.txt", false, System.Text.Encoding.Default))
            {
                foreach(String line in textFromFile)
                {
                    sw.WriteLine(line.Count());
                }
            }

            var k = textFromFile.Select(s => s.Length).ToArray();
            Console.WriteLine($"Min - {textFromFile[Array.IndexOf(k, k.Min())]}\nMax - {textFromFile[Array.IndexOf(k, k.Max())]}");

            List<string> onlyVar = new List<string>();

            foreach (String line in textFromFile)
            {
                if (line.Contains("var"))
                {
                    onlyVar.Add(line);
                }
            }

            using (StreamWriter sw = new StreamWriter(@"D:\onlyVar.txt", false, System.Text.Encoding.Default))
            {
                foreach(string line in onlyVar)
                {
                    sw.WriteLine(line);
                }
            }

            Console.ReadKey();

        }
    }
}
