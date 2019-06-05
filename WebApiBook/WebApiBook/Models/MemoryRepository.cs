using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiBook.Interfaces;

namespace WebApiBook.Models
{
    public class MemoryRepository : IRepository
    {
        public Book this[int id] => throw new NotImplementedException();

        public IEnumerable<Book> Books => throw new NotImplementedException();

        public Book AddBook(Book book)
        {
            throw new NotImplementedException();
        }

        public void DeleteBook(int id)
        {
            throw new NotImplementedException();
        }

        public Book Update(Book book)
        {
            throw new NotImplementedException();
        }
    }
}
