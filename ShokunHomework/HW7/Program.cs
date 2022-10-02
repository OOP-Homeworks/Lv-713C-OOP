using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShokunHW7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, string> phoneBook = new Dictionary<string, string>();
            string pathToPhoneBook = @"D:\phones.txt";
            string pathToPhones = @"D:\PhonesOnly.txt";
            string newPhones = @"D:\new.txt";
            int i = 0;

            using (StreamReader sr = new StreamReader(pathToPhoneBook, System.Text.Encoding.Default))
            {
                using (StreamWriter sw = new StreamWriter(pathToPhones, false, System.Text.Encoding.Default))
                {
                    while(i < 9)
                    {
                        string[] input = sr.ReadLine().Split(' ');
                        phoneBook.Add(input[0], input[1]);
                        sw.WriteLine(input[1]);
                        i++;
                    }
                }

                Console.WriteLine("Enter the name");
                string inputname = Console.ReadLine();
                foreach(KeyValuePair<string, string> v in phoneBook)
                {
                    if (v.Key == inputname)
                    {
                        Console.WriteLine(v.Value);
                    }
                }

                using (StreamWriter sw = new StreamWriter(newPhones, false, System.Text.Encoding.Default))
                {
                    foreach(string phone in phoneBook.Values)
                    {
                        if (!phone.StartsWith("+3"))
                        {
                            sw.WriteLine("+3" + phone);
                        }
                        else
                        {
                            sw.WriteLine(phone);
                        }
                    }
                }
            }
        }
    }
}
