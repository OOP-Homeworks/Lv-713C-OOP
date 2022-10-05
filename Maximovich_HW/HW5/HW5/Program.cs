namespace HW5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IDeveloper> developers = new List<IDeveloper>();
            developers.Add(new Programmer("Max", "C#"));
            developers.Add(new Programmer("Taras", "C++"));
            developers.Add(new Programmer("Ivan", "Java"));
            developers.Add(new Builder("Petro", "Stolyarka"));
            developers.Add(new Builder("Semen", "Benzopula"));
            developers.Add(new Builder("Vasyl", "Drelka"));
            for (int i = 0; i < developers.Count; i++)
            {
                Console.WriteLine(developers[i].ToString());
                developers[i].Create();
                developers[i].Destroy();
                Console.WriteLine("----------");
            }
            Console.WriteLine("/////////////");
            Console.WriteLine("Use IComparable");
            Console.WriteLine("/////////////");
            Console.WriteLine(" ");

            developers.Sort();
            foreach (IDeveloper developer in developers)
            {
                developer.Create();
                developer.Destroy();
                Console.WriteLine(".................");
            }
            //Use Dictionary
            Console.WriteLine("-------------------");
            Console.WriteLine("/////////////");
            Console.WriteLine("Use Dictionary");
            Console.WriteLine("/////////////");
            Console.WriteLine(" ");
            Dictionary<uint, string> keyValuePairs = new Dictionary<uint, string>();
            keyValuePairs.Add(1, "John");
            keyValuePairs.Add(5, "Erica");
            keyValuePairs.Add(77, "Georgii");
            keyValuePairs.Add(112, "Stefan");
            keyValuePairs.Add(8, "Ibrahim");
            keyValuePairs.Add(2, "Umar");
            keyValuePairs.Add(543, "Daniel");
            Console.Write("Aviable ID: ");
            foreach (KeyValuePair<uint, string> pair in keyValuePairs)
            {
                Console.Write($"{pair.Key}, ");
            }
            Console.WriteLine();
            Console.Write("Enter ID: ");
            uint num = Convert.ToUInt32(Console.ReadLine());
            bool keyCountain = keyValuePairs.ContainsKey(num);
            if (keyCountain)
            {
                Console.WriteLine(keyValuePairs[num]);
            }
            else
            {
                Console.WriteLine("Invalid ID");
            }
        }
    }
}