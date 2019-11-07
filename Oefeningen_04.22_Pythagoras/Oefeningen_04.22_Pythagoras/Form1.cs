using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefeningen_04._22_Pythagoras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Berekenen_Click(object sender, EventArgs e)
        {
            double getalA;
            double getalB;
            double uitkomst;

            getalA = Convert.ToDouble(Tb_GetalA.Text);
            getalB = Convert.ToDouble(Tb_GetalB.Text);

            uitkomst = Math.Sqrt(Math.Pow(getalA,2) + Math.Pow(getalB,2));

            Tb_uitkomst.AppendText("c² = a²+b²" + Environment.NewLine);
            Tb_uitkomst.AppendText("sqrt(a²+b²)" + Environment.NewLine);
            Tb_uitkomst.AppendText("sqrt(Math.Pow(A,2)+Math.Pow(B,2))" + Environment.NewLine);
            Tb_uitkomst.AppendText("c = " + uitkomst + Environment.NewLine);
        }

        private void Tb_uitkomst_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tb_GetalB_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tb_GetalA_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
