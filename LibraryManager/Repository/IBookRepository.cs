using LibraryManagerWeb.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagerWeb.Repository
{
    public interface IBookRepository
    {
        List<Book> GetBooks();
        Book GetBookByID(int bookId);
        void InsertBook(Book book);
        void DeleteBook(int bookId);
        void UpdateBook(Book book);
        List<Book> SearchBooksByTitleOrAuthorOrPublicDateOrLocaion(string search);
    }
}
