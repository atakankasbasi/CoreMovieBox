using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreMovieBox.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TvSerieController : Controller
    {
        TvSerieManager cm = new TvSerieManager(new EfTvSerieDal());
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
        public IActionResult AddMovie(TvSerie tvSerie)
        {
            tvSerie.Status = true;
            cm.TInsert(tvSerie);
            return RedirectToAction("Index", "TvSerie", new { area = "Admin" });
        }
        public IActionResult DeleteMovie(int id)
        {

            var value = cm.TGetByID(id);
            value.Status = false;
            cm.TUpdate(value);
            return RedirectToAction("Index", "TvSerie", new { area = "Admin" });
        }
        [HttpGet]
        public IActionResult UpdateMovie(int id)
        {
            var value = cm.TGetByID(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateMovie(TvSerie tvSerie)
        {
            cm.TUpdate(tvSerie);
            return RedirectToAction("Index", "TvSerie", new { area = "Admin" });
        }

    }
}