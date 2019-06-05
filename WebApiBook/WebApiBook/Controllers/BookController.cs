using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiBook.Interfaces;
using WebApiBook.Models;

namespace WebApiBooks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private IRepository repository { get; set; }

        public BookController(IRepository repo) => repository = repo;

        [HttpGet]
        public IEnumerable<Book> GetBooks()
        {
            return MemoryRepository.SharedRepository.Books;
        }
        [HttpGet("{id}")]
        public IActionResult GetBooks(int id)
        {
            Book book = repository.Books.FirstOrDefault(x => x.BookId == id);
            if (book == null)
                return NotFound();
            return new ObjectResult(book);
        }
        [HttpPost]
        public IActionResult Post([FromBody]Book book)
        {
            if (book == null)
            {
                return BadRequest();
            }
            repository.AddBook(book);
            return Ok(book);
        }
        [HttpPut("{id}")]
        public IActionResult Put([FromBody]Book book)
        {
            if (book == null)
            {
                return BadRequest();
            }
            if (!repository.Books.Any(x => x.BookId == book.BookId))
            {
                return NotFound();
            }
            repository.Update(book);
            return Ok(book);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete([FromBody] int id)
        {
            Book book = repository.Books.FirstOrDefault(x => x.BookId == id);
            if (book == null)
            {
                return NotFound();
            }
            repository.DeleteBook(id);
            return Ok(book);
        }
    }
    
}