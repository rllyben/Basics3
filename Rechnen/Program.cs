namespace Rechnen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double uebergabeWert1;
            double uebergabeWert2;
            Console.WriteLine("Please Enter Your Numbers");
            Console.Write("Number 1:"); uebergabeWert1 = double.Parse(Console.ReadLine());
            Console.Write("Number 2:"); uebergabeWert2 = double.Parse(Console.ReadLine());

            Rechnen rechnen = new Rechnen();

            rechnen.Zahl1 = uebergabeWert1;
            rechnen.Zahl2 = uebergabeWert2;

            string methode;
            Console.WriteLine("Gebe deine Methode an (+,-,*,/, ^):");
            methode = Console.ReadLine();

            if (methode == "+")
                rechnen.Addieren();
            if (methode == "-")
                rechnen.Subtrahieren();
            if (methode == "*")
                rechnen.Multiplizieren();
            if (methode == "/")
                rechnen.Dividieren();
            if (methode == "^")
                rechnen.Potenzieren();

            Console.WriteLine($"Das Ergebnis ist {rechnen.Ergebnis}");

        }

    }

    internal class Rechnen
    {
        private double _zahl1;
        private double _zahl2;
        private double _ergebnis;

        public double Zahl1 { get; set; }

        public double Zahl2 { get; set; }

        public double Ergebnis { get; private set; }

        internal void Addieren()
        {
            Ergebnis = Zahl1 + Zahl2;
        }
        internal void Subtrahieren()
        {
            Ergebnis = Zahl1 - Zahl2;
        }
        internal void Multiplizieren()
        {
            Ergebnis = Zahl1 * Zahl2;
        }
        internal void Dividieren()
        {
            if (Zahl2 == 0) { throw new DivideByZeroException(); }
            Ergebnis = Zahl1 / Zahl2;
        }
        internal void Potenzieren()
        {
            double zwischenspeicher = Zahl1;
            for (int count = 0; count < Zahl2 -1; count++)
            {
                zwischenspeicher *= Zahl1;
            }
            Ergebnis = zwischenspeicher;
        }

    }

}
