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

namespace oefeningen_07._06_Persoonsgegevens2
{
    public partial class Stalker : Form
    {
        public Stalker()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Klaar_Click(object sender, EventArgs e)
        {
            int jaar, maand, dag;
            StreamWriter gegevens = new StreamWriter(@"E:\ICT\Programeren\oefeningen_07.06_Persoonsgegevens2\Gegevens.txt", true);

            gegevens.WriteLine("achternaam : " + Tb_Achternaam.Text);
            Tb_Achternaam.Clear();
            gegevens.WriteLine("voornaam : " + Tb_Voornaam.Text);
            Tb_Voornaam.Clear();

            jaar = Convert.ToInt32(Tb_jaar.Text);
            maand = Convert.ToInt32(Tb_maand.Text);
            dag = Convert.ToInt32(Tb_dag.Text);
            DateTime geboorte = new DateTime(jaar, maand, dag);
            Tb_jaar.Clear();
            Tb_maand.Clear();
            Tb_dag.Clear();

            gegevens.WriteLine("geboortedatum : {0:D}", geboorte);

            gegevens.WriteLine("Woonplaats : {0}", Tb_woonplaats.Text);
            Tb_woonplaats.Clear();

            gegevens.WriteLine("-----------------------------------------------------------");
            gegevens.Close();
        }
    }
}
