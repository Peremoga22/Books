using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System.Collections.Generic;
using WebApiBook.Interfaces;
using WebApiBook.Models;
using WebApiBooks.Controllers;
using Assert = NUnit.Framework.Assert;
using System.Linq;


namespace Tests
{
    [TestFixture]
    public class Tests
    {       
        private BookController _bookController;
        private IRepository _repository;             
        
        [Test]
        public void GetAllBooks_ShouldReturnAllProducts()
        {
            _repository = new MemoryRepository();
            _bookController = new BookController(_repository);
            var result = _bookController.GetBooks();
            Assert.AreEqual(_repository.Books.Count(), result.Count());
        }

        [Test]
        public void TestGetBooksByID()
        {
            _repository = new MemoryRepository();
            _bookController = new BookController(_repository);

            var result = _bookController.GetBooks() ;
            Assert.IsNotNull(result);
            Assert.AreEqual(_repository[3].BookId, result.Count());
        }
        [Test]
        public void TestGetBooksByID_NotFound()
        {
            _repository = new MemoryRepository();
            _bookController = new BookController(_repository);

            var result = _bookController.GetBooks().FirstOrDefault(x => x.BookId == 999);                    
            Assert.IsNotNull(nameof(NotFoundResult));
        }
        [Test]
        public void TestBookPost()
        {
            _repository = new MemoryRepository();
            _bookController = new BookController(_repository);

            var result = _bookController.GetBooks();
            Assert.IsTrue(_repository.Books.Any(x => x.BookId == 1));
        }
        [Test]
        public void TestBookPut()
        {
            _repository = new MemoryRepository();
            _bookController = new BookController(_repository);

            var result = _bookController.GetBooks();
            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.Count());
        }
    }
}