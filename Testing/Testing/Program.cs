using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter bestand = new StreamWriter(@"E:\ICT\Programeren\Testing\bestand.txt");

            bestand.WriteLine("------I like trains-----");
            bestand.WriteLine("naam: Melvin Goorden");
            bestand.WriteLine("klas: 5TICT");
            bestand.WriteLine("");



        }
    }
}
