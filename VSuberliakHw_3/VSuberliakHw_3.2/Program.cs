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

            Console.WriteLine("Please enter the number of month");
            int monthNumber = Int16.Parse(Console.ReadLine());

            try
            {

                if (monthNumber == 2)
                {
                    Console.WriteLine("there can be 28 or 29 days depending on year (leap or no).Add year you need");
                    int year = Int32.Parse(Console.ReadLine());
                    int days = DateTime.DaysInMonth(year, monthNumber);
                    Console.WriteLine($"In your month there are " + days + "days");
                }
                else if (monthNumber <= 0 || monthNumber >= 13)
                {
                    Console.WriteLine("Year has 12 months,please add value between 1-12");
                }
                else if (monthNumber == 0 || monthNumber == 13 || monthNumber == 13)
                {
                    Console.WriteLine("Year has 12 months,please add value between 1-12");
                }
                else                
                {
                    Console.WriteLine("In your month there are 31 days");
                }
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Only digits are alloved,please add value between 1-12 for month and 1 and 9999 for year ");
            }
            catch (System.ArgumentOutOfRangeException)
            {
                Console.WriteLine("Year must be between 1 and 9999");
            }

        }
    }
}
