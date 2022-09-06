namespace OOP_HomeWork_1_Maximovich
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task1

            Console.WriteLine("Write leght square side: ");
            int a = Convert.ToInt32(Console.ReadLine()); //Тут було б краще використовувати double бо дані також можуть бути і десятковими
            Console.WriteLine("Area square: {0}", Math.Pow(a, 2);
            Console.WriteLine("Perimeter square: {0}", a * 4);

            //task2

            Console.Write("Whats you name?");
            string name = Console.ReadLine();
            Console.Write($"How old are you, {name}?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You name: {0}, you are {1} years old", name, age);

            //task3

            Console.Write("Write radius of circle: ");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Leght circle: {0:F1}", 2 * Math.PI * r);
            Console.WriteLine("Area circle: {0:F1}", Math.PI * Math.Pow(r, 2));
            Console.WriteLine("Volume circle: {0:F1}", 4 / 3 * Math.PI * Math.Pow(r, 3));
        }
    }
}