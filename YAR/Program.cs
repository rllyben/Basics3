using System.Security.Cryptography.X509Certificates;

namespace YAR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char zeichen = ' ';
            Eingabe();
        }
        static void Eingabe()
        {
            Console.WriteLine("Bitte gebe deine erste Zahl ein:");
            int _zahl1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Bitte gebe deine zweite Zahl ein:");
            int _zahl2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Bitte gebe dein Zeichen ein (+,-,*,/,^)");
            char _zeichen = Console.ReadKey().KeyChar;

            int _ergebnis = Rechnen(_zahl1, _zahl2, _zeichen);

            Ausgabe(_zahl1, _zahl2, _zeichen, _ergebnis);
        }

        static int Rechnen(int zahl1, int zahl2, char zeichen)
        {
            int ergebnis = 0;
            if (zeichen == '+')
            {
                ergebnis = zahl1 + zahl2;
            }
            else if (zeichen == '-')
            {
                ergebnis = zahl1 - zahl2;
            }
            else if (zeichen == '*')
            {
                ergebnis = zahl1 * zahl2;
            }
            else if (zeichen == '/')
            {
                ergebnis = zahl1 / zahl2;
            }
            else if (zeichen == '^')
            {
                for (int count = 1; count < zahl2; count++)
                {
                    ergebnis *= zahl1;
                }

            }
            else { }

            return ergebnis;

        }

        static void Ausgabe(int zahl1, int zahl2, char zeichen, int ergebnis)
        {
            Console.Clear();
            Console.WriteLine(zahl1 + zeichen + zahl2 + "=" + ergebnis);
        }

    }

}
