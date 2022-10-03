using System;
using System.Collections.Generic;
using System.Text;
class StartEnd
{
    static void ReadNumber(int start, int end)
    {
        Console.WriteLine(" Please enter ten numbers from 1 to 100 !");
        int[] allNumbers = new int[10];
        int q = 1;
        for (int i = 0; i < 10; i++)
        {
            a1:
            try
            {
                Console.WriteLine($"Number {q++}");
                allNumbers[i] = int.Parse(Console.ReadLine());
                if (allNumbers[i] < start || allNumbers[i] > end)
                    
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter number again! " +
                                    "Invalid format of input!");
                goto a1;
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Please enter number again! " +
                                    "The number is out of the range!");
                goto a1;
                
            }
            start = allNumbers[i]; 
        }
    }
    static void Main()
    {
        int start = 1;
        int end = 100;
        ReadNumber(start, end);
        Console.ReadLine();
    }
   
}