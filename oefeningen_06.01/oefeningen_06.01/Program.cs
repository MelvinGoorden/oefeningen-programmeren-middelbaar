using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefeningen_06._01
{
    class Program
    {
        static void Main(string[] args)
        {
            int jaartal, maand, dag;

            Console.WriteLine("geef uw geboortedatum in");
            Console.Write("jaartal: ");
            jaartal = Convert.ToInt32(Console.ReadLine());
            Console.Write("maand: ");
            maand = Convert.ToInt32(Console.ReadLine());
            Console.Write("dag: ");
            dag = Convert.ToInt32(Console.ReadLine());

            DateTime geboortedatum = new DateTime(jaartal, maand, dag);

            Console.WriteLine("je bent geboren op een {0}", geboortedatum.DayOfWeek);

            TimeSpan leeftijd = new TimeSpan(DateTime.Now.Ticks - geboortedatum.Ticks);
            Console.WriteLine("je bent {0} dagen oud", leeftijd.Days);

            if (DateTime.IsLeapYear(geboortedatum.Year))
            {
                Console.WriteLine("je bent geboren in een schrikkeljaar");
            }
            else
            {
                Console.WriteLine("je bent niet geboren in een schrikkeljaar");
            }
        }
    }
}
