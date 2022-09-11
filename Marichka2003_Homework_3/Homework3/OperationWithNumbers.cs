using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class OperationWithNumbers
    {
        public void Operation()
        {
            const int numbers = 10;
            int num;
            int sum = 0;
            int product = 1;
            List<int> tenNumbers = new List<int>();
            List<int> fivepositive = new List<int>();
            List<int> fivenegative = new List<int>();
            int counter = 0;
            for (int i = 0; i < numbers; i++)
            {
                Console.Write("Enter ten numbers : ");
                if (i > 9)
                {
                    break;
                }
                num = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                tenNumbers.Add(num);
            }
            for (int i = 0; i < tenNumbers.Count; i++)
            {
                if (i < 5 && tenNumbers[i] > 0)
                {
                    counter++;
                    
                }
                if (i > 4)
                {

                    fivenegative.Add(tenNumbers[i]);
                }
                if (i < 5)
                {
                    fivepositive.Add(tenNumbers[i]);
                }
            }

            if (counter == 5)
            {
                foreach (var item in fivepositive)
                {
                    sum += item;
                }
                Console.WriteLine($"We have a 5 positive element and their sum is : {sum}");
            }
            else
            {
                foreach (var item in fivenegative)
                {
                    product *= item;
                }
                Console.WriteLine($"We have negative element, so product is : {product}");
            }
        }
    }
}
