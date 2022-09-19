namespace HW3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1

            Console.Write("Enter some text: ");
            string str = Console.ReadLine().ToLower();
            int countA = 0;
            int countO = 0;
            int countI = 0;
            int countE = 0;
            foreach (char c in str)
            {
                switch (c)
                {
                    case 'a':
                        countA++;
                        break;
                    case 'o':
                        countO++;
                        break;
                    case 'i':
                        countI++;
                        break;
                    case 'e':
                        countE++;
                        break;
                }
            }
            Console.WriteLine($"Char 'a' = {countA}; Char 'o' = {countO} Char 'i' = {countI}; Char 'e' = {countE}");

            //Task 2 - Цей варіант я використав ще до розбору на уроці, чесне слово)

            Console.WriteLine("Enter number of Month");
            int numberMonth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter years");
            int numberYears = Convert.ToInt32(Console.ReadLine());
            int dayOfMonth = DateTime.DaysInMonth(numberYears, numberMonth);
            Console.WriteLine("Month have " + dayOfMonth.ToString() + " days");

            //Task 3

            Console.WriteLine("Enter 10 numbers");
            int[] arr = new int[10];
            int sum = 0;
            int product = 1;
            bool NegNum = false;
            for (int i = 0; i < arr.Length; i++)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                arr[i] = num;
                if (arr[i] < 0)
                {
                    NegNum = true;
                }
            }
            if (NegNum == true)
            {
                for (int i = 5; i < 10; i++)
                {
                    product *= arr[i];
                }
            }
            if (NegNum == false)
            {
                for (int i = 0; i < 5; i++)
                {
                    sum += arr[i];
                }
            }
            Console.WriteLine(product);
            Console.WriteLine(sum);
        }
    }
}