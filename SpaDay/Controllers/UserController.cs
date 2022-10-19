using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        string error = "It's broken";
        public IActionResult Index()
        {
            return View();
        }

        [Route("/user/add")]
        public IActionResult Add()
        {
            //ViewBag.Error = "Passwords must match.";
            return View();
        }
        [HttpPost]
        [Route("/user")]
        public IActionResult SubmitAddUserForm(User newUser, string verify)
        {
            if (newUser.Password == verify)
            {
                //ViewBag.verify = verify;
                ViewBag.ThisUser = newUser;

                return View("Index");
            } else
            {
                ViewBag.Error = error;
                ViewBag.username = newUser.Username;
                ViewBag.email = newUser.Email;
                return View("Add");
            }
        }

    }
}
