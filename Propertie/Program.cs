namespace Propertie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MeineKlasse obj = new MeineKlasse();
            Console.WriteLine("Gebe deine Zahl zwischen -100 und 100 ein");
            obj.Prop = int.Parse(Console.ReadLine());
            Console.WriteLine(obj.Prop);

            MeineKlasse newObj = new MeineKlasse()
            {
                Prop = 30,
                Number = 30.2f,
                MeinText = "Hello"
            };

        }

        public class MeineKlasse
        {
            // Attribute
            private int _alter;

            //Properties
            // Kurzschreibweise
            public int MeinePropertie { get; set; }

            // Prop darf niemals den Bereich von -100 bis 100 verlassen
            // Langschreibweise
            private int _prop;
            public int Prop
            {
                //gibt den Wert zurueck
                get { return _prop; }
                // setzt den Wert, value ist der Wert von aussen
                set 
                {
                    if (value < -100 || value > 100)
                    {
                        throw new ArgumentOutOfRangeException("Der Wert ist nicht im Bereich!");
                    }
                    _prop = value;
                    
                }

            }

            public string MeinText { get; set; }

            private float _meineNummer;

            public float Number
            {
                get { return _meineNummer; }
                set { _meineNummer = value; }
            }


        }

    }

}
