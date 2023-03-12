using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreMovieBox.ViewComponents
{
    public class MainMovieList: ViewComponent
    {
            MovieManager movieManager = new MovieManager(new EfMovieDal());
            public IViewComponentResult Invoke()
            {
            var values = movieManager.TGetList();
                return View(values);
            }
    }
}
