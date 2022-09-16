using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Marichka2003_Homework_5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> persons = new Dictionary<int, string>();
            bool ifTrue = true;
            int i = 0;
            while(ifTrue)
            {
                try
                {
                    for (; i < 7; i++)
                    {
                        Console.Write("Enter the ID of person : ");
                        int number = Convert.ToInt32(Console.ReadLine());
                        foreach (var item in persons)
                        {
                            if (number == item.Key)
                            {
                                Console.WriteLine("You enter duplicate ID!");
                                Console.Write("Enter the ID of person : ");
                                number = Convert.ToInt32(Console.ReadLine());
                            }
                        }
                        Console.Write("Enter the name of person : ");
                        string name = Console.ReadLine();

                        persons.Add(number, name);

                        if(i == 6)
                        {
                            ifTrue = false;
                        }
                    }
                }
                catch (Exception)
                {
                    Debug.WriteLine("Exception Message");
                }
            }
            Console.Clear();
            ifTrue = true;
            foreach (var item in persons)
            {
                Console.WriteLine($"{item.Key} {item.Value} ");
            }


            Console.Write("Enter the ID: ");
            int ID = Convert.ToInt32(Console.ReadLine());
            foreach (var item in persons)
            {
                if (ID == item.Key)
                {
                    Console.WriteLine($"This ID has name : {item.Value}");
                    ifTrue = false;
                }
            }
            if (ifTrue)
            {
                Console.WriteLine("There aren't the such ID");
            }

        }
    }
}
