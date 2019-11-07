using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace Oefeningen_07._04
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList namen = new ArrayList();
            string naam;

            StreamReader bestand = new StreamReader(@"E:\ICT\Programeren\Oefeningen_07.04\namen.txt");

            while ((naam = bestand.ReadLine()) != null)
            {
                int x = namen.IndexOf(naam);
                if (x == -1)
                {
                    namen.Add(naam);
                }
            }
            bestand.Close();
            namen.Sort();

            StreamWriter document = new StreamWriter(@"E:\ICT\Programeren\Oefeningen_07.04\namen.txt");
            foreach(string y in namen)
            {
                Console.WriteLine(y);


            }
        }
    }
}
