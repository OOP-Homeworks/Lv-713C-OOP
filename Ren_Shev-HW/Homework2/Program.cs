using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    internal class Program
    {
        enum HTTPError
        {
            BadRequest = 400,
            Unauthorized,
            PaymentRequired,
            Forbidden,
            NotFound,
            MethodNotAllowed,
            NotAcceptable,
            ProxyAuthenticationRequired,
            RequestTimeout,
            Conflict,
            InternalServerError = 500,
            NotImplemented
        }
        enum TestCaseStatus
        {
            Pass,
            Fail,
            Blocked,
            WP,
            Unexecuted
        }

        struct Dog
        {
            public string Name;
            public string Mark;
            public int Age;
            public override string ToString()
            {
                return string.Format("My dog`s name is {0}, his mark is {1}, and his age is {2} years old", Name, Mark, Age);
            }
        }
        struct RGB
        {
            public byte R;
            public byte G;
            public byte B;
        }
        struct Message
        {
            public int Id;
            public string TypefNum;

            public void ShowMessage()
            {
                Console.WriteLine("Enter {0} number {1}: ", TypefNum, Id);
            }

            public void ShowMessage2()
            {
                Console.WriteLine("Enter number {0}: ", Id);
            }

            public string ReadMessage()
            {
              return Console.ReadLine();
            }

            public float ConvertStringToFloat(string message)
            {
                return float.Parse(message, CultureInfo.InvariantCulture.NumberFormat);
            }

            public int ConvertStringToInt(string message)
            {
                return Convert.ToInt32(message);
            }

            public double ConvertStringToDouble(string message)
            {
                return double.Parse(message, CultureInfo.InvariantCulture.NumberFormat);
            }
        }

        static void Main(string[] args)
        {
            Console.Title = "Homework 2";
           
            // task 1
            Message task1Message;
            task1Message.Id = 1;
            task1Message.TypefNum = "integer";
            task1Message.ShowMessage();
            string task1Message1 = task1Message.ReadMessage();
            int tack1Num1 = task1Message.ConvertStringToInt(task1Message1);

            Message task1Message2;
            task1Message2.Id = 2;
            task1Message2.TypefNum = "integer";
            task1Message2.ShowMessage();
            string task1MessageTwo = task1Message2.ReadMessage();
            int tack1Num2 = task1Message2.ConvertStringToInt(task1MessageTwo);

            CheckDaysNumber(tack1Num1);
            CheckMonthNumber(tack1Num2);

            // task 2
            Message task2Message;
            task2Message.Id = 1;
            task2Message.TypefNum = "double";
            task2Message.ShowMessage();
            string task2Message1 = task2Message.ReadMessage();
            double tack2Num = task2Message.ConvertStringToDouble(task2Message1);

            double firstNum = (tack2Num % 1) * 10;
            double secondNum = (firstNum % 1) * 10;
            int sumOfNumbers = (int) firstNum + (int) secondNum;
            Console.WriteLine("First number {0} + second number {1} = {2}", (int) firstNum, (int) secondNum, sumOfNumbers);
            
            // task 3
            Message task3Message;
            task3Message.Id = 1;
            task3Message.TypefNum = "integer";
            task3Message.ShowMessage();
            string task3Message1 = task3Message.ReadMessage();
            int tack3Num = task3Message.ConvertStringToInt(task3Message1);
            
            CheckTimeOfDay(tack3Num);

            // task 4
            TestCaseStatus test1Status = TestCaseStatus.Pass;
            Console.WriteLine($"Test status pass is {test1Status}");

            // task 5
            RGB whiteRGB;
            whiteRGB.R = 255;
            whiteRGB.G = 255;
            whiteRGB.B = 255;
            Console.WriteLine("White color is rgb({0}, {1}, {2})", whiteRGB.R, whiteRGB.G, whiteRGB.B);

            RGB blackRGB;
            blackRGB.R = 0;
            blackRGB.G = 0;
            blackRGB.B = 0;
            Console.WriteLine("Black color is rgb({0}, {1}, {2})", blackRGB.R, blackRGB.G, blackRGB.B);

             // hw 1
            Message message1;
            message1.Id = 1;
            message1.TypefNum = "float";
            message1.ShowMessage();
            string messageForOne = message1.ReadMessage();
            float numberOfOne = message1.ConvertStringToFloat(messageForOne);

            Message message2;
            message2.Id = 2;
            message2.TypefNum = "float";
            message2.ShowMessage();
            string messageForTwo = message2.ReadMessage();
            float numberOfTwo = message2.ConvertStringToFloat(messageForTwo);

            Message message3;
            message3.Id = 3;
            message3.TypefNum = "float";
            message3.ShowMessage();
            string messageForThree = message3.ReadMessage();
            float numberOfThree = message3.ConvertStringToFloat(messageForThree);

            string checkNumbers = numberOfOne >= -5 && numberOfOne <= 5 && 
                             numberOfTwo >= -5 && numberOfTwo <= 5 && 
                             numberOfThree >= -5  && numberOfThree <= 5 ? 
                             "This numbers is all in the rang [-5.5]." :
                             "This numbers is not all in the rang [-5.5].";

            Console.WriteLine(checkNumbers);

            // hw 2
            Message messageHwTwo;
            messageHwTwo.Id = 1;
            messageHwTwo.TypefNum = "integer";
            messageHwTwo.ShowMessage();
            string messageForHw2 = messageHwTwo.ReadMessage();
            int numberOneHwTwo = messageHwTwo.ConvertStringToInt(messageForHw2);

            Message message2HwTwo;
            message2HwTwo.Id = 2;
            message2HwTwo.TypefNum = "integer";
            message2HwTwo.ShowMessage();
            string message2ForHw2 = message2HwTwo.ReadMessage();
            int numberTwoHwTwo = messageHwTwo.ConvertStringToInt(message2ForHw2);

            Message message3HwTwo;
            message3HwTwo.Id = 3;
            message3HwTwo.TypefNum = "integer";
            message3HwTwo.ShowMessage();
            string message3ForHw2 = message3HwTwo.ReadMessage();
            int numberThreeHwTwo = messageHwTwo.ConvertStringToInt(message3ForHw2);

            int minumumNumber = GetMinNumber(numberOneHwTwo, numberTwoHwTwo, numberThreeHwTwo);
            int maximumNumber = GetMaxNumber(numberOneHwTwo, numberTwoHwTwo, numberThreeHwTwo);
            Console.WriteLine($"Minimum number is {minumumNumber}, maximum number is {maximumNumber}");

            // hw 3
            Console.WriteLine("Enter number of error");
            string numberOfError = Console.ReadLine();
            HTTPError errors = (HTTPError) Convert.ToInt32(numberOfError);
            Console.WriteLine($"Error {numberOfError} is {errors}");

            // hw 4
            Dog myDog;
            Console.WriteLine("Enter your dog`s name?");
            myDog.Name = Console.ReadLine();
            Console.WriteLine("Enter your dog`s age?");
            myDog.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your dog`s mark?");
            myDog.Mark = Console.ReadLine();
            Console.WriteLine(myDog);

            Console.ReadKey();
        }
        public static int GetMaxNumber(int number1, int number2, int number3)
        {
            return Math.Max(number1, Math.Max(number2, number3));
        }
        public static int GetMinNumber(int number1, int number2, int number3)
        {
            return Math.Min(number1, Math.Min(number2, number3));
        }
        public static void CheckDaysNumber(int number) 
        {
            const int daysOfMonth = 31;
            
            if(number > 0 && number <= daysOfMonth)
            {
                Console.WriteLine("This number - {0} can represent a day", number);
            }
            else
            {
                Console.WriteLine("This number - {0} can not represent a day", number);
            };
        }
        public static void CheckMonthNumber(int number) 
        {
            const int monthOfYear = 31;

               if(number > 0 && number <= monthOfYear)
            {
                Console.WriteLine("This number - {0} can represent a month", number);
            }
            else
            {
                Console.WriteLine("This number - {0} can not represent a month", number);
            };
        }
        public static void CheckTimeOfDay(int hour) 
        {

             if (hour >= 6 && hour <= 11)
            {
                Console.WriteLine("Good morning!");
            }
            else if (hour >= 12 && hour <= 19)
            {
                Console.WriteLine("Good afternoon!");
            }
            else if (hour >= 20 && hour <= 23)
            {
                Console.WriteLine("Good evening!");
            }
            else if (hour == 24 || hour >= 0 && hour <= 5)
            {
                Console.WriteLine("Good night!");
            }
            else
            {
                Console.WriteLine("There is no this time of day on planet the earth.");
            }
        }

    }
}
