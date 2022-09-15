using System.Globalization;

namespace HW4
{
    internal class Person
    {
        private string _name;
        public string Name { get => _name; }

        private DateTime _birthYear;
        public DateTime BirthYear { get => _birthYear; }
        public Person(string name, DateTime birthYear)
        {
            _name = name;
            _birthYear = birthYear;
        }

        public int Age()
        {
            int age = DateTime.Today.Year - _birthYear.Year;
            if (DateTime.Today.DayOfYear < _birthYear.DayOfYear)
                age--;
            return age;
        }
        public void ChangeName(string newName)
        {
            _name = newName;
        }

        public void Input()
        {
            Console.Write("Enter the name: ");
            _name = Console.ReadLine();

            Console.Write("Enter birt year in foremat dd.MM.yyyy: ");
            _birthYear  = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
                         
        }

        public override string ToString()
        {
            return $"Name: {_name}; Birth Year: {_birthYear.ToString("dd MMM yyyy")}";
        }

        public void Output()
        {
            Console.WriteLine(ToString());
        }
        public static bool operator == (Person a, Person b)
        {
            return a.Name == b.Name;
        }
        public static bool operator !=(Person a, Person b)
        {
            if (a.Name != b.Name)
                return true;
            else
                return false;
        }
    }


}