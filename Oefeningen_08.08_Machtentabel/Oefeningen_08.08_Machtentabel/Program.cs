using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Oefeningen_08._08_Machtentabel
{
    class Program
    {
        static void Main(string[] args)
        {
            double grondtal;
            
            Console.Write("geef het grondtal in : ");
            grondtal = Convert.ToDouble(Console.ReadLine());

            ArrayList machten = new ArrayList();
            machten = MachtBerekening(grondtal);

            Afprinten(machten);

        }
        static ArrayList MachtBerekening(double grondtal)
        {
            ArrayList machten = new ArrayList();
            double macht;

            for (double x = 0; x < 11; x++)
            {
                macht = Math.Pow(grondtal,x);
                machten.Add(macht);
            }
            return machten;
        }
        static void Afprinten(ArrayList machten)
        {
            foreach(double macht in machten)
            {
                Console.WriteLine(macht);
            }
        }
    }
}
