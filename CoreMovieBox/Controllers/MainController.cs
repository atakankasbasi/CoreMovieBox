using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreMovieBox.Controllers
{
    public class MainController : Controller
    {
        MovieManager movieManager = new MovieManager(new EfMovieDal());
        TvSerieManager tvSerieManager = new TvSerieManager(new EfTvSerieDal());

        public IActionResult Index()
        {
            var values = movieManager.TGetList();
            return View(values);
        }

        public IActionResult Index2()
        {
            var values = tvSerieManager.TGetList();
            return View(values);
        }
    }
}
