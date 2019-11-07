using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefeningen_04._25_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nummer = new int[10];
            int x = 0;

            while(x < 10)
            {
                Console.Write("Typ een int-waarde: ");
                nummer[x] = Convert.ToInt32(Console.ReadLine());

                x++;
            }
            Console.WriteLine("nummer = " + nummer[0] + nummer[1] + nummer[2] + nummer[3] + " " + nummer[4] + nummer[5] + " " + nummer[6] + nummer[7] + " " + nummer[8] + nummer[9]);
        }
    }
}
