using System.Xml.Serialization;

namespace KlassenUndObjekte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Stunde = DateTime.Now.Hour;
            int Minute = DateTime.Now.Minute;

            Uhrzeit zeit = new Uhrzeit();

            zeit.Zeitsetzten(Stunde, Minute);
            zeit.Ausgeben();

            zeit.AddMinutes(5);
            zeit.Ausgeben();

            zeit.AddMinutes(50);
            zeit.Ausgeben();

            Uhrzeit neueZeit = new Uhrzeit();

            neueZeit.Zeitsetzten(Stunde, Minute);
            neueZeit.Ausgeben();
            zeit.Ausgeben();

        }

    }

    internal class Uhrzeit
    {
        private int StundeIN, MinuteIN;

        public void Zeitsetzten(int Stunde, int Minute)
        {
            StundeIN = Stunde;
            MinuteIN = Minute;
        }

        public void Ausgeben()
        {
            Console.WriteLine($"Die Uhrzeit ist {StundeIN}:{MinuteIN}");
        }

        public void AddMinutes(int Minute)
        {
            MinuteIN += Minute;

            while(MinuteIN >= 60)
            {
                StundeIN++;
                MinuteIN -= 60;
            }

            while(StundeIN >= 24)
            {
                StundeIN -= 24;
            }

        }


    }

}
