using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Counting
    {
        public void CountingLetters()
        {
            int countA = 0;
            int countO = 0;
            int countI = 0;
            int countE = 0;

            Console.Write("Enter the text: ");
            string str = Console.ReadLine();
            string[] strList = str.Split(' ');
            foreach (var i in strList)
            {
                foreach (var j in i)
                {
                    if (j == 'a')
                    {
                        countA++;
                    }
                    if (j == 'o')
                    {
                        countO++;
                    }
                    if (j == 'i')
                    {
                        countI++;
                    }
                    if (j == 'e')
                    {
                        countE++;
                    }
                }
            }

            Console.WriteLine($"Count of 'a' : {countA}, 'o' : {countO}, 'e' : {countE}, 'i' : {countI}");
        }
    }
}
