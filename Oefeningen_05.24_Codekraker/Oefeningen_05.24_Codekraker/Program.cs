using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefeningen_05._24_Codekraker
{
    class Program
    {
        static void Main(string[] args)
        {
            int code;
            int kraker;

            Console.Write("geef een code tussen tussen 0000 tot 9999 :");
            code = Convert.ToInt32(Console.ReadLine());

            for(kraker = 0; kraker != code; kraker++)
            {
                Console.WriteLine("de code is niet: " + kraker);
            }
            Console.WriteLine("de code is: " + kraker);
        }
    }
}
