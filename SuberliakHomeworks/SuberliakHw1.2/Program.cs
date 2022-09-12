using System;

namespace SuberliakHw1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TASK2: Print user name and age

            static void ShowErrorMessage()
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("You added wrong value,add only positive number and > 0");
            }

            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            userName = char.ToUpper(userName[0]) + userName.Substring(1).ToLower();
            Console.WriteLine($"How old are you, {userName}?");

            try
            {

                int age = Convert.ToInt32(Console.ReadLine());

                if (age > 0)
                {
                    Console.WriteLine($"Hello {userName},your are {age} years old.");
                }
                else
                {
                    ShowErrorMessage();
                }
            }
            catch (FormatException)
            {
                ShowErrorMessage();
            }

        }
    }
}