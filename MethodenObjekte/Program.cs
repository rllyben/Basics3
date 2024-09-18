using System;
using System.Runtime.CompilerServices;

namespace MethodenObjekte
{
    internal class Program
    {
        static int seitenlaenge = 10;
        static void Main(string[] args)
        {
            Console.WriteLine("Gebe die länge an:");
            seitenlaenge = int.Parse(Console.ReadLine());

            Console.Write("\n");
            Quadrat();
            Console.Write("\n");
            HolesQuadrat();
            Console.Write("\n");
            RechtwinkligesDreieck();
            Console.Write("\n");
            GleichseitigesDreieck();
            Console.Write("\n");
            HolesGleichseitigesDreieck();
            Console.Write("\n");
            TriForce();
            Console.Write("\n");
            Kreis();
        }

        static void Quadrat()
        {
            // Wiederholt Zeile
            for (int line = seitenlaenge; line > 0; line--) 
            {
                // Wiederholt Zeichen
                for (int count = seitenlaenge; count > 0; count--)
                {
                    Console.Write("x");
                }
                Console.WriteLine();
            }

        }

        static void HolesQuadrat()
        {
            for (int outer = 0; outer < seitenlaenge; outer++)
            {
                //Console.Write("test");
                // Wiederholt die Zeichen
                for (int inner = 0; inner < seitenlaenge; inner++)
                {
                    if (outer == 0 || outer == (seitenlaenge - 1) || inner == 0 || inner == (seitenlaenge - 1))
                    {
                        Console.Write("x");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
                //Console.WriteLine();
                Console.Write("\n");
            }

        }

        static void RechtwinkligesDreieck()
        {
            for(int line = seitenlaenge; line > 0; line--)
            {
                for(int count = 0; count < line; count++)
                {
                    Console.Write("x");
                }
                Console.WriteLine();
            }

        }

        static void GleichseitigesDreieck()
        {
            for (int outer = 0; outer < seitenlaenge; outer++)
            {
                // wiederholt die Space
                for (int inner = 1; inner <= seitenlaenge - outer; inner++)
                {
                    Console.Write(" ");
                }
                // Wiederholt die Zeichen
                for (int inner = 0; inner <= outer; inner++)
                {
                    Console.Write("x ");
                }
                //Console.WriteLine();
                Console.Write("\n");
            }

        }

        static void HolesGleichseitigesDreieck()
        {
            for (int outer = 0; outer < seitenlaenge; outer++)
            {
                // wiederholt die Space
                for (int inner = 1; inner <= seitenlaenge - outer; inner++)
                {
                    Console.Write(" ");
                }
                // Wiederholt die Zeichen
                for (int inner = 0; inner <= outer; inner++)
                {
                    if (inner == 0 || inner == outer || outer == seitenlaenge - 1)
                    {
                        Console.Write("x ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }

                }
                //Console.WriteLine();
                Console.Write("\n");
            }

        }
        static void TriForce()
        {
            for (int outer = 0; outer < seitenlaenge; outer++)
            {
                // wiederholt die Space
                for (int inner = 1; inner <= seitenlaenge * 2 - outer; inner++)
                {
                    Console.Write(" ");
                }
                // Wiederholt die Zeichen
                for (int inner = 0; inner <= outer; inner++)
                {
                    Console.Write("x ");
                }
                //Console.WriteLine();
                Console.Write("\n");
            }
            // untere Dreiecke
            for (int outer = 0; outer < seitenlaenge; outer++)
            {
                // wiederholt die Space
                for (int inner = 1; inner <= seitenlaenge - outer; inner++)
                {
                    Console.Write(" ");
                }
                // Wiederholt die Zeichen
                for (int inner = 0; inner <= outer; inner++)
                {
                    Console.Write("x ");
                }
                // wiederholt die inner Space
                for (int inner = 1; inner <= seitenlaenge - outer - 1; inner++)
                {
                    Console.Write("  ");
                }
                // Wiederholt die Zeichen
                for (int inner = 0; inner <= outer; inner++)
                {
                    Console.Write("x ");
                }
                //Console.WriteLine();
                Console.Write("\n");
            }

        }

        static void Kreis()
        {
            int _radius = seitenlaenge;
            int _startY = 0;
            int _startX = 0;
            double thickness = 0.4;
            double rIn = _radius - thickness, rOut = _radius + thickness;

                for (double y = _radius + _startY; y >= -_radius; --y)
                {
                    if (!(y > _radius))
                    {
                        int spaceCount = 0;
                        for (double x = -_radius; x < rOut; x += 0.5)
                        {
                            double value = x * x + y * y;

                            if (spaceCount < _startX)
                            {
                                Console.Write(" ");
                                spaceCount++;
                            }
                            else if (value >= rIn * rIn && value <= rOut * rOut)
                            {
                                Console.Write("x");
                            }
                            else
                            {
                                Console.Write(" ");
                            }

                        }

                    }

                    Console.WriteLine();
                }

        }

    }

}

