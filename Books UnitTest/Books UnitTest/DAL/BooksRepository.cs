using Books_UnitTest.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Books_UnitTest.DAL
{
    public class BooksRepository : IBooksRepository
    {
        Entities entities = null;

        public BooksRepository(Entities entities)
        {
            this.entities = entities;
        }

        public List<Book> GetAllBooks()
        {
            return entities.Books.ToList();
        }

        public Book GetBookById(int id)
        {
            return entities.Books.SingleOrDefault(book => book.ID == id);
        }

        public void AddBook(Book book)
        {
            entities.Books.Add(book);
        }

        public void UpdateBook(Book book)
        {
 //           entities.Books.Attach(book);
 //           entities.ObjectStateManager.ChangeObjectState(book, EntityState.Modified);
            entities.Entry(book).State = EntityState.Modified;
        }

        public void DeleteBook(Book book)
        {
            entities.Books.Remove(book);
        }

        public void Save()
        {
            entities.SaveChanges();
        }
    }
}