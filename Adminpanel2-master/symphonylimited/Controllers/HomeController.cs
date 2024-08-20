using Microsoft.AspNetCore.Mvc;
using symphonylimited.Models;
using System.Diagnostics;

namespace symphonylimited.Controllers
{
	public class HomeController : Controller
	{
		  
        private readonly SymphonyContext db;
        public HomeController(SymphonyContext _db)
        {
            db = _db;
        }
        public IActionResult Index()
		{
            //if (HttpContext.Session.GetString("role") == "user")
            //{
            //    ViewBag.email = HttpContext.Session.GetString("userEmail");
            //    return View();
            //}
            //else
            //{
            //    return RedirectToAction("Login","Admin");
            //}
            return View();
        }

		public IActionResult About()
		{
            //if (HttpContext.Session.GetString("role") == "user")
            //{
            //    ViewBag.email = HttpContext.Session.GetString("userEmail");
            //    return View();
            //}
            //else
            //{
            //    return RedirectToAction("Login", "Admin");
            //}
            return View();
        }

		public IActionResult Courses()
		{
            //if (HttpContext.Session.GetString("role") == "user")
            //{
            //    ViewBag.email = HttpContext.Session.GetString("userEmail");
            //    return View();
            //}
            //else
            //{
            //    return RedirectToAction("Login", "Admin");
            //}
            return View();
        }

		public IActionResult CoursesDetails()
		{
            //if (HttpContext.Session.GetString("role") == "user")
            //{
            //    ViewBag.email = HttpContext.Session.GetString("userEmail");
            //    return View();
            //}
            //else
            //{
            //    return RedirectToAction("Login", "Admin");
            //}
            return View();
        }
		public IActionResult EntranceExammination()
		{
            //if (HttpContext.Session.GetString("role") == "user")
            //{
            //    ViewBag.email = HttpContext.Session.GetString("userEmail");
            //    return View();
            //}
            //else
            //{
            //    return RedirectToAction("Login", "Admin");
            //}
            return View();
        }

		public IActionResult FAQs()
		{
            //if (HttpContext.Session.GetString("role") == "user")
            //{
            //    ViewBag.email = HttpContext.Session.GetString("userEmail");
            //    return View();
            //}
            //else
            //{
            //    return RedirectToAction("Login", "Admin");
            //}
            return View();
        }

		public IActionResult Contact()
		{
            //if (HttpContext.Session.GetString("role") == "user")
            //{
            //    ViewBag.email = HttpContext.Session.GetString("userEmail");
            //    return View();
            //}
            //else
            //{
            //    return RedirectToAction("Login", "Admin");
            //}
            return View();

        }
		public IActionResult LogoutUser()
		{
			HttpContext.Session.Clear();
			HttpContext.Session.Remove("role");
			HttpContext.Session.Remove("userEmail");

			return RedirectToAction("Login", "Admin");

		}
		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
