namespace MathRandom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double value = Math.Pow(2, 10);
            Console.WriteLine(value);

            // r^2 * pi
            double r = 2;
            double kreisfläche = Math.Pow(r, 2) * Math.PI;
            Console.WriteLine(kreisfläche);

            // Pseoudorandomgenerator

            Random myRandom = new Random();

            for (int count = 0; count < 10000; count++)
            {
                int myValue = myRandom.Next();
                Console.WriteLine(myValue);
            }

        }

    }

}
