using System.Security.Cryptography.X509Certificates;

namespace Methoden
{
    internal class Program
    {
        static int _neueVariable = 5;
        static void Main(string[] args)
        {
            // locale Variable
            // existiert nur in diesem Anweisungsblock
            int mainVariable = 5;
            Console.WriteLine(_neueVariable);
            MeineMethode();
            Console.WriteLine("Hello Hell!");
            MeineMethode();
            Console.WriteLine(_neueVariable);

            MethodeMitUebergabe(6);
            MethodeMitMehrParametern(5, 't', "Tis is Patric!");
            MethodeMitMehrParametern(zeichen: 'a', count: 3, message: "Hello There!");

            int temp = MethodeMitRueckgabe();
            Console.WriteLine(temp);
            MethodeMitUebergabe(MethodeMitRueckgabe());

            Console.WriteLine(Summe(5, 9));
        }

        // Rueckgabewert, Namen der Methode,(Parameter) {Anweisungsblock}
        // Dumme Methode ohne Rueckgabeparameter
        private static void MeineMethode()
        {
            // mainVariable = 3;
            _neueVariable++;

            for (int count = 0; count <10; count++)
            {
                Console.Write("MyMethod ");
            }

            Console.WriteLine();
        }

        private static void MethodeMitUebergabe(int laenge)
        {
            for (int i = laenge; i > 0; i--)
            {
                Console.Write("int ");
            }
            Console.WriteLine();
        }
        private static void MethodeMitMehrParametern(int count, char zeichen, string message)
        {
            Console.WriteLine(message);
            for ( int i = count; i > 0; i--)
            {
                Console.Write(zeichen);
            }

        }
        private static int MethodeMitRueckgabe()
        {
            int myVar = 50;

            if(myVar == 0)
            {
                return -1;
            }

            return myVar;
        }

        private static int Summe(int zahl1, int zahl2)
        {
            int ergebnis = zahl1 + zahl2;
            return ergebnis;
        }

    }

}
