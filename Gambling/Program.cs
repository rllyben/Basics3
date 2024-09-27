namespace Gambling
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int money = 500;
            bool gameRun = true;

            while (gameRun && money > 0)
            {
                Random random = new Random();
                int zahl = random.Next(1, 11);
                Console.WriteLine("Number guessing");

                Console.WriteLine("Wähle wie viel du setzten willst (Max. 100$).");
                int einsatz = int.Parse(Console.ReadLine());
                money -= einsatz;
                Console.WriteLine($"Dein Einsatz ist {einsatz}$.");

                for (int count = 0; count < 3; count++)
                {
                    Console.WriteLine("Rate eine Zahl zwischen 1 und 10");
                    int guess = int.Parse(Console.ReadLine());

                    if (guess < zahl && count != 2)
                    {
                        Console.WriteLine("Deine Zahl ist zu klein!");
                    }
                    else if (guess > zahl && count != 2)
                    {
                        Console.WriteLine("Deine Zahl ist zu groß!");
                    }
                    else if (guess == zahl)
                    {
                        money = money + einsatz * 2;
                        Console.WriteLine("Glückwunsch du hast die Zahl erraten!");
                        Console.WriteLine($"Du erhälst {einsatz}$");
                        break;
                    }

                    if (count == 2)
                    {
                        Console.WriteLine($"Du hast keine Versuche mehr übrig, die Zahl war {zahl}.");
                    }

                }

                Console.WriteLine($"Du hast noch {money}$\n" +
                                  "Willst du noch einmal spielen?\n Yes/No");
                string game = Console.ReadLine();

                if (game == "no" || game == "n")
                {
                    gameRun = false;
                }
                
            }
            
        }

    }

}
