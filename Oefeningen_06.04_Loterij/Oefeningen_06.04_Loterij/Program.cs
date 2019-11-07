using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Oefeningen_06._04_Loterij
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList reeks1 = new ArrayList();
            ArrayList reeks2 = new ArrayList();
            ArrayList reeks3 = new ArrayList();

            Random toevalsgetal = new Random();

            for (int x = 0; x < 10; x++)
            {
                int getal = toevalsgetal.Next(1,15);

                reeks1.Add(getal);
            }
            
            for (int x = 0; x < 6; x++)
            {
                int getal = toevalsgetal.Next(1, 35);

                reeks2.Add(getal);
            }
            
            for (int x = 0; x < 2; x++)
            {
                int getal = toevalsgetal.Next(1, 35);

                reeks3.Add(getal);
            }

            Console.WriteLine("          Welkom Loterij");
            Console.WriteLine("          ==============");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("reeks 1:");
            Console.WriteLine("---------------");
            foreach (int x in reeks1)
            {
                Console.Write(x + " / ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("reeks 2:");
            Console.WriteLine("---------------");
            foreach (int x in reeks2)
            {
                Console.Write(x + " / ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("reeks 3 :");
            Console.WriteLine("---------------");
            foreach (int x in reeks3)
            {
                Console.Write(x + " / ");
            }
            Console.WriteLine();
        }
    }
}
