using LibraryManagerWeb.BusinessObject;
using LibraryManagerWeb.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace LibrayWebApp.Controllers
{
    public class ManagerController : Controller
    {
        IBookRepository bookRepository = new BookRepository();
        // GET: ManagerController
        public ActionResult Index(int? page)
        {
            if (page == null) page = 1;
            int pageSize = 10;
            int pageNumber = (page ?? 1);

            var books = bookRepository.GetBooks().ToPagedList(pageNumber, pageSize);

            return View(books);
        }

        // GET: ManagerController/Details/5
        public ActionResult Details(int id)
        {   
            if (id == null)
            {
                return NotFound();
            }
            var book = bookRepository.GetBookByID(id);
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }

        // GET: ManagerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ManagerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Book book)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    bookRepository.InsertBook(book);
                }
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View(book);
            }
        }

        // GET: ManagerController/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var book = bookRepository.GetBookByID(id.Value);
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }

        // POST: ManagerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Book book)
        {
            try
            {
                if (id != book.BookId)
                {
                    return NotFound();
                }
                if (ModelState.IsValid)
                {
                    bookRepository.UpdateBook(book);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ManagerController/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var book = bookRepository.GetBookByID(id.Value);
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }

        // POST: ManagerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                bookRepository.DeleteBook(id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View();
            }
        }
    }
}
