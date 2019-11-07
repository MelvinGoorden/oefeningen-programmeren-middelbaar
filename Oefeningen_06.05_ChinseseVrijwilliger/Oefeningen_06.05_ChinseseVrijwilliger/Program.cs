using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Oefeningen_06._05_ChinseseVrijwilliger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> leerlingen = new Dictionary<int, string>();
            leerlingen.Add(0,"arthur");
            leerlingen.Add(1, "robbe");
            leerlingen.Add(2, "melvin");
            leerlingen.Add(3, "arno");
            leerlingen.Add(4, "ruben");
            leerlingen.Add(5, "mathias");
            while (true)
            {
                Random random = new Random();
                int getal = random.Next(0, leerlingen.Count);
                Console.WriteLine(leerlingen[getal]);
                Console.ReadKey();
            }
        }
    }
}
