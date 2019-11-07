using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefeningen_05._29_paswoord
{
    class Program
    {
        static void Main(string[] args)
        {
            const string wachtwoord = "paswoord";
            string invoer = null;
            int teller = 0;

            while((invoer != wachtwoord) && (teller < 3))
            {
                Console.Write("geef wachtwoord: ");
                invoer = Console.ReadLine();

                teller++;
            }

            if (invoer == wachtwoord)
            {
                Console.WriteLine("Welkom");
            }
            else
            {
                Console.WriteLine("geen pogingen meer!");
            }
        }
    }
}
