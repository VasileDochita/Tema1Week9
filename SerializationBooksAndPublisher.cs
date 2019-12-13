using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft;
using Newtonsoft.Json;

namespace Tema1Week9
{
    class SerializationBooksAndPublisher
    {
        public class SerializeBooksAndPublisher
        {

            private IBookRepository BookRepo = new BookRepository();
            private IPublisherRepository PublisherRepo = new PublisherRepository();
            private List<Book> Books;
            private List<Publisher> Publishers;

            public SerializeBandP()
            {
                Books = BookRepo.GetAllBooks();
                Publishers = PublisherRepo.AllPublishers();
            }

            public string SerializeWithJsonBook()
            {
                return JsonConvert.SerializeObject(Books);
            }
            public string SerializeWithJsonPublisher()
            {
                return JsonConvert.SerializeObject(Publishers);
            }
        }
    }
}
