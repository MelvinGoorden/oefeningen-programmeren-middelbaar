using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.IO;
using System.Data.OleDb;

namespace Oefening_Logboek_server
{
    class Program
    {
        static void Main(string[] args)
        {
            //netwerkapplicatie
            int socket = 8888;
            double uren = 0;
            string naam = "Melvin";

            string hostName = Dns.GetHostName();
            Console.WriteLine(hostName);
            string myIP = Dns.GetHostByName(hostName).AddressList[0].ToString();
            Console.Title = string.Format("Serverapplication @ IP-adres: {0} and server port {1}", myIP, socket);

            while((true))
            {
                TcpListener serverSocket = new TcpListener(socket);
                int verzoekTeller = 0;
                TcpClient clientSocket = default(TcpClient);

                serverSocket.Start();
                Console.WriteLine("  >> Service beschikbaar.");
                clientSocket = serverSocket.AcceptTcpClient();
                Console.WriteLine("  >> verbinding met cliënt aanvaarden.");
                verzoekTeller = 0;

                try
                {
                    verzoekTeller += 1;
                    NetworkStream netwerkStream = clientSocket.GetStream();
                    byte[] bytesIn = new byte[100025];

                    netwerkStream.Read(bytesIn, 0, (int)clientSocket.ReceiveBufferSize);
                    string clientData = System.Text.Encoding.ASCII.GetString(bytesIn);
                    uren = Convert.ToDouble(clientData.Substring(0, clientData.IndexOf("$")));

                    Console.WriteLine("  >> Data ontvangen van client: " + uren);

                    //database
                    string query;
                    string connstring = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = E:\2018-2019\ICT\Programmeren\logboek\DataBase\Logboek2002.mdb; User Id = admin;Password =;";

                    query = "INSERT INTO Logboek(NAAM, UREN) VALUES ('" + naam + "', '" + uren + "')";
                    UitvoerenQuery(connstring, query);

                    string query2 = "SELECT UREN FROM Logboek;";
                    double TOTuur = SomQuery(connstring, query2);
                    string y = Convert.ToString(TOTuur);

                    //netwerkapplicatie
                    byte[] verstuurbytes = Encoding.ASCII.GetBytes(y);
                    netwerkStream.Write(verstuurbytes, 0, verstuurbytes.Length);
                    netwerkStream.Flush();
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.ToString());
                }
                finally
                {
                    clientSocket.Close();
                    serverSocket.Stop();
                }
            }

        }
        static void UitvoerenQuery(string connstring, string query)
        {
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = connstring;

            try
            {
                connection.Open();

                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = query;

                command.ExecuteNonQuery();
                Console.WriteLine("  >> Waarde in Db gezet");
            }
            catch (OleDbException error)
            {
                Console.WriteLine(error.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        static double SomQuery(string connstring, string query)
        {
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = connstring;
            double uren = 0;

            try
            {
                connection.Open();

                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    uren += Convert.ToDouble(reader[0]);
                }
             }
            catch (OleDbException error)
            {
                Console.WriteLine(error.Message);
            }
            finally
            {
                connection.Close();
            }
            return uren;
        }
    }
}
