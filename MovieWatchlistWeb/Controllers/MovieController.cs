using Microsoft.AspNetCore.Mvc;
using MovieWatchlistWeb.Data;

namespace MovieWatchlistWeb.Controllers
{
    public class MovieController : Controller
    {
        private readonly ApplicationDbContext _db;

        public MovieController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var objMovieList = _db.Movies.ToList();
            return View();
        }
    }
}
