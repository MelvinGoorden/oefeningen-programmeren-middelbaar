using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefeningen_08._07_Bevolkingsgroei
{
    class Program
    {
        static void Main(string[] args)
        {
            Bevolkingsgroei(100000, 0.05, 10);
        }
        static void Bevolkingsgroei(double startaantal, double groeifactor, int jaar)
        {
            
            for (int x = 1; x < jaar + 1; x++)
            {
                startaantal = startaantal * Math.Pow((1 + groeifactor), x);
                Console.WriteLine("Na " + x + " jaar         : " + Math.Round(startaantal));    
            }

        }
    }
}
