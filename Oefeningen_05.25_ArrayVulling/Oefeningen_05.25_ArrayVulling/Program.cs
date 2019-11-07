using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefeningen_05._25_ArrayVulling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] verzameling = new int[9, 9];
            int teller = 0;

            for (int x = 0; x < 9; x++)
            {
                for(int y = 0; y < 9; y++)
                {
                    verzameling[x, y] = (x * 10) + y;
                }
            }

            foreach (int waarde in verzameling)
            {
                if(teller < 8)
                {
                    Console.Write(waarde + " ");
                    teller++;
                }
                else
                {
                    Console.WriteLine(waarde + " ");
                    teller = 0;
                }
            }
        }
    }
}
