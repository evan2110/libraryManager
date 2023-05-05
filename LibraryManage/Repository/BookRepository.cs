using LibraryManage.BusinessObject;
using LibraryManage.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManage.Repository
{
    public class BookRepository : IBookRepository
    {
        public void DeleteBook(int bookId) => BookDAO.Instance.Remove(bookId);


        public Book GetBookByID(int bookId) => BookDAO.Instance.GetBookByID(bookId);


        public List<Book> GetBooks(int page, int recordNum) => BookDAO.Instance.GetBookList(page, recordNum);
        

        public void InsertBook(Book book) => BookDAO.Instance.AddNew(book);

        public List<Book> SearchBooksByTitleOrAuthorOrPublicDateOrLocaion(string search) => BookDAO.Instance.SearchBooksByTitleOrAuthorOrPublicDateOrLocaion(search);

        public void UpdateBook(Book book) => BookDAO.Instance.Update(book);

    }
}
