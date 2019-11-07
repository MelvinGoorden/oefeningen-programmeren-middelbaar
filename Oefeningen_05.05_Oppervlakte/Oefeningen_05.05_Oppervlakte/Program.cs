using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefeningen_05._05_Oppervlakte
{
    class Program
    {
        static void Main(string[] args)
        {
            string keuze;
            double oppervlakte;

            Console.WriteLine("Voor welk type figuur wilt u de oppervlakte berekenen?");
            Console.WriteLine("- vierkant");
            Console.WriteLine("- rechthoek");
            Console.WriteLine("- cirkel");
            Console.WriteLine("- piramide");
            Console.WriteLine();

            keuze = Convert.ToString(Console.ReadLine());

            switch (keuze)
            {
                case "vierkant":
                    {
                        double zijde;

                        Console.Write("Geef de zijde: ");
                        zijde = Convert.ToDouble(Console.ReadLine());

                        oppervlakte = zijde * zijde;

                        Console.WriteLine("de oppervlakt van het vierkant is " + oppervlakte);

                        break;
                    }
                case "rechthoek":
                    {
                        double zijdeA;
                        double zijdeB;

                        Console.Write("Geef de eerste zijde: ");
                        zijdeA = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Geef de tweede zijde: ");
                        zijdeB = Convert.ToDouble(Console.ReadLine());

                        oppervlakte = zijdeA * zijdeB;

                        Console.WriteLine("de oppervlakte van de rechthoek is " + oppervlakte);
                        break;
                    }
                case "cirkel":
                    {
                        double straal;

                        Console.Write("Wat is de straal van de cirkel: ");
                        straal = Convert.ToDouble(Console.ReadLine());

                        oppervlakte = Math.PI * Math.Pow(straal, 2);

                        Console.WriteLine("de oppervlakte van de cirkel is " + oppervlakte);
                        break;
                    }
                case "piramide":
                    {
                        double basis;
                        double hoogte;

                        Console.Write("Wat is de lengte van de basis van de piramide: ");
                        basis = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Wat is de hoogte van de piramide: ");
                        hoogte = Convert.ToDouble(Console.ReadLine());

                        oppervlakte = (basis * hoogte) / 2;

                        Console.WriteLine("de oppervlakte van de piramide is " + oppervlakte);
                        break; 
                    }
                default:
                    {
                        Console.WriteLine("incorrecte keuze");
                        break;
                    }
            }
        }
    }
}
