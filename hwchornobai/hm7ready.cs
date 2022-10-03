using System;
using System.Collections.Generic;
using System.IO;


namespace hm7try
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> PhoneBook = new Dictionary<string, string>();
            Dictionary<string, string> newtxt = new Dictionary<string, string>();
            var phone_numbers = "/Users/marianchornobai/Desktop/Phones.txt";
            var write_phone = "/Users/marianchornobai/Desktop/new.txt";
            var blabla = "/Users/marianchornobai/Desktop/Phones2.txt";
            string person_name;
            string read = "";
            int counter = 1;



            StreamReader reader = new StreamReader(phone_numbers, System.Text.Encoding.Default);
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine($"Enter name {counter++} ");
                person_name = Console.ReadLine();
                PhoneBook[person_name] = line;
            }
            reader.Close();


            Console.WriteLine("***** PHONE BOOK INFO *****:");
            foreach (KeyValuePair<string, string> kvp in PhoneBook)
            {
                Console.WriteLine("Value = {0}, Key = {1}",
                    kvp.Key, kvp.Value);
            }

        a1:
            Console.WriteLine(" PLEASE ENTER NAME TO FIND NUMBER : ");
            string find_name = Console.ReadLine();
            string find_phone = "";

            if (PhoneBook.TryGetValue(find_name, out find_phone))
            {
                Console.WriteLine($"For phone number  = {find_phone}, name is = {find_name}.", find_name);
            }
            else
            {
                Console.WriteLine($"Name  = {find_name} is not found.");
                goto a1;
            }
            Console.ReadKey();

            using (StreamWriter sw = new StreamWriter(blabla, false, System.Text.Encoding.Default))
            {
                foreach (string phone in PhoneBook.Values)
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
            using (StreamReader rd = new StreamReader (blabla, System.Text.Encoding.Default))
            {

                read = rd.ReadToEnd();

                using (StreamWriter sw = new StreamWriter(write_phone, false, System.Text.Encoding.Default))
                {

                    sw.WriteLine(read);
                }
                   
                  
                  
                   
            }

                

       

           
           
            
           

        }

    }
}