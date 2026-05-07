using DeveloperPortfolio.Models;
using Microsoft.AspNetCore.Mvc;

namespace DeveloperPortfolio.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(ContactModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Message = "Message sent successfully!";
                ModelState.Clear();
            }

            return View();
        }
    }
}