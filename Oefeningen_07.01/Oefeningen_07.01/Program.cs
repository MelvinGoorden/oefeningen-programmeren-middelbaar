using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace Oefeningen_07._01
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter boodschap = new StreamWriter("Boodschap.txt");
            string zin;

            Console.Write("Voer een boodschap in: ");
            zin = Convert.ToString(Console.ReadLine());

            boodschap.WriteLine(zin);
            
            boodschap.Close();
        }
    }
}
