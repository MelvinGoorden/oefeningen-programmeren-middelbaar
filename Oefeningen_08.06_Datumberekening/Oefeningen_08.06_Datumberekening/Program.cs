using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefeningen_08._06_Datumberekening
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime volgende_week = new DateTime();
            
            volgende_week = Berekening();
            Console.WriteLine(volgende_week);
        }
        static DateTime Berekening()
        {
            DateTime volgende_week = new DateTime();

            volgende_week = DateTime.Now;
            volgende_week = volgende_week.AddDays(7);

            return volgende_week;
        }
    }
}
