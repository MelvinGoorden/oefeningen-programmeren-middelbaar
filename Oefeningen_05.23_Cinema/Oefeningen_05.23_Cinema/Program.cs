using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefeningen_05._23_Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            int leeftijd;
            double kostprijs;

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("         kostberekening cinema");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine();
            Console.Write("Wat is uw leeftijd: ");
            leeftijd = Convert.ToInt32(Console.ReadLine());

            if(leeftijd < 16)
            {
                kostprijs = 6;

                Console.WriteLine("de prijs is " + kostprijs + " euro");
            }
            else if((leeftijd >= 16) && (leeftijd < 25))
            {
                string student;

                Console.Write("Heeft u een studentenkaart?: ");
                student = Convert.ToString(Console.ReadLine());

                if(student == "ja")
                {
                    kostprijs = 8 * 0.8;
                }
                else
                {
                    kostprijs = 8;
                }

                Console.WriteLine("de prijs is " + kostprijs + " euro");
            }
            else if(leeftijd >= 25)
            {
                string antwoord;

                Console.Write("heeft u een kaart van de gezinsbond of een seniorenkaart: ");
                antwoord = Convert.ToString(Console.ReadLine());

                if(antwoord == "ja")
                {
                    kostprijs = 0;
                }
                else
                {
                    kostprijs = 9;
                }
                Console.WriteLine("de prijs is " + kostprijs + " euro");
            }
        }
    }
}
