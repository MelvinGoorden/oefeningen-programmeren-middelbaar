using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefeningen_06._02_projectteam
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime vandaag = DateTime.Now;
            DateTime deadline = vandaag.AddDays(250);

            Console.WriteLine("Projectstart op {0:D}", vandaag);
            Console.WriteLine();

            for(int x = 0; x < 7; x++)
            {
                vandaag = vandaag.AddDays(35);
                Console.WriteLine("vergadering {0} op {1:D}", x + 1, vandaag);
            }

            Console.WriteLine();
            Console.WriteLine("deadline op {0:D}", deadline);
        }
    }
}
