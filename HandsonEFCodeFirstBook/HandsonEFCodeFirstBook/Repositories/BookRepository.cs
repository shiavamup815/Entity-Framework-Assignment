using HandsonEFCodeFirstBook.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsonEFCodeFirstBook.Repositories
{
    internal class BookRepository
    {
        public MyContextDB db = new MyContextDB();
        public void AddBook(Book Book)
        {
            db.Books.Add(Book);
            db.SaveChanges();
        }

        public List<Book> GetAllBooks()
        {
            return db.Books.ToList();
        }

        public Book GetBook(string BookId)
        {
            return db.Books.Find(BookId);
        }

        public void DeleteBook(string BookId)
        {
            Book Book= db.Books.Find(BookId);
            db.Books.Remove(Book);
            db.SaveChanges();
        }

        public void EditBook(string BookId, double Price)
        {
            Book Book = db.Books.Find(BookId);
            Book.Price = Price;
            db.SaveChanges();
        }

    }
}
