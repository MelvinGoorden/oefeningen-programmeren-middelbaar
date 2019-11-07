using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_HogerLager
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomNumber = new Random();
            int Getal;
            int nieuwGetal;
            int x = 1;
            string antwoord;

            Getal = randomNumber.Next(0, 14);

            while (x < 3)
            {
                nieuwGetal = randomNumber.Next(0, 14);

                Console.WriteLine("Het getal is " + Getal);
                Console.Write("Hoger of lager: ");
                antwoord = Console.ReadLine();

                if(antwoord == "hoger")
                {
                    if(Getal < nieuwGetal)
                    {
                        Console.Clear();
                        Console.WriteLine("JUIST!!!");
                        Getal = nieuwGetal;

                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Fout :/");
                        Console.WriteLine();
                        x++;
                    }
                }
                else
                {
                    if(Getal > nieuwGetal)
                    {
                        Console.Clear();
                        Console.WriteLine("JUIST!!!");
                        Getal = nieuwGetal;                        
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Fout :/");
                        Console.WriteLine();
                        x++;
                    }
                }
            }
            Console.WriteLine("Alle levens op :(");
        }
    }
}
