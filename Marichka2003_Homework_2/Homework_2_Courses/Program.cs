using System;


namespace Homework_2_Courses
{
    class Program
    {
        struct Dog
        {
            public string name;
            public string mark;
            public int age;
            public override string ToString()
            {
                return string.Format($"Dog is: {name}, it's mark is: {mark}, and age is: {age}");
            }
        };
        struct Student
        {
            public string name;
            public int group;
            public override string ToString()
            {
                return string.Format($"Student is: {name}, and group is: {group}");
            }
        };
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            NumbersInRange numbers = new NumbersInRange();
            MeaningError error = new MeaningError();
            SearchMaxAndMin searching = new SearchMaxAndMin();

            cat.EatSomething();
            numbers.RangeOfNumber();
            searching.MaxAndMin();

            Console.ReadLine( );
            Console.Clear();

            Dog myDog;
            Console.WriteLine("Third task");
            Console.Write("Enter the name of your dog: ");
            myDog.name = Console.ReadLine();
            Console.Write("Enter the mark of your dog: ");
            myDog.mark = Console.ReadLine();
            Console.Write("Enter the age of your dog: ");
            myDog.age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(myDog.ToString());

            Console.ReadLine();
            Console.Clear();

            Student myStudent;
            Console.WriteLine("Fifth task");
            Student[] student31 = new Student[4] ;
            for (int i = 0;  ; i++)
            {
                Console.Write("Enter the your Last name: ");
                myStudent.name = Console.ReadLine();
                if (myStudent.name == "!")
                {
                    break;
                }
                Console.Write("Enter the number of your group - 31: ");
                myStudent.group = Convert.ToInt32(Console.ReadLine());
                student31[i] = myStudent;

            }
            
            Console.Write("Searching the same Last Name in your group, enter first letter: ");
            char letter = Convert.ToChar(Console.ReadLine());

            for (int i = 0; i < student31.Length; i++)
            {
                if (letter == student31[i].name[0])
                {
                    Console.WriteLine($"We see maybe {student31[i]}");
                }
            }
            
            error.Error();

        }
                  
    }



    
}
