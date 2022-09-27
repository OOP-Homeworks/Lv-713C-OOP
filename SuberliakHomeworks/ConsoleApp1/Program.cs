using System;
using System.Dynamic;
using System.Xml.Linq;

namespace SuberliakHw2._4


{
    internal class Program
    {
        //Declare struct Dog with fields name, mark, age.
        //Declare object myDog of Dog type and read values for it.
        //Output information on the console. (Override method ToString in struct)


        
        
        struct Dog
        {
            public string name;
            public string breed;
            public int age;
        
        }          

        static void Main(string[] args)
        { 

            Dog myDog = new Dog();
            Console.WriteLine("please add name of your dog: ");

            myDog.name = Console.ReadLine();
            Console.WriteLine("please add breed of your dog: ");

            myDog.breed = Console.ReadLine();
            Console.WriteLine("please add age of your dog: ");

            try
            {
                myDog.age = Convert.ToInt32(Console.ReadLine());
            }

            catch (FormatException)
            {
                Console.WriteLine("\nPlease add a number for dog age!");
            }                       
                                 
        }
    }
}
