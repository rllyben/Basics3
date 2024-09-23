namespace ObjektID
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestKlasse test1 = new TestKlasse();
            TestKlasse test2 = new TestKlasse();
            TestKlasse test3 = new TestKlasse();

            Console.WriteLine(test1.ObjectID);
            Console.WriteLine(test2.ObjectID);
            Console.WriteLine(test3.ObjectID);
            Console.WriteLine(TestKlasse.ObjectCounter);

        }

    }

    public class TestKlasse
    {
        public int ObjectID { get; private set; }
        
        public static int ObjectCounter { get; private set; } = 0;

        public TestKlasse() 
        {
            ObjectCounter++;
            ObjectID = ObjectCounter;
        }

    }

}
