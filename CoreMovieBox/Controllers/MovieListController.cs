using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreMovieBox.Controllers
{
    public class MovieListController : Controller
    {
        MovieManager movieManager = new MovieManager(new EfMovieDal());
        public IActionResult MovieList(int id)
        {
            var values = movieManager.GetMoviesByID(id);
            return View();
        }
    }
}
