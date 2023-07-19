using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LayeredMvc.Presentation.Models;

namespace LayeredMvc.Presentation.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View("Privacy");
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
