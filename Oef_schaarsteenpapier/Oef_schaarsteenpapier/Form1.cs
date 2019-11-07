using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Oef_schaarsteenpapier
{
    public partial class Form1 : Form
    {
        Dictionary<int, string> ai_keuze = new Dictionary<int, string> {
        [1] = "Schaar",
        [2] = "Steen",
        [3] = "Papier"
        };
        Random reeks = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string keuze = Cb_keuze.Text;

            int random = reeks.Next(1, 4);
            string computerKeuze = ai_keuze[random];
            StreamWriter bestand = new StreamWriter(@"E:\ICT\Programeren\Oef_schaarsteenpapier\Datalog.txt", true);

            if(((keuze == "Schaar") && (computerKeuze == "Schaar")) || ((keuze == "Steen") && (computerKeuze == "Steen")) || ((keuze == "Papier") && (computerKeuze == "Papier")))
            {
                lbl_resultaat.Text = "Gelijkspel: " + keuze + " VS " + computerKeuze;
                bestand.WriteLine("gelijkspel: {0} VS {1}", keuze, computerKeuze);
            }
            else if(((keuze == "Schaar") && (computerKeuze == "Papier")) || ((keuze == "Steen") && (computerKeuze == "Schaar")) || ((keuze == "Papier") && (computerKeuze == "Steen")))
            {
                lbl_resultaat.Text = "Gewonnen: " + keuze + " VS " + computerKeuze;
                bestand.WriteLine("gewonnen: {0} VS {1}", keuze, computerKeuze);
            }
            else if(((keuze == "Schaar") && (computerKeuze == "Steen")) || ((keuze == "Steen") && (computerKeuze == "papier")) || ((keuze == "Papier") && (computerKeuze == "Schaar")))
            {
                lbl_resultaat.Text = "verloren: " + keuze + " VS " + computerKeuze;
                bestand.WriteLine("Verloren: {0} VS {1}", keuze, computerKeuze);
            }
            bestand.Close();
        }
    }
}
