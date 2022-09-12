using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Data;
namespace _455
{
  
    class program
    {
  
        
        static void Main(string[] args)
        {
           //========= home work 3.1
            Console.WriteLine(" Ведіть ваше речення");
            string str = Console.ReadLine();


            int letters = 0;

            foreach (char c in str)
            {
                if (c == 'a')
                    letters++;
                if (c == 'o')
                    letters++;
                if (c == 'i')
                    letters++;
                if (c == 'e')
                    letters++;
            }

            Console.WriteLine("count = {0}", letters);
            Console.ReadKey();
            //========= home work 3.1

            Console.WriteLine(" Ведіть ваше речення");
            string str = Console.ReadLine();


            int letters = 0;
            int a = 0;
            int letterso = 0;
            int letterse = 0;
            int lettersi = 0;

            foreach (char c in str)
            {
                if (c == 'a')
                    letters++;
                a++;
                if (c == 'o')
                    letters++;
                
                if (c == 'i')
                    letters++;
                
                if (c == 'e')
                    letters++;
                
            }

            Console.WriteLine("count = {0}", letters);
            Console.WriteLine("count = {a}", a);         //??? Чому вибиває синтаксис
            //Console.WriteLine("count = {O}", letterso);
            //Console.WriteLine("count = {i}", lettersi);
            //Console.WriteLine("count = {E}", letterse);
            Console.ReadKey();
     

            //========= home work 3.2 

            Console.WriteLine("Ведіть рік ! ");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("Ведіть номер місяця ! ");
            int month = int.Parse(Console.ReadLine());

            int days = DateTime.DaysInMonth(year, month);
            Console.WriteLine(" Днів :  " + days +
                " міяціь  : " + month +
                " рік  : " + year);

            Console.ReadLine();


            //========= home work 3.3 if else
            Console.WriteLine("Ведіть 10 чисел");
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
            int number4 = int.Parse(Console.ReadLine());
            int number5 = int.Parse(Console.ReadLine());
            int number6 = int.Parse(Console.ReadLine());
            int number7 = int.Parse(Console.ReadLine());
            int number8 = int.Parse(Console.ReadLine());
            int number9 = int.Parse(Console.ReadLine());
            int number10 = int.Parse(Console.ReadLine());

            if (number1 > 0)
            {
            }
            if (number2 > 0)
            {
            }
            if (number3 > 0)
            {
            }
            if (number4 > 0)
            {
            }
            if (number5 > 0)
            {
                Console.WriteLine($"Sum = :{number1 + number2 + number3 + number4 + number5}");
            }
            else
            {
                Console.WriteLine($"Sum = :{number6 + number7 + number8 + number9 + number10}");
            }

            //========= home work 3.3 while
            Console.WriteLine("Ведіть 10 чисел");
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
            int number4 = int.Parse(Console.ReadLine());
            int number5 = int.Parse(Console.ReadLine());
            int number6 = int.Parse(Console.ReadLine());
            int number7 = int.Parse(Console.ReadLine());
            int number8 = int.Parse(Console.ReadLine());
            int number9 = int.Parse(Console.ReadLine());
            int number10 = int.Parse(Console.ReadLine());

            while ((number1 > 0) && (number2 > 0) && (number3 > 0) && (number4 > 0) && (number5 > 0))
            {
                Console.WriteLine($"Sum = :{number1 + number2 + number3 + number4 + number5}");
                break;
                Console.ReadKey();
            }
            Console.WriteLine($"Sum = :{number6 + number7 + number8 + number9 + number10}");

            Console.ReadKey();



        }
    }
}



