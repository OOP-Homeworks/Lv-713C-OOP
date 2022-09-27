using System;

namespace SuberliakHw2._3
{
    internal class Program
    {
        //TASK3: Read number of HTTP Error(400, 401,402, ...) and write the name of this error (Declare enum HTTPError)

        
        static void Main(string[] args)
        {
            GetErrorCodeFromUser();
            var response = Convert.ToInt32(Console.ReadLine());
            ErrorCodeToText((HTTPErrorsEnum)response);
        }

        static void ErrorCodeToText(HTTPErrorsEnum response)
        {
            Console.WriteLine("Your code means: " + response.ToString());
        }

        static void GetErrorCodeFromUser()
        {
            Console.Write("Please add error code : ");
        }
    }



}
