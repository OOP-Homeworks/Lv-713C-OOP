using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Marichka2003_Homework7
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> PhoneBook = new Dictionary<string, string>();
            Dictionary<string, string> NewPhoneBook = new Dictionary<string, string>();

            string[] PhoneNumbers;
            using (StreamReader r = new StreamReader("phones.txt"))
            {
                string line;
                while ((line = r.ReadLine()) != null)
                {
                    PhoneNumbers = line.Split(' ');
                    PhoneBook.Add(PhoneNumbers[0],PhoneNumbers[1]);
                    NewPhoneBook.Add(PhoneNumbers[0], PhoneNumbers[1]);
                }

                r.Close();
            }

            using (StreamWriter w = new StreamWriter("Phone.txt"))
            {
                foreach (var item in PhoneBook)
                {
                    w.Write($"{item.Value} \n");
                }
                w.Close();
            }

            using (StreamWriter w = new StreamWriter("New.txt"))
            {
                foreach (var item in PhoneBook)
                {
                    if (item.Value[0] == '0' )
                    {
                        NewPhoneBook[item.Key] = $"+38{item.Value}";
                        w.Write($"{NewPhoneBook[item.Key]} \n");
                    }
                    else if (item.Value[0] == '8')
                    {
                        NewPhoneBook[item.Key] = $"+3{item.Value}";
                        w.Write($"{NewPhoneBook[item.Key]} \n");
                    }
                    else if (item.Value[0] == '3')
                    {
                        NewPhoneBook[item.Key] = $"+{item.Value}";
                        w.Write($"{NewPhoneBook[item.Key]} \n");
                    }
                }
                w.Close();
            }

        start:
            try
            {
                Console.Write("Enter the name: ");
                string name = Console.ReadLine();
                Console.WriteLine($"{NewPhoneBook[name]}");
            }
            catch (Exception)
            {
                Console.WriteLine("This name isn't in phone book");
                goto start;
            }

        }
        
    }
}
