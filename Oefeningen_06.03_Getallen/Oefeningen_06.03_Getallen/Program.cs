using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Oefeningen_06._03_Getallen
{
    class Program
    {
        static void Main(string[] args)
        {
            Random toevalsgetal = new Random();
            ArrayList getallen = new ArrayList();

            for (int x = 0; x < 7; x++)
            {
                int getal = toevalsgetal.Next(1, 10);

                int index = getallen.IndexOf(getal);

                if (index != -1)
                {
                    x--;
                }
                else
                {
                    getallen.Add(getal);
                }
            }
                foreach (int waarde in getallen)
                {
                    Console.WriteLine(waarde);
                }
            
        }
    }
}