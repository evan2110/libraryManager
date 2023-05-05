using LibraryManagerWeb.BusinessObject;
using LibraryManagerWeb.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using System.Diagnostics;

namespace LibrayWebApp.Controllers
{
    public class LoginController : Controller
    {
        IAccountRepository accountRepository = new AccountRepository();
        // GET: LoginController
        public ActionResult Index()
        {
            return View();
        }


		public IActionResult Login()
		{
			Log.Information("Hello World");
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Login(Account acc)
		{
                Account accFind = null;
                accFind = accountRepository.GetAccountByEmailAndPass(acc);
				if (accFind != null)
				{
                if (accFind.Email.Equals("manager")) 
                {
					return RedirectToAction("Index", "Manager");
                }
                else
                {
					return RedirectToAction("Index", "Student");
                }
			    }
				else
				{
					ViewBag.Error = "Dont have that user!";
				}
			return View(acc);
		}

		public IActionResult Logout()
		{
			HttpContext.Session.Remove("user");
			return RedirectToAction("Login", "Auth");
		}

		// GET: LoginController/Details/5
		public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LoginController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LoginController/Create
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

        // GET: LoginController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LoginController/Edit/5
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

        // GET: LoginController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LoginController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
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
    }
}
