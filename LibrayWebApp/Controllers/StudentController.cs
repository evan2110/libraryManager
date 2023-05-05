using LibraryManagerWeb.BusinessObject;
using LibraryManagerWeb.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace LibrayWebApp.Controllers
{
    public class StudentController : Controller
    {
        IBookRepository bookRepository = new BookRepository();
        // GET: StudentController
        public ActionResult Index(int? page, string searchString)
        {
            if (page == null) page = 1;
            int pageSize = 10;
            int pageNumber = (page ?? 1);

            ViewData["Title"] = "Index";
            ViewBag.CurrentFilter = searchString;
            List<Book> books = bookRepository.GetBooks();

            if (!String.IsNullOrEmpty(searchString))
            {
                books = books.Where(b => b.Title.Contains(searchString)
                                       || b.Author.Contains(searchString)
                                       || b.ShelfLocation.Contains(searchString)).ToList();
            }
           
            return View(books.ToPagedList(pageNumber, pageSize));
        }

        // GET: StudentController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StudentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StudentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentController/Delete/5
        public ActionResult Borrow(int? id)
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

        // POST: StudentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Borrow(int id, IFormCollection collection)
        {
            try
            {
                Book bookFind = bookRepository.GetBookByID(id);
                bookFind.AvailableCopies -= 1;
                bookRepository.UpdateBook(bookFind);
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex) 
            {
                ViewBag.Message = ex.Message;
                return View();
            }
        }
    }
}
