using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.OleDb;


namespace SummaryPublisherApp
{
    class Program
    {
        //BooksPublishedIn2010(connection)
        //Count(connection);
        //Top10(connection);
        //TotalPrice(connection);
        // NrOfBooks(connection);
        static void Main(string[] args)
        {
            string connectionString = "Data Source=.;Initial Catalog=Tema9;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

        }
        private static void Count(SqlConnection connection)
        {
            try
            {
                var commandQuery = "select count(PublisherId) from Publisher";

                SqlCommand countCommand = new SqlCommand(commandQuery, connection);

                var count = countCommand.ExecuteScalar();

                Console.WriteLine($"Number is: {count}");
                Console.ReadKey();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        private static void Top10(SqlConnection connection)
        {
            try
            {
                var query = "select * from Publisher where PublisherId < 11";

                SqlCommand command = new SqlCommand(query, connection);

                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    var currentRow = dataReader;

                    var id = currentRow["PublisherId"];
                    var name = currentRow["Name"];

                    Console.WriteLine($"{id} - {name}");
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }

        }
        private static void TotalPrice(SqlConnection connection)
        {
            try
            {
                Console.WriteLine("Insert ID here:");

                var id = int.Parse(Console.ReadLine());

                var query = "SELECT SUM(Price)FROM Book WHERE Publisherid = " + id;

                SqlCommand command = new SqlCommand(query, connection);
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        private static void NrOfBooks(SqlConnection connection)
        {
            try
            {
                var query = "select * from [dbo].[Book] ";

                SqlCommand command = new SqlCommand(query, connection);

                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    int s = 0;
                    var currentRow = dataReader;
                    foreach (var id in currentRow)
                    {
                        var Id = currentRow["PublisherId"];

                        if (currentRow == id) s += 1;
                        {
                            Console.WriteLine(s);
                        }

                    }
                                   
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        private static void BooksPublishedIn2010(SqlConnection connection)
        {
            try
            {
                var query = "select * from Book where Year = 2010";
                
                SqlCommand count = new SqlCommand(query, connection);

                var counter = counter.ExecuteScalar();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            

        }
        private static void MaxYear(SqlConnection connection)
        {
            try
            {
                var query = "select max(Year) from Book";

                SqlCommand command = new SqlCommand(query, connection);

                SqlDataReader dataReader = command.ExecuteReader();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {

            }

        }

    }
}
