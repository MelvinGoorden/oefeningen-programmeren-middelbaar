//naam: Melvin goorden
//klas: 5TICT
//nr: 4
//datum: 22/01/2018
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace oefening_stack
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbool;
            Stack<DateTime> datum = new Stack<DateTime>();
            
            symbool = Convert.ToChar(Console.ReadLine());

            while (symbool == '+')
            {
                datum.Push(DateTime.Now);

                symbool = Convert.ToChar(Console.ReadLine());
            }
            
            foreach(DateTime x in datum)
            {
                Console.WriteLine("{0:T}", x);
            }
        }
    }
}
