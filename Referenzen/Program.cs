namespace Referenzen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int variableA = 1;
            int variableB = 2;
            int outTest = 0;

            Console.WriteLine($"Ausserhalb der Methode:{variableA} und  {variableB}");
            MyMethod(ref variableA, variableB);
            Console.WriteLine($"Ausserhalb der Methode:{variableA} und {variableB}");

            Console.WriteLine($"Return{MyOutMethod(variableA, variableB, out outTest)} Das Ergebnis ist {outTest}");
        }

        static int MyOutMethod(int z1, int z2, out int z3)
        {
            z3 = z1 + z2;
            return 0;
        }

        static void MyMethod(ref int zahl1, int  zahl2)
        {
            Console.WriteLine($"In der Methode: {zahl1} und {zahl2}");

            zahl1 = 50;
            zahl2 = 60;

            Console.WriteLine($"In der Methode:{zahl1} und {zahl2}");
        }

    }

}
