using System.Collections.Generic;

namespace Tema1Week9
{
    partial class Program
    {
        public interface IBookRepository
        {
            List<Book> GetAllBooks();
        }
    }
}
