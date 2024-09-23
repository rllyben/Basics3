using System.Data;

namespace PropertiesUebung
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

            Person ich = new Person();

            ich.Name = name;
            ich.Email = adress;
            ich.Alter = age;

            Console.WriteLine("Drücke eine beliebige Taste zur ausgabe der angegebenen Daten");
            Console.ReadLine();
            ich.Print();
        }

    }

    internal class Person
    {
        private string _names;
        private string _email;
        private int _alter;

        public string Name { get; set; }
        public string Email { get; set; }
        public int Alter
        {
            get { return _alter; }
            set 
            {
                if (value < 14 || value > 150)
                {
                    throw new Exception("Inkorrekt");
                }
                _alter = value; 
            }

        }

        public void Print()
        {
            Console.WriteLine($"Dein Name ist: {_names}\nDeine Email ist:  {_email}\nDein Alter ist: {_alter}");
        }

    }

}