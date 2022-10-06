using System;


namespace VSuberliakHw_3._2
{
    internal class Program
    {
        //Ask user to enter the number of month.
        //Read value and output the count of days in this month.
        //1,3,5,7,8,10,12 - 31
        //2 - 28/29
        //4,6,9,11 - 30
        

        static void Main(string[] args)
        {          

            try
            {
                Console.WriteLine("Please enter the number of month");
                int monthNumber = Int16.Parse(Console.ReadLine());
                if (monthNumber == 1 || monthNumber == 3 || monthNumber == 5)
                {
                    Console.WriteLine("28");
                }
                else if (monthNumber == 2 )
                {
                    Console.WriteLine("28");
                }
                else
                {
                    Console.WriteLine("30");
                }
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Year has 12 months,please add value between 1-12");
            }
        }
    }
}
