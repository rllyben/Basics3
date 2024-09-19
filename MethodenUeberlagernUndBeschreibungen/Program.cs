namespace MethodenUeberlagernUndBeschreibungen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Summe(5, 8));
            Console.WriteLine(Summe(5, 9, 10));
            Console.WriteLine(Summe(10.89F, 12.56F));
        }
        /// <summary>
        /// Gibt und die Summe der Zahlen
        /// </summary>
        /// <param name="z1"> Zahl 1</param>
        /// <param name="z2"> Zahl 2</param>
        /// <returns> Gibt die Summe </returns>
        static int Summe(int z1, int z2)
        {
            return z1 + z2;
        }

        static float Summe(float z1, float z2)
        {
            return z1 + z2;
        }

        static int Summe(int z1, int z2, int z3)
        {
            return (z1 + z2 + z3);
        }

    }

}
