using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefeningen_08._02_Random
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomGenerator();
        }
        static void RandomGenerator()
        {
            Random toevalsgetal = new Random();

            for (int x = 0; x < 5; x++)
            {
                int getal = toevalsgetal.Next(1, 10);
                Console.WriteLine(getal);
            }   
        }
    }
}
