using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace Oefeningen_07._02
{
    class Program
    {
        static void Main(string[] args)
        {
            string achternaam;
            string voornaam;
            string gemeente;
            int jaar;
            int maand;
            int dag;

            Console.Write("Achternaam: ");
            achternaam = Convert.ToString(Console.ReadLine());
            Console.Write("Voornaam: ");
            voornaam = Convert.ToString(Console.ReadLine());
            Console.Write("Gemeente: ");
            gemeente = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Geboortedatum");
            Console.Write("Dag: ");
            dag = Convert.ToInt16(Console.ReadLine());
            Console.Write("Maand: ");
            maand = Convert.ToInt16(Console.ReadLine());
            Console.Write("Jaar: ");
            jaar = Convert.ToInt16(Console.ReadLine());

            DateTime geboortedatum = new DateTime(jaar, maand, dag);
            StreamWriter Gegevens = new StreamWriter(@"C:\Users\Goorden Melvin\Desktop\" + achternaam + voornaam + ".txt");

            Gegevens.WriteLine("Voornaam: " + voornaam);
            Gegevens.WriteLine("Achternaam: " + achternaam);
            Gegevens.WriteLine("gemeente: " + gemeente);
            Gegevens.WriteLine("Geboortedatum: " + geboortedatum);
            
            Gegevens.Close();
        }
    }
}
