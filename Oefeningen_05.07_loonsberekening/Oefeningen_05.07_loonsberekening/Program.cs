using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefeningen_05._07_loonsberekening
{
    class Program
    {
        static void Main(string[] args)
        {
            int uren;
            double uitbetaling;
            double overuren;


            Console.Write("Hoeveel uur heeft u deze week gewerkt: ");
            uren = Convert.ToInt32(Console.ReadLine());

            if(uren <= 40)
            {
                uitbetaling = uren * 17;

                Console.WriteLine("U krijgt deze week " + uitbetaling + " euro uitbetaald.");
            }
            else
            {
                uitbetaling = 40 * 17;
                overuren = (uren - 40) * 17 + ((17 / 100) * 40);
                uitbetaling += overuren;

                Console.WriteLine("U krijgt deze week " + uitbetaling + " euro uitbetaald.");
            }
        }
    }
}
