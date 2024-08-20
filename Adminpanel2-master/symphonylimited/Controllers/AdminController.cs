using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace symphonylimited.Controllers
{
    public class AdminController : Controller
    {
        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            //if(HttpContext.Session.GetString("role") == "admin")
            //{
            //    ViewBag.email = HttpContext.Session.GetString("adminEmail");
            //    return View();
            //}
            //else
            //{
            //    return RedirectToAction("Login");
            //}
            return View();
        }

		public IActionResult Login()
		{
			return View();
		}

        
        [HttpPost]

        [ValidateAntiForgeryToken]

        public IActionResult Login(string email, string pass)
        {
            //if (email == "admin@gmail.com" && pass == "123")
            //{
            //    HttpContext.Session.SetString("adminEmail", email);
            //    HttpContext.Session.SetString("role", "admin");
            //    return RedirectToAction("Index");
            //}
            //else if (email == "user@gmail.com" && pass == "123")
            //{
            //    HttpContext.Session.SetString("userEmail", email);
            //    HttpContext.Session.SetString("role", "user");
            //    return RedirectToAction("Index", "Home");
            //}
            //else
            //{
            //    ViewBag.msg = "Invalid Credentials";
            //    return View();
            //}
            return View();
        }

      

        public IActionResult Aboutus()
        {
            //if (HttpContext.Session.GetString("role") == "admin")
            //{
            //    ViewBag.email = HttpContext.Session.GetString("adminEmail");
            //    return View();
            //}
            //else
            //{
            //    return RedirectToAction("Login");
            //}
            return View();
        }


        public IActionResult Contactus()
        {
            //if (HttpContext.Session.GetString("role") == "admin")
            //{
            //    ViewBag.email = HttpContext.Session.GetString("adminEmail");
            //    return View();
            //}
            //else
            //{
            //    return RedirectToAction("Login");
            //}
            return View();
        }


        public IActionResult academicdepartment()
        {
            //if (HttpContext.Session.GetString("role") == "admin")
            //{
            //    ViewBag.email = HttpContext.Session.GetString("adminEmail");
            //    return View();
            //}
            //else
            //{
            //    return RedirectToAction("Login");
            //}
            return View();
        }


        public IActionResult Accountdepartment()
        {
            //if (HttpContext.Session.GetString("role") == "admin")
            //{
            //    ViewBag.email = HttpContext.Session.GetString("adminEmail");
            //    return View();
            //}
            //else
            //{
            //    return RedirectToAction("Login");
            //}
            return View();
        }


        public IActionResult LogoutAdmin()
        {
            HttpContext.Session.Clear();
            HttpContext.Session.Remove("role");
            HttpContext.Session.Remove("adminEmail");

            return RedirectToAction("Login");

        }


    }
}
