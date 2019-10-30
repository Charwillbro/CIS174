using Microsoft.AspNetCore.Mvc;
using CIS174.Models;

namespace CIS174.Controllers
{
    public class Assignment7_1Controller : Controller
    {
        public IActionResult Index()
        {
            var model = new UserModel();
            model.Country = "CA";
            return View(model);

        }
        [HttpPost]
        public IActionResult Index(UserModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            return RedirectToAction("Index", "Home");
        }
    }
}