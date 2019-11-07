using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefeningen_08._05_Rekenen
{
    class Program
    {
        static void Main(string[] args)
        {
            double A = 3.5;
            double B = 2.5;
            double C;

            C = Som(A, B);
            Console.WriteLine(C);

            C = Verschil(A, B);
            Console.WriteLine(C);
        }
        static double Som(double getal_1, double getal_2)
        {
            double resultaat;

            resultaat = getal_1 + getal_2;

            return resultaat;
        }
        static double Verschil(double getal_1, double getal_2)
        {
            double resultaat;

            resultaat = getal_1 - getal_2;

            return resultaat;
        }
    }
}
