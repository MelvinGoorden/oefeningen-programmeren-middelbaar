using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefeningen_04._23_Kassa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_berekenen_Click(object sender, EventArgs e)
        {
            int hamburgers, frieten, dranken;
            double bedrag;

            hamburgers = Convert.ToInt32(tb_hamburgers.Text);
            frieten = Convert.ToInt32(tb_frieten.Text);
            dranken = Convert.ToInt32(tb_dranken.Text);

            bedrag = (hamburgers * 3) + (frieten * 2) + (dranken * 1.5);

            Lbl_TotaalBedrag.Text = Convert.ToString(bedrag);
        }

        private void btn_wisselgeld_Click(object sender, EventArgs e)
        {
            double bedrag, betaald, teruggave;

            bedrag = Convert.ToDouble(Lbl_TotaalBedrag.Text);
            betaald = Convert.ToDouble(tb_betaald.Text);

            teruggave = betaald - bedrag;

            Lbl_Teruggave.Text = Convert.ToString(teruggave);
        }
    }
}
