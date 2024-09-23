namespace InstanzUndStatisch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Member mem = new Member();

            Console.WriteLine(mem.Count);
            mem.CountUp(10);
            Console.WriteLine(mem.Count);


            Member.ZaehlerRauf(7);
            Console.WriteLine(Member.Zaehler);
            mem.CountUp(1);
            Console.WriteLine(mem.Count);

            mem.CountDown(4);
            Console.WriteLine(mem.Count);
            Console.WriteLine(Member.Zaehler);

            Member mem2 = new Member();

            mem2.CountUp(5);
            Console.WriteLine(mem2.Count);
            Member.ZaehlerRauf(3);
            Console.WriteLine(Member.Zaehler);
        }

    }

    public class Member
    {
        // statische Member
        public static int Zaehler {  get; set; }
        public static void ZaehlerRauf(int zaehler)
        {
            Zaehler += zaehler;
        }
        public static void ZaehlerRunter(int zaehler)
        {
            Zaehler -= zaehler;
        }

        // Instanzmember
        public int Count { get; set; }
        public void CountUp(int count)
        {
            Count += count + Zaehler;
        }
        public void CountDown(int count)
        {
            Count -= count;
            ZaehlerRunter(3);
        }

    }

}

