using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace Oefeningen_07._04_Filteren
{
    class Program
    {
        static void Main(string[] args)
        {
            string naam;
            ArrayList namen = new ArrayList();
            StreamReader bestand = new StreamReader(@"F:\programmeren\Oefeningen\Oefeningen_07.04_Filteren\Namen.txt");
            
            while((naam = bestand.ReadLine())!= null)
            {
                int index = namen.IndexOf(naam);

                if (index != -1)
                {
                    
                }
                else
                {
                    namen.Add(naam);
                }
            }
            bestand.Close();

            namen.Sort();

            StreamWriter newbestand = new StreamWriter(@"F:\programmeren\Oefeningen\Oefeningen_07.04_Filteren\Namen.txt");

            foreach (string x in namen)
            {
                Console.WriteLine(x);
                newbestand.WriteLine(x);
            }
            newbestand.Close();
        }
    }
}
