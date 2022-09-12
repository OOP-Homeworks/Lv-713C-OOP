using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Month
    {
        public void MonthAndTheirDays()
        {
            Dictionary<string, int> monthAndDay = new Dictionary<string, int>()
            {
                { "JANUARY", 31},
                { "FEBRUARY", 28},
                { "MARCH", 31},
                { "APRIL", 30},
                { "MAY", 31},
                { "JUNE", 30},
                { "JULE", 31},
                { "AUGUST", 30},
                { "SEPTEMBER", 31},
                { "OCTOBER", 30},
                { "NOVEMBER", 31},
                { "DECEMBER", 30}

            };
            Console.Write("Enter the month: ");
            string month = Console.ReadLine().ToUpper();
            foreach (var item in monthAndDay)
            {
                if (month == item.Key)
                {
                    Console.WriteLine($"This month has {item.Value} days");
                }
            }
        }
    }
}
