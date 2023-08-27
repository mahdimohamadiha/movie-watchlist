using Microsoft.AspNetCore.Mvc;

namespace MovieWatchlistWeb.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
