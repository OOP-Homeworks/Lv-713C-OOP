using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK6
{
    internal class Program
    {


        static int Div(int a, int b)
        {
            return a / b;
        }

        static double Div(double a, double b)
        {
            return a / b;
        }

        static void ReadNumber(ref int start,ref int end)
        {
            a0:
            Console.Write("Enter start number: ");
            try
            {
                start = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                
                Console.WriteLine("Error, try again");
                goto a0;
            }

            Console.Write("Enter end number: ");
            
            try  
            {
                end = Convert.ToInt32(Console.ReadLine());
                if (end <= start)
                {
                    throw new Exception("End < Start, try again");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error, try again");
                goto a0;
            }
            catch (Exception ex) 
            {
                Console.Clear();
                Console.WriteLine($"{ex.Message}");
                goto a0;
            }
           
        }

        static void Main(string[] args)
        {
        //TASK1
        b1:

            try
            {
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(Div(a, b));
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                goto b1;
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                goto b1;
            }

        //TASK2
        b2:
            try
            {
                double x = Convert.ToDouble(Console.ReadLine());
                double y = Convert.ToDouble(Console.ReadLine());

                if (y == 0)
                {
                    throw new Exception("Div / 0");

                }

                Console.WriteLine(Div(x, y));
            }
            catch (FormatException e)
            {
                Console.WriteLine($"{e.Message}");
                goto b2;

            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
                goto b2;

            }

            //TASK3

            int start = 0;
            int end = 0;

            ReadNumber(ref start, ref end);

            for (int i = 0; i < 10; i++)
            {
                try
                {
                    Console.WriteLine($"Enter {i + 1} number");
                    int num = Convert.ToInt32(Console.ReadLine());
                    if (num <= start || num >= end)
                    {
                        throw new Exception("Error, try again");
                    }
                    start = num;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error, try again");
                    i--;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}");
                    i--;
                }


            }


        //    ReadNumber(ref start,ref end);
        //    Console.WriteLine($"You need to enter 10 numbers from {start} to {end}");
        
        //a1:

        //    try
        //    {
        //        Console.WriteLine("Enter 1 number");
        //        int num1 = Convert.ToInt32(Console.ReadLine());
        //        if (num1 <= start || num1 >= end)
        //        {
        //            throw new Exception("Error, try again");
        //        }
        //        start = num1;

        //    }
        //    catch(FormatException)
        //    {
        //        Console.WriteLine("Error, try again");
        //        goto a1;
        //    }
        //    catch(Exception ex)
        //    {
        //        Console.WriteLine($"{ex.Message}");
        //        goto a1;
        //    }
            
        //a2:
        //    try
        //    {
        //        Console.WriteLine("Enter 2 number");
        //        int num2 = Convert.ToInt32(Console.ReadLine());
        //        if (num2 <= start || num2 >= end)
        //        {
        //            throw new Exception("Error, try again");
        //        }
        //        start = num2;

        //    }
        //    catch (FormatException)
        //    {
        //        Console.WriteLine("Error, try again");
        //        goto a2;
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine($"{ex.Message}");
        //        goto a2;
        //    }

        //a3:

        //    try
        //    {
        //        Console.WriteLine("Enter 3 number");
        //        int num3 = Convert.ToInt32(Console.ReadLine());
        //        if (num3 <= start || num3 >= end)
        //        {
        //            throw new Exception("Error, try again");
        //        }
        //        start = num3;

        //    }
        //    catch (FormatException)
        //    {
        //        Console.WriteLine("Error, try again");
        //        goto a3;
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine($"{ex.Message}");
        //        goto a3;
        //    }
        //a4:
        //    try
        //    {
        //        Console.WriteLine("Enter 4 number");
        //        int num4 = Convert.ToInt32(Console.ReadLine());
        //        if (num4 <= start || num4 >= end)
        //        {
        //            throw new Exception("Error, try again");
        //        }
        //        start = num4;

        //    }
        //    catch (FormatException)
        //    {
        //        Console.WriteLine("Error, try again");
        //        goto a4;
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine($"{ex.Message}");
        //        goto a4;
        //    }

        //a5:
        //    try
        //    {
        //        Console.WriteLine("Enter 5 number");
        //        int num5 = Convert.ToInt32(Console.ReadLine());
        //        if (num5 <= start || num5 >= end)
        //        {
        //            throw new Exception("Error, try again");
        //        }
        //        start = num5;

        //    }
        //    catch (FormatException)
        //    {
        //        Console.WriteLine("Error, try again");
        //        goto a5;
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine($"{ex.Message}");
        //        goto a5;
        //    }

        //a6:
        //    try
        //    {
        //        Console.WriteLine("Enter 6 number");
        //        int num6 = Convert.ToInt32(Console.ReadLine());
        //        if (num6 <= start || num6 >= end)
        //        {
        //            throw new Exception("Error, try again");
        //        }
        //        start = num6;

        //    }
        //    catch (FormatException)
        //    {
        //        Console.WriteLine("Error, try again");
        //        goto a6;
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine($"{ex.Message}");
        //        goto a6;
        //    }

        //a7:
        //    try
        //    {
        //        Console.WriteLine("Enter 7 number");
        //        int num7 = Convert.ToInt32(Console.ReadLine());
        //        if (num7 <= start || num7 >= end)
        //        {
        //            throw new Exception("Error, try again");
        //        }
        //        start = num7;

        //    }
        //    catch (FormatException)
        //    {
        //        Console.WriteLine("Error, try again");
        //        goto a7;
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine($"{ex.Message}");
        //        goto a7;
        //    }

        //a8:
        //    try
        //    {
        //        Console.WriteLine("Enter 8 number");
        //        int num8 = Convert.ToInt32(Console.ReadLine());
        //        if (num8 <= start || num8 >= end)
        //        {
        //            throw new Exception("Error, try again");
        //        }
        //        start = num8;

        //    }
        //    catch (FormatException)
        //    {
        //        Console.WriteLine("Error, try again");
        //        goto a8;
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine($"{ex.Message}");
        //        goto a8;
        //    }

        //a9:
        //    try
        //    {
        //        Console.WriteLine("Enter 9 number");
        //        int num9 = Convert.ToInt32(Console.ReadLine());
        //        if (num9 <= start || num9 >= end)
        //        {
        //            throw new Exception("Error, try again");
        //        }
        //        start = num9;

        //    }
        //    catch (FormatException)
        //    {
        //        Console.WriteLine("Error, try again");
        //        goto a9;
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine($"{ex.Message}");
        //        goto a9;
        //    }

        //a10:
        //    try
        //    {
        //        Console.WriteLine("Enter 10 number");
        //        int num10 = Convert.ToInt32(Console.ReadLine());
        //        if (num10 <= start || num10 >= end)
        //        {
        //            throw new Exception("Error, try again");
        //        }
        //        start = num10;

        //    }
        //    catch (FormatException)
        //    {
        //        Console.WriteLine("Error, try again");
        //        goto a10;
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine($"{ex.Message}");
        //        goto a10;
        //    }


        }
    }

 }

