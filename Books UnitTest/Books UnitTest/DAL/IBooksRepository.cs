using Books_UnitTest.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Books_UnitTest.DAL
{
    public interface IBooksRepository
    {
        // This interface will give define a contract for CRUD operations on
        // Books entity

        List<Book> GetAllBooks();
        Book GetBookById(int id);
        void AddBook(Book book);
        void UpdateBook(Book book);
        void DeleteBook(Book book);
        void Save();
        
    }
}
