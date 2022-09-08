namespace HW2_Maximovich
{
    internal class Program
    {
        enum HTTPError { BadRequest = 400, Unauthorizet = 401, Payment = 402, Forbidden = 403, PageNotFound = 404 };
        struct Dog
        {
            public Dog(string name, string mark, int age)
            {
                Name = name;
                Mark = mark;
                Age = age;
            }

            public string Name { get; set; }
            public string Mark { get; set; }
            public int Age { get; set; }

            public override string? ToString()
            {
                return $"Name dog: {Name}, Age: {Age}, Breed: {Mark}";
            }
        }

        static void Main(string[] args)
        {
            //task1

            Console.Write("enter first number: ");
            float num1 = Convert.ToSingle(Console.ReadLine());
            Console.Write("enter second number: ");
            float num2 = Convert.ToSingle(Console.ReadLine());
            Console.Write("enter third number: ");
            float num3 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine(num1 <= 5 && num1 >= -5 ? "In range" : "Out of range");
            Console.WriteLine(num2 <= 5 && num2 >= -5 ? "In range" : "Out of range");
            Console.WriteLine(num3 <= 5 && num3 >= -5 ? "In range" : "Out of range");

            //task2

            Console.Write("Enter first number: ");
            int first_num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter first number: ");
            int second_num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter first number: ");
            int third_num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Maximum value from 3 numbers: " + Math.Max(first_num, Math.Max(second_num, third_num)));
            Console.WriteLine("Minimum value from 3 numbers: " + Math.Min(first_num, Math.Min(second_num, third_num)));

            //task3

            Console.WriteLine("Enter Error Code from 400 to 404");
            int enterCode = Convert.ToInt32(Console.ReadLine());
            if (enterCode == (int)HTTPError.BadRequest)
            {
                Console.WriteLine("400 error, Bad Request");
            }
            else if (enterCode == (int)HTTPError.Unauthorizet)
            {
                Console.WriteLine("401 error, Unauthorizet");
            }
            else if (enterCode == (int)HTTPError.Payment)
            {
                Console.WriteLine("402 error, Payment Required");
            }
            else if (enterCode == (int)HTTPError.Forbidden)
            {
                Console.WriteLine("403 error, Error Forbidden");
            }
            else if (enterCode == (int)HTTPError.PageNotFound)
            {
                Console.WriteLine("404 error, Page not found");
            }
            else
            {
                Console.WriteLine("Invalid code");
            }

            //task4

            Dog myDog = new Dog();
            myDog.Age = 4;
            myDog.Mark = "Mops";
            myDog.Name = "Stepan";
            Console.WriteLine(myDog.ToString());
        }
    }
}