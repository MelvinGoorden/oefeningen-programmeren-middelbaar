using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toets
{
    class Program
    {
        static void Main(string[] args)
        {
            double kapitaal;
            double rentevoet;
            int looptijd;

            while(true)
            {

            Console.WriteLine("======= Interest tabel =======");
            Console.WriteLine();

            Console.Write("Kapitaal (in EUR)       :");
            kapitaal = Convert.ToDouble(Console.ReadLine());
            Console.Write("Vaste rentevoet (in %)  :");
            rentevoet = Convert.ToDouble(Console.ReadLine());
            Console.Write("Looptijd (in jaren)     :");
            looptijd = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            double[] verzameling = new double[looptijd];
            rentevoet = rentevoet / 100 + 1;

            for (int x = 0; x < looptijd; x++)
            {
                kapitaal = kapitaal * rentevoet;
                verzameling[x] = kapitaal;
            }
            foreach (double bedrag in verzameling)
            {
                Console.WriteLine(bedrag);
            }
            }
        }
    }
}
