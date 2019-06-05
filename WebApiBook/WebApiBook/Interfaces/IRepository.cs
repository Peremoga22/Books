using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiBook.Models;

namespace WebApiBook.Interfaces
{
   public interface IRepository
    {
        IEnumerable<Book> Books { get; }
        Book this[int id] { get; }
        Book AddBook(Book book);
        Book Update(Book book);
        void DeleteBook(int id);
    }
}
