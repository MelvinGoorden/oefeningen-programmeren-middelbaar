using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefeningen_05._28_Passagiers
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] verameling = new char[6, 10];
            int rij;
            int stoel;
            int teller = 0;

            for (int x = 0; x < 6; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    verameling[x, y] = 'O';
                }
            }
            while (true)
            {
                foreach (char x in verameling)
                {
                    if (teller < 9)
                    {
                        Console.Write(" " + x);

                        teller++;
                    }
                    else
                    {
                        Console.WriteLine(" " + x);

                        teller = 0;
                    }
                }

                Console.WriteLine();
                Console.WriteLine("welke stoel wilt u verkopen?:");
                Console.Write("welke rij: ");
                rij = Convert.ToInt32(Console.ReadLine());
                Console.Write("welke stoel: ");
                stoel = Convert.ToInt32(Console.ReadLine());

                verameling[stoel - 1, rij - 1] = 'X';

                Console.Clear();
            }
        }
    }
}
