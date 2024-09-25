using OeBBNameSpace.Erweiterung;
using MyName = OeBBNameSpace.Erweiterung;
namespace OeBBNameSpace
{
    namespace Origin
    {
        internal class Program
        { 
            static void Main(string[] args)
            {
                MyName.MeineKlasse klasse = new MyName.MeineKlasse();
            }

        }

        public class MeineKlasse
        {

        }

    }

    namespace Erweiterung
    {
      public class MeineKlasse
        {
            public int Counter { get; set; }
        }

    }

}

