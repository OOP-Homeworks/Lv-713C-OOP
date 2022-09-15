using HW4;

Person[] persons = new Person[6];
persons[0] = new Person("Volodymyr", new DateTime(1977,02,23));
persons[1] = new Person("Anastasia", new DateTime(1988,10,17));
persons[2] = new Person("Forvard", new DateTime(1995,12,30));
persons[3] = new Person("Anastasia", new DateTime(1985,10,12));
persons[4] = new Person("Ludmila", new DateTime(1993,03,25));
persons[5] = new Person("Valentina", new DateTime(2011,05,27));


for (int i = 0; i < persons.Length; i++)
{
    Console.WriteLine($"{persons[i]}, age: {persons[i].Age()}");
}

for (int i = 0; i < persons.Length; i++)
{
    if (persons[i].Age() < 16)
    {
        persons[i].ChangeName("Very Young");
    }
}

Console.WriteLine();
for (int i = 0; i < persons.Length; i++)
{
    persons[i].Output();
}

Console.WriteLine();
for (int i = 0; i < persons.Length; i++)
    for (int j = i+1; j < persons.Length; j++)
    {
        if (persons[i] == persons[j])
        {
            Console.WriteLine($"Same persons: {persons[i]}; {persons[j]}");
        }
    }


