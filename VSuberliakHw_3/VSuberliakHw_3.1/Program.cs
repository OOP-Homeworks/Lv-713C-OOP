using System;
using System.ComponentModel.Design;
using System.Drawing;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;
namespace VSuberliakHw_3._1
{
    //TASK 3.1: Read some string str.
    //Calculate the counts of characters ‘a’, ’o’, ’i’, ’e’  in this text.

    internal class Program
    {
        static void Main(string[] args)
        {
            string userText = Console.ReadLine();

            int charA = 0;
            int charO = 0;
            int charI = 0;
            int charE = 0;

            foreach (char c in userText)
            {
                if (c == 'a') charA++;
                else if (c == 'o') charO++;
                else if (c == 'i') charI++;
                else if (c == 'e') charE++;
            }

            if (charA == 0 & charO == 0 & charI == 0 & charE == 0)
            {
                Console.WriteLine("there is no expected characters in your text ");
            }
            else
            {
                Console.WriteLine($"'a' is repeated " + charA + " times" +
                    "\n" + "'o' is repeated " + charO + " times"+
                    "\n" + "'i' is repeated " + charI + " times"+
                    "\n" + "'e' is repeated " + charE + " times");
            }   
        }
    }
}

