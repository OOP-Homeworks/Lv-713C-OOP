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
        }
        static void Main(string[] args)
        {
            Console.Title = "Homework 2";
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

            string checkNumbers = numberOfOne >= -5.5 && 
                             numberOfTwo >= -5 && 
                             numberOfThree <= 5 ? 
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

    }
}
