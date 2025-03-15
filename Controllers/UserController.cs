using Microsoft.AspNetCore.Mvc;
using MVCvalidate.Models;

namespace MVCvalidate.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Index(Validate validate)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Message = "registration Successful!.";
                return View();
            }
            return View(validate);
        }
    }
}
