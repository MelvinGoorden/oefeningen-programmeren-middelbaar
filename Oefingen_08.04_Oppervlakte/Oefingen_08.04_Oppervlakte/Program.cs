using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefingen_08._04_Oppervlakte
{
    class Program
    {
        static void Main(string[] args)
        {
            Oppervlakte_Driehoek(3.50, 2.25);
        }
        static void Oppervlakte_Driehoek(double basis, double hoogte)
        {
            double resultaat;

            resultaat = (basis * hoogte) / 2;

            Console.WriteLine(resultaat);
        }
    }
}
