using System;
using System.Security.Cryptography; 

class Program
{
    static void Main(string[] args)
    {
        try 
        {
            Console.WriteLine("Enter 2 numbers");
            Console.Write("start=");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.Write("end=");
            int end = Convert.ToInt32(Console.ReadLine());
            if (start > end) { throw new ApplicationException("start must be < end"); }
            if (start == 0) { throw new FormatException("start  must be >0"); }
            if (end == 0) { throw new FormatException(" end must be >0"); }
            int[] numbers = ReadNumber(start, end);
        }
        catch (FormatException exception)
        {
            Console.WriteLine(exception.Message);
        }
        catch (ApplicationException exception)
        {
            Console.WriteLine(exception.Message);
        }
        catch(Exception ex)
        {
            Console.WriteLine($"Unexpected exception: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("________________");
        }
        Console.ReadKey();
    }

    public static int[] ReadNumber(int start, int end)
    {
        const int COUNT = 10;
        int[] result = new int[COUNT];
        int min = start;
        for (int i = 0; i < COUNT; i++)
        {
            Console.WriteLine($"Enter 10 numbers in range [{start}, {end}]");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num <= min || num >= end)
            {
                throw new Exception("Error, try again");
            }
            min = num;
            result[i] = num;
        }
        return result;
    }
}


