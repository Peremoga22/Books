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
        public MemoryRepository()
        {
            items = new Dictionary<int, Book>();
            new List<Book>
            {
               new Book{BookId=1,Name="Lord of the Flies",Author="William Golding",Price=15},
               new Book{BookId=2,Name="Sherlock Holmes",Author="Sir Arthur Conan Doyle",Price=17},
               new Book{BookId=3,Name="Gulliver's Travels",Author="Jonathan Swift",Price=12}
            }.ForEach(r => AddBook(r));
        }

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
