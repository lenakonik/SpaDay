using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;
using System.Collections.Generic;

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/User/Add")]
        public IActionResult Add()
        
        {
            return View();
        }

        [HttpPost]
        [Route("/User/Add")]
        public IActionResult SubmitAddUserForm(User newUser, string verify)
        {
            if (newUser.Password.Equals(verify))
            {
                ViewBag.username = newUser.Username;
                return View("Index");
            }
            ViewBag.username = newUser.Username;
            ViewBag.email = newUser.Email;
            ViewBag.error = "Your passwords should match";
            return View("Add");

        }
    }
}
