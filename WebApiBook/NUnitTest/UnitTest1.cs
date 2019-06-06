//ing Microsoft.AspNetCore.Mvc;
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
    }
}