using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefeingen_08._01_Begroeting
{
    class Program
    {
        static void Main(string[] args)
        {
            Begroeting();
        }
        static void Begroeting()
        {
            Console.WriteLine("Welkom beste bezoeker, het is vandaag " + DateTime.Now);
        }
    }
}
