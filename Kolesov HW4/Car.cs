using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASKS4
{
    //TASK
    internal class Car
    {
        private string name;
        private string color;
        private double price;
        private const string CompanyName = "BMW";
       
        public Car()
        {
            name = "120";
            color = "black";
            price = 30000;

        }
        
        public Car(string name, string color, double price)
        {
            this.name = name;
            this.color = color;
            this.price = price;
        }
        public string Color { get; set; }

        public static Car Input()
        {
            Console.Write("Enter a name of car: ");
            string name = Console.ReadLine();
            Console.Write("Enter a price of car: ");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter a color of car: ");
            string color = Console.ReadLine();
            
            Car car = new Car(name, color, price);
            return car;

        }
        public void Print()
        {
            Console.WriteLine($"Company name: {CompanyName}\nname {name}\ncolor {color}\nprice {price}");
        }

        public void ChangePrice(double a)
        {
            price -= price * a / 100;
        }

        public static bool operator == (Car first, Car second)
        {
            return (first.name == second.name && first.price == second.price);
        }
        public static bool operator != (Car first, Car second)
        {
            return !(first.name == second.name && first.price == second.price);
        }

        public override string ToString()
        {
            return $"Company name: {CompanyName} name: {name} color: {color} price: {price}";
        }

    }
}
