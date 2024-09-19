using System.Xml.Serialization;

namespace OptionaleParameter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Method(5, 10);
            Method(5, 20, 100);
            Method(10, 20, v4: 15.57f);
        }

        static void Method(int v1, float v2, int v3 = 50, float v4 = 10.45f)
        {
            Console.WriteLine($"{v1} {v2} {v3} {v4}");
        }
    }
}
