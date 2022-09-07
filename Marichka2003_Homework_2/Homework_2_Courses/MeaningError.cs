using System;


namespace Homework_2_Courses
{
    class MeaningError
    {
        enum HTTPError
        {
            BadRequest = 400,
            Unauthorized = 401,
            PaymentRequired = 402,
            Forbidden = 403
        };
        public void Error()
        {
            Console.WriteLine("Sixth task");
            bool ifTrue = true;
            string result;
            do
            {
                Console.Write("Enter number the error : ");
                int search = Convert.ToInt32(Console.ReadLine());

                switch (search)
                {
                    case 400:
                        Console.Clear();
                        result = "The equivalent of HTTP status 400. BadRequest indicates that the request cannot " +
                    "be accepted by the server.BadRequest is sent when any other error is not applicable or the error" +
                    " is unknown or does not have its own error code.";
                        Console.WriteLine(result);
                        break;
                    case 401:
                        Console.Clear();
                        result = "Equivalent to HTTP status 401. The Unauthorized value indicates that authentication " +
                    "is required for the requested resource. The WWW-Authenticate header describes the authentication " +
                    "procedure in detail.";
                        Console.WriteLine(result);
                        break;
                    case 402:
                        Console.Clear();
                        result = "The equivalent of HTTP status 402.PaymentRequired is reserved for further use.";
                        Console.WriteLine(result);
                        break;
                    case 403:
                        Console.Clear();
                        result = "The equivalent of HTTP status 403.Access to content is prohibited.";
                        Console.WriteLine(result);
                        break;
                    default:
                        Console.Clear();
                        ifTrue = false;
                        break;
                }
            } while (ifTrue);
        }
    }
}
