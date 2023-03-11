using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreMovieBox.Controllers
{
    public class TvSerieController : Controller
    {
        TvSerieManager tvSerieManager = new TvSerieManager(new EfTvSerieDal());
        public IActionResult Index()
        {
            var values = tvSerieManager.TGetList();
            return View(values);
        }


        [HttpGet]
        public IActionResult TvSerieAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult TvSerieAdd(TvSerie tvSerie)
        {
            tvSerieManager.TInsert(tvSerie);
            return RedirectToAction("Index");
        }


        public IActionResult TvSerieDelete(int id)
        {
            var values = tvSerieManager.TGetByID(id);
            tvSerieManager.TDelete(values);
            return RedirectToAction("Index");

        }




        [HttpGet]
        public IActionResult TvSerieEdit(int id)
        {
            var values = tvSerieManager.TGetByID(id);
            return View();
        }
        [HttpPost]
        public IActionResult TvSerieEdit(TvSerie tvSerie)
        {
            tvSerieManager.TUpdate(tvSerie);
            return RedirectToAction("Index");
        }
    }
}
