using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreMovieBox.ViewComponents.PopularMovies
{
    public class PopularMovies : ViewComponent
    {
        MovieManager movieManager = new MovieManager(new EfMovieDal());
        public IViewComponentResult Invoke(int id)
        {
            var values = movieManager.TGetList();
            return View(values);
        }

    }

}
