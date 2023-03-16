using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreMovieBox.Controllers
{
    public class DenemeController : Controller
    {
        MovieManager movieManager = new MovieManager(new EfMovieDal());
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult MovieDetailsDeneme(int id)
        {
            var values = movieManager.GetMoviesByID(id);
            return View(values);
        }
    }
}
