using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefeningen_05._18_Machtentabel
{
    class Program
    {
        static void Main(string[] args)
        {
            int getalA;
            int getalB;
            double macht;

            Console.Write("Geef een getal: ");
            getalA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Geef nog een getal: ");
            getalB = Convert.ToInt32(Console.ReadLine());

            for(int x = 1; x <= getalB; x++)
            {
                macht = Math.Pow(getalA, x);

                Console.WriteLine(macht);
            }
        }
    }
}
