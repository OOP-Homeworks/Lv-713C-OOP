// See https://aka.ms/new-console-template for more information


// task_1 Exercise_1


Console.WriteLine("Enter name: ");
string name = Console.ReadLine();
Console.Write("Enter a = ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter b = ");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Sum: {1} + {0} = {2}.", a, b, a + b);
Console.WriteLine("Sub: " + a + " - " + b + " = " + (a - b) + ".");
Console.WriteLine($"Mult: {a} * {b} = {a * b}" + ".");
Console.WriteLine("Division: {0} / {1} = {2:F3}.", a, b, a / b);
Console.ReadLine();

//task_1 Exercise_2


//Console.WriteLine("How are you? ");
//string answer = Console.ReadLine();
//Console.WriteLine($"You are {answer}");
//Console.ReadKey();

////task_1(Char) Exercise_3

//Console.Write("Please, enter first char ");
//char char1 = Convert.ToChar(Console.ReadLine());
//Console.WriteLine("Please, enter second char ");
//char char2 = Convert.ToChar(Console.ReadLine());
//Console.WriteLine("Please, enter third char ");
//char char3 = Convert.ToChar(Console.ReadLine());
//Console.WriteLine("You entered {0}, {1}, {2}", char1, char2, char3);
//Console.ReadKey();

////task_1(Char) Exercise_4

////int a, b;
//Console.WriteLine("Please, enter number ");
//a = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Please, enter second number ");
//b = Convert.ToInt32(Console.ReadLine()); 
//if ((a > b) && (b > 0))
//{
//    Console.WriteLine("At least one 0 or negative");
//}
//else
//{
//    Console.WriteLine("At least one 0 or negative");
//}
//Console.WriteLine();