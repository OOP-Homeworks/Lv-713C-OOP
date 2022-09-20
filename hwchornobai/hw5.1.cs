using System;
using System.Collections.Generic;
using System.Collections;
using System.Numerics;

namespace hm5
{
    interface IDeveloper
    {
        void Create();
        void Destroy();

    }
    class Programer : IDeveloper
    {
        private string name;
        private string language;
        public Programer(string name, string language)
        {
            this.name = name;
            this.language = language;
        }
        public void Create()
        {
            Console.WriteLine("The developer : {0} create on {1}", name, language);
        }
        public void Destroy()
        {
            Console.WriteLine("The developer : {0} destroy on {1}", name, language);
        }
     class Builder : IDeveloper
        {
            private string name;
            private string tool;
            public Builder(string name, string tool)
            {
                this.name = name;
                this.tool = tool;
            }
            public void Create()
            {
                Console.WriteLine("The developer : {0} create with the {1}", name, tool);
            }
            public void Destroy()
            {
                Console.WriteLine("The developer : {0} destroy with the {1}", name, tool);
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                List<IDeveloper> worklist = new List<IDeveloper>();
                worklist.Add(new Programer("ANDRII", "С#"));
                worklist.Add(new Programer("VASIL", "С++"));
                worklist.Add(new Builder("Roma", "Plutochnik"));
                worklist.Add(new Builder("OLEG", "KABELICHUK"));
                for (int i = 0; i < worklist.Count; i++)
                { 
                        worklist[i].Create();
                }
               
                for (int i = 0; i <worklist.Count; i++)
                {
                    worklist[i].Destroy();
                }
                foreach(IDeveloper b in worklist)
                {
                    Console.WriteLine(b);
                }
                                


                Console.ReadKey();
            }
        }
    }
}
