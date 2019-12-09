using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Tema1Week9
{
    class CRUDBookApp
    {
        static string connectionString = "Data Source=.;Initial Catalog=Tema9;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);
        connection.Open();

        private static void UpdateBook(SqlConnection connection)
        {
            try
            {
                Console.WriteLine("Insert BookID to be updated : ");
                var bookid = Console.ReadLine();

                var command = "update Book set Title = 'Title' where BookId = @BookIdParam";

                SqlParameter param = new SqlParameter("@BookIdParam", bookid);

                SqlCommand updateCommand = new SqlCommand(command, connection);

                updateCommand.Parameters.Add(param);

                updateCommand.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        private static void DeleteBook(SqlConnection connection)
        {
            try
            {
                Console.WriteLine("Enter BookId to delete: ");

                var bookid = int.Parse(Console.ReadLine());

                var command = "delete from Book where BookId = @BookIdParam";

                SqlParameter param = new SqlParameter("@BookIdParam", bookid);

                SqlCommand deleteCommand = new SqlCommand(command, connection);

                deleteCommand.Parameters.Add(param);

                deleteCommand.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    
    }
}