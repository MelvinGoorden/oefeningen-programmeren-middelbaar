using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.OleDb;

namespace Oefeningen_10._01_Deelnermerslijst
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            { 
            string query, voornaam, achternaam;
            string connstring = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = E:\2018-2019\ICT\Programmeren\Database\10.01_Deelnemerslijst\Oefeningen2002-3.mdb; User Id = admin;Password =;";

            Console.Write("wat is uw voornaam? : ");
            voornaam = Console.ReadLine();
            Console.Write("wat is uw acthernaam? : ");
            achternaam = Console.ReadLine();
            query = "INSERT INTO deelnemers(voornaam, achternaam) VALUES ('" + voornaam + "', '" + achternaam + "');";

            UitvoerenQuery(connstring, query);
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
                Console.WriteLine("Waarde doorgestuurd!");
            }
            catch(OleDbException error)
            {
                Console.WriteLine(error.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        static void LeesQuery(string connstring, string query)
        {
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = connstring;

            try
            {
                connection.Open();

                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();
                while(reader.Read())
                {
                    Console.WriteLine(reader[0] + " " + reader[1]);
                }

                Console.WriteLine("");
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
    }
}
