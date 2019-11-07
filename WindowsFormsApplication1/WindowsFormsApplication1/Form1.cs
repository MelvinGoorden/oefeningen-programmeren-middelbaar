using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        int lol = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            while (lol != 1)
            {
                MessageBox.Show("ERROR", "TIS KAPODT", MessageBoxButtons.YesNo);
                if (MessageBoxButtons.YesNo.ToString() == "Ja")
                {
                    lol = 1;
                }
            }
        }
    }
}
