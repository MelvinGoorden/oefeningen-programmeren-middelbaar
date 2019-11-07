using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefningen_05._13_Tafels
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int x = 0; x < 11; x++)
            {
                int tafel;

                tafel = 5 * x;

                Console.WriteLine("5 x " + x + " = " + tafel);
            }
        }
    }
}
