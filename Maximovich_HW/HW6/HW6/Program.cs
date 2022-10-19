namespace HW6
{
    internal class Program
    {
        int num1, num2;
        double symb1, symb2;
        public void Div()
        {
            int result = num1 / num2;
            Console.WriteLine("Result: {0}", result);
        }
        public void DivDouble()
        {
            double resultDouble = symb1 / symb2;
            if (symb2 == 0)
            {
                throw new DivideByZeroException();
            }
            Console.WriteLine("Result: {0}", resultDouble);
        }
        public void ReadNumber(int start, int end)
        {
            Console.Write("Enter first num: ");
            int countNum = -1;
            int[] arr = new int[10];
            for (int i = 0; i < 10; i++)
            {
                bool numCorrectlyParsed = int.TryParse(Console.ReadLine(), out int number);
                if (numCorrectlyParsed)
                {
                    Console.WriteLine(number);
                    arr[i] = number;
                    if (number > start && number <= end && number > countNum)
                    {
                        countNum = number;
                    }
                    else
                    {
                        throw new Exception("Error! Try again. Write 10 numbers: ");
                    }
                }
                else
                {
                    throw new Exception("Format error");
                }
            }
            Console.Write("All elements, who you write: ");
            foreach (int i in arr)
            {
                Console.Write($" {i} ");
            }
        }
        static void Main(string[] args)
        {
            //Task 1

            Program dividing = new Program();
            Console.Write("Enter first number: ");
            dividing.num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            dividing.num2 = Convert.ToInt32(Console.ReadLine());
            try
            {
                dividing.Div();
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Divide by zero - unreal!)");
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }

            //Task 2

            Program dividingDouble = new Program();
            Console.Write("Enter first double number: ");
            dividingDouble.symb1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second double number: ");
            dividingDouble.symb2 = Convert.ToDouble(Console.ReadLine());
            try
            {
                dividingDouble.DivDouble();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //Task 3
            Program program = new Program();
            Console.Write("Enter start number: ");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter end number: ");
            int end = Convert.ToInt32(Console.ReadLine());
            bool continueExcecution = true;
            while (continueExcecution)
            {
                try
                {
                    program.ReadNumber(start, end);
                    continueExcecution = false;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(" ");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(" ");
                }
            }
            Console.WriteLine(" ");
            Console.WriteLine("Finish");
        }
    }
}