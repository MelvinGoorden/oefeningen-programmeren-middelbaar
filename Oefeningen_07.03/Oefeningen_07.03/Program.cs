using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace Oefeningen_07._03
{
    class Program
    {
        static void Main(string[] args)
        {
            string naam;
            string new_naam;
            string overeenkomst;
            StreamReader bestand = new StreamReader(@"E:\programmeren\Oefeningen\Oefeningen_07.03\Bestand.txt");

            naam = bestand.ReadToEnd();

            bestand.Close();

            Console.WriteLine("Is {0} u naam ?", naam);
            overeenkomst = Convert.ToString(Console.ReadLine());

            if(overeenkomst == "ja")
            {
                Console.Beep(3000, 1000);
            }
            else
            {
                Console.Beep(300, 1000);

                Console.Write("Geef u naam in: ");
                new_naam = Convert.ToString(Console.ReadLine());

                StreamWriter x = new StreamWriter(@"E:\programmeren\Oefeningen\Oefeningen_07.03\Bestand.txt");
                x.Write(new_naam);

                x.Close();
            }
        }
    }
}
