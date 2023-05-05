using LibraryManage.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManage.Repository
{
    public interface IBookRepository
    {
        List<Book> GetBooks(int page, int recordNum);
        Book GetBookByID(int bookId);
        void InsertBook(Book book);
        void DeleteBook(int bookId);
        void UpdateBook(Book book);
        List<Book> SearchBooksByTitleOrAuthorOrPublicDateOrLocaion(string search);
    }
}
