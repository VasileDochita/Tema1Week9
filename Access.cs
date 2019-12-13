using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;


namespace Tema1Week9
{
    public class BookRepository : IBookRepository
    {
        public BookRepository()
        {
            con = ConnectionManager.GetConnection();
            reader = null;
            cmd = null;
            AllBooks = new List<Book>();

        }

        private SqlConnection con;
        private SqlDataReader reader;
        private SqlCommand cmd;
        private List<Book> AllBooks;
    }
