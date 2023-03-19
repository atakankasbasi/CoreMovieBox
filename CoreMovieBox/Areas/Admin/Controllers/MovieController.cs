using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreMovieBox.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MovieController : Controller
    {
        MovieManager cm = new MovieManager(new EfMovieDal());
        public IActionResult Index()
        {
            var values = cm.TGetListByFilter(x => x.Status == true);
            return View(values);
        }
        [HttpGet]
        public IActionResult AddMovie()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddMovie(Movie movie)
        {
            movie.Status = true;
            cm.TInsert(movie);
            return RedirectToAction("Index", "Movie", new { area = "Admin" });
        }
        public IActionResult DeleteMovie(int id)
        {

            var value = cm.TGetByID(id);
            value.Status = false;
            cm.TUpdate(value);
            return RedirectToAction("Index", "Movie", new { area = "Admin" });
        }
        [HttpGet]
        public IActionResult UpdateMovie(int id)
        {
            var value = cm.TGetByID(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateMovie(Movie movie)
        {
            cm.TUpdate(movie);
            return RedirectToAction("Index", "Movie", new { area = "Admin" });
        }

    }
}
