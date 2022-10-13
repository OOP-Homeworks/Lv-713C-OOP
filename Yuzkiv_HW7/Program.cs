using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_7
{
    public class Program
    {
        static void Main(string[] args)
        {
            string readPath = @"D:\Learn .Net\SoftServeHomeTasks\HW_7\phones.txt";
            string writePath = @"D:\Learn .Net\SoftServeHomeTasks\HW_7\Phones1.txt";
            string writeNewPath = @"D:\Learn .Net\SoftServeHomeTasks\HW_7\New.txt";

            Dictionary<string, string> PhoneBook = new Dictionary<string, string>(9);

            using (StreamReader sr = new StreamReader(readPath, Encoding.UTF8))
            {
                string[] str = new string[9];
                string[] personName = new string[9];
                string[] phoneNumber = new string[9];
                string temp = "";

                for (int i = 0; i < 9; i++)
                {
                    str[i] = File.ReadLines(readPath).Skip(i).First();

                    temp = str[i];

                    for (int k = 0; k < temp.Length; k++)
                    {
                        if (char.IsLetter(temp[k]))
                        {
                            personName[i] = personName[i] + temp[k].ToString();
                        }
                        else if (temp[k] == ' ')
                        {
                            continue;
                        }
                        else
                        {
                            phoneNumber[i] = phoneNumber[i] + temp[k];
                        }
                    }

                    PhoneBook.Add(personName[i], phoneNumber[i]);

                    string numbers = phoneNumber[i];
                    using (StreamWriter sw = new StreamWriter(writePath, true, Encoding.UTF8))
                    {
                        sw.WriteLine(numbers);

                        string n = phoneNumber[i].ToString();
                        if (n.Length == 11)
                        {
                            using (StreamWriter newSw = new StreamWriter(writeNewPath, true, Encoding.UTF8))
                            {
                                newSw.WriteLine(n.Substring(0, 0) + "+3" + n);
                            }                                
                        }
                    }                  
                }
            }

            Console.WriteLine("Enter Person name ");
            string findNumber = Console.ReadLine();
            if (PhoneBook.Keys.Contains(findNumber))
            {
                Console.WriteLine(PhoneBook[findNumber]);
            }
            else
            {
                Console.WriteLine("This name is not valid!");
            }
        }
    }
}
