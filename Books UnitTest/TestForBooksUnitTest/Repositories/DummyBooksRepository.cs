﻿using System.Collections.Generic;
using System.Linq;
using Books_UnitTest.DAL;
using Books_UnitTest.Models;

namespace TestForBooksUnitTest.Repositories
{
    class DummyBooksRepository : IBooksRepository
    {
        // Master list of books that will mimic the persitent database storage
        List<Book> m_books = null;

        public DummyBooksRepository(List<Book> books)
        {
            m_books = books;
        }

        public List<Book> GetAllBooks()
        {
            return m_books;
        }

        public Book GetBookById(int id)
        {
            return m_books.SingleOrDefault(book => book.ID == id);
        }

        public void AddBook(Book book)
        {
            m_books.Add(book);
        }

        public void UpdateBook(Book book)
        {
            int id = book.ID;
            Book bookToUpdate = m_books.SingleOrDefault(b => b.ID == id);
            DeleteBook(bookToUpdate);
            m_books.Add(book);
        }

        public void DeleteBook(Book book)
        {
            m_books.Remove(book);
        }

        public void Save()
        {
            // Nothing to do here
        }
    }
}
