using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefeningen_05._03
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal;

            Console.Write("Geef een getal in: ");
            getal = Convert.ToInt32(Console.ReadLine());

            if((getal > 0) && (getal < 10))
            {
                Console.WriteLine("getal ligt tussen 0 en 10");
            }
            else
            {
                Console.WriteLine("getal ligt NIET tussen 0 en 10");
            }

            if ((getal > 10) && (getal < 20))
            {
                Console.WriteLine("getal ligt tussen 10 en 20");
            }
            else
            {
                Console.WriteLine("getal ligt NIET tussen 10 en 20");
            }

            if ((getal > 20) && (getal < 50))
            {
                Console.WriteLine("getal ligt tussen 20 en 50");
            }
            else
            {
                Console.WriteLine("getal ligt NIET tussen 20 en 50");
            }

            if ((getal > 50) && (getal < 80))
            {
                Console.WriteLine("het getal is groter dan 50 maar kleiner dan 80");
            }
            else
            {
                Console.WriteLine("getal is NIET groter dan 50 maar kleiner dan 80");
            }

            if ((getal > 80) && (getal < 100))
            {
                Console.WriteLine("getal is groter dan 80 en kleiner dan 100");
            }
            else
            {
                Console.WriteLine("getal is NIET groter dan 80 en kleiner dan 100");
            }
            
            if(getal < 100)
            {
                Console.WriteLine("getal is kleiner dan 100");
            }
            else
            {
                Console.WriteLine("getal is groter dan 100");
            }

        }
    }
}
