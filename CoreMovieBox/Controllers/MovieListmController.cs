using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreMovieBox.Controllers
{
    public class MovieListmController : Controller
    {
        MovieManager movieManager = new MovieManager(new EfMovieDal());
        public IActionResult Index()
        {
          var values =  movieManager.TGetList();
            return View(values);
        }
    }
}
