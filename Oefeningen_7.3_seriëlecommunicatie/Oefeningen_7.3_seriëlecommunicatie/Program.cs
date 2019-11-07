using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Ports;
using System.Collections;

namespace Oefeningen_7._3_seriëlecommunicatie
{
    class Program
    {
        static void Main(string[] args)
        {
            string Com;

            Console.Write("welke ComPoort?: ");
            Com = Convert.ToString(Console.ReadLine());

            SerialPort commlijn = new SerialPort();

            commlijn.PortName = ("COM" + Com);

            commlijn.Open();

            while(true)
            {
                if(Console.ReadLine() == "")
                {
                    commlijn.WriteLine("#aan");
                }
            }

            commlijn.Close();
        }
    }
}
