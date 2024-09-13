using Microsoft.AspNetCore.Mvc;

namespace MonolithMVC.Controllers
{
    public class SumController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(int num1, int num2)
        {
            int sum = num1 + num2;
            ViewBag.Sum = sum; /* Esto pasa el resultado a la vista */

            return View();
        }
    }
}