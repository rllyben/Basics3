using System.Diagnostics.Metrics;

namespace PeronenKlasse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte gebe deinen Namen ein:");
            string name = Console.ReadLine();
            Console.WriteLine("Bitte gebe deine Email-Adresse ein:");
            string adress = Console.ReadLine();
            Console.WriteLine("Bitte gebe dein Alter ein:");
            int age = int.Parse(Console.ReadLine());

            Person ich = new Person(name, adress, age);

            ich.SetName(name);
            ich.SetEmail(adress);
            ich.SetAlter(age);

            Console.WriteLine("Drücke eine beliebige Taste zur ausgabe der angegebenen Daten");
            Console.ReadLine();
        }

    }

    internal class Person
    {
        private string _names;
        private string _email;
        private int _alter;

        public Person(string name, string email, int age)
        {
            _names = name;
            _email = email;
            _alter = age;
        }

        public void SetName(string name)
        {
            _names = name;
        }

        public void SetEmail(string email)
        {
            _email = email;
        }

        public void SetAlter(int age)
        {
            alter = age;
        }

        public void Print()
        {
            Console.WriteLine($"Dein Name ist: {_names}\nDeine Email ist:  {_email}\nDein Alter ist: {_alter}");
        }

    }

}
