using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreMovieBox.Controllers
{
    public class TopMoviesController : Controller
    {
        Top10MovieListManager top10MovieListManager = new Top10MovieListManager(new EfTop10MovieListDal());
        public IActionResult Index()
        {
            var values = top10MovieListManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddTopMovie()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddTopMovie(Top10MovieList top10MovieList)
        {
            top10MovieListManager.TInsert(top10MovieList);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteTopMovie(int id)
        {
            var value = top10MovieListManager.TGetByID(id);
            top10MovieListManager.TDelete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateTopMovie(int id)
        {
            var value = top10MovieListManager.TGetByID(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateTopMovie(Top10MovieList top10MovieList)
        {
            top10MovieListManager.TUpdate(top10MovieList);
            return RedirectToAction("Index");
        }
    }
}
