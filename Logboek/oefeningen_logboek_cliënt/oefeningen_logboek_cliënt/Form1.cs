using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;

namespace oefeningen_logboek_cliënt
{
    public partial class Form1 : Form
    {
        string serverIP = "172.18.103.207";
        int servicePoort = 8888;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serverIP = Tb_IP.Text;
            servicePoort = Convert.ToInt32(Tb_Port.Text);

            TcpClient clientsocket = new TcpClient();

            try
            {
                clientsocket.Connect(serverIP, servicePoort);

                NetworkStream serverStream = clientsocket.GetStream();
                byte[] outStream = System.Text.Encoding.ASCII.GetBytes(Tb_uren.Text + "$");
                serverStream.Write(outStream, 0, outStream.Length);
                serverStream.Flush();

                byte[] instream = new byte[100025];
                serverStream.Read(instream, 0, (int)clientsocket.ReceiveBufferSize);
                string returndata = System.Text.Encoding.ASCII.GetString(instream);
                Lbl_uren.Text = returndata;


            }
            catch(Exception error)
            {
                
            }
            finally
            {
                Tb_uren.Clear();
                clientsocket.Close();
            }
        }
    }
}
