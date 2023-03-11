using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreMovieBox.Controllers
{
    public class MovieController : Controller
    {
        MovieManager movieManager = new MovieManager(new EfMovieDal());
        public IActionResult Index()
        {
            var values = movieManager.TGetList();
            return View(values);
        }



        [HttpGet]
        public IActionResult MovieAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult MovieAdd(Movie movie)
        {
           movieManager.TInsert(movie);
            return RedirectToAction("Index");
        }




        public IActionResult MovieDelete(int id)
        {
            var values = movieManager.TGetByID(id);
            movieManager.TDelete(values);
            return RedirectToAction("Index");
        }




        [HttpGet]
        public IActionResult MovieEdit(int id)
        {
            var values = movieManager.TGetByID(id);
            return View();
        }
        [HttpPost]
        public IActionResult MovieEdit(Movie movie)
        {
            movieManager.TUpdate(movie);
            return RedirectToAction("Index");
        }

    }
}
