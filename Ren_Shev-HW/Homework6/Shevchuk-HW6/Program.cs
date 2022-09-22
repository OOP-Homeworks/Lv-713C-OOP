using System;


namespace Shevchuk_HW6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter number 1: ");
                int num1 = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Enter number 2: ");
                int num2 = Convert.ToInt16(Console.ReadLine());

                int result = Div(num1, num2);
                Console.WriteLine(result);

               

                Console.WriteLine("Enter double number 1: ");
                double num3 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter double number 2: ");
                double num4 = Convert.ToDouble(Console.ReadLine());
                if (num4 == 0)
                {
                    throw new DivideByZeroException("Number 2 should bu more then 0");
                }
                    
                double result2 = Dividing(num3, num4);

                Console.WriteLine(result2);

                Console.WriteLine("Enter numbers in the range 1 to 100");
                ReadNumber(1, 100);


            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (ApplicationException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("You are finish");
            }
            Console.ReadKey();
        }

        static int Div(int num1, int num2)
        {
            return num1 / num2;
        }

        static double Dividing(double num1, double num2)
        {
            return num1 / num2;
        }

        static void ReadNumber(int start, int end)
        {
            
            int previousNum = start;

            for(int i = 1; i <= 10; i++)
            {
         start:
                try
                {
                    Console.WriteLine($"Enter number {i}");
                        int currentNum = Convert.ToInt32(Console.ReadLine());
                    if(currentNum <= end)
                    {
                        if (previousNum < currentNum)
                        {
                            previousNum = currentNum;
                        }
                        else
                        {

                            throw new ApplicationException($"Current number {currentNum} must be > previous number {previousNum}");
                        }

                    }
                    else
                    {
                        throw new ApplicationException($"Current number {currentNum} must be < {end}");
                    }
                }
                catch (ApplicationException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    goto start;

                }
                        
            }
  
        }
    }
}
