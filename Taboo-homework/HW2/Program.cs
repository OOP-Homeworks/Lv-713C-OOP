

Console.Write("Write first float number: ");
float a = Convert.ToSingle(Console.ReadLine());
Console.Write("Write second float number: ");
float b = Convert.ToSingle(Console.ReadLine());
Console.Write("Write third float number: ");
float c = Convert.ToSingle(Console.ReadLine());

Console.WriteLine((a >= -5) && (a <= 5) ? "To learn" : "Don't study");
Console.WriteLine((b >= -5) && (b <= 5) ? "To learn" : "Don't study");
Console.WriteLine((c >= -5) && (c <= 5) ? "To learn" : "Don't study");
Console.ReadKey();

////////////////////////////////////////////////////////////////////////////////////////////////////
/

Console.Write("Write first integer number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Write first integer number: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Write first integer number: ");
int c = Convert.ToInt32(Console.ReadLine());
int max = Math.Max(b, c);
max = Math.Max(max, a);
int min = Math.Min(b, c);
min = Math.Min(min, a);
Console.WriteLine("Max number: " + max);
Console.WriteLine("Min number: " + min);
Console.ReadKey();

///////////////////////////////////////////////////////

enum HTTPError
{
    BadRequest = 400,
    Unauthorized,
    Paymebt_Required,
    Forbidden,
    NotFound,
    Method_Not_Allowed,
    Not_Acceptable
}

Console.Write("Enter the number of HTTP Error ");
int input = Convert.ToInt32(Console.ReadLine());
if (Enum.IsDefined(typeof(HTTPError), input))
{
    Console.WriteLine("The name of the erroris {0}", Enum.GetName(typeof(HTTPError), input));
}
else
{
    Console.WriteLine("Error name not found((");
}



enum HTTPError

Dog homeDog = new Dog("Sharik", "Spaniel", 99);
Console.WriteLine(homeDog);

struct Dog
{
    public string Name;
    public string Mark;
    public int Age;

    public Dog(string name, string mark, int age)
    {
        Name = name;
        Mark = mark;
        Age = age;
    }

    public override string ToString()
    {
        return $"Dog name: {Name} \nDog mark: {Mark} \nAge: {Age} year";
    }

}






