using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASKS5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TASK1
            List<IFlyable> list = new List<IFlyable>();
            list.Add(new Bird("eagle", true));
            list.Add(new Plane("Boing", 10000));

            foreach (IFlyable item in list)
            {
                item.Fly();
            }

            //TASK2
            List<int> myColl = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                int a = Convert.ToInt32(Console.ReadLine());
                myColl.Add(a);

            }
            Console.Clear();

            foreach (int i in myColl)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            for (int i = 0; i < myColl.Count; i++)
            {
                if (myColl[i] == -10)
                {
                    Console.WriteLine(i + 1);
                }
            }
            Console.WriteLine();


            for (int i = 0; i < myColl.Count; i++)
            {
                if (myColl[i] > 20)
                {
                    myColl.RemoveAt(i);
                    i--;
                }
            }

            foreach (int i in myColl)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            try
            {
                myColl.Insert(2, 1);
                myColl.Insert(8, -3);
                myColl.Insert(5, -4);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Incorect positions ");
            }
            Console.WriteLine();

            foreach (int i in myColl)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            myColl.Sort();

            foreach (int i in myColl)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            //HW5.1

            List<IDeveloper> dev = new List<IDeveloper>();

            Programer Boris = new Programer();
            Boris.Tool = "C#";
            Programer Anton = new Programer();
            Anton.Tool = "C++";



            Builder Oleg = new Builder();
            Oleg.Tool = "hammer";
            Builder Vladislav = new Builder();
            Vladislav.Tool = "screwdriver";


            dev.Add(Anton);
            dev.Add(Vladislav);
            dev.Add(Boris);
            dev.Add(Oleg);


            foreach (IDeveloper arg in dev)
            {
                arg.Create();
                arg.Destroy();
            }

            dev.Sort();

            Console.WriteLine("\n\n\n\n\n");

            foreach (IDeveloper arg in dev)
            {
                arg.Create();
                arg.Destroy();
            }

            //HW 5.2

            Dictionary<uint, string> names = new Dictionary<uint, string>();

            names.Add(1, "Boris");
            names.Add(2, "Andriy");
            names.Add(3, "Olena");
            names.Add(4, "Tatyana");
            names.Add(5, "Oleg");
            names.Add(6, "Vitaliy");
            names.Add(7, "Grigoriy");

            Console.Write("Enter  ID: ");
            uint id = Convert.ToUInt32(Console.ReadLine());
          
            if (names.ContainsKey(id))
            {
                Console.WriteLine(names[id]);
            }

            else
            {
                Console.WriteLine("Incorrect ID");
            }


            

        }
    }
}
