using Microsoft.AspNetCore.Mvc;
using Lab3_test3.Models;

namespace Lab3_test3.Controllers
{
    public class NameLoopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Loop(NameLoopFormModel model)
        {
            if (ModelState.IsValid)
            {
                return View("Loop", model);
            }
            return View(model);
        }
    }
}