using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiBook.Interfaces;

namespace WebApiBook.Models
{
    public class MemoryRepository : IRepository
    {
        private static MemoryRepository sharedRepository = new MemoryRepository();

        public static MemoryRepository SharedRepository => sharedRepository;

        public Book this[int id] => throw new NotImplementedException();

        private Dictionary<int, Book> items;

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
