using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASKS4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //TASK
            Car[] cars = new Car[3];

            for (int i = 0; i < cars.Length; i++)
            {
                cars[i] = Car.Input();
                Console.Clear();
            }

            foreach (Car car in cars)
            {
                car.Print();
            }

            for (int i = 0; i < cars.Length; i++)
            {
                cars[i].ChangePrice(10);
            }

            string newColor = Console.ReadLine();
            string oldColor = "white";

            for (int i = 0; i < cars.Length; i++)
            {
                if (cars[i].Color == oldColor)
                {
                    cars[i].Color = newColor;
                }
            }


            //HW

            Person[] people = new Person[3];

            for (int i = 0; i < people.Length; i++)
            {
                people[i] = Person.Input();
                Console.Clear();
            }

            

            for (int i = 0; i < people.Length; i++)
            {
                Console.WriteLine($"Name: {people[i].Name}");
                Console.WriteLine($"Age: {people[i].Age()}");
            }

            for (int i = 0; i < people.Length; i++)
            {
                if (people[i].Age() < 16)
                {
                    people[i].ChangeName("Very young");
                }
            }

            foreach (Person j in people)
            {
               j.Output();
            }

            for (int i = 0; i < people.Length; i++)
            {
                for(int j = i+1; j <people.Length;j++)
                {
                    if(people[i]==people[j])
                    {
                        people[i].Output();
                        Console.WriteLine("\n\n\n");
                        people[j].Output();
                    }

                }
            }

        }
    }
}
