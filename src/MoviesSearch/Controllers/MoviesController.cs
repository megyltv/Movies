using Microsoft.AspNetCore.Mvc;

namespace MoviesSearch.Controllers
{
    public class MoviesController : Controller
    {
           
        public MoviesController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}
