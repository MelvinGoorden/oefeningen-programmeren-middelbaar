using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4pin_paswoordKraker
{
    class Program
    {
        static void Main(string[] args)
        {
            long paswoord = 0;
            long teller1 = 0;
            long teller2 = 0;
            long teller3 = 0;
            long teller4 = 0;
            long teller5 = 0;
            long teller6 = 0;
            long teller7 = 0;
            long teller8 = 0;
            long teller9 = 0;
            long teller10 = 0;

            Console.Write("Geef geheime code in: ");
            paswoord = Convert.ToInt64(Console.ReadLine());

            for (int u = 0; u < 10;u++)
            {
                teller1 = u * 1000000000;

                for (int v = 0; v < 10; v++)
                {
                    teller2 = teller1 + (v * 100000000);

                    for (int w = 0; w < 10; w++)
                    {
                        teller3 = teller2 + (w * 10000000);

                        for (int x = 0; x < 10; x++)
                        {
                            teller4 = teller3 + (x * 1000000);

                            for (int y = 0; y < 10; y++)
                            {
                                teller5 = teller4 + (y * 100000);

                                for (int z = 0; z < 10; z++)
                                {
                                    teller6 = teller5 + (z * 10000);

                                    for (int a = 0; a < 10; a++)
                                    {
                                        teller7 = teller6 + (a * 1000);

                                        for (int b = 0; b < 10; b++)
                                        {
                                            teller8 = teller7 + (b * 100);

                                            for (int c = 0; c < 10; c++)
                                            {
                                                teller9 = teller8 + (c * 10);

                                                for (int d = 0; d < 10; d++)
                                                {
                                                    teller10 = teller9 + (d * 1);

                                                    if(paswoord == teller10)
                                                    {
                                                        goto Done;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        Done: Console.WriteLine("het wachtwoord is " + teller10);
        }
    }
}
