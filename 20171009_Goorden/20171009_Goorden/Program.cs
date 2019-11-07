using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20171009_Goorden
{
    class Program
    {
        static void Main(string[] args)
        {
            double hoogte, basis, oppRechthoek, oppDriehoek, diagonaal;
            bool controle;

            Console.WriteLine("     Pythagoras:");
            Console.WriteLine("----------------------");
            Console.WriteLine();

            Console.Write("Geef de lengte van de basis: ");
            basis = Convert.ToDouble(Console.ReadLine());
            Console.Write("Geef de lengte van de hoogte: ");
            hoogte = Convert.ToDouble(Console.ReadLine());

            oppRechthoek = (hoogte * basis);
            oppDriehoek = (hoogte * basis) / 2;
            diagonaal = Math.Sqrt(Math.Pow(hoogte, 2) + Math.Pow(basis, 2));
            controle = (oppDriehoek > 10) || (diagonaal >= 7);

            Console.WriteLine();
            Console.WriteLine("Oppervlakte rechthoek: " + oppRechthoek);
            Console.WriteLine("Oppervlakte driehoek: " + oppDriehoek);
            Console.WriteLine("Diagonale driehoek: " + diagonaal);
            Console.WriteLine("Controle van oppervlakte en diagonale: " + controle);
            Console.WriteLine();
        }
    }
}
