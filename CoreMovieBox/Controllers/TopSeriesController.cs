using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreMovieBox.Controllers
{
    public class TopSeriesController : Controller
    {
        Top10TvSerieListManager top10TvSerieListManager = new Top10TvSerieListManager(new EfTop10TvSerieListDal());
        public IActionResult Index()
        {
            var values = top10TvSerieListManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddTopSerie()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddTopSerie(Top10TvSerieList p)
        {
            top10TvSerieListManager.TInsert(p);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteTopSerie(int id)
        {
            var value = top10TvSerieListManager.TGetByID(id);
            top10TvSerieListManager.TDelete(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateTopSerie(int id)
        {
            var value = top10TvSerieListManager.TGetByID(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateTopSerie(Top10TvSerieList top10TvSerieList)
        {
            top10TvSerieListManager.TUpdate(top10TvSerieList);
            return RedirectToAction("Index");
        }

    }
}
