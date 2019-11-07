using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefeningen_05._10_spel
{
    class Program
    {
        static void Main(string[] args)
        {
            string speler1;
            string speler2;

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("      welkom bij schaar-steen-papier");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("schaar, steen of papier ?");

            Console.Write("Speler 1 : ");
            speler1 = Convert.ToString(Console.ReadLine());
            Console.Write("Speler 2 : ");
            speler2 = Convert.ToString(Console.ReadLine());

            if((speler1 == "steen") && (speler2 == "papier"))
            {
                Console.WriteLine("papier verslaat steen.  speler 2 wint!!!");
            }
            else if((speler1 == "steen") && (speler2 == "schaar"))
            {
                Console.WriteLine("steen verslaat schaar.  speler 1 wint!!!");
            }
            else if ((speler1 == "steen") && (speler2 == "steen"))
            {
                Console.WriteLine("gelijkspel!!!");
            }
            else if ((speler1 == "papier") && (speler2 == "steen"))
            {
                Console.WriteLine("papier verslaat steen.  speler 1 wint!!!");
            }
            else if ((speler1 == "papier") && (speler2 == "schaar"))
            {
                Console.WriteLine("schaar verslaat papier.  speler 2 wint!!!");
            }
            else if ((speler1 == "papier") && (speler2 == "papier"))
            {
                Console.WriteLine("gelijkspel!!!");
            }
            else if ((speler1 == "schaar") && (speler2 == "steen"))
            {
                Console.WriteLine("steen verslaat schaar.  speler 2 wint!!!");
            }
            else if ((speler1 == "schaar") && (speler2 == "papier"))
            {
                Console.WriteLine("schaar verslaat papier.  speler 1 wint!!!");
            }
            else if ((speler1 == "schaar") && (speler2 == "schaar"))
            {
                Console.WriteLine("gelijkspel!!!");
            }
        }
    }
}
