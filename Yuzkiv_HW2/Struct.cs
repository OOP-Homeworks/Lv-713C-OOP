using System;

namespace HW_2
{
    public class Struct
    {
        public struct Dog
        {
            public string name;
            public string mark;
            public int age;

            public void Info()
            {
                Console.WriteLine($"Dog name: {name} \nDog mark: {mark} \nAge: {age} year");
            }
        }
    }
}
