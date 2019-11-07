using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Oefeningen_06._06_Bevolkingsaangroei
{
    class Program
    {
        static void Main(string[] args)
        {
            double bevolking = 100000;
            Dictionary<double, double>bevolkingaangroei = new Dictionary<double, double>();
            double y = 1;
            double jaar;

            for (int x = 1; x < 31; x++)
            {
                bevolking = bevolking * 1.02;
                bevolkingaangroei.Add(y, Math.Round(bevolking));
                y++;
            }
            while (true)
            {
                Console.Write("Jaar: ");
               jaar = Convert.ToDouble(Console.ReadLine());
               double aantal = bevolkingaangroei[jaar];
               Console.WriteLine("Bevolking = " + aantal);
               Console.WriteLine();
            }
        }
    }
}
