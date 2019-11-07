using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefeningen_05._06_WetVanOhm
{
    class Program
    {
        static void Main(string[] args)
        {
            string keuze;
            double stroom, spanning, weerstand;

            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("              De wet van Ohm");
            Console.WriteLine("------------------------------------------------");

            Console.Write("wilt u een spanning, weerstand of stroom berekenen ? : ");
            keuze = Convert.ToString(Console.ReadLine());

            switch (keuze)
            {
                case "spanning" :
                    {
                        Console.Write("Geef de stroom : ");
                        stroom = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Geef de weerstand : ");
                        weerstand = Convert.ToDouble(Console.ReadLine());

                        spanning = stroom * weerstand;

                        Console.WriteLine("de spanning is " + spanning);
                        break;
                    }
                case "weerstand" :
                    {
                        Console.Write("Geef de stroom : ");
                        stroom = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Geef de spanning : ");
                        spanning = Convert.ToDouble(Console.ReadLine());

                        weerstand = spanning / stroom;

                        Console.WriteLine("de weerstand is " + weerstand);
                        break;
                    }
                case "stroom" :
                    {
                        Console.Write("Geef de spanning : ");
                        spanning = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Geef de weerstand : ");
                        weerstand = Convert.ToDouble(Console.ReadLine());

                        stroom = spanning / weerstand;

                        Console.WriteLine("de stroom is " + stroom);
                        break;
                    }
                default :
                    {
                        Console.WriteLine("Keuze bestaat niet.");
                        break;
                    }
            }
        }
    }
}
