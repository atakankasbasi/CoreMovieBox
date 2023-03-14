using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreMovieBox.ViewComponents
{
    public class MainMovieList: ViewComponent
    {
            //MovieManager movieManager = new MovieManager(new EfMovieDal());
            Context c = new Context();
            public IViewComponentResult Invoke()
            {
            var values = c.Top10MovieLists.ToList();
                return View(values);
            }
    }
}
