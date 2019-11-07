using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefeningen_08._03_Rekenen
{
    class Program
    {
        static void Main(string[] args)
        {
            Som(7, 8);
            Verschil(7, 8);
        }
        static void Som(int getal_1, int getal_2)
        {
            int resultaat;
            resultaat = getal_1 + getal_2;
            Console.WriteLine(getal_1 + " + " + getal_2 + " = " + resultaat);
        }
        static void Verschil(int getal_1, int getal_2)
        {
            int resultaat;
            resultaat = getal_1 - getal_2;
            Console.WriteLine(getal_1 + " - " + getal_2 + " = " + resultaat);
        }
    }
}
