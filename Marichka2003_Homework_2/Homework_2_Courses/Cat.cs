using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2_Courses
{
    class Cat
    {
        
        enum Food { Milk = 30, DryFeed = 50, Meat = 70, Fish = 50};
        public int satietyLevel = 0;
        public int CatProperties
        {

            get
            {
                Console.Write(" The satiety level: ");
                return satietyLevel;
            }

            set
            {
                satietyLevel = value;
            }
        }
        public void EatSomething()
        {
            Console.WriteLine("Fourth task");
            bool ifTrue = true;
            do
            {
                Console.Write("Enter what kind of food you give to your cat :" +
                    "\nmilk - 1, dry feed - 2 , meat - 3 or fish - 4 or back - 5 : ");
                int eatings = Convert.ToInt32(Console.ReadLine());

                switch (eatings)
                {
                    case 1:
                        Console.Clear();
                        satietyLevel += (int)Food.Milk;
                        if (satietyLevel > 100)
                        {
                            Console.WriteLine("The cat ate too much!");
                        }
                        Console.WriteLine($"Satiety level : {satietyLevel}");  
                        
                        break;
                    case 2:
                        Console.Clear();
                        satietyLevel += (int)Food.DryFeed;
                        if (satietyLevel > 100)
                        {
                            Console.WriteLine("the cat ate too much");
                        }
                        Console.WriteLine($"Satiety level : {satietyLevel}");
                        break;
                    case 3:
                        Console.Clear();
                        satietyLevel += (int)Food.Meat;
                        if (satietyLevel > 100)
                        {
                            Console.WriteLine("the cat ate too much");
                        }
                        Console.WriteLine($"Satiety level : {satietyLevel}");
                        break;
                    case 4:
                        Console.Clear();
                        satietyLevel += (int)Food.Fish;
                        if (satietyLevel > 100)
                        {
                            Console.WriteLine("the cat ate too much");
                        }
                        Console.WriteLine($"Satiety level : {satietyLevel}");
                        break;
                    default:
                        Console.Clear();
                        ifTrue = false;
                        break;
                }
            } while (ifTrue);
            
        }
    }
}
