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

        public Book this[int id] => items.ContainsKey(id) ? items[id] : null;

        public IEnumerable<Book> Books => items.Values;

        public Book AddBook(Book book)
        {
            if (book.BookId == 0)
            {
                int key = items.Count;
                while (items.ContainsKey(key)) { key++; };
                book.BookId = key;
            }
            items[book.BookId] = book;
            return book;
        }

        public void DeleteBook(int id) => items.Remove(id);


        public Book Update(Book book) => AddBook(book);
    }
}
