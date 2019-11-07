using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefeningen_05._14__Bevolkingsgroei
{
    class Program
    {
        static void Main(string[] args)
        {
            double bevolking = 100000;
            double percentage;

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("              Bevolkingsaangroei:");
            Console.WriteLine("--------------------------------------------------");

            for (int x = 1; x < 31; x++)
            {
                bevolking = bevolking * 1.05;

                Console.WriteLine("Na " + x + " jaar          " + Math.Round(bevolking));
            }
            percentage = Math.Round(bevolking / 1000, 3);
            Console.WriteLine("Totale bevolingaangroei is: " + percentage + "%");
        }
    }
}
