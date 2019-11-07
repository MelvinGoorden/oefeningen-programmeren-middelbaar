using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefeningen_05._02
{
    class Program
    {
        static void Main(string[] args)
        {
            const string wachtwoord = "Gitok";
            string input;

            Console.Write("Geef wachtwoord in: ");
            input = Convert.ToString(Console.ReadLine());

            if(wachtwoord == input)
            {
                Console.WriteLine("welkom gebruiker");
            }
            else
            {
                Console.WriteLine("Wachtwoord onjuist!");
            }

        }
    }
}
